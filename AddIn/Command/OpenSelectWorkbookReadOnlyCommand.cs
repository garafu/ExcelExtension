namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// 「ファイルを選択して別ウィンドウの読み取り専用で開く」コマンド
    /// </summary>
    public class OpenSelectWorkbookReadOnlyCommand : OpenFileCommand, ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public async void Execute()
        {
            // OpenFileDialogインスタンスを作成
            var ofd = this.CreateOpenFileDialog();

            // OK 以外は無視
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // 指定されたファイルを読み取り専用で開く
            await this.OpenNewWindowAsync(ofd.FileName, true);
        }
    }
}
