namespace ExcelX.AddIn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 列挙子に表示名を設定します。設定した表示名は GetDisplayName 拡張メソッド から取得できます。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field,
        AllowMultiple = false,
        Inherited = false)]
    public class DisplayNameAttribute : Attribute
    {
        /// <summary>
        /// 表示名
        /// </summary>
        private string text = string.Empty;

        /// <summary>
        /// 表示名を指定して DisplayNameAttribute クラス の インスタンス を初期化します。
        /// </summary>
        /// <param name="text">表示名</param>
        public DisplayNameAttribute(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// 表示名を取得します。
        /// </summary>
        public string Text
        {
            get
            {
                return this.text;
            }
        }
    }
}
