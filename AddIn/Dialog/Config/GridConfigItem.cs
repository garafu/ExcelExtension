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
    using ExcelX.AddIn.Config;
    using ExcelX.AddIn.Const;

    /// <summary>
    /// 「方眼紙」に関する設定画面
    /// </summary>
    public partial class GridConfigItem : ConfigItemBase
    {
        /// <summary>
        /// 「方眼紙」に関する設定
        /// </summary>
        private GridConfig config = ConfigDocument.Current.Edit.Grid;

        /// <summary>
        /// GridConfigItem クラスのインスタンスを初期化します。
        /// </summary>
        public GridConfigItem()
        {
            this.InitializeComponent();
            this.Deserialize();
        }

        /// <summary>
        /// カテゴリ名を取得します。
        /// </summary>
        public override string CategoryName
        {
            get
            {
                return ConfigCategoryName.Edit;
            }
        }

        /// <summary>
        /// GUIDを取得します。
        /// </summary>
        public override string GUID
        {
            get
            {
                return "{FDC04A7B-0AA0-4ADA-8722-C93144DAACF7}";
            }
        }

        /// <summary>
        /// 設定項目名を取得します。
        /// </summary>
        public override string ItemName
        {
            get
            {
                return "方眼紙";
            }
        }

        /// <summary>
        /// 「適用」ボタン押下時に呼び出されます。
        /// </summary>
        public override void OnApply()
        {
            this.Serialize();
        }

        /// <summary>
        /// 「非表示」時に呼び出されます。
        /// </summary>
        public override void OnHide()
        {
        }

        /// <summary>
        /// 「表示」時に呼び出されます。
        /// </summary>
        public override void OnShow()
        {
        }

        /// <summary>
        /// 「開く」ボタン押下時に呼び出されます。
        /// </summary>
        public override void OnRefresh()
        {
            this.config = ConfigDocument.Current.Edit.Grid;
            this.Deserialize();
        }

        /// <summary>
        /// サイズの入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void SizeComboBox_Validating(object sender, CancelEventArgs e)
        {
            var combobox = sender as ComboBox;
            int size = 0;

            if (int.TryParse(combobox.Text, out size) == true &&
                0 < size)
            {
                this.errorProvider.SetError(combobox, string.Empty);
            }
            else
            {
                this.errorProvider.SetError(combobox, ErrorMessage.IntegerOf1OrMore);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 「現在の設定」を「画面」に反映します。
        /// </summary>
        private void Deserialize()
        {
            this.SizeComboBox.Text = this.config.Size.ToString();
        }

        /// <summary>
        /// 「画面に設定された情報」を「現在の設定」に反映します。
        /// </summary>
        private void Serialize()
        {
            this.config.Size = int.Parse(this.SizeComboBox.Text);
        }
    }
}
