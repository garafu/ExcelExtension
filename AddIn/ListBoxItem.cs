namespace ExcelX.AddIn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// ListBox の DataSouce に投入するデータ型
    /// </summary>
    /// <typeparam name="T">列挙体を指定します</typeparam>
    public class ListBoxItem<T>
        where T : struct
    {
        /// <summary>
        /// キー値の実態
        /// </summary>
        private T key;

        /// <summary>
        /// 列挙値を指定して ListBoxItem を初期化します。
        /// </summary>
        /// <param name="item">列挙体</param>
        public ListBoxItem(T item)
        {
            this.key = item;
        }

        /// <summary>
        /// キーを取得または設定します。
        /// </summary>
        public T Key
        {
            get
            {
                return this.key;
            }

            set
            {
                this.key = value;
            }
        }

        /// <summary>
        /// 表示名を取得します。
        /// </summary>
        public string Value
        {
            get
            {
                if (this.key is Enum)
                {
                    return (this.key as Enum).GetDisplayName();
                }

                return this.key.ToString();
            }
        }

        /// <summary>
        /// 項目を示す文字列を取得します。
        /// </summary>
        /// <returns>項目を表す文字列</returns>
        public override string ToString()
        {
            return this.Value;
        }
    }
}
