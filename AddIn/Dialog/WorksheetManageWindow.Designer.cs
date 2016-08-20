namespace ExcelX.AddIn.Dialog
{
    partial class WorksheetManageWindow
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
            this.CompleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.AscButton = new System.Windows.Forms.Button();
            this.DescButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.NoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibleColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProtectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ApplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompleteButton
            // 
            this.CompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteButton.Location = new System.Drawing.Point(375, 326);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(75, 23);
            this.CompleteButton.TabIndex = 0;
            this.CompleteButton.Text = "OK";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(456, 326);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(93, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(174, 12);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 6;
            this.UpButton.Text = "上へ";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(255, 12);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 7;
            this.DownButton.Text = "下へ";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // AscButton
            // 
            this.AscButton.Location = new System.Drawing.Point(336, 12);
            this.AscButton.Name = "AscButton";
            this.AscButton.Size = new System.Drawing.Size(75, 23);
            this.AscButton.TabIndex = 8;
            this.AscButton.Text = "昇順";
            this.AscButton.UseVisualStyleBackColor = true;
            this.AscButton.Click += new System.EventHandler(this.AscButton_Click);
            // 
            // DescButton
            // 
            this.DescButton.Location = new System.Drawing.Point(417, 12);
            this.DescButton.Name = "DescButton";
            this.DescButton.Size = new System.Drawing.Size(75, 23);
            this.DescButton.TabIndex = 9;
            this.DescButton.Text = "降順";
            this.DescButton.UseVisualStyleBackColor = true;
            this.DescButton.Click += new System.EventHandler(this.DescButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoColumn,
            this.TypeColumn,
            this.NameColumn,
            this.VisibleColumn,
            this.ProtectionColumn});
            this.DataGridView.Location = new System.Drawing.Point(12, 41);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 21;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(600, 279);
            this.DataGridView.TabIndex = 10;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            this.DataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView_CellValidating);
            // 
            // NoColumn
            // 
            this.NoColumn.DataPropertyName = "NewIndex";
            this.NoColumn.HeaderText = "No";
            this.NoColumn.Name = "NoColumn";
            this.NoColumn.ReadOnly = true;
            this.NoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NoColumn.Width = 40;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "NewType";
            this.TypeColumn.HeaderText = "種類";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "NewName";
            this.NameColumn.HeaderText = "名前";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 310;
            // 
            // VisibleColumn
            // 
            this.VisibleColumn.DataPropertyName = "NewVisible";
            this.VisibleColumn.HeaderText = "表示";
            this.VisibleColumn.Name = "VisibleColumn";
            this.VisibleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ProtectionColumn
            // 
            this.ProtectionColumn.DataPropertyName = "NewProtected";
            this.ProtectionColumn.HeaderText = "保護";
            this.ProtectionColumn.Name = "ProtectionColumn";
            this.ProtectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProtectionColumn.Visible = false;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(537, 326);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 11;
            this.ApplyButton.Text = "適用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // WorksheetManageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.DescButton);
            this.Controls.Add(this.AscButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CompleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WorksheetManageWindow";
            this.ShowInTaskbar = false;
            this.Text = "ワークシート管理";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button AscButton;
        private System.Windows.Forms.Button DescButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VisibleColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProtectionColumn;
    }
}