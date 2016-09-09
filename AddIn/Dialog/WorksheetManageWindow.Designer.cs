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
            this.completeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.ascButton = new System.Windows.Forms.Button();
            this.descButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibleColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProtectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.Location = new System.Drawing.Point(375, 326);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 23);
            this.completeButton.TabIndex = 0;
            this.completeButton.Text = "OK";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(456, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(93, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(174, 12);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 6;
            this.upButton.Text = "上へ";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(255, 12);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 7;
            this.downButton.Text = "下へ";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // ascButton
            // 
            this.ascButton.Location = new System.Drawing.Point(336, 12);
            this.ascButton.Name = "ascButton";
            this.ascButton.Size = new System.Drawing.Size(75, 23);
            this.ascButton.TabIndex = 8;
            this.ascButton.Text = "昇順";
            this.ascButton.UseVisualStyleBackColor = true;
            this.ascButton.Click += new System.EventHandler(this.AscButton_Click);
            // 
            // descButton
            // 
            this.descButton.Location = new System.Drawing.Point(417, 12);
            this.descButton.Name = "descButton";
            this.descButton.Size = new System.Drawing.Size(75, 23);
            this.descButton.TabIndex = 9;
            this.descButton.Text = "降順";
            this.descButton.UseVisualStyleBackColor = true;
            this.descButton.Click += new System.EventHandler(this.DescButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoColumn,
            this.TypeColumn,
            this.NameColumn,
            this.VisibleColumn,
            this.ProtectionColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(600, 279);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView_CellValidating);
            this.dataGridView.Sorted += new System.EventHandler(this.DataGridView_Sorted);
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
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(537, 326);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "適用";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // WorksheetManageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.descButton);
            this.Controls.Add(this.ascButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.completeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WorksheetManageWindow";
            this.ShowInTaskbar = false;
            this.Text = "ワークシート管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button ascButton;
        private System.Windows.Forms.Button descButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VisibleColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProtectionColumn;
    }
}