namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索条件を表現します。
    /// </summary>
    public class SearchCondition
    {
        /// <summary>
        /// 比較処理の実態
        /// </summary>
        private Func<string, string, bool> compare;

        /// <summary>
        /// カルチャー情報
        /// </summary>
        private CompareInfo compareInfo;

        /// <summary>
        /// 大文字/小文字を区別するかどうか
        /// </summary>
        private bool matchCase;

        /// <summary>
        /// 完全位置するものを対象とするかどうか
        /// </summary>
        private bool matchExact;

        /// <summary>
        /// 全角/半角を区別するかどうか
        /// </summary>
        private bool matchWidth;

        /// <summary>
        /// 比較オプション
        /// </summary>
        private CompareOptions options;

        /// <summary>
        /// 通常一致における完全一致または部分一致を行う比較処理の実態
        /// </summary>
        private Func<string, string, bool> state;

        /// <summary>
        /// 正規表現を使うかどうか
        /// </summary>
        private bool useRegexp;

        /// <summary>
        /// 検索条件を指定して SearchCondition インスタンス を初期化します。
        /// </summary>
        /// <param name="searchText">検索文字列</param>
        /// <param name="useRegexp">正規表現を使うかどうか</param>
        /// <param name="matchExact">完全一致とするかどうか</param>
        /// <param name="matchCase">大文字/小文字を区別するかどうか</param>
        /// <param name="matchWidth">全角/半角を区別するかどうか</param>
        public SearchCondition(string searchText, bool useRegexp, bool matchExact, bool matchCase, bool matchWidth)
        {
            this.compareInfo = CultureInfo.CurrentCulture.CompareInfo;

            this.SearchText = searchText;
            this.UseRegexp = useRegexp;
            this.MatchExact = matchExact;
            this.MatchCase = matchCase;
            this.MatchWidth = matchWidth;
        }

        /// <summary>
        /// 大文字/小文字を区別するかどうかを取得または設定します。
        /// </summary>
        public bool MatchCase
        {
            get
            {
                return this.matchCase;
            }

            set
            {
                if (value == true &&
                    ((this.options & CompareOptions.IgnoreCase) != 0) == true)
                {
                    this.options &= ~CompareOptions.IgnoreCase;
                }
                else if (value == false &&
                   ((this.options & CompareOptions.IgnoreCase) != 0) == false)
                {
                    this.options |= CompareOptions.IgnoreCase;
                }

                this.matchCase = value;
            }
        }

        /// <summary>
        /// 完全一致させるかどうかを取得または設定します。
        /// </summary>
        public bool MatchExact
        {
            get
            {
                return this.matchExact;
            }

            set
            {
                if (value == true)
                {
                    this.state = this.MatchExactCompareInfoValidate;
                }
                else
                {
                    this.state = this.MatchPartialCompareInfoValidate;
                }

                this.matchExact = value;
            }
        }

        /// <summary>
        /// 全角/半角を区別するかどうかを取得または設定します。
        /// </summary>
        public bool MatchWidth
        {
            get
            {
                return this.matchWidth;
            }

            set
            {
                if (value == true &&
                    ((this.options & CompareOptions.IgnoreWidth) != 0) == true)
                {
                    this.options &= ~CompareOptions.IgnoreWidth;
                }
                else if (value == false &&
                   ((this.options & CompareOptions.IgnoreWidth) != 0) == false)
                {
                    this.options |= CompareOptions.IgnoreWidth;
                }

                this.matchWidth = value;
            }
        }

        /// <summary>
        /// 検索文字列を取得または設定します。
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// 正規表現を使うかどうかを取得または設定します。
        /// </summary>
        public bool UseRegexp
        {
            get
            {
                return this.useRegexp;
            }

            set
            {
                if (value == true)
                {
                    this.compare = this.RegexpValidate;
                }
                else
                {
                    this.compare = this.CompareInfoValidate;
                }

                this.useRegexp = value;
            }
        }

        /// <summary>
        /// 指定された文字列が検索条件に合致するかどうかを検証します。
        /// </summary>
        /// <param name="text">検証したい文字列</param>
        /// <returns>指定された検証文字列が検索条件に合致する場合 true 、それ以外の場合 false</returns>
        public bool Validate(string text)
        {
            return this.compare(text, this.SearchText);
        }

        /// <summary>
        /// CompareInfoを利用して文字列を比較します。
        /// </summary>
        /// <param name="source">検証したい文字列</param>
        /// <param name="target">検索文字列</param>
        /// <returns>指定された検証文字列が検索条件に合致する場合 true 、それ以外の場合 false</returns>
        private bool CompareInfoValidate(string source, string target)
        {
            return this.state(source, target);
        }

        /// <summary>
        /// 完全一致で文字列を比較します。
        /// </summary>
        /// <param name="source">検証したい文字列</param>
        /// <param name="target">検索文字列</param>
        /// <returns>指定された検証文字列が検索条件に合致する場合 true 、それ以外の場合 false</returns>
        private bool MatchExactCompareInfoValidate(string source, string target)
        {
            return this.compareInfo.Compare(source, target, this.options) == 0;
        }

        /// <summary>
        /// 部分一致で文字列を比較します。
        /// </summary>
        /// <param name="source">検証したい文字列</param>
        /// <param name="target">検索文字列</param>
        /// <returns>指定された検証文字列が検索条件に合致する場合 true 、それ以外の場合 false</returns>
        private bool MatchPartialCompareInfoValidate(string source, string target)
        {
            return this.compareInfo.IndexOf(source, target, this.options) >= 0;
        }

        /// <summary>
        /// 正規表現で文字列を比較します。
        /// </summary>
        /// <param name="source">検証したい文字列</param>
        /// <param name="target">検索文字列</param>
        /// <returns>指定された検証文字列が検索条件に合致する場合 true 、それ以外の場合 false</returns>
        private bool RegexpValidate(string source, string target)
        {
            return Regex.IsMatch(source, target);
        }
    }
}
