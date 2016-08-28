namespace ExcelX.AddIn.Config
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 「吹き出し」に関する設定
    /// </summary>
    public class RectangleBalloonConfig
    {
        /// <summary>
        /// 表示名を取得または設定します。
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 有効かどうかを示す値を取得または設定します。
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 幅を取得または設定します。
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// 高さを取得または設定します。
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// 枠線の太さを取得または設定します。
        /// </summary>
        public float BorderSize { get; set; }

        /// <summary>
        /// 枠線の色を取得または設定します。
        /// </summary>
        public ColorConfig BorderColor { get; set; }

        /// <summary>
        /// 背景色を取得または設定します。
        /// </summary>
        public ColorConfig BackgroundColor { get; set; }

        /// <summary>
        /// フォントサイズを取得または設定します。
        /// </summary>
        public float FontSize { get; set; }

        /// <summary>
        /// フォント色を取得または設定します。
        /// </summary>
        public ColorConfig FontColor { get; set; }

        /// <summary>
        /// フォント名を取得または設定します。
        /// </summary>
        public string FontName { get; set; }

        /// <summary>
        /// 現在の設定情報を複製します。
        /// </summary>
        /// <returns>複製された設定情報</returns>
        public RectangleBalloonConfig Close()
        {
            return new RectangleBalloonConfig()
            {
                DisplayName = this.DisplayName,
                Enabled = this.Enabled,
                Width = this.Width,
                Height = this.Height,
                BorderSize = this.BorderSize,
                BorderColor = this.BorderColor,
                BackgroundColor = this.BackgroundColor,
                FontSize = this.FontSize,
                FontColor = this.FontColor,
                FontName = this.FontName
            };
        }
    }
}
