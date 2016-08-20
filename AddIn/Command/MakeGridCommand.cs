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

            // すべてのセルサイズを同一に設定
            Excel.Range all = sheet.Cells;
            all.ColumnWidth = size * 0.118;
            all.RowHeight = size * 0.75;
        }
    }
}
