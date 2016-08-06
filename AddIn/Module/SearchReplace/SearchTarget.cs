namespace ExcelX.AddIn.Module.SearchReplace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 検索対象を表現します。
    /// </summary>
    public class SearchTarget
    {
        private SearchTargetType targets;

        public SearchTarget(SearchTargetType targets)
        {
            this.targets = targets;
        }

        public SearchTarget(bool includeFormula, bool includeValue, bool includeComment, bool includeShape, bool includeChart)
        {
            if (includeFormula)
            {
                this.targets |= SearchTargetType.FORMULA;
            }
            if (includeValue)
            {
                this.targets |= SearchTargetType.VALUE;
            }
            if (includeComment)
            {
                this.targets |= SearchTargetType.COMMENT;
            }
            if (includeShape)
            {
                this.targets |= SearchTargetType.SHAPE;
            }
            if (includeChart)
            {
                this.targets |= SearchTargetType.CHART;
            }
        }

        public bool IncludeFormula
        {
            get
            {
                return (this.targets & SearchTargetType.FORMULA) != 0;
            }
        }

        public bool IncludeValue
        {
            get
            {
                return (this.targets & SearchTargetType.VALUE) != 0;
            }
        }

        public bool IncludeComment
        {
            get
            {
                return (this.targets & SearchTargetType.COMMENT) != 0;
            }
        }

        public bool IncludeShape
        {
            get
            {
                return (this.targets & SearchTargetType.SHAPE) != 0;
            }
        }

        public bool IncludeChart
        {
            get
            {
                return (this.targets & SearchTargetType.CHART) != 0;
            }
        }
    }
}
