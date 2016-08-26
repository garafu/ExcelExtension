namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core = Microsoft.Office.Core;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 検索処理を行う実態クラス。
    /// </summary>
    public class SearchEngine
    {
        /// <summary>
        /// 検索範囲
        /// </summary>
        private SearchScope scope;

        /// <summary>
        /// 検索対象
        /// </summary>
        private SearchTarget target;

        /// <summary>
        /// 検索条件
        /// </summary>
        private SearchCondition condition;

        /// <summary>
        /// 検索範囲、検索対象、検索条件を指定して検索を行います。
        /// </summary>
        /// <param name="scope">検索範囲</param>
        /// <param name="target">検索対象</param>
        /// <param name="condition">検索条件</param>
        /// <returns>検索結果</returns>
        public SortableBindingList<SearchResult> Execute(SearchScope scope, SearchTarget target, SearchCondition condition)
        {
            var result = new List<SearchResult>();

            this.scope = scope;
            this.target = target;
            this.condition = condition;

            foreach (var range in this.scope.Ranges)
            {
                if (this.target.IncludeFormula ||
                    this.target.IncludeValue ||
                    this.target.IncludeComment)
                {
                    var found = this.FindCell(range);
                    if (found.Count > 0)
                    {
                        result.AddRange(found);
                    }
                }

                if (this.target.IncludeShape)
                {
                    var found = this.FindShape(range);
                    if (found.Count > 0)
                    {
                        result.AddRange(found);
                    }
                }

                if (this.target.IncludeChart)
                {
                    var found = this.FindChart(range);
                    if (found.Count > 0)
                    {
                        result.AddRange(found);
                    }
                }
            }

            return new SortableBindingList<SearchResult>(result);
        }

        /// <summary>
        /// 検索範囲、検索対象、検索条件を指定して非同期に検索を行います。
        /// </summary>
        /// <param name="scope">検索範囲</param>
        /// <param name="target">検索対象</param>
        /// <param name="condition">検索条件</param>
        /// <returns>検索結果</returns>
        public Task<SortableBindingList<SearchResult>> ExecuteAsync(SearchScope scope, SearchTarget target, SearchCondition condition)
        {
            return Task.Factory.StartNew(() =>
            {
                return this.Execute(scope, target, condition);
            });
        }

        /// <summary>
        /// 指定された検索結果に該当するオブジェクトにフォーカスします。
        /// </summary>
        /// <param name="result">検索結果</param>
        public void Focus(SearchResult result)
        {
            switch (result.Type)
            {
                case SearchTargetType.FORMULA:
                    this.FocusCell(result);
                    break;
                case SearchTargetType.VALUE:
                    this.FocusCell(result);
                    break;
                case SearchTargetType.COMMENT:
                    this.FocusComment(result);
                    break;
                case SearchTargetType.SHAPE:
                    this.FocusAutoShape(result);
                    break;
                case SearchTargetType.CHART:
                    this.FocusChart(result);
                    break;
            }
        }

        /// <summary>
        /// 指定された範囲のセル情報から 式 、 値 、 コメント を探します。
        /// </summary>
        /// <param name="range">検索範囲</param>
        /// <returns>検索結果</returns>
        private List<SearchResult> FindCell(Excel.Range range)
        {
            var result = new List<SearchResult>();

            for (var row = 1; row <= range.Rows.Count; row++)
            {
                for (var col = 1; col <= range.Columns.Count; col++)
                {
                    Excel.Range cell = range.Cells[row, col];
                    string text = string.Empty;

                    // セル式に一致する文字列が存在するかどうか
                    if (this.target.IncludeFormula &&
                        cell.HasFormula &&
                        string.IsNullOrEmpty(text = cell.FormulaLocal) == false &&
                        this.condition.Validate(text) == true)
                    {
                        result.Add(new SearchResult()
                        {
                            Book = this.scope.Book.Name,
                            Sheet = range.Worksheet.Name,
                            Cell = cell.Address,
                            Name = string.Empty,
                            Type = SearchTargetType.FORMULA,
                            Text = text
                        });
                    }

                    // セル値に一致する文字列が存在するかどうか
                    if (this.target.IncludeValue &&
                        string.IsNullOrEmpty(text = cell.Text) == false &&
                        this.condition.Validate(text) == true)
                    {
                        result.Add(new SearchResult()
                        {
                            Book = this.scope.Book.Name,
                            Sheet = range.Worksheet.Name,
                            Cell = cell.Address,
                            Name = string.Empty,
                            Type = SearchTargetType.VALUE,
                            Text = text
                        });
                    }

                    // コメントに一致する文字が存在するかどうか
                    if (this.target.IncludeComment &&
                        cell.Comment != null &&
                        string.IsNullOrEmpty(text = cell.Comment.Text()) == false &&
                        this.condition.Validate(text) == true)
                    {
                        result.Add(new SearchResult()
                        {
                            Book = this.scope.Book.Name,
                            Sheet = range.Worksheet.Name,
                            Cell = cell.Address,
                            Name = string.Empty,
                            Type = SearchTargetType.COMMENT,
                            Text = text
                        });
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 指定された範囲に含まれる シェイプ を探します。
        /// </summary>
        /// <param name="range">検索範囲</param>
        /// <returns>検索結果</returns>
        private List<SearchResult> FindShape(Excel.Range range)
        {
            var result = new List<SearchResult>();

            var sheet = range.Worksheet;
            var shapes = sheet.Shapes;

            for (var i = 1; i <= shapes.Count; i++)
            {
                var shape = shapes.Item(i);

                switch (shape.Type)
                {
                    case Core.MsoShapeType.msoGroup:
                        this.FindGroupShape(shape, i, -1, result);
                        break;
                    case Core.MsoShapeType.msoSmartArt:
                        this.FindSmartArt(shape, i, -1, result);
                        break;
                    case Core.MsoShapeType.msoAutoShape:
                    case Core.MsoShapeType.msoCallout:
                    case Core.MsoShapeType.msoFreeform:
                    case Core.MsoShapeType.msoTextBox:
                        this.FindDefaultShape(shape, i, -1, result);
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// グループ化されたシェイプから検索対象を探します。
        /// </summary>
        /// <param name="parentShape">グループ化されたシェイプ</param>
        /// <param name="parentIndex">親シェイプインデックス</param>
        /// <param name="childIndex">子シェイプインデックス</param>
        /// <param name="result">検索結果の反映先</param>
        private void FindGroupShape(Excel.Shape parentShape, int parentIndex, int childIndex, List<SearchResult> result)
        {
            var groupItems = parentShape.GroupItems;

            for (var i = 1; i <= groupItems.Count; i++)
            {
                var childShape = groupItems.Item(i);

                switch (childShape.Type)
                {
                    case Core.MsoShapeType.msoSmartArt:
                        this.FindSmartArt(childShape, parentIndex, i, result);
                        break;
                    default:
                        this.FindDefaultShape(childShape, parentIndex, i, result);
                        break;
                }
            }
        }

        /// <summary>
        /// スマートアートから検索対象を探します。
        /// </summary>
        /// <param name="parentShape">スマートアート</param>
        /// <param name="parentIndex">親シェイプインデックス</param>
        /// <param name="childIndex">子シェイプインデックス</param>
        /// <param name="result">検索結果の反映先</param>
        private void FindSmartArt(Excel.Shape parentShape, int parentIndex, int childIndex, List<SearchResult> result)
        {
            var nodes = parentShape.SmartArt.AllNodes;
            var book = this.scope.Book;
            var sheet = parentShape.TopLeftCell.Worksheet;

            for (var i = 1; i <= nodes.Count; i++)
            {
                var node = nodes[i];
                var text = node.TextFrame2.TextRange.Text;

                if (string.IsNullOrEmpty(text) == true ||
                    this.condition.Validate(text) == false)
                {
                    continue;
                }

                result.Add(new SearchResult()
                {
                    Book = book.Name,
                    Sheet = sheet.Name,
                    Cell = string.Format("{0}:{1}", parentShape.TopLeftCell.Address, parentShape.BottomRightCell.Address),
                    ParentIndex = parentIndex,
                    ChildIndex = childIndex,
                    Name = parentShape.Name,
                    Type = SearchTargetType.SHAPE,
                    Text = text
                });
            }
        }

        /// <summary>
        /// 指定されたシェイプが検索対象かを判定します。
        /// </summary>
        /// <param name="shape">シェイプ</param>
        /// <param name="parentIndex">親シェイプインデックス</param>
        /// <param name="childIndex">子シェイプインデックス</param>
        /// <param name="result">検索結果の反映先</param>
        private void FindDefaultShape(Excel.Shape shape, int parentIndex, int childIndex, List<SearchResult> result)
        {
            string text = string.Empty;

            try
            {
                text = shape.TextFrame.Characters().Text;
            }
            catch
            {
            }

            if (string.IsNullOrEmpty(text) == true ||
                this.condition.Validate(text) == false)
            {
                return;
            }

            result.Add(new SearchResult()
            {
                Book = this.scope.Book.Name,
                Sheet = shape.TopLeftCell.Worksheet.Name,
                Cell = string.Format("{0}:{1}", shape.TopLeftCell.Address, shape.BottomRightCell.Address),
                ParentIndex = parentIndex,
                ChildIndex = childIndex,
                Name = shape.Name,
                Type = SearchTargetType.SHAPE,
                Text = text
            });
        }

        /// <summary>
        /// 指定された範囲に含まれる グラフ を探します。
        /// </summary>
        /// <param name="range">検索範囲</param>
        /// <returns>検索結果</returns>
        private List<SearchResult> FindChart(Excel.Range range)
        {
            var result = new List<SearchResult>();

            Excel.Worksheet sheet = range.Worksheet;
            Excel.ChartObjects chartObjects = sheet.ChartObjects();
            string text = string.Empty;
            Excel.Axis axis = null;

            foreach (Excel.ChartObject chartObject in chartObjects)
            {
                Excel.Chart chart = chartObject.Chart;

                // グラフタイトル
                text = chart.ChartTitle.Text;
                if (this.condition.Validate(text))
                {
                    result.Add(new SearchResult()
                    {
                        Book = this.scope.Book.Name,
                        Sheet = sheet.Name,
                        Cell = string.Format("{0}:{1}", chartObject.TopLeftCell.Address, chartObject.BottomRightCell.Address),
                        Name = chartObject.Name,
                        Type = SearchTargetType.CHART,
                        Text = text
                    });
                }

                // 横軸タイトル
                axis = chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
                if (axis.HasTitle &&
                    this.condition.Validate(text = axis.AxisTitle.Characters.Text))
                {
                    result.Add(new SearchResult()
                    {
                        Book = this.scope.Book.Name,
                        Sheet = sheet.Name,
                        Cell = string.Format("{0}:{1}", chartObject.TopLeftCell.Address, chartObject.BottomRightCell.Address),
                        Name = chartObject.Name,
                        Type = SearchTargetType.CHART,
                        Text = text
                    });
                }

                // 縦軸タイトル
                axis = chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
                if (axis.HasTitle &&
                    this.condition.Validate(text = axis.AxisTitle.Characters.Text))
                {
                    result.Add(new SearchResult()
                    {
                        Book = this.scope.Book.Name,
                        Sheet = sheet.Name,
                        Cell = string.Format("{0}:{1}", chartObject.TopLeftCell.Address, chartObject.BottomRightCell.Address),
                        Name = chartObject.Name,
                        Type = SearchTargetType.CHART,
                        Text = text
                    });
                }
            }

            return result;
        }

        /// <summary>
        /// 指定されたシート名のワークシートを取得します。
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <returns>Worksheet オブジェクト</returns>
        private Excel.Worksheet GetWorksheet(string sheetName)
        {
            var application = Globals.ThisAddIn.Application;
            Excel.Workbook book = application.ActiveWorkbook;
            Excel.Worksheet sheet = null;

            if (application.ActiveSheet.Name == sheetName)
            {
                sheet = application.ActiveSheet;
            }
            else
            {
                sheet = book.Sheets.Item[sheetName];
                ((Excel._Worksheet)sheet).Activate();
            }

            return sheet;
        }

        /// <summary>
        /// 指定された検索結果に該当する Shape を取得します。
        /// </summary>
        /// <param name="result">検索結果</param>
        /// <returns>Shape オブジェクト</returns>
        private Excel.Shape GetShape(SearchResult result)
        {
            var sheet = this.GetWorksheet(result.Sheet);

            // 親要素取得
            var shape1 = sheet.Shapes.Item(result.ParentIndex);

            // グループ or SmartArt は子要素を再取得
            if (shape1.Type == Microsoft.Office.Core.MsoShapeType.msoAutoShape ||
                shape1.Type == Microsoft.Office.Core.MsoShapeType.msoGroup)
            {
                shape1 = shape1.GroupItems.Item(result.ChildIndex);
            }

            return shape1;
        }

        /// <summary>
        /// 指定されたセルにフォーカスします。
        /// </summary>
        /// <param name="result">検索結果</param>
        /// <returns>フォーカスした範囲</returns>
        private Excel.Range FocusCell(SearchResult result)
        {
            var sheet = this.GetWorksheet(result.Sheet);
            var range = sheet.Range[result.Cell];

            // シートを選択
            sheet.Select();

            // 対象の範囲を選択
            range.Select();
            range.Activate();

            return range;
        }

        /// <summary>
        /// コメント入力されたセルにフォーカスします。
        /// </summary>
        /// <param name="result">検索結果</param>
        /// <returns>フォーカスした範囲</returns>
        private Excel.Range FocusComment(SearchResult result)
        {
            var sheet = this.GetWorksheet(result.Sheet);
            var range = sheet.Range[result.Cell];

            // シートを選択
            sheet.Select();

            // 対象の範囲を選択
            range.Select();
            range.Activate();

            return range;
        }

        /// <summary>
        /// 指定したシート、セルに存在するオートシェイプにフォーカスします。
        /// </summary>
        /// <param name="result">検索結果</param>
        /// <returns>オートシェイプが存在する領域</returns>
        private Excel.Range FocusAutoShape(SearchResult result)
        {
            var sheet = this.GetWorksheet(result.Sheet);
            var range = sheet.Range[result.Cell];
            var shape = this.GetShape(result);

            // シートを選択
            sheet.Select();

            // 対象の範囲を選択
            range.Select();
            range.Activate();
            
            try
            {
                // オブジェクトを選択
                shape.Select();
            }
            catch
            {
            }

            return range;
        }

        /// <summary>
        /// 指定されたグラフにフォーカスします。
        /// </summary>
        /// <param name="result">検索結果</param>
        /// <returns>フォーカスした範囲</returns>
        private Excel.Range FocusChart(SearchResult result)
        {
            var sheet = this.GetWorksheet(result.Sheet);
            var range = sheet.Range[result.Cell];
            var chart = sheet.ChartObjects(result.Name);

            var application = Globals.ThisAddIn.Application;
            application.Goto(range, true);

            try
            {
                // オブジェクトを選択
                chart.Select();
            }
            catch
            {
            }

            return range;
        }
    }
}
