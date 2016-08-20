namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// OpenFileDialogのフィルタ文字列を生成します。
    /// </summary>
    public class FilterStringBuilder
    {
        /// <summary>
        /// フィルターリスト
        /// </summary>
        private List<FilterInfo> filters;

        /// <summary>
        /// FilterStringBuilder クラス を初期化します。
        /// </summary>
        public FilterStringBuilder()
        {
            this.filters = new List<FilterInfo>();
        }

        /// <summary>
        /// フィルターを追加します。
        /// </summary>
        /// <param name="filterInfo">フィルター情報</param>
        public void Append(FilterInfo filterInfo)
        {
            this.filters.Add(filterInfo);
        }

        /// <summary>
        /// フィルター文字列を生成します。
        /// </summary>
        /// <returns>フィルター文字列</returns>
        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var item in this.filters)
            {
                result.Append(item.ToString());
                result.Append("|");
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
    }
}
