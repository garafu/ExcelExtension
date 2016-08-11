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
        /// <summary>
        /// 検索対象種別
        /// </summary>
        private SearchTargetType targets;

        /// <summary>
        /// 検索対象種別を指定して SearchTarget クラスを初期化します。
        /// </summary>
        /// <param name="targets">検索対象種別</param>
        public SearchTarget(SearchTargetType targets)
        {
            this.targets = targets;
        }

        /// <summary>
        /// 検索対象を個別に指定して SearchTarget クラスを初期化します。
        /// </summary>
        /// <param name="includeFormula">セル(式)を対象とするかどうか</param>
        /// <param name="includeValue">セル(値)を対象とするかどうか</param>
        /// <param name="includeComment">コメントを対象とするかどうか</param>
        /// <param name="includeShape">シェイプを対象とするかどうか</param>
        /// <param name="includeChart">グラフを対象とするかどうか</param>
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

        /// <summary>
        /// セル(式)を対象とするかどうかを取得します。
        /// </summary>
        public bool IncludeFormula
        {
            get
            {
                return (this.targets & SearchTargetType.FORMULA) != 0;
            }
        }

        /// <summary>
        /// セル(値)を対象とするかどうかを取得します。
        /// </summary>
        public bool IncludeValue
        {
            get
            {
                return (this.targets & SearchTargetType.VALUE) != 0;
            }
        }

        /// <summary>
        /// コメントを対象とするかどうかを取得します。
        /// </summary>
        public bool IncludeComment
        {
            get
            {
                return (this.targets & SearchTargetType.COMMENT) != 0;
            }
        }

        /// <summary>
        /// シェイプを対象とするかどうかを取得します。
        /// </summary>
        public bool IncludeShape
        {
            get
            {
                return (this.targets & SearchTargetType.SHAPE) != 0;
            }
        }

        /// <summary>
        /// グラフを対象とするかどうかを取得します。
        /// </summary>
        public bool IncludeChart
        {
            get
            {
                return (this.targets & SearchTargetType.CHART) != 0;
            }
        }
    }
}
