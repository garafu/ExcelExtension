namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ExcelX.AddIn.Dialog;

    /// <summary>
    /// 「検索/置換」ウィンドウを開くコマンド
    /// </summary>
    public class OpenSearchReplaceCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            // ダイアログのインスタンスを取得
            var dialog = SearchReplaceWindow.GetInstance();

            if (dialog.Visible == false)
            {
                // Excelのウィンドウハンドルを取得
                var owner = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);

                // オーナーを指定してダイアログの表示
                dialog.Show(owner);
            }
            else
            {
                // 既に表示済みなのでフォーカス
                dialog.Focus();
            }
        }
    }
}
