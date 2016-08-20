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
    /// 「A1」に関する設定画面
    /// </summary>
    public partial class A1ConfigItem : ConfigItemBase
    {
        /// <summary>
        /// 「A1」に関する設定
        /// </summary>
        private A1Config config = ConfigDocument.Current.Edit.A1;

        /// <summary>
        /// A1ConfigItem クラスのインスタンスを初期化します。
        /// </summary>
        public A1ConfigItem()
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
                return "{805D9A2B-D071-4002-8A02-F97D0C86E9CF}";
            }
        }

        /// <summary>
        /// 設定項目名を取得します。
        /// </summary>
        public override string ItemName
        {
            get
            {
                return "A1";
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
        /// 「設定後に保存する」のチェック状態が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ChkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;

            this.DdlAutoSaveOverwrite.Enabled = checkbox.Checked;
        }

        /// <summary>
        /// 「グループ化を設定する」のチェック状態が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ChkGroupEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;

            this.LblRowLevels.Enabled = checkbox.Checked;
            this.LblColumnLevels.Enabled = checkbox.Checked;
            this.TxtRowLevels.Enabled = checkbox.Checked;
            this.TxtColumnLevels.Enabled = checkbox.Checked;
        }

        /// <summary>
        /// 「表示倍率を設定する」の入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ChkZoomEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;

            this.CmbZoomRatio.Enabled = checkbox.Checked;
        }

        /// <summary>
        /// 表示倍率の入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void CmbZoomRatio_Validating(object sender, CancelEventArgs e)
        {
            var combobox = sender as ComboBox;
            int ratio = 0;

            if (int.TryParse(combobox.Text, out ratio) == true &&
                (10 <= ratio && ratio <= 400))
            {
                this.errorProvider.SetError(combobox, string.Empty);
            }
            else
            {
                this.errorProvider.SetError(combobox, ErrorMessage.IntegerOf10To400);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 「現在の設定」を「画面」に反映します。
        /// </summary>
        private void Deserialize()
        {
            // 値を設定する
            this.ChkZoomEnabled.Checked = this.config.ZoomEnabled;
            this.CmbZoomRatio.Text = this.config.ZoomRatio.ToString();
            this.ChkGroupEnabled.Checked = this.config.GroupEnabled;
            this.TxtRowLevels.Text = this.config.RowLevels.ToString();
            this.TxtColumnLevels.Text = this.config.ColumnLevels.ToString();
            this.ChkAutoSave.Checked = this.config.AutoSaveEnabled;
            this.DdlAutoSaveOverwrite.SelectedIndex = this.config.AutoSaveOverwrite ? 0 : 1;

            // 付随項目の表示状態を更新する
            this.CmbZoomRatio.Enabled = this.config.ZoomEnabled;
            this.LblRowLevels.Enabled = this.config.GroupEnabled;
            this.LblColumnLevels.Enabled = this.config.GroupEnabled;
            this.TxtRowLevels.Enabled = this.config.GroupEnabled;
            this.TxtColumnLevels.Enabled = this.config.GroupEnabled;
            this.DdlAutoSaveOverwrite.Enabled = this.config.AutoSaveEnabled;
        }

        /// <summary>
        /// 「画面に設定された情報」を「現在の設定」に反映します。
        /// </summary>
        private void Serialize()
        {
            this.config.ZoomEnabled = this.ChkZoomEnabled.Checked;
            this.config.ZoomRatio = int.Parse(this.CmbZoomRatio.Text);
            this.config.GroupEnabled = this.ChkGroupEnabled.Checked;
            this.config.RowLevels = int.Parse(this.TxtRowLevels.Text);
            this.config.ColumnLevels = int.Parse(this.TxtColumnLevels.Text);
            this.config.AutoSaveEnabled = this.ChkAutoSave.Checked;
            this.config.AutoSaveOverwrite = this.DdlAutoSaveOverwrite.SelectedIndex == 0;
        }

        /// <summary>
        /// グループ化レベルの入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void TxtGroupLevels_Validating(object sender, CancelEventArgs e)
        {
            var textbox = sender as TextBox;
            int level = 0;

            if (int.TryParse(textbox.Text, out level) == true &&
                0 < level)
            {
                this.errorProvider.SetError(textbox, string.Empty);
            }
            else
            {
                this.errorProvider.SetError(textbox, ErrorMessage.IntegerOf1OrMore);
                e.Cancel = true;
            }
        }
    }
}
