namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn;

    /// <summary>
    /// 「現在のワークブックが存在するフォルダを開く」コマンド
    /// </summary>
    public class OpenActiveWorkbookFolderCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            // 開くフォルダのパスを取得
            var filePath = this.GetActiveWorkbookPath();
            var folderPath = Path.GetDirectoryName(filePath);

            // パスが存在するかどうか確認（新規作成だと存在しない）
            if (Directory.Exists(folderPath) == false)
            {
                return;
            }

            // 該当のフォルダを開く
            System.Diagnostics.Process.Start(folderPath);
        }

        /// <summary>
        /// 現在開いているワークブックのファイルパスを取得します。
        /// </summary>
        /// <returns>ファイルパス</returns>
        private string GetActiveWorkbookPath()
        {
            var application = Globals.ThisAddIn.Application;

            var activeWorkbook = application.ActiveWorkbook;

            return activeWorkbook.FullName;
        }
    }
}
