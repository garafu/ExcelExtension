namespace ExcelX.AddIn
{
    using ExcelX.Addin.Command;
    using ExcelX.AddIn.Dialog;
    using Microsoft.Office.Tools.Ribbon;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        /// <summary>
        /// 「現在のブックを別ウィンドウの読み取り専用で開く」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenActiveWorkbookReadOnlyButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenActiveWorkbookReadOnlyCommand();
            command.Execute();
        }

        /// <summary>
        /// 「現在のブックを別ウィンドウの編集用で開く」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenActiveWorkbookEditableButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenActiveWorkbookEditableCommand();
            command.Execute();
        }

        /// <summary>
        /// 「ファイルを選択して別ウィンドウの読み取り専用で開く」コマンド
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenSelectWorkbookReadOnlyButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenSelectWorkbookReadOnlyCommand();
            command.Execute();
        }

        /// <summary>
        /// 「ファイルを選択して別ウィンドウの編集用で開く」コマンド
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenSelectWorkbookEditableButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenSelectWorkbookEditableCommand();
            command.Execute();
        }

        /// <summary>
        /// 「フォルダを開く」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void OpenFolderButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new OpenActiveWorkbookFolderCommand();
            command.Execute();
        }

        /// <summary>
        /// 「読み取り専用の設定/解除」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void ToggleEditModeButton_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new ToggleEditModeCommand();
            command.Execute();
        }

        private void SearchSplitButton_Click(object sender, RibbonControlEventArgs e)
        {
            this.OpenSearchReplaceWindow();
        }

        private void OpenSearchReplaceWindow()
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

        /// <summary>
        /// 「A1」ボタンを押下したとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元</param>
        /// <param name="e">イベント変数</param>
        private void SetA1Button_Click(object sender, RibbonControlEventArgs e)
        {
            var command = new SetA1Command();
            command.Execute();
        }
    }
}
