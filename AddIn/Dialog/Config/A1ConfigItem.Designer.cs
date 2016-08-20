namespace ExcelX.AddIn.Dialog.Config
{
    partial class A1ConfigItem
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ChkZoomEnabled = new System.Windows.Forms.CheckBox();
            this.CmbZoomRatio = new System.Windows.Forms.ComboBox();
            this.ChkGroupEnabled = new System.Windows.Forms.CheckBox();
            this.LblRowLevels = new System.Windows.Forms.Label();
            this.TxtRowLevels = new System.Windows.Forms.TextBox();
            this.LblColumnLevels = new System.Windows.Forms.Label();
            this.TxtColumnLevels = new System.Windows.Forms.TextBox();
            this.ChkAutoSave = new System.Windows.Forms.CheckBox();
            this.DdlAutoSaveOverwrite = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkZoomEnabled
            // 
            this.ChkZoomEnabled.AutoSize = true;
            this.ChkZoomEnabled.Location = new System.Drawing.Point(23, 13);
            this.ChkZoomEnabled.Name = "ChkZoomEnabled";
            this.ChkZoomEnabled.Size = new System.Drawing.Size(124, 16);
            this.ChkZoomEnabled.TabIndex = 0;
            this.ChkZoomEnabled.Text = "表示倍率を設定する";
            this.ChkZoomEnabled.UseVisualStyleBackColor = true;
            this.ChkZoomEnabled.CheckedChanged += new System.EventHandler(this.ChkZoomEnabled_CheckedChanged);
            // 
            // CmbZoomRatio
            // 
            this.CmbZoomRatio.FormattingEnabled = true;
            this.CmbZoomRatio.Items.AddRange(new object[] {
            "70",
            "80",
            "85",
            "90",
            "100",
            "110",
            "120"});
            this.CmbZoomRatio.Location = new System.Drawing.Point(216, 11);
            this.CmbZoomRatio.Name = "CmbZoomRatio";
            this.CmbZoomRatio.Size = new System.Drawing.Size(121, 20);
            this.CmbZoomRatio.TabIndex = 2;
            this.CmbZoomRatio.Validating += new System.ComponentModel.CancelEventHandler(this.CmbZoomRatio_Validating);
            // 
            // ChkGroupEnabled
            // 
            this.ChkGroupEnabled.AutoSize = true;
            this.ChkGroupEnabled.Location = new System.Drawing.Point(23, 65);
            this.ChkGroupEnabled.Name = "ChkGroupEnabled";
            this.ChkGroupEnabled.Size = new System.Drawing.Size(126, 16);
            this.ChkGroupEnabled.TabIndex = 3;
            this.ChkGroupEnabled.Text = "グループ化を設定する";
            this.ChkGroupEnabled.UseVisualStyleBackColor = true;
            this.ChkGroupEnabled.CheckedChanged += new System.EventHandler(this.ChkGroupEnabled_CheckedChanged);
            // 
            // LblRowLevels
            // 
            this.LblRowLevels.AutoSize = true;
            this.LblRowLevels.Location = new System.Drawing.Point(214, 66);
            this.LblRowLevels.Name = "LblRowLevels";
            this.LblRowLevels.Size = new System.Drawing.Size(108, 12);
            this.LblRowLevels.TabIndex = 4;
            this.LblRowLevels.Text = "行グループ表示レベル";
            // 
            // TxtRowLevels
            // 
            this.TxtRowLevels.Location = new System.Drawing.Point(340, 63);
            this.TxtRowLevels.Name = "TxtRowLevels";
            this.TxtRowLevels.Size = new System.Drawing.Size(100, 19);
            this.TxtRowLevels.TabIndex = 5;
            this.TxtRowLevels.Validating += new System.ComponentModel.CancelEventHandler(this.TxtGroupLevels_Validating);
            // 
            // LblColumnLevels
            // 
            this.LblColumnLevels.AutoSize = true;
            this.LblColumnLevels.Location = new System.Drawing.Point(214, 91);
            this.LblColumnLevels.Name = "LblColumnLevels";
            this.LblColumnLevels.Size = new System.Drawing.Size(108, 12);
            this.LblColumnLevels.TabIndex = 6;
            this.LblColumnLevels.Text = "列グループ表示レベル";
            // 
            // TxtColumnLevels
            // 
            this.TxtColumnLevels.Location = new System.Drawing.Point(340, 88);
            this.TxtColumnLevels.Name = "TxtColumnLevels";
            this.TxtColumnLevels.Size = new System.Drawing.Size(100, 19);
            this.TxtColumnLevels.TabIndex = 7;
            this.TxtColumnLevels.Validating += new System.ComponentModel.CancelEventHandler(this.TxtGroupLevels_Validating);
            // 
            // ChkAutoSave
            // 
            this.ChkAutoSave.AutoSize = true;
            this.ChkAutoSave.Location = new System.Drawing.Point(23, 137);
            this.ChkAutoSave.Name = "ChkAutoSave";
            this.ChkAutoSave.Size = new System.Drawing.Size(112, 16);
            this.ChkAutoSave.TabIndex = 8;
            this.ChkAutoSave.Text = "設定後に保存する";
            this.ChkAutoSave.UseVisualStyleBackColor = true;
            this.ChkAutoSave.CheckedChanged += new System.EventHandler(this.ChkAutoSave_CheckedChanged);
            // 
            // DdlAutoSaveOverwrite
            // 
            this.DdlAutoSaveOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlAutoSaveOverwrite.FormattingEnabled = true;
            this.DdlAutoSaveOverwrite.Items.AddRange(new object[] {
            "上書き保存",
            "名前を付けて保存"});
            this.DdlAutoSaveOverwrite.Location = new System.Drawing.Point(216, 135);
            this.DdlAutoSaveOverwrite.Name = "DdlAutoSaveOverwrite";
            this.DdlAutoSaveOverwrite.Size = new System.Drawing.Size(121, 20);
            this.DdlAutoSaveOverwrite.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // A1ConfigItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DdlAutoSaveOverwrite);
            this.Controls.Add(this.ChkAutoSave);
            this.Controls.Add(this.TxtColumnLevels);
            this.Controls.Add(this.LblColumnLevels);
            this.Controls.Add(this.TxtRowLevels);
            this.Controls.Add(this.LblRowLevels);
            this.Controls.Add(this.ChkGroupEnabled);
            this.Controls.Add(this.CmbZoomRatio);
            this.Controls.Add(this.ChkZoomEnabled);
            this.Name = "A1ConfigItem";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkZoomEnabled;
        private System.Windows.Forms.ComboBox CmbZoomRatio;
        private System.Windows.Forms.CheckBox ChkGroupEnabled;
        private System.Windows.Forms.Label LblRowLevels;
        private System.Windows.Forms.TextBox TxtRowLevels;
        private System.Windows.Forms.Label LblColumnLevels;
        private System.Windows.Forms.TextBox TxtColumnLevels;
        private System.Windows.Forms.CheckBox ChkAutoSave;
        private System.Windows.Forms.ComboBox DdlAutoSaveOverwrite;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
