namespace ExcelX.AddIn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 列挙体の拡張メソッドを提供します。
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// 属性 DisplayNameAttribute で指定された 文字列 を取得します。
        /// </summary>
        /// <param name="value">文字列取得したい列挙子</param>
        /// <returns>取得された文字列</returns>
        public static string GetDisplayName(this Enum value)
        {
            // MemberInfo を取得
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            var memberInfo = type.GetMember(name).First();

            // 設定されている属性を取得
            var attribute = Attribute.GetCustomAttribute(memberInfo, typeof(DisplayNameAttribute));

            // 属性から表示名を取得。取得できなければ空文字を返す。
            var displayName = attribute as DisplayNameAttribute;
            if (displayName != null)
            {
                return displayName.Text;
            }

            return string.Empty;
        }
    }
}
