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
        /// コマンドからのコールバックがあるとき発生します。
        /// </summary>
        public event EventHandler Callback;

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            var dialog = new ConfigWindow();
            dialog.Apply += this.Dialog_Apply;

            // Excelのウィンドウハンドルを取得
            var owner = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);

            // オーナーを指定してダイアログの表示
            dialog.Show(owner);
        }

        /// <summary>
        /// ダイアログで「適用」が実行されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void Dialog_Apply(object sender, EventArgs e)
        {
            if (this.Callback != null)
            {
                this.Callback(this, new EventArgs());
            }
        }
    }
}
