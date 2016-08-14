namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「読み取り専用の設定/解除」コマンド
    /// </summary>
    public class ToggleEditModeCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            // 現在のワークブックを取得
            var application = Globals.ThisAddIn.Application;
            var workbook = application.ActiveWorkbook;

            // 新規作成かどうか
            if (workbook.Name == workbook.FullName)
            {
                return;
            }

            // 読み取り専用設定を反転
            if (workbook.ReadOnly)
            {
                workbook.ChangeFileAccess(XlFileAccess.xlReadWrite);
            }
            else
            {
                workbook.ChangeFileAccess(XlFileAccess.xlReadOnly);
            }
        }
    }
}
