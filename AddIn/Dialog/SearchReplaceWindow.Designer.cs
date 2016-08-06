namespace ExcelX.AddIn.Dialog
{
    partial class SearchReplaceWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchScopeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTargetCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatchExactCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchByteCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchRegexpCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(537, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(456, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextComboBox
            // 
            this.SearchTextComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextComboBox.FormattingEnabled = true;
            this.SearchTextComboBox.Location = new System.Drawing.Point(100, 14);
            this.SearchTextComboBox.Name = "SearchTextComboBox";
            this.SearchTextComboBox.Size = new System.Drawing.Size(311, 20);
            this.SearchTextComboBox.TabIndex = 0;
            this.SearchTextComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextComboBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "検索文字列";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "検索範囲";
            // 
            // SearchScopeComboBox
            // 
            this.SearchScopeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchScopeComboBox.FormattingEnabled = true;
            this.SearchScopeComboBox.Location = new System.Drawing.Point(100, 58);
            this.SearchScopeComboBox.Name = "SearchScopeComboBox";
            this.SearchScopeComboBox.Size = new System.Drawing.Size(176, 20);
            this.SearchScopeComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "検索対象";
            // 
            // SearchTargetCheckedListBox
            // 
            this.SearchTargetCheckedListBox.FormattingEnabled = true;
            this.SearchTargetCheckedListBox.Location = new System.Drawing.Point(100, 84);
            this.SearchTargetCheckedListBox.Name = "SearchTargetCheckedListBox";
            this.SearchTargetCheckedListBox.Size = new System.Drawing.Size(176, 74);
            this.SearchTargetCheckedListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MatchExactCheckBox);
            this.groupBox1.Controls.Add(this.MatchByteCheckBox);
            this.groupBox1.Controls.Add(this.MatchCaseCheckBox);
            this.groupBox1.Controls.Add(this.MatchRegexpCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(282, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索オプション";
            // 
            // MatchExactCheckBox
            // 
            this.MatchExactCheckBox.AutoSize = true;
            this.MatchExactCheckBox.Location = new System.Drawing.Point(6, 40);
            this.MatchExactCheckBox.Name = "MatchExactCheckBox";
            this.MatchExactCheckBox.Size = new System.Drawing.Size(162, 16);
            this.MatchExactCheckBox.TabIndex = 1;
            this.MatchExactCheckBox.Text = "完全一致するものを検索する";
            this.MatchExactCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchByteCheckBox
            // 
            this.MatchByteCheckBox.AutoSize = true;
            this.MatchByteCheckBox.Location = new System.Drawing.Point(6, 84);
            this.MatchByteCheckBox.Name = "MatchByteCheckBox";
            this.MatchByteCheckBox.Size = new System.Drawing.Size(130, 16);
            this.MatchByteCheckBox.TabIndex = 3;
            this.MatchByteCheckBox.Text = "半角/全角を区別する";
            this.MatchByteCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchCaseCheckBox
            // 
            this.MatchCaseCheckBox.AutoSize = true;
            this.MatchCaseCheckBox.Location = new System.Drawing.Point(6, 62);
            this.MatchCaseCheckBox.Name = "MatchCaseCheckBox";
            this.MatchCaseCheckBox.Size = new System.Drawing.Size(154, 16);
            this.MatchCaseCheckBox.TabIndex = 2;
            this.MatchCaseCheckBox.Text = "大文字/小文字を区別する";
            this.MatchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchRegexpCheckBox
            // 
            this.MatchRegexpCheckBox.AutoSize = true;
            this.MatchRegexpCheckBox.Location = new System.Drawing.Point(6, 18);
            this.MatchRegexpCheckBox.Name = "MatchRegexpCheckBox";
            this.MatchRegexpCheckBox.Size = new System.Drawing.Size(124, 16);
            this.MatchRegexpCheckBox.TabIndex = 0;
            this.MatchRegexpCheckBox.Text = "正規表現を使用する";
            this.MatchRegexpCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AllowUserToResizeRows = false;
            this.ResultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.ResultDataGridView.Location = new System.Drawing.Point(12, 184);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.RowTemplate.Height = 21;
            this.ResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataGridView.Size = new System.Drawing.Size(600, 165);
            this.ResultDataGridView.TabIndex = 5;
            this.ResultDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Book";
            this.Column1.HeaderText = "ブック";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sheet";
            this.Column2.HeaderText = "シート";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Cell";
            this.Column3.HeaderText = "セル";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name";
            this.Column4.HeaderText = "名前";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TypeDisplayName";
            this.Column5.HeaderText = "種別";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Text";
            this.Column6.HeaderText = "文字列";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Type";
            this.Column7.HeaderText = "種別";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // SearchReplaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.ResultDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchTargetCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchScopeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SearchReplaceWindow";
            this.ShowInTaskbar = false;
            this.Text = "検索/置換";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchTextComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SearchScopeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox SearchTargetCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox MatchByteCheckBox;
        private System.Windows.Forms.CheckBox MatchCaseCheckBox;
        private System.Windows.Forms.CheckBox MatchRegexpCheckBox;
        private System.Windows.Forms.CheckBox MatchExactCheckBox;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}