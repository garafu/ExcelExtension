namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ExcelX.AddIn.Dialog;

    /// <summary>
    /// 「バージョン」コマンド
    /// </summary>
    public class OpenVersionInfoWindowCommand : ICommand
    {
        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            var dialog = new VersionInfoWindow();
            dialog.ShowDialog();
        }
    }
}
