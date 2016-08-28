namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn.Config;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「方眼紙」コマンド
    /// </summary>
    public class MakeGridCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            // グリッドサイズはピクセル指定
            var size = ConfigDocument.Current.Edit.Grid.Size;

            // ワークシートを取得
            var application = Globals.ThisAddIn.Application;
            Excel.Workbook book = application.ActiveWorkbook;
            Excel.Worksheet sheet = book.ActiveSheet;

            // 環境値の取得
            var cell = sheet.Range["A1"];
            double x1 = 10, x2 = 20, y1, y2, a, b;
            
            cell.ColumnWidth = x1;
            y1 = cell.Width;

            cell.ColumnWidth = x2;
            y2 = cell.Width;

            a = (y2 - y1) / (x2 - x1);
            b = y2 - (((y2 - y1) / (x2 - x1)) * x2);

            // すべてのセルサイズを同一に設定
            Excel.Range all = sheet.Cells;
            all.ColumnWidth = ((size * 0.75) - b) / a;
            all.RowHeight = size * 0.75;
        }
    }
}
