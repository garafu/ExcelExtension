namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 図形グループの設定
    /// </summary>
    public class ShapeConfig
    {
        /// <summary>
        /// 「吹き出し」に関する設定を取得または設定します。
        /// </summary>
        [XmlElement("RectangleBalloon")]
        public List<RectangleBalloonConfig> RectangleBalloonList { get; set; }
    }
}
