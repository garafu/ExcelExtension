namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 「問題の報告」コマンド
    /// </summary>
    public class ReportIssuesCommand : ICommand
    {
        /// <summary>
        /// 新規Issuesリンク
        /// </summary>
        private const string NewIssuesUrl = @"https://github.com/garafu/ExcelExtension/issues";

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        public void Execute()
        {
            Process.Start(ReportIssuesCommand.NewIssuesUrl);
        }
    }
}
