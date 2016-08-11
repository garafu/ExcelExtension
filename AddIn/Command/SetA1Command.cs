namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「A1」コマンド
    /// </summary>
    public class SetA1Command : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            var application = Globals.ThisAddIn.Application;
            Workbook book = application.ActiveWorkbook;

            // 後ろのシートから先頭のシートに向かって処理する
            for (var i = book.Worksheets.Count; i > 0; i--)
            {
                Window window = book.Windows[1];
                _Worksheet sheet = book.Worksheets[i];

                // 表示中シートのみが対象
                if (sheet.Visible != XlSheetVisibility.xlSheetVisible)
                {
                    continue;
                }

                // デフォルト状態に設定
                sheet.Activate();
                sheet.Range["A1"].Activate();
                window.ScrollRow = 1;
                window.ScrollColumn = 1;
            }
        }
    }
}
