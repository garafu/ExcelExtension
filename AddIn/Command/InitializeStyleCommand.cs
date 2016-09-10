namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ExcelX.AddIn;
    using ExcelX.AddIn.Dialog;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「スタイル初期化」コマンド
    /// </summary>
    public class InitializeStyleCommand : ICommand
    {
        /// <summary>
        /// 実行中かどうか
        /// </summary>
        private bool isExecuting = false;

        /// <summary>
        /// 処理のキャンセルが行われたかどうか
        /// </summary>
        private bool isCanceled = false;

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            // Excelのウィンドウハンドルを取得
            var owner = Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle);

            var dialog = new InitializeStyleWindow();
            dialog.Canceled += this.Dialog_Canceled;
            dialog.FormClosing += this.Dialog_FormClosing;
            dialog.Shown += this.Dialog_Shown;
            dialog.ShowDialog(owner);
        }

        /// <summary>
        /// キャンセルボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void Dialog_Canceled(object sender, EventArgs e)
        {
            var text = "処理を停止してよろしいですか？";
            var caption = "処理停止の確認";

            if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.isCanceled = true;
            }
        }

        /// <summary>
        /// フォームを閉じようとしたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isExecuting == false ||
                this.isCanceled == true)
            {
                return;
            }
            
            var text = "処理を停止してよろしいですか？";
            var caption = "処理停止の確認";

            if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.isCanceled = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// フォームが表示されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void Dialog_Shown(object sender, EventArgs e)
        {
            Excel.Workbook book = Globals.ThisAddIn.Application.ActiveWorkbook;

            var dialog = sender as InitializeStyleWindow;
            dialog.Minimum = 0;
            dialog.Maximum = book.Styles.Count;
            dialog.Step = 1;

            Task.Factory.StartNew(() =>
            {
                this.isExecuting = true;

                foreach (Excel.Style style in book.Styles)
                {
                    if (this.isCanceled)
                    {
                        break;
                    }

                    dialog.PerformStep(style.Name);

                    if (style.BuiltIn == true)
                    {
                        continue;
                    }

                    style.Delete();
                }

                dialog.PerformStep(string.Empty);
                dialog.Close();

                this.isExecuting = false;
            });
        }
    }
}
