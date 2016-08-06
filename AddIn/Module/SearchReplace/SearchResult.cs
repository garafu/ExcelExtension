namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SearchResult
    {
        public string Book { get; set; }

        public string Sheet { get; set; }

        public string Cell { get; set; }

        public string Name { get; set; }

        public SearchTargetType Type { get; set; }

        public string TypeDisplayName
        {
            get
            {
                return this.Type.GetDisplayName();
            }
        }

        public string Text { get; set; }

        public SearchResult()
        {
        }

        public SearchResult(string book, string sheet, string cell, string name, SearchTargetType type, string text)
        {
            this.Book = book;
            this.Sheet = sheet;
            this.Cell = cell;
            this.Name = name;
            this.Type = type;
            this.Text = text;
        }
    }
}
