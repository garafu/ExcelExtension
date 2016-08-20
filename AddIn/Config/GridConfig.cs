namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 「方眼紙」コマンドに関する設定
    /// </summary>
    public class GridConfig
    {
        /// <summary>
        /// 表示倍率を取得または設定します。
        /// </summary>
        [XmlElement("Size")]
        public int Size { get; set; }
    }
}
