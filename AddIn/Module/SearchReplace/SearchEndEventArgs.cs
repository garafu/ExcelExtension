namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SearchEndEventArgs : EventArgs
    {
        public int Finds { get; private set; }

        public SearchEndEventArgs(int finds)
        {
            this.Finds = finds;
        }
    }
}
