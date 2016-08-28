namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 色設定
    /// </summary>
    public class ColorConfig
    {
        /// <summary>
        /// ColorConfig クラスのインスタンスを初期化します。
        /// </summary>
        public ColorConfig()
        {
            this.R = 0;
            this.G = 0;
            this.B = 0;
            this.A = 1.0f;
        }

        /// <summary>
        /// 値を指定して ColorConfig クラスのインスタンスを初期化します。
        /// </summary>
        /// <param name="red">赤(0 - 255)</param>
        /// <param name="green">緑(0 - 255)</param>
        /// <param name="blue">青(0 - 255)</param>
        /// <param name="alpha">透過率(0.0 - 1.0)</param>
        public ColorConfig(int red, int green, int blue, float alpha = 1.0f)
        {
            this.R = red;
            this.G = green;
            this.B = blue;
            this.A = alpha;
        }

        /// <summary>
        /// 赤色を示す値を取得または設定します。
        /// </summary>
        [XmlAttribute("R")]
        public int R { get; set; }

        /// <summary>
        /// 緑色を示す値を取得または設定します。
        /// </summary>
        [XmlAttribute("G")]
        public int G { get; set; }

        /// <summary>
        /// 青色を示す値を取得または設定します。
        /// </summary>
        [XmlAttribute("B")]
        public int B { get; set; }

        /// <summary>
        /// 透過率を示す値を取得または設定します。
        /// </summary>
        [XmlAttribute("A")]
        public float A { get; set; }

        /// <summary>
        /// 透過率を考慮しない Color 構造体を取得します。
        /// </summary>
        public int Color
        {
            get
            {
                return System.Drawing.Color.FromArgb(this.B, this.G, this.R).ToArgb();
            }
        }

        /// <summary>
        /// 透過率を取得します。
        /// </summary>
        public float Transparency
        {
            get
            {
                return this.A;
            }
        }

        /// <summary>
        /// ColorConfig クラス を Color 構造体 へ暗黙の型変換を行います。
        /// </summary>
        /// <param name="config">変換元のデータ</param>
        /// <returns>変換されたデータ</returns>
        public static implicit operator Color(ColorConfig config)
        {
            return System.Drawing.Color.FromArgb(config.R, config.G, config.B);
        }

        /// <summary>
        /// Color 構造体 を ColorConfig クラス へ暗黙の型変換を行います。
        /// </summary>
        /// <param name="color">変換元のデータ</param>
        /// <returns>変換されたデータ</returns>
        public static implicit operator ColorConfig(Color color)
        {
            return new ColorConfig(color.R, color.G, color.B, (float)color.A / 255.0f);
        }
    }
}
