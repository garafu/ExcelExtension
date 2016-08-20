namespace ExcelX.AddIn.Const
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// エラーメッセージの定義
    /// </summary>
    public static class ErrorMessage
    {
        /// <summary>
        /// 「10 ～ 400 の整数を入力してください。」
        /// </summary>
        public const string IntegerOf10To400 = @"10 ～ 400 の整数を入力してください。";

        /// <summary>
        /// 「1 以上の整数を入力してください。」
        /// </summary>
        public const string IntegerOf1OrMore = @"1 以上の整数を入力してください。";
    }
}
