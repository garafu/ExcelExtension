namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 「現在のブックを別ウィンドウの編集用で開く」コマンド
    /// </summary>
    public class OpenActiveWorkbookEditableCommand : OpenFileCommand, ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public async void Execute()
        {
            // 新規ブックの場合何もしない
            if (this.IsNewBook() == true)
            {
                return;
            }

            // 開いているブックのファイルパスを取得
            var filepath = this.GetActiveWorkbookPath();

            // 新規ウィンドウ編集用で開く
            await this.OpenNewWindowAsync(filepath, false);
        }
    }
}
