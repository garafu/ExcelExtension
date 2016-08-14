namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ExcelX.Addin.Dialog;

    /// <summary>
    /// 「ワークシート管理を開く」コマンド
    /// </summary>
    public class OpenWorksheetManageWindowCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            var dialog = new WorksheetManageWindow();

            // Excelのウィンドウハンドルを取得
            var owner = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);

            // オーナーを指定してダイアログの表示
            dialog.Show(owner);
        }
    }
}
