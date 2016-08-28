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
            this.fileGroup = this.Factory.CreateRibbonGroup();
            this.openFileMenu = this.Factory.CreateRibbonMenu();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.openActiveWorkbookReadOnlyButton = this.Factory.CreateRibbonButton();
            this.openActiveWorkbookEditableButton = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.openSelectWorkbookReadOnlyButton = this.Factory.CreateRibbonButton();
            this.openSelectWorkbookEditableButton = this.Factory.CreateRibbonButton();
            this.openFolderButton = this.Factory.CreateRibbonButton();
            this.toggleEditModeButton = this.Factory.CreateRibbonButton();
            this.editGroup = this.Factory.CreateRibbonGroup();
            this.searchButton = this.Factory.CreateRibbonButton();
            this.setA1Button = this.Factory.CreateRibbonButton();
            this.initializeStyleButton = this.Factory.CreateRibbonButton();
            this.makeGridButton = this.Factory.CreateRibbonButton();
            this.manageWorksheetButton = this.Factory.CreateRibbonButton();
            this.shapeGroup = this.Factory.CreateRibbonGroup();
            this.balloonMenu = this.Factory.CreateRibbonMenu();
            this.helpGroup = this.Factory.CreateRibbonGroup();
            this.configButton = this.Factory.CreateRibbonButton();
            this.helpMenu = this.Factory.CreateRibbonMenu();
            this.openHelpButton = this.Factory.CreateRibbonButton();
            this.openVersionInfoButton = this.Factory.CreateRibbonButton();
            this.reportIssuesButton = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.fileGroup.SuspendLayout();
            this.editGroup.SuspendLayout();
            this.shapeGroup.SuspendLayout();
            this.helpGroup.SuspendLayout();
            // 
            // tab
            // 
            this.tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab.Groups.Add(this.fileGroup);
            this.tab.Groups.Add(this.editGroup);
            this.tab.Groups.Add(this.shapeGroup);
            this.tab.Groups.Add(this.helpGroup);
            this.tab.Label = "拡張ツール";
            this.tab.Name = "tab";
            // 
            // fileGroup
            // 
            this.fileGroup.Items.Add(this.openFileMenu);
            this.fileGroup.Items.Add(this.openFolderButton);
            this.fileGroup.Items.Add(this.toggleEditModeButton);
            this.fileGroup.Label = "ファイル";
            this.fileGroup.Name = "fileGroup";
            // 
            // openFileMenu
            // 
            this.openFileMenu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openFileMenu.Items.Add(this.separator1);
            this.openFileMenu.Items.Add(this.openActiveWorkbookReadOnlyButton);
            this.openFileMenu.Items.Add(this.openActiveWorkbookEditableButton);
            this.openFileMenu.Items.Add(this.separator2);
            this.openFileMenu.Items.Add(this.openSelectWorkbookReadOnlyButton);
            this.openFileMenu.Items.Add(this.openSelectWorkbookEditableButton);
            this.openFileMenu.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openFileMenu.Label = "ファイルを開く";
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.OfficeImageId = "FileOpen";
            this.openFileMenu.ShowImage = true;
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Title = "現在のブックを開く";
            // 
            // openActiveWorkbookReadOnlyButton
            // 
            this.openActiveWorkbookReadOnlyButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openActiveWorkbookReadOnlyButton.Label = "現在のブックを別ウィンドウの読み取り専用で開く";
            this.openActiveWorkbookReadOnlyButton.Name = "openActiveWorkbookReadOnlyButton";
            this.openActiveWorkbookReadOnlyButton.OfficeImageId = "FilePermission";
            this.openActiveWorkbookReadOnlyButton.ShowImage = true;
            this.openActiveWorkbookReadOnlyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenActiveWorkbookReadOnlyButton_Click);
            // 
            // openActiveWorkbookEditableButton
            // 
            this.openActiveWorkbookEditableButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openActiveWorkbookEditableButton.Label = "現在のブックを別ウィンドウの編集用で開く";
            this.openActiveWorkbookEditableButton.Name = "openActiveWorkbookEditableButton";
            this.openActiveWorkbookEditableButton.OfficeImageId = "SignatureLineInsert";
            this.openActiveWorkbookEditableButton.ShowImage = true;
            this.openActiveWorkbookEditableButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenActiveWorkbookEditableButton_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Title = "ファイルを選択して開く";
            // 
            // openSelectWorkbookReadOnlyButton
            // 
            this.openSelectWorkbookReadOnlyButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openSelectWorkbookReadOnlyButton.Label = "ファイルを選択して別ウィンドウの読み取り専用で開く";
            this.openSelectWorkbookReadOnlyButton.Name = "openSelectWorkbookReadOnlyButton";
            this.openSelectWorkbookReadOnlyButton.OfficeImageId = "FileOpen";
            this.openSelectWorkbookReadOnlyButton.ShowImage = true;
            this.openSelectWorkbookReadOnlyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenSelectWorkbookReadOnlyButton_Click);
            // 
            // openSelectWorkbookEditableButton
            // 
            this.openSelectWorkbookEditableButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openSelectWorkbookEditableButton.Label = "ファイルを選択して別ウィンドウの編集用で開く";
            this.openSelectWorkbookEditableButton.Name = "openSelectWorkbookEditableButton";
            this.openSelectWorkbookEditableButton.OfficeImageId = "FileOpen";
            this.openSelectWorkbookEditableButton.ShowImage = true;
            this.openSelectWorkbookEditableButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenSelectWorkbookEditableButton_Click);
            // 
            // openFolderButton
            // 
            this.openFolderButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openFolderButton.Label = "フォルダを開く";
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.OfficeImageId = "Folder";
            this.openFolderButton.ShowImage = true;
            this.openFolderButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenFolderButton_Click);
            // 
            // toggleEditModeButton
            // 
            this.toggleEditModeButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.toggleEditModeButton.Label = "読み取り専用の設定/解除";
            this.toggleEditModeButton.Name = "toggleEditModeButton";
            this.toggleEditModeButton.OfficeImageId = "ReadOnly";
            this.toggleEditModeButton.ShowImage = true;
            this.toggleEditModeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleEditModeButton_Click);
            // 
            // editGroup
            // 
            this.editGroup.Items.Add(this.searchButton);
            this.editGroup.Items.Add(this.setA1Button);
            this.editGroup.Items.Add(this.initializeStyleButton);
            this.editGroup.Items.Add(this.makeGridButton);
            this.editGroup.Items.Add(this.manageWorksheetButton);
            this.editGroup.Label = "編集";
            this.editGroup.Name = "editGroup";
            // 
            // searchButton
            // 
            this.searchButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.searchButton.Label = "検索";
            this.searchButton.Name = "searchButton";
            this.searchButton.OfficeImageId = "FindDialog";
            this.searchButton.ShowImage = true;
            this.searchButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SearchButton_Click);
            // 
            // setA1Button
            // 
            this.setA1Button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.setA1Button.Label = "A1";
            this.setA1Button.Name = "setA1Button";
            this.setA1Button.OfficeImageId = "BlogHomePage";
            this.setA1Button.ShowImage = true;
            this.setA1Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetA1Button_Click);
            // 
            // initializeStyleButton
            // 
            this.initializeStyleButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.initializeStyleButton.Label = "スタイル初期化";
            this.initializeStyleButton.Name = "initializeStyleButton";
            this.initializeStyleButton.OfficeImageId = "TableOfContentsRemove";
            this.initializeStyleButton.ShowImage = true;
            this.initializeStyleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InitializeStyleButton_Click);
            // 
            // makeGridButton
            // 
            this.makeGridButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.makeGridButton.Label = "方眼紙";
            this.makeGridButton.Name = "makeGridButton";
            this.makeGridButton.OfficeImageId = "ViewNormalViewExcel";
            this.makeGridButton.ShowImage = true;
            this.makeGridButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MakeGridButton_Click);
            // 
            // manageWorksheetButton
            // 
            this.manageWorksheetButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.manageWorksheetButton.Label = "シート管理";
            this.manageWorksheetButton.Name = "manageWorksheetButton";
            this.manageWorksheetButton.OfficeImageId = "DefinePrintStyles";
            this.manageWorksheetButton.ShowImage = true;
            this.manageWorksheetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ManageWorksheetButton_Click);
            // 
            // shapeGroup
            // 
            this.shapeGroup.Items.Add(this.balloonMenu);
            this.shapeGroup.Label = "図形";
            this.shapeGroup.Name = "shapeGroup";
            // 
            // balloonMenu
            // 
            this.balloonMenu.Dynamic = true;
            this.balloonMenu.Label = "吹き出し";
            this.balloonMenu.Name = "balloonMenu";
            this.balloonMenu.OfficeImageId = "ShapeRoundedRectangularCallout";
            this.balloonMenu.ShowImage = true;
            // 
            // helpGroup
            // 
            this.helpGroup.Items.Add(this.configButton);
            this.helpGroup.Items.Add(this.helpMenu);
            this.helpGroup.Name = "helpGroup";
            // 
            // configButton
            // 
            this.configButton.Label = "設定";
            this.configButton.Name = "configButton";
            this.configButton.OfficeImageId = "ControlToolboxOutlook";
            this.configButton.ShowImage = true;
            this.configButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ConfigButton_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Items.Add(this.openHelpButton);
            this.helpMenu.Items.Add(this.openVersionInfoButton);
            this.helpMenu.Items.Add(this.reportIssuesButton);
            this.helpMenu.Label = "ヘルプ";
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.OfficeImageId = "ContentsAndIndex";
            this.helpMenu.ShowImage = true;
            // 
            // openHelpButton
            // 
            this.openHelpButton.Label = "ヘルプの表示";
            this.openHelpButton.Name = "openHelpButton";
            this.openHelpButton.OfficeImageId = "ContentsAndIndex";
            this.openHelpButton.ShowImage = true;
            this.openHelpButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenHelpButton_Click);
            // 
            // openVersionInfoButton
            // 
            this.openVersionInfoButton.Label = "バージョン情報";
            this.openVersionInfoButton.Name = "openVersionInfoButton";
            this.openVersionInfoButton.OfficeImageId = "Info";
            this.openVersionInfoButton.ShowImage = true;
            this.openVersionInfoButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenVersionInfoButton_Click);
            // 
            // reportIssuesButton
            // 
            this.reportIssuesButton.Label = "問題の報告";
            this.reportIssuesButton.Name = "reportIssuesButton";
            this.reportIssuesButton.OfficeImageId = "HighImportance";
            this.reportIssuesButton.ShowImage = true;
            this.reportIssuesButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ReportIssuesButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.fileGroup.ResumeLayout(false);
            this.fileGroup.PerformLayout();
            this.editGroup.ResumeLayout(false);
            this.editGroup.PerformLayout();
            this.shapeGroup.ResumeLayout(false);
            this.shapeGroup.PerformLayout();
            this.helpGroup.ResumeLayout(false);
            this.helpGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup editGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton searchButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup fileGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openFolderButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton toggleEditModeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openActiveWorkbookReadOnlyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openActiveWorkbookEditableButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu openFileMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openSelectWorkbookReadOnlyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openSelectWorkbookEditableButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton setA1Button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton initializeStyleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton manageWorksheetButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton makeGridButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup helpGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openHelpButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openVersionInfoButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton configButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu helpMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton reportIssuesButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup shapeGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu balloonMenu;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
