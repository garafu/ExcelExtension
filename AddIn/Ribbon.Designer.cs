namespace ExcelX.AddIn
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// デザイナー変数が必要です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = this.Factory.CreateRibbonTab();
            this.EditGroup = this.Factory.CreateRibbonGroup();
            this.SearchSplitButton = this.Factory.CreateRibbonSplitButton();
            this.SearchButton = this.Factory.CreateRibbonButton();
            this.ReplaceButton = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.EditGroup.SuspendLayout();
            // 
            // tab
            // 
            this.tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab.Groups.Add(this.EditGroup);
            this.tab.Label = "拡張ツール";
            this.tab.Name = "tab";
            // 
            // EditGroup
            // 
            this.EditGroup.Items.Add(this.SearchSplitButton);
            this.EditGroup.Label = "編集";
            this.EditGroup.Name = "EditGroup";
            // 
            // SearchSplitButton
            // 
            this.SearchSplitButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SearchSplitButton.Items.Add(this.SearchButton);
            this.SearchSplitButton.Items.Add(this.ReplaceButton);
            this.SearchSplitButton.Label = "検索";
            this.SearchSplitButton.Name = "SearchSplitButton";
            this.SearchSplitButton.OfficeImageId = "FindDialog";
            this.SearchSplitButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SearchSplitButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Label = "検索";
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.OfficeImageId = "FindDialog";
            this.SearchButton.ShowImage = true;
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Label = "置換";
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.OfficeImageId = "FindDialog";
            this.ReplaceButton.ShowImage = true;
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.EditGroup.ResumeLayout(false);
            this.EditGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup EditGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton SearchSplitButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SearchButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ReplaceButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
