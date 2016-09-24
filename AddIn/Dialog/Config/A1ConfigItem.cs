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
        /// 「開く」ボタン押下時に呼び出されます。
        /// </summary>
        public override void OnRefresh()
        {
            this.config = ConfigDocument.Current.Edit.A1;
            this.Deserialize();
        }

        /// <summary>
        /// 「設定後に保存する」のチェック状態が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void AutoSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;

            this.autoSaveOverwriteDropDownList.Enabled = checkbox.Checked;
        }

        /// <summary>
        /// 「グループ化を設定する」のチェック状態が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void GroupEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;

            this.rowLevelsLabel.Enabled = checkbox.Checked;
            this.columnLevelsLabel.Enabled = checkbox.Checked;
            this.rowLevelsTextBox.Enabled = checkbox.Checked;
            this.columnLevelsTextBox.Enabled = checkbox.Checked;
        }

        /// <summary>
        /// 「表示倍率を設定する」の入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ZoomEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;

            this.zoomRatioComboBox.Enabled = checkbox.Checked;
        }

        /// <summary>
        /// 表示倍率の入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ZoomRatioComboBox_Validating(object sender, CancelEventArgs e)
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
            this.zoomEnabledCheckBox.Checked = this.config.ZoomEnabled;
            this.zoomRatioComboBox.Text = this.config.ZoomRatio.ToString();
            this.groupEnabledCheckBox.Checked = this.config.GroupEnabled;
            this.rowLevelsTextBox.Text = this.config.RowLevels.ToString();
            this.columnLevelsTextBox.Text = this.config.ColumnLevels.ToString();
            this.autoSaveCheckBox.Checked = this.config.AutoSaveEnabled;
            this.autoSaveOverwriteDropDownList.SelectedIndex = this.config.AutoSaveOverwrite ? 0 : 1;

            // 付随項目の表示状態を更新する
            this.zoomRatioComboBox.Enabled = this.config.ZoomEnabled;
            this.rowLevelsLabel.Enabled = this.config.GroupEnabled;
            this.columnLevelsLabel.Enabled = this.config.GroupEnabled;
            this.rowLevelsTextBox.Enabled = this.config.GroupEnabled;
            this.columnLevelsTextBox.Enabled = this.config.GroupEnabled;
            this.autoSaveOverwriteDropDownList.Enabled = this.config.AutoSaveEnabled;
        }

        /// <summary>
        /// 「画面に設定された情報」を「現在の設定」に反映します。
        /// </summary>
        private void Serialize()
        {
            this.config.ZoomEnabled = this.zoomEnabledCheckBox.Checked;
            this.config.ZoomRatio = int.Parse(this.zoomRatioComboBox.Text);
            this.config.GroupEnabled = this.groupEnabledCheckBox.Checked;
            this.config.RowLevels = int.Parse(this.rowLevelsTextBox.Text);
            this.config.ColumnLevels = int.Parse(this.columnLevelsTextBox.Text);
            this.config.AutoSaveEnabled = this.autoSaveCheckBox.Checked;
            this.config.AutoSaveOverwrite = this.autoSaveOverwriteDropDownList.SelectedIndex == 0;
        }

        /// <summary>
        /// グループ化レベルの入力値が検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void GroupLevelsTextBox_Validating(object sender, CancelEventArgs e)
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
