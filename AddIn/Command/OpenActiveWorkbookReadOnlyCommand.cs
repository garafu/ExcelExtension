namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 「現在のブックを新しいウィンドウの読み取り専用で開く」コマンド
    /// </summary>
    public class OpenActiveWorkbookReadOnlyCommand : OpenFileCommand, ICommand
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

            // 新規ウィンドウ読み取り専用で開く
            await this.OpenNewWindowAsync(filepath, true);
        }
    }
}
