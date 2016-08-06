namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索範囲を表します。
    /// </summary>
    public enum SearchScopeType
    {
        /// <summary>
        /// 現在のシート
        /// </summary>
        [DisplayName("現在のシート")]
        CURRENT_SHEET,

        /// <summary>
        /// 選択範囲
        /// </summary>
        [DisplayName("選択範囲")]
        SELECTED_RANGE,

        /// <summary>
        /// 選択シート
        /// </summary>
        [DisplayName("選択シート")]
        SELECTED_SHEET,

        /// <summary>
        /// ブック全体
        /// </summary>
        [DisplayName("ブック全体")]
        BOOK
    }
}
