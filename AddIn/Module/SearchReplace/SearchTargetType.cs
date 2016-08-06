namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索対象を表します。
    /// </summary>
    [Flags]
    public enum SearchTargetType
    {
        /// <summary>
        /// セル(式)
        /// </summary>
        [DisplayName("セル(式)")]
        FORMULA = 0x001,

        /// <summary>
        /// セル(値)
        /// </summary>
        [DisplayName("セル(値)")]
        VALUE   = 0x002,

        /// <summary>
        /// コメント
        /// </summary>
        [DisplayName("コメント")]
        COMMENT = 0x004,

        /// <summary>
        /// シェイプ
        /// </summary>
        [DisplayName("シェイプ")]
        SHAPE   = 0x008,

        /// <summary>
        /// グラフ
        /// </summary>
        [DisplayName("グラフ")]
        CHART   = 0x010
    }

    public static class SearchTargetTypeExtensions
    {
        public static string ToString(this SearchTargetType val)
        {
            return val.GetDisplayName();
        }
    }
}
