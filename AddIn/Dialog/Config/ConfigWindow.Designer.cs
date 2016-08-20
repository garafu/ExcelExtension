namespace ExcelX.AddIn.Dialog.Config
{
    partial class ConfigWindow
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
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TrvConfigList = new System.Windows.Forms.TreeView();
            this.PnlConfigItemt = new System.Windows.Forms.Panel();
            this.border = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.Location = new System.Drawing.Point(535, 426);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "OK";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(616, 426);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "キャンセル";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TrvConfigList
            // 
            this.TrvConfigList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TrvConfigList.Location = new System.Drawing.Point(12, 12);
            this.TrvConfigList.Name = "TrvConfigList";
            this.TrvConfigList.Size = new System.Drawing.Size(230, 408);
            this.TrvConfigList.TabIndex = 2;
            this.TrvConfigList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvConfigList_AfterSelect);
            // 
            // PnlConfigItemt
            // 
            this.PnlConfigItemt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlConfigItemt.AutoScroll = true;
            this.PnlConfigItemt.Location = new System.Drawing.Point(248, 12);
            this.PnlConfigItemt.Name = "PnlConfigItemt";
            this.PnlConfigItemt.Size = new System.Drawing.Size(524, 403);
            this.PnlConfigItemt.TabIndex = 3;
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.Location = new System.Drawing.Point(248, 418);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(524, 2);
            this.border.TabIndex = 4;
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.Location = new System.Drawing.Point(697, 426);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 5;
            this.BtnApply.Text = "適用";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.border);
            this.Controls.Add(this.PnlConfigItemt);
            this.Controls.Add(this.TrvConfigList);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ConfigWindow";
            this.ShowInTaskbar = false;
            this.Text = "設定";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TreeView TrvConfigList;
        private System.Windows.Forms.Panel PnlConfigItemt;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.Button BtnApply;
    }
}