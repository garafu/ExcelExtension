namespace ExcelX.AddIn.Dialog.Config
{
    partial class RectangleBalloonConfigItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.profileComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillColorLabel = new System.Windows.Forms.Label();
            this.fillAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fillAlphaTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.borderSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.borderAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.borderAlphaTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.borderColorButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fontNameComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fillAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillAlphaTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderAlphaTrackBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "プロファイル";
            // 
            // profileComboBox
            // 
            this.profileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.Location = new System.Drawing.Point(113, 13);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(264, 20);
            this.profileComboBox.TabIndex = 1;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfileComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "高さ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "幅";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.widthNumericUpDown);
            this.groupBox1.Controls.Add(this.heightNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "サイズ";
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.DecimalPlaces = 2;
            this.widthNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.widthNumericUpDown.Location = new System.Drawing.Point(234, 43);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.widthNumericUpDown.TabIndex = 8;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.DecimalPlaces = 2;
            this.heightNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.heightNumericUpDown.Location = new System.Drawing.Point(234, 18);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.heightNumericUpDown.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fillColorLabel);
            this.groupBox2.Controls.Add(this.fillAlphaNumericUpDown);
            this.groupBox2.Controls.Add(this.fillAlphaTrackBar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fillColorButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "塗りつぶし";
            // 
            // fillColorLabel
            // 
            this.fillColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fillColorLabel.Location = new System.Drawing.Point(234, 18);
            this.fillColorLabel.Name = "fillColorLabel";
            this.fillColorLabel.Size = new System.Drawing.Size(91, 23);
            this.fillColorLabel.TabIndex = 6;
            // 
            // fillAlphaNumericUpDown
            // 
            this.fillAlphaNumericUpDown.Location = new System.Drawing.Point(234, 47);
            this.fillAlphaNumericUpDown.Name = "fillAlphaNumericUpDown";
            this.fillAlphaNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.fillAlphaNumericUpDown.TabIndex = 4;
            this.fillAlphaNumericUpDown.ValueChanged += new System.EventHandler(this.FillAlphaNumericUpDown_ValueChanged);
            // 
            // fillAlphaTrackBar
            // 
            this.fillAlphaTrackBar.AutoSize = false;
            this.fillAlphaTrackBar.LargeChange = 20;
            this.fillAlphaTrackBar.Location = new System.Drawing.Point(107, 47);
            this.fillAlphaTrackBar.Maximum = 100;
            this.fillAlphaTrackBar.Name = "fillAlphaTrackBar";
            this.fillAlphaTrackBar.Size = new System.Drawing.Size(104, 19);
            this.fillAlphaTrackBar.SmallChange = 5;
            this.fillAlphaTrackBar.TabIndex = 5;
            this.fillAlphaTrackBar.TickFrequency = 20;
            this.fillAlphaTrackBar.Scroll += new System.EventHandler(this.FillAlphaTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "透明度";
            // 
            // fillColorButton
            // 
            this.fillColorButton.Location = new System.Drawing.Point(331, 18);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(23, 23);
            this.fillColorButton.TabIndex = 1;
            this.fillColorButton.Text = "...";
            this.fillColorButton.UseVisualStyleBackColor = true;
            this.fillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "色";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.borderColorLabel);
            this.groupBox3.Controls.Add(this.borderSizeNumericUpDown);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.borderAlphaNumericUpDown);
            this.groupBox3.Controls.Add(this.borderAlphaTrackBar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.borderColorButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(21, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "枠線";
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borderColorLabel.Location = new System.Drawing.Point(234, 18);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(91, 23);
            this.borderColorLabel.TabIndex = 7;
            // 
            // borderSizeNumericUpDown
            // 
            this.borderSizeNumericUpDown.DecimalPlaces = 2;
            this.borderSizeNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.borderSizeNumericUpDown.Location = new System.Drawing.Point(234, 72);
            this.borderSizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.borderSizeNumericUpDown.Name = "borderSizeNumericUpDown";
            this.borderSizeNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.borderSizeNumericUpDown.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "幅";
            // 
            // borderAlphaNumericUpDown
            // 
            this.borderAlphaNumericUpDown.Location = new System.Drawing.Point(234, 47);
            this.borderAlphaNumericUpDown.Name = "borderAlphaNumericUpDown";
            this.borderAlphaNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.borderAlphaNumericUpDown.TabIndex = 4;
            this.borderAlphaNumericUpDown.ValueChanged += new System.EventHandler(this.BorderAlphaNumericUpDown_ValueChanged);
            // 
            // borderAlphaTrackBar
            // 
            this.borderAlphaTrackBar.AutoSize = false;
            this.borderAlphaTrackBar.LargeChange = 20;
            this.borderAlphaTrackBar.Location = new System.Drawing.Point(106, 47);
            this.borderAlphaTrackBar.Maximum = 100;
            this.borderAlphaTrackBar.Name = "borderAlphaTrackBar";
            this.borderAlphaTrackBar.Size = new System.Drawing.Size(104, 19);
            this.borderAlphaTrackBar.SmallChange = 5;
            this.borderAlphaTrackBar.TabIndex = 3;
            this.borderAlphaTrackBar.TickFrequency = 20;
            this.borderAlphaTrackBar.Scroll += new System.EventHandler(this.BorderAlphaTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "透明度";
            // 
            // borderColorButton
            // 
            this.borderColorButton.Location = new System.Drawing.Point(331, 18);
            this.borderColorButton.Name = "borderColorButton";
            this.borderColorButton.Size = new System.Drawing.Size(23, 23);
            this.borderColorButton.TabIndex = 1;
            this.borderColorButton.Text = "...";
            this.borderColorButton.UseVisualStyleBackColor = true;
            this.borderColorButton.Click += new System.EventHandler(this.BorderColorButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "色";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fontColorButton);
            this.groupBox4.Controls.Add(this.fontColorLabel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.fontSizeComboBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.fontNameComboBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(21, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "書式";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(331, 70);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(23, 23);
            this.fontColorButton.TabIndex = 6;
            this.fontColorButton.Text = "...";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.FontColorButton_Click);
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fontColorLabel.Location = new System.Drawing.Point(234, 70);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(91, 23);
            this.fontColorLabel.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "色";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizeComboBox.Location = new System.Drawing.Point(234, 44);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(120, 20);
            this.fontSizeComboBox.TabIndex = 3;
            this.fontSizeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.FontSizeComboBox_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "サイズ";
            // 
            // fontNameComboBox
            // 
            this.fontNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontNameComboBox.FormattingEnabled = true;
            this.fontNameComboBox.Location = new System.Drawing.Point(32, 44);
            this.fontNameComboBox.Name = "fontNameComboBox";
            this.fontNameComboBox.Size = new System.Drawing.Size(196, 20);
            this.fontNameComboBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "フォント";
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Location = new System.Drawing.Point(427, 23);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(48, 16);
            this.enabledCheckBox.TabIndex = 11;
            this.enabledCheckBox.Text = "有効";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.displayNameTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.enabledCheckBox);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 492);
            this.panel1.TabIndex = 12;
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.Location = new System.Drawing.Point(111, 21);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(266, 19);
            this.displayNameTextBox.TabIndex = 13;
            this.displayNameTextBox.TextChanged += new System.EventHandler(this.DisplayNameTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "表示名";
            // 
            // RectangleBalloonConfigItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileComboBox);
            this.Controls.Add(this.label1);
            this.Name = "RectangleBalloonConfigItem";
            this.Size = new System.Drawing.Size(500, 549);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fillAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillAlphaTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderAlphaTrackBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox profileComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar fillAlphaTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fillColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown fillAlphaNumericUpDown;
        private System.Windows.Forms.NumericUpDown borderSizeNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown borderAlphaNumericUpDown;
        private System.Windows.Forms.TrackBar borderAlphaTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button borderColorButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label borderColorLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox fontNameComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fillColorLabel;
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.Label label9;

    }
}
