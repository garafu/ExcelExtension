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
            this.closeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchScopeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTargetCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchExactCheckBox = new System.Windows.Forms.CheckBox();
            this.matchByteCheckBox = new System.Windows.Forms.CheckBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.matchRegexpCheckBox = new System.Windows.Forms.CheckBox();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(537, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(456, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextComboBox
            // 
            this.searchTextComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextComboBox.FormattingEnabled = true;
            this.searchTextComboBox.Location = new System.Drawing.Point(100, 14);
            this.searchTextComboBox.Name = "searchTextComboBox";
            this.searchTextComboBox.Size = new System.Drawing.Size(311, 20);
            this.searchTextComboBox.TabIndex = 0;
            this.searchTextComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextComboBox_KeyPress);
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
            // searchScopeComboBox
            // 
            this.searchScopeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchScopeComboBox.FormattingEnabled = true;
            this.searchScopeComboBox.Location = new System.Drawing.Point(100, 58);
            this.searchScopeComboBox.Name = "searchScopeComboBox";
            this.searchScopeComboBox.Size = new System.Drawing.Size(176, 20);
            this.searchScopeComboBox.TabIndex = 1;
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
            // searchTargetCheckedListBox
            // 
            this.searchTargetCheckedListBox.CheckOnClick = true;
            this.searchTargetCheckedListBox.FormattingEnabled = true;
            this.searchTargetCheckedListBox.Location = new System.Drawing.Point(100, 84);
            this.searchTargetCheckedListBox.Name = "searchTargetCheckedListBox";
            this.searchTargetCheckedListBox.Size = new System.Drawing.Size(176, 74);
            this.searchTargetCheckedListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matchExactCheckBox);
            this.groupBox1.Controls.Add(this.matchByteCheckBox);
            this.groupBox1.Controls.Add(this.matchCaseCheckBox);
            this.groupBox1.Controls.Add(this.matchRegexpCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(282, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索オプション";
            // 
            // matchExactCheckBox
            // 
            this.matchExactCheckBox.AutoSize = true;
            this.matchExactCheckBox.Location = new System.Drawing.Point(6, 40);
            this.matchExactCheckBox.Name = "matchExactCheckBox";
            this.matchExactCheckBox.Size = new System.Drawing.Size(162, 16);
            this.matchExactCheckBox.TabIndex = 1;
            this.matchExactCheckBox.Text = "完全一致するものを検索する";
            this.matchExactCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchByteCheckBox
            // 
            this.matchByteCheckBox.AutoSize = true;
            this.matchByteCheckBox.Location = new System.Drawing.Point(6, 84);
            this.matchByteCheckBox.Name = "matchByteCheckBox";
            this.matchByteCheckBox.Size = new System.Drawing.Size(130, 16);
            this.matchByteCheckBox.TabIndex = 3;
            this.matchByteCheckBox.Text = "半角/全角を区別する";
            this.matchByteCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(6, 62);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(154, 16);
            this.matchCaseCheckBox.TabIndex = 2;
            this.matchCaseCheckBox.Text = "大文字/小文字を区別する";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchRegexpCheckBox
            // 
            this.matchRegexpCheckBox.AutoSize = true;
            this.matchRegexpCheckBox.Location = new System.Drawing.Point(6, 18);
            this.matchRegexpCheckBox.Name = "matchRegexpCheckBox";
            this.matchRegexpCheckBox.Size = new System.Drawing.Size(124, 16);
            this.matchRegexpCheckBox.TabIndex = 0;
            this.matchRegexpCheckBox.Text = "正規表現を使用する";
            this.matchRegexpCheckBox.UseVisualStyleBackColor = true;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.AllowUserToResizeRows = false;
            this.resultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.resultDataGridView.Location = new System.Drawing.Point(12, 184);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.RowTemplate.Height = 21;
            this.resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGridView.Size = new System.Drawing.Size(600, 152);
            this.resultDataGridView.TabIndex = 5;
            this.resultDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataGridView_RowEnter);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // SearchReplaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchTargetCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchScopeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SearchReplaceWindow";
            this.ShowInTaskbar = false;
            this.Text = "検索/置換";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchTextComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchScopeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox searchTargetCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox matchByteCheckBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.CheckBox matchRegexpCheckBox;
        private System.Windows.Forms.CheckBox matchExactCheckBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}