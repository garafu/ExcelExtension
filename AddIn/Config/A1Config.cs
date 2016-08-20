namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 「A1」コマンドに関する設定
    /// </summary>
    public class A1Config
    {
        /// <summary>
        /// 拡大率を変更するかどうかを示す値を取得または設定します。
        /// </summary>
        [XmlElement("ZoomEnabled")]
        public bool ZoomEnabled { get; set; }

        /// <summary>
        /// 拡大率を取得または設定します。
        /// </summary>
        [XmlElement("ZoomRatio")]
        public int ZoomRatio { get; set; }

        /// <summary>
        /// 自動保存するかどうかを示す値を取得または設定します。
        /// </summary>
        [XmlElement("AutoSave")]
        public bool AutoSave { get; set; }

        /// <summary>
        /// グループ化設定を変更するかどうかを示す値を取得または設定します。
        /// </summary>
        [XmlElement("GroupEnabled")]
        public bool GroupEnabled { get; set; }

        /// <summary>
        /// 行方向のグループ化表示レベルを取得または設定します。
        /// </summary>
        [XmlElement("RowLevels")]
        public int RowLevels { get; set; }

        /// <summary>
        /// 列方向のグループ化表示レベルを取得または設定します。
        /// </summary>
        [XmlElement("ColumnLevels")]
        public int ColumnLevels { get; set; }
    }
}
