namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ExcelX.AddIn.Dialog.Config;

    /// <summary>
    /// 「設定」コマンド
    /// </summary>
    public class OpenConfigWindowCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            var dialog = new ConfigWindow();

            // Excelのウィンドウハンドルを取得
            var owner = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);

            // オーナーを指定してダイアログの表示
            dialog.Show(owner);
        }
    }
}
