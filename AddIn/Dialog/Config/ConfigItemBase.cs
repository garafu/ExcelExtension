namespace ExcelX.AddIn.Dialog.Config
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// 各設定を表示する基本コントロール
    /// </summary>
    public partial class ConfigItemBase : UserControl
    {
        /// <summary>
        /// ConfigItemBase クラスのインスタンスを初期化します。
        /// </summary>
        public ConfigItemBase()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// カテゴリ名を取得します。
        /// </summary>
        public virtual string CategoryName
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// GUIDを取得します。
        /// </summary>
        public virtual string GUID
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 設定項目名を取得します。
        /// </summary>
        public virtual string ItemName
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 「適用」ボタン押下時に呼び出されます。
        /// </summary>
        public virtual void OnApply()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 「非表示」時に呼び出されます。
        /// </summary>
        public virtual void OnHide()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 「表示」時に呼び出されます。
        /// </summary>
        public virtual void OnShow()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 「開く」ボタン押下時に呼び出されます。
        /// </summary>
        public virtual void OnRefresh()
        {
            throw new NotImplementedException();
        }
    }
}
