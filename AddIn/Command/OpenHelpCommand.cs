namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 「ヘルプ」コマンド
    /// </summary>
    public class OpenHelpCommand : ICommand
    {
        /// <summary>
        /// ヘルプリンク
        /// </summary>
        private const string HelpUrl = @"https://github.com/garafu/ExcelExtension/wiki";

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            Process.Start(OpenHelpCommand.HelpUrl);
        }
    }
}
