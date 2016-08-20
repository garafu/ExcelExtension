namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 編集グループの設定
    /// </summary>
    public class EditConfig
    {
        /// <summary>
        /// 「A1」コマンドに関する設定を取得または設定します。
        /// </summary>
        [XmlElement("A1")]
        public A1Config A1 { get; set; }

        /// <summary>
        /// 「方眼紙」コマンドに関する設定を取得または設定します。
        /// </summary>
        [XmlElement("Grid")]
        public GridConfig Grid { get; set; }
    }
}
