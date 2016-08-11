namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索結果を表現するクラス
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// SearchResult クラス を初期化します。
        /// </summary>
        public SearchResult()
        {
        }

        /// <summary>
        /// 初期値を指定して SerachResulg クラスを初期化します。
        /// </summary>
        /// <param name="book">ブック名</param>
        /// <param name="sheet">シート名</param>
        /// <param name="cell">セル</param>
        /// <param name="name">名前</param>
        /// <param name="type">種別</param>
        /// <param name="text">文字列</param>
        public SearchResult(string book, string sheet, string cell, string name, SearchTargetType type, string text)
        {
            this.Book = book;
            this.Sheet = sheet;
            this.Cell = cell;
            this.Name = name;
            this.Type = type;
            this.Text = text;
        }

        /// <summary>
        /// ブック名を取得または設定します。
        /// </summary>
        public string Book { get; set; }

        /// <summary>
        /// セル名を取得または設定します。
        /// </summary>
        public string Cell { get; set; }

        /// <summary>
        /// オブジェクト名を取得または設定します。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// シート名を取得または設定します。
        /// </summary>
        public string Sheet { get; set; }

        /// <summary>
        /// 検索結果文字列を取得または設定します。
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 検索対象種別を取得または設定します。
        /// </summary>
        public SearchTargetType Type { get; set; }

        /// <summary>
        /// 検索対象種別の表示名を取得します。
        /// </summary>
        public string TypeDisplayName
        {
            get
            {
                return this.Type.GetDisplayName();
            }
        }
    }
}
