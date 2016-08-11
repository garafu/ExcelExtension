namespace ExcelX.Addin.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 「スタイル初期化」コマンド
    /// </summary>
    public class InitializeStyleCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public async void Execute()
        {
            await this.RemoveStylesAsync();
        }

        /// <summary>
        /// 作成されたスタイルをすべて削除します。
        /// </summary>
        private void RemoveStyles()
        {
            Excel.Workbook book = Globals.ThisAddIn.Application.ActiveWorkbook;

            foreach (Excel.Style style in book.Styles)
            {
                if (style.BuiltIn == true)
                {
                    continue;
                }

                style.Delete();
            }
        }

        /// <summary>
        /// 作成されたスタイルをすべて非同期に削除します。
        /// </summary>
        /// <returns>非同期タスク</returns>
        private Task RemoveStylesAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                this.RemoveStyles();
            });
        }
    }
}
