namespace ExcelX.AddIn.Module.SearchReplace
{
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索範囲を表現します。
    /// </summary>
    public class SearchScope
    {
        private Application application;

        private Workbook book;
        private int index;
        private List<Range> ranges;
        private List<Worksheet> sheets;
        private Window window;

        public SearchScope(SearchScopeType type)
        {
            this.application = Globals.ThisAddIn.Application;
            this.window = this.application.ActiveWindow;
            this.book = this.application.ActiveWorkbook;
            this.sheets = new List<Worksheet>();
            this.ranges = new List<Range>();
            this.index = 0;

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

        private void SetSelectedRangeScope()
        {
            Worksheet activeSheet = this.book.ActiveSheet;

            // シートは現在選択中を検索範囲にする
            this.sheets.Add(activeSheet);

            // 実際に使っている範囲と選択範囲の積集合を検索範囲にする
            Range range = this.application.Intersect(activeSheet.UsedRange, this.window.RangeSelection);
            this.ranges.Add(range);
        }

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

        private void SetCurrentSheetScope()
        {
            Worksheet activeSheet = this.book.ActiveSheet;
            this.sheets.Add(activeSheet);
            this.ranges.Add(activeSheet.UsedRange);
        }

        public Workbook Book
        {
            get
            {
                return this.book;
            }
        }

        public List<Worksheet> Sheets
        {
            get
            {
                return this.sheets;
            }
        }

        public List<Range> Ranges
        {
            get
            {
                return this.ranges;
            }
        }

        public bool HasNext()
        {
            return this.index < this.ranges.Count;
        }

        public Range Next()
        {
            if (this.HasNext() == false)
            {
                return null;
            }

            return this.ranges[this.index++];
        }
    }
}
