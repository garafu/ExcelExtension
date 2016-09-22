namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索開始イベント変数
    /// </summary>
    public class SearchStartEventArgs : EventArgs
    {
        /// <summary>
        /// SearchStartEventArgs クラス の インスタンスを初期化します。
        /// </summary>
        /// <param name="max">検索範囲</param>
        public SearchStartEventArgs(int max)
        {
            this.Maxmimum = max;
        }

        /// <summary>
        /// 検索範囲の最大数を取得します。
        /// </summary>
        public int Maxmimum { get; private set; }
    }
}
