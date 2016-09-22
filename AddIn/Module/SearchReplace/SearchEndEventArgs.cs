namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索終了イベント変数
    /// </summary>
    public class SearchEndEventArgs : EventArgs
    {
        /// <summary>
        /// SearchEndEventArgs クラス の インスタンスを初期化します。
        /// </summary>
        /// <param name="finds">検索ヒット数</param>
        public SearchEndEventArgs(int finds)
        {
            this.Finds = finds;
        }

        /// <summary>
        /// 検索ヒット数を取得します。
        /// </summary>
        public int Finds { get; private set; }
    }
}
