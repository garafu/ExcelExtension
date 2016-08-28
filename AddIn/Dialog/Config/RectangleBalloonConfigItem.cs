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
    /// 「吹き出し」に関する設定画面
    /// </summary>
    public partial class RectangleBalloonConfigItem : ConfigItemBase
    {
        /// <summary>
        /// オリジナルの設定データ
        /// </summary>
        private List<RectangleBalloonConfig> originals = ConfigDocument.Current.Shape.RectangleBalloonList;

        /// <summary>
        /// 編集中の設定データ
        /// </summary>
        private List<RectangleBalloonConfig> edits = new List<RectangleBalloonConfig>();

        /// <summary>
        /// RectangleBalloonConfigItem クラスのインスタンスを初期化します。
        /// </summary>
        public RectangleBalloonConfigItem()
        {
            // 最初の選択肢インデックスを設定
            this.CurrentSelectedIndex = 0;

            // コンポーネントを初期化
            this.InitializeComponent();

            // フォントコンボボックスを初期化
            var fonts = new System.Drawing.Text.InstalledFontCollection();
            var items = (from item in fonts.Families
                         select item.Name).ToArray();
            this.fontNameComboBox.Items.AddRange(items);

            // 設定を読み込み
            this.Deserialize();
        }

        /// <summary>
        /// GUID を取得します。
        /// </summary>
        public override string GUID
        {
            get
            {
                return "{A94F9F5D-2EDF-4E9D-A8D4-3230064702F7}";
            }
        }

        /// <summary>
        /// カテゴリ名を取得します。
        /// </summary>
        public override string CategoryName
        {
            get
            {
                return Const.ConfigCategoryName.Shape;
            }
        }

        /// <summary>
        /// 設定項目名を取得します。
        /// </summary>
        public override string ItemName
        {
            get
            {
                return "吹き出し";
            }
        }

        /// <summary>
        /// 現在選択中のプロファイルインデックスを取得または設定します。
        /// </summary>
        private int CurrentSelectedIndex { get; set; }

        /// <summary>
        /// 「適用」ボタン押下時に呼び出されます。
        /// </summary>
        public override void OnApply()
        {
            // 現在の状態を保存
            this.Save(this.edits[this.profileComboBox.SelectedIndex]);

            // 設定に反映
            this.Serialize();
        }

        /// <summary>
        /// 「非表示」時に呼び出されます。
        /// </summary>
        public override void OnHide()
        {
            // 現在の状態を保存
            this.Save(this.edits[this.profileComboBox.SelectedIndex]);
        }

        /// <summary>
        /// 「表示」時に呼び出されます。
        /// </summary>
        public override void OnShow()
        {
            // 前回の選択状態を復元
            this.profileComboBox.SelectedIndex = this.CurrentSelectedIndex;
            this.Load(this.edits[this.CurrentSelectedIndex]);
        }

        /// <summary>
        /// 枠線透過率の数値が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BorderAlphaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (this.borderAlphaNumericUpDown.Focused == false)
            {
                return;
            }

            // NumericUpDown の値を TrackBar へ反映
            this.borderAlphaTrackBar.Value = (int)this.borderAlphaNumericUpDown.Value;
        }

        /// <summary>
        /// 枠線透過率のスライダが変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BorderAlphaTrackBar_Scroll(object sender, EventArgs e)
        {
            if (this.borderAlphaTrackBar.Focused == false)
            {
                return;
            }

            // スクロール状態を NumericUpDown へ反映
            this.borderAlphaNumericUpDown.Value = this.borderAlphaTrackBar.Value;
        }

        /// <summary>
        /// 枠線色ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void BorderColorButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = this.borderColorLabel.BackColor;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.borderColorLabel.BackColor = dialog.Color;
        }

        /// <summary>
        /// 表示名テキストボックスの値が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void DisplayNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.displayNameTextBox.Focused == false)
            {
                return;
            }

            this.profileComboBox.Items[this.CurrentSelectedIndex] = this.displayNameTextBox.Text;
        }

        /// <summary>
        /// 塗りつぶし透過率の値が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void FillAlphaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (this.fillAlphaNumericUpDown.Focused == false)
            {
                return;
            }

            // NumericUpDown の値を TrackBar へ反映
            this.fillAlphaTrackBar.Value = (int)this.fillAlphaNumericUpDown.Value;
        }

        /// <summary>
        /// 塗りつぶし透過率のスライダが変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void FillAlphaTrackBar_Scroll(object sender, EventArgs e)
        {
            if (this.fillAlphaTrackBar.Focused == false)
            {
                return;
            }

            // スクロール状態を NumericUpDown へ反映
            this.fillAlphaNumericUpDown.Value = this.fillAlphaTrackBar.Value;
        }

        /// <summary>
        /// 塗りつぶし色ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void FillColorButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = this.fillColorLabel.BackColor;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.fillColorLabel.BackColor = dialog.Color;
        }

        /// <summary>
        /// フォント色ボタンが押下されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void FontColorButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = this.fontColorLabel.BackColor;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.fontColorLabel.BackColor = dialog.Color;
        }

        /// <summary>
        /// フォントサイズが変更され検証されるとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void FontSizeComboBox_Validating(object sender, CancelEventArgs e)
        {
            float result;

            // float に変換できる文字列が入力されているかどうか
            if (float.TryParse(this.fontSizeComboBox.Text, out result) == true)
            {
                return;
            }

            // 操作をキャンセルして値を元に戻す
            e.Cancel = true;
            this.fontSizeComboBox.Text = this.edits[this.CurrentSelectedIndex].FontSize.ToString();
        }

        /// <summary>
        /// プロファイルコンボボックスの選択が変更されたとき呼び出されます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベント変数</param>
        private void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CurrentSelectedIndex == this.profileComboBox.SelectedIndex)
            {
                return;
            }

            // 古いプロファイルを保存
            this.Save(this.edits[this.CurrentSelectedIndex]);

            // 新しいプロファイルを読み込み
            this.Load(this.edits[this.profileComboBox.SelectedIndex]);

            // 現在の選択肢を更新
            this.CurrentSelectedIndex = this.profileComboBox.SelectedIndex;
        }

        /// <summary>
        /// 「画面に設定された情報」を「現在の設定」に反映します。
        /// </summary>
        private void Serialize()
        {
            this.originals.Clear();
            this.originals.AddRange(this.edits);
        }

        /// <summary>
        /// 「現在の設定」を「画面」に反映します。
        /// </summary>
        private void Deserialize()
        {
            foreach (var original in this.originals)
            {
                var editable = original.Close();
                this.edits.Add(editable);
                this.profileComboBox.Items.Add(editable.DisplayName);
            }
        }

        /// <summary>
        /// 指定された設定情報を画面に反映します。
        /// </summary>
        /// <param name="config">設定情報</param>
        private new void Load(RectangleBalloonConfig config)
        {
            this.displayNameTextBox.Text = config.DisplayName;
            this.enabledCheckBox.Checked = config.Enabled;
            this.widthNumericUpDown.Value = (decimal)config.Width;
            this.heightNumericUpDown.Value = (decimal)config.Height;
            this.fillColorLabel.BackColor = config.BackgroundColor;
            this.fillAlphaTrackBar.Value = (int)(config.BackgroundColor.Transparency * 100);
            this.fillAlphaNumericUpDown.Value = (decimal)(config.BackgroundColor.Transparency * 100);
            this.borderColorLabel.BackColor = config.BorderColor;
            this.borderAlphaTrackBar.Value = (int)(config.BorderColor.Transparency * 100);
            this.borderAlphaNumericUpDown.Value = (decimal)(config.BorderColor.Transparency * 100);
            this.borderSizeNumericUpDown.Value = (decimal)config.BorderSize;
            this.fontNameComboBox.Text = config.FontName;
            this.fontSizeComboBox.Text = config.FontSize.ToString();
            this.fontColorLabel.BackColor = config.FontColor;
        }

        /// <summary>
        /// 画面に設定された値を指定された設定情報に反映します。
        /// </summary>
        /// <param name="config">設定情報</param>
        private void Save(RectangleBalloonConfig config)
        {
            config.DisplayName = this.displayNameTextBox.Text;
            config.Enabled = this.enabledCheckBox.Checked;
            config.Width = (float)this.widthNumericUpDown.Value;
            config.Height = (float)this.heightNumericUpDown.Value;
            config.BackgroundColor = this.fillColorLabel.BackColor;
            config.BackgroundColor.A = (float)this.fillAlphaNumericUpDown.Value / 100.0f;
            config.BorderColor = this.borderColorLabel.BackColor;
            config.BorderColor.A = (float)this.borderAlphaNumericUpDown.Value / 100.0f;
            config.BorderSize = (int)this.borderSizeNumericUpDown.Value;
            config.FontName = this.fontNameComboBox.Text;
            config.FontSize = int.Parse(this.fontSizeComboBox.Text);
            config.FontColor = this.fontColorLabel.BackColor;
        }
    }
}
