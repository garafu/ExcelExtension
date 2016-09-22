namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SearchStartEventArgs : EventArgs
    {
        public int Maxmimum { get; private set; }

        public SearchStartEventArgs(int max)
        {
            this.Maxmimum = max;
        }
    }
}
