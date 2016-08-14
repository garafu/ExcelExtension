namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// リボンから実行可能なコマンド
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        ///  コマンドを実行します。
        /// </summary>
        void Execute();
    }
}
