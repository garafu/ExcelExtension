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
            this.zoomEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.zoomRatioComboBox = new System.Windows.Forms.ComboBox();
            this.groupEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.rowLevelsLabel = new System.Windows.Forms.Label();
            this.rowLevelsTextBox = new System.Windows.Forms.TextBox();
            this.columnLevelsLabel = new System.Windows.Forms.Label();
            this.columnLevelsTextBox = new System.Windows.Forms.TextBox();
            this.autoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSaveOverwriteDropDownList = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomEnabledCheckBox
            // 
            this.zoomEnabledCheckBox.AutoSize = true;
            this.zoomEnabledCheckBox.Location = new System.Drawing.Point(23, 13);
            this.zoomEnabledCheckBox.Name = "zoomEnabledCheckBox";
            this.zoomEnabledCheckBox.Size = new System.Drawing.Size(124, 16);
            this.zoomEnabledCheckBox.TabIndex = 0;
            this.zoomEnabledCheckBox.Text = "表示倍率を設定する";
            this.zoomEnabledCheckBox.UseVisualStyleBackColor = true;
            this.zoomEnabledCheckBox.CheckedChanged += new System.EventHandler(this.ZoomEnabledCheckBox_CheckedChanged);
            // 
            // zoomRatioComboBox
            // 
            this.zoomRatioComboBox.FormattingEnabled = true;
            this.zoomRatioComboBox.Items.AddRange(new object[] {
            "70",
            "80",
            "85",
            "90",
            "100",
            "110",
            "120"});
            this.zoomRatioComboBox.Location = new System.Drawing.Point(216, 11);
            this.zoomRatioComboBox.Name = "zoomRatioComboBox";
            this.zoomRatioComboBox.Size = new System.Drawing.Size(121, 20);
            this.zoomRatioComboBox.TabIndex = 2;
            this.zoomRatioComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ZoomRatioComboBox_Validating);
            // 
            // groupEnabledCheckBox
            // 
            this.groupEnabledCheckBox.AutoSize = true;
            this.groupEnabledCheckBox.Location = new System.Drawing.Point(23, 65);
            this.groupEnabledCheckBox.Name = "groupEnabledCheckBox";
            this.groupEnabledCheckBox.Size = new System.Drawing.Size(126, 16);
            this.groupEnabledCheckBox.TabIndex = 3;
            this.groupEnabledCheckBox.Text = "グループ化を設定する";
            this.groupEnabledCheckBox.UseVisualStyleBackColor = true;
            this.groupEnabledCheckBox.CheckedChanged += new System.EventHandler(this.GroupEnabledCheckBox_CheckedChanged);
            // 
            // rowLevelsLabel
            // 
            this.rowLevelsLabel.AutoSize = true;
            this.rowLevelsLabel.Location = new System.Drawing.Point(214, 66);
            this.rowLevelsLabel.Name = "rowLevelsLabel";
            this.rowLevelsLabel.Size = new System.Drawing.Size(108, 12);
            this.rowLevelsLabel.TabIndex = 4;
            this.rowLevelsLabel.Text = "行グループ表示レベル";
            // 
            // rowLevelsTextBox
            // 
            this.rowLevelsTextBox.Location = new System.Drawing.Point(340, 63);
            this.rowLevelsTextBox.Name = "rowLevelsTextBox";
            this.rowLevelsTextBox.Size = new System.Drawing.Size(100, 19);
            this.rowLevelsTextBox.TabIndex = 5;
            this.rowLevelsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GroupLevelsTextBox_Validating);
            // 
            // columnLevelsLabel
            // 
            this.columnLevelsLabel.AutoSize = true;
            this.columnLevelsLabel.Location = new System.Drawing.Point(214, 91);
            this.columnLevelsLabel.Name = "columnLevelsLabel";
            this.columnLevelsLabel.Size = new System.Drawing.Size(108, 12);
            this.columnLevelsLabel.TabIndex = 6;
            this.columnLevelsLabel.Text = "列グループ表示レベル";
            // 
            // columnLevelsTextBox
            // 
            this.columnLevelsTextBox.Location = new System.Drawing.Point(340, 88);
            this.columnLevelsTextBox.Name = "columnLevelsTextBox";
            this.columnLevelsTextBox.Size = new System.Drawing.Size(100, 19);
            this.columnLevelsTextBox.TabIndex = 7;
            this.columnLevelsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GroupLevelsTextBox_Validating);
            // 
            // autoSaveCheckBox
            // 
            this.autoSaveCheckBox.AutoSize = true;
            this.autoSaveCheckBox.Location = new System.Drawing.Point(23, 137);
            this.autoSaveCheckBox.Name = "autoSaveCheckBox";
            this.autoSaveCheckBox.Size = new System.Drawing.Size(112, 16);
            this.autoSaveCheckBox.TabIndex = 8;
            this.autoSaveCheckBox.Text = "設定後に保存する";
            this.autoSaveCheckBox.UseVisualStyleBackColor = true;
            this.autoSaveCheckBox.CheckedChanged += new System.EventHandler(this.AutoSaveCheckBox_CheckedChanged);
            // 
            // autoSaveOverwriteDropDownList
            // 
            this.autoSaveOverwriteDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoSaveOverwriteDropDownList.FormattingEnabled = true;
            this.autoSaveOverwriteDropDownList.Items.AddRange(new object[] {
            "上書き保存",
            "名前を付けて保存"});
            this.autoSaveOverwriteDropDownList.Location = new System.Drawing.Point(216, 135);
            this.autoSaveOverwriteDropDownList.Name = "autoSaveOverwriteDropDownList";
            this.autoSaveOverwriteDropDownList.Size = new System.Drawing.Size(121, 20);
            this.autoSaveOverwriteDropDownList.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // A1ConfigItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.autoSaveOverwriteDropDownList);
            this.Controls.Add(this.autoSaveCheckBox);
            this.Controls.Add(this.columnLevelsTextBox);
            this.Controls.Add(this.columnLevelsLabel);
            this.Controls.Add(this.rowLevelsTextBox);
            this.Controls.Add(this.rowLevelsLabel);
            this.Controls.Add(this.groupEnabledCheckBox);
            this.Controls.Add(this.zoomRatioComboBox);
            this.Controls.Add(this.zoomEnabledCheckBox);
            this.Name = "A1ConfigItem";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zoomEnabledCheckBox;
        private System.Windows.Forms.ComboBox zoomRatioComboBox;
        private System.Windows.Forms.CheckBox groupEnabledCheckBox;
        private System.Windows.Forms.Label rowLevelsLabel;
        private System.Windows.Forms.TextBox rowLevelsTextBox;
        private System.Windows.Forms.Label columnLevelsLabel;
        private System.Windows.Forms.TextBox columnLevelsTextBox;
        private System.Windows.Forms.CheckBox autoSaveCheckBox;
        private System.Windows.Forms.ComboBox autoSaveOverwriteDropDownList;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
