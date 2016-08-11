namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 検索範囲を表現します。
    /// </summary>
    public class SearchScope
    {
        /// <summary>
        /// Excel アプリケーション
        /// </summary>
        private Application application;

        /// <summary>
        /// ワークブック
        /// </summary>
        private Workbook book;

        /// <summary>
        /// すべての検索範囲
        /// </summary>
        private List<Range> ranges;

        /// <summary>
        /// すべての検索対象シート
        /// </summary>
        private List<Worksheet> sheets;

        /// <summary>
        /// ウィンドウ
        /// </summary>
        private Window window;

        /// <summary>
        /// 検索範囲種別を指定して SearchScope を初期化します。
        /// </summary>
        /// <param name="type">検索範囲種別</param>
        public SearchScope(SearchScopeType type)
        {
            this.application = Globals.ThisAddIn.Application;
            this.window = this.application.ActiveWindow;
            this.book = this.application.ActiveWorkbook;
            this.sheets = new List<Worksheet>();
            this.ranges = new List<Range>();

            switch (type)
            {
                case SearchScopeType.CURRENT_SHEET:
                    this.SetCurrentSheetScope();
                    break;
                case SearchScopeType.SELECTED_SHEET:
                    this.SetSelectedSheetScope();
                    break;
                case SearchScopeType.SELECTED_RANGE:
                    this.SetSelectedRangeScope();
                    break;
                case SearchScopeType.BOOK:
                    this.SetBookScope();
                    break;
            }
        }

        /// <summary>
        /// 検索対象ブックを取得します。
        /// </summary>
        public Workbook Book
        {
            get
            {
                return this.book;
            }
        }

        /// <summary>
        /// 検索範囲を取得します。
        /// </summary>
        public List<Range> Ranges
        {
            get
            {
                return this.ranges;
            }
        }

        /// <summary>
        /// 検索対象シートを取得します。
        /// </summary>
        public List<Worksheet> Sheets
        {
            get
            {
                return this.sheets;
            }
        }

        /// <summary>
        /// ブック全体が検索範囲となるよう設定します。
        /// </summary>
        private void SetBookScope()
        {
            Sheets allSheets = this.book.Worksheets;
            foreach (Worksheet sheet in allSheets)
            {
                if (sheet.Visible != XlSheetVisibility.xlSheetVisible)
                {
                    continue;
                }

                this.sheets.Add(sheet);
                this.ranges.Add(sheet.UsedRange);
            }
        }

        /// <summary>
        /// 現在のシートが検索範囲となるよう設定します。
        /// </summary>
        private void SetCurrentSheetScope()
        {
            Worksheet activeSheet = this.book.ActiveSheet;
            this.sheets.Add(activeSheet);
            this.ranges.Add(activeSheet.UsedRange);
        }

        /// <summary>
        /// 選択範囲が検索範囲となるよう設定します。
        /// </summary>
        private void SetSelectedRangeScope()
        {
            Worksheet activeSheet = this.book.ActiveSheet;

            // シートは現在選択中を検索範囲にする
            this.sheets.Add(activeSheet);

            // 実際に使っている範囲と選択範囲の積集合を検索範囲にする
            Range range = this.application.Intersect(activeSheet.UsedRange, this.window.RangeSelection);
            this.ranges.Add(range);
        }

        /// <summary>
        /// 選択シートが検索範囲となるよう設定します。
        /// </summary>
        private void SetSelectedSheetScope()
        {
            var selectedSheets = this.window.SelectedSheets;
            foreach (Worksheet selectedSheet in selectedSheets)
            {
                if (selectedSheet.Visible != XlSheetVisibility.xlSheetVisible)
                {
                    continue;
                }

                this.sheets.Add(selectedSheet);
                this.ranges.Add(selectedSheet.UsedRange);
            }
        }
    }
}
