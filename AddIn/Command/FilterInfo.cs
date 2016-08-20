namespace ExcelX.AddIn.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// OpenFileDialogのフィルタ情報
    /// </summary>
    public class FilterInfo
    {
        /// <summary>
        /// FilterInfo クラス を初期化します。
        /// </summary>
        public FilterInfo()
        {
            this.DisplayName = string.Empty;
            this.Extensions = new List<string>();
        }

        /// <summary>
        /// 表示名、拡張子を指定して FilterInfo クラス を初期化します。
        /// </summary>
        /// <param name="displayName">表示名</param>
        /// <param name="extensions">拡張子</param>
        public FilterInfo(string displayName, params string[] extensions)
        {
            this.DisplayName = displayName;
            this.Extensions = new List<string>(extensions);
        }

        /// <summary>
        /// 表示名を取得または設定します。
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 拡張子を取得または設定します。
        /// </summary>
        public List<string> Extensions { get; set; }

        /// <summary>
        /// フィルターを表す文字列を取得します。
        /// </summary>
        /// <returns>フィルター文字列</returns>
        public override string ToString()
        {
            var extensions = new StringBuilder();

            foreach (var ext in this.Extensions)
            {
                extensions.Append("*.");
                extensions.Append(ext);
                extensions.Append(";");
            }

            extensions.Remove(extensions.Length - 1, 1);

            var filter = new StringBuilder();

            filter.Append(this.DisplayName);
            filter.Append("(");
            filter.Append(extensions.ToString());
            filter.Append(")|");
            filter.Append(extensions.ToString());

            return filter.ToString();
        }
    }
}
