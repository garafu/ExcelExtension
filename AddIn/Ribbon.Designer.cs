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
            this.FileGroup = this.Factory.CreateRibbonGroup();
            this.EditGroup = this.Factory.CreateRibbonGroup();
            this.OpenFileMenu = this.Factory.CreateRibbonMenu();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.OpenActiveWorkbookReadOnlyButton = this.Factory.CreateRibbonButton();
            this.OpenActiveWorkbookEditableButton = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.OpenSelectWorkbookReadOnlyButton = this.Factory.CreateRibbonButton();
            this.OpenSelectWorkbookEditableButton = this.Factory.CreateRibbonButton();
            this.OpenFolderButton = this.Factory.CreateRibbonButton();
            this.ToggleEditModeButton = this.Factory.CreateRibbonButton();
            this.SearchButton = this.Factory.CreateRibbonButton();
            this.SetA1Button = this.Factory.CreateRibbonButton();
            this.InitializeStyleButton = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.FileGroup.SuspendLayout();
            this.EditGroup.SuspendLayout();
            // 
            // tab
            // 
            this.tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab.Groups.Add(this.FileGroup);
            this.tab.Groups.Add(this.EditGroup);
            this.tab.Label = "拡張ツール";
            this.tab.Name = "tab";
            // 
            // FileGroup
            // 
            this.FileGroup.Items.Add(this.OpenFileMenu);
            this.FileGroup.Items.Add(this.OpenFolderButton);
            this.FileGroup.Items.Add(this.ToggleEditModeButton);
            this.FileGroup.Label = "ファイル";
            this.FileGroup.Name = "FileGroup";
            // 
            // EditGroup
            // 
            this.EditGroup.Items.Add(this.SearchButton);
            this.EditGroup.Items.Add(this.SetA1Button);
            this.EditGroup.Items.Add(this.InitializeStyleButton);
            this.EditGroup.Label = "編集";
            this.EditGroup.Name = "EditGroup";
            // 
            // OpenFileMenu
            // 
            this.OpenFileMenu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenFileMenu.Items.Add(this.separator1);
            this.OpenFileMenu.Items.Add(this.OpenActiveWorkbookReadOnlyButton);
            this.OpenFileMenu.Items.Add(this.OpenActiveWorkbookEditableButton);
            this.OpenFileMenu.Items.Add(this.separator2);
            this.OpenFileMenu.Items.Add(this.OpenSelectWorkbookReadOnlyButton);
            this.OpenFileMenu.Items.Add(this.OpenSelectWorkbookEditableButton);
            this.OpenFileMenu.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenFileMenu.Label = "ファイルを開く";
            this.OpenFileMenu.Name = "OpenFileMenu";
            this.OpenFileMenu.OfficeImageId = "FileOpen";
            this.OpenFileMenu.ShowImage = true;
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Title = "現在のブックを開く";
            // 
            // OpenActiveWorkbookReadOnlyButton
            // 
            this.OpenActiveWorkbookReadOnlyButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenActiveWorkbookReadOnlyButton.Label = "現在のブックを別ウィンドウの読み取り専用で開く";
            this.OpenActiveWorkbookReadOnlyButton.Name = "OpenActiveWorkbookReadOnlyButton";
            this.OpenActiveWorkbookReadOnlyButton.OfficeImageId = "FilePermission";
            this.OpenActiveWorkbookReadOnlyButton.ShowImage = true;
            this.OpenActiveWorkbookReadOnlyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenActiveWorkbookReadOnlyButton_Click);
            // 
            // OpenActiveWorkbookEditableButton
            // 
            this.OpenActiveWorkbookEditableButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenActiveWorkbookEditableButton.Label = "現在のブックを別ウィンドウの編集用で開く";
            this.OpenActiveWorkbookEditableButton.Name = "OpenActiveWorkbookEditableButton";
            this.OpenActiveWorkbookEditableButton.OfficeImageId = "SignatureLineInsert";
            this.OpenActiveWorkbookEditableButton.ShowImage = true;
            this.OpenActiveWorkbookEditableButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenActiveWorkbookEditableButton_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Title = "ファイルを選択して開く";
            // 
            // OpenSelectWorkbookReadOnlyButton
            // 
            this.OpenSelectWorkbookReadOnlyButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenSelectWorkbookReadOnlyButton.Label = "ファイルを選択して別ウィンドウの読み取り専用で開く";
            this.OpenSelectWorkbookReadOnlyButton.Name = "OpenSelectWorkbookReadOnlyButton";
            this.OpenSelectWorkbookReadOnlyButton.OfficeImageId = "FileOpen";
            this.OpenSelectWorkbookReadOnlyButton.ShowImage = true;
            this.OpenSelectWorkbookReadOnlyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenSelectWorkbookReadOnlyButton_Click);
            // 
            // OpenSelectWorkbookEditableButton
            // 
            this.OpenSelectWorkbookEditableButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenSelectWorkbookEditableButton.Label = "ファイルを選択して別ウィンドウの編集用で開く";
            this.OpenSelectWorkbookEditableButton.Name = "OpenSelectWorkbookEditableButton";
            this.OpenSelectWorkbookEditableButton.OfficeImageId = "FileOpen";
            this.OpenSelectWorkbookEditableButton.ShowImage = true;
            this.OpenSelectWorkbookEditableButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenSelectWorkbookEditableButton_Click);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.OpenFolderButton.Label = "フォルダを開く";
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.OfficeImageId = "Folder";
            this.OpenFolderButton.ShowImage = true;
            this.OpenFolderButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenFolderButton_Click);
            // 
            // ToggleEditModeButton
            // 
            this.ToggleEditModeButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ToggleEditModeButton.Label = "読み取り専用の設定/解除";
            this.ToggleEditModeButton.Name = "ToggleEditModeButton";
            this.ToggleEditModeButton.OfficeImageId = "ReadOnly";
            this.ToggleEditModeButton.ShowImage = true;
            this.ToggleEditModeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleEditModeButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SearchButton.Label = "検索";
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.OfficeImageId = "FindDialog";
            this.SearchButton.ShowImage = true;
            this.SearchButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SearchButton_Click);
            // 
            // SetA1Button
            // 
            this.SetA1Button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SetA1Button.Label = "A1";
            this.SetA1Button.Name = "SetA1Button";
            this.SetA1Button.OfficeImageId = "BlogHomePage";
            this.SetA1Button.ShowImage = true;
            this.SetA1Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetA1Button_Click);
            // 
            // InitializeStyleButton
            // 
            this.InitializeStyleButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.InitializeStyleButton.Label = "スタイル初期化";
            this.InitializeStyleButton.Name = "InitializeStyleButton";
            this.InitializeStyleButton.OfficeImageId = "TableOfContentsRemove";
            this.InitializeStyleButton.ShowImage = true;
            this.InitializeStyleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InitializeStyleButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.FileGroup.ResumeLayout(false);
            this.FileGroup.PerformLayout();
            this.EditGroup.ResumeLayout(false);
            this.EditGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup EditGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SearchButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup FileGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenFolderButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ToggleEditModeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenActiveWorkbookReadOnlyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenActiveWorkbookEditableButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu OpenFileMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenSelectWorkbookReadOnlyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenSelectWorkbookEditableButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetA1Button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InitializeStyleButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
