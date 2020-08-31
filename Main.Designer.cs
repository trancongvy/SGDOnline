namespace CDT
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.barToolbars = new DevExpress.XtraBars.Bar();
            this.iRestart = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iExit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barMainMenu = new DevExpress.XtraBars.Bar();
            this.barSubItemSystem = new DevExpress.XtraBars.BarSubItem();
            this.iChangePassword = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iUserConfig = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iBackup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iRestore = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iCollectData = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iViewHistory = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iCheckData = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.bsiUserName = new DevExpress.XtraBars.BarStaticItem();
            this.bsiStyle = new DevExpress.XtraBars.BarStaticItem();
            this.bsiToday = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManagerMain = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.tlcMenuName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControlMain = new DevExpress.XtraNavBar.NavBarControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollectionMain = new DevExpress.Utils.ImageCollection(this.components);
            this.iHelpOnline = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iUserTrace = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItemHelp = new DevExpress.XtraBars.BarSubItem();
            this.mdiTabMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.treeListColumnMenuName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerMain)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barToolbars,
            this.barMainMenu,
            this.barStatus});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.DockManager = this.dockManagerMain;
            this.barManagerMain.Form = this;
            this.barManagerMain.Images = this.imageCollectionMain;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemSystem,
            this.bsiUserName,
            this.bsiStyle,
            this.bsiToday,
            this.iRestart,
            this.iChangePassword,
            this.iCheckData,
            this.iHelpOnline,
            this.iHelp,
            this.iAbout,
            this.iExit,
            this.iBackup,
            this.iRestore,
            this.iUserConfig,
            this.iViewHistory,
            this.iUserTrace,
            this.iCollectData});
            this.barManagerMain.MainMenu = this.barMainMenu;
            this.barManagerMain.MaxItemId = 29;
            this.barManagerMain.StatusBar = this.barStatus;
            // 
            // barToolbars
            // 
            this.barToolbars.Appearance.Options.UseTextOptions = true;
            this.barToolbars.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.barToolbars.BarName = "Tools";
            this.barToolbars.DockCol = 0;
            this.barToolbars.DockRow = 1;
            this.barToolbars.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barToolbars.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iRestart, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iHelp, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barToolbars.Text = "Tools";
            // 
            // iRestart
            // 
            this.iRestart.Caption = "Đăng nhập lại";
            this.iRestart.Id = 12;
            this.iRestart.ImageIndex = 2;
            this.iRestart.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.iRestart.Name = "iRestart";
            this.iRestart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iRestart_ItemClick);
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Giúp đỡ";
            this.iHelp.Id = 15;
            this.iHelp.ImageIndex = 1;
            this.iHelp.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.iHelp.Name = "iHelp";
            // 
            // iExit
            // 
            this.iExit.Caption = "Kết thúc";
            this.iExit.Id = 17;
            this.iExit.ImageIndex = 3;
            this.iExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.iExit.Name = "iExit";
            // 
            // barMainMenu
            // 
            this.barMainMenu.BarName = "Main menu";
            this.barMainMenu.DockCol = 0;
            this.barMainMenu.DockRow = 0;
            this.barMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSystem)});
            this.barMainMenu.OptionsBar.DrawDragBorder = false;
            this.barMainMenu.OptionsBar.MultiLine = true;
            this.barMainMenu.OptionsBar.UseWholeRow = true;
            this.barMainMenu.Text = "Main menu";
            // 
            // barSubItemSystem
            // 
            this.barSubItemSystem.Caption = "Hệ thống";
            this.barSubItemSystem.Id = 0;
            this.barSubItemSystem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iRestart),
            new DevExpress.XtraBars.LinkPersistInfo(this.iChangePassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.iUserConfig),
            new DevExpress.XtraBars.LinkPersistInfo(this.iBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.iRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCollectData),
            new DevExpress.XtraBars.LinkPersistInfo(this.iViewHistory),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCheckData),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit)});
            this.barSubItemSystem.Name = "barSubItemSystem";
            // 
            // iChangePassword
            // 
            this.iChangePassword.Caption = "Đổi mật khẩu";
            this.iChangePassword.Id = 13;
            this.iChangePassword.Name = "iChangePassword";
            // 
            // iUserConfig
            // 
            this.iUserConfig.Caption = "Tham số người dùng";
            this.iUserConfig.Id = 24;
            this.iUserConfig.Name = "iUserConfig";
            // 
            // iBackup
            // 
            this.iBackup.Caption = "Sao lưu số liệu";
            this.iBackup.Id = 22;
            this.iBackup.ImageIndex = 4;
            this.iBackup.Name = "iBackup";
            // 
            // iRestore
            // 
            this.iRestore.Caption = "Phục hồi số liệu";
            this.iRestore.Id = 23;
            this.iRestore.Name = "iRestore";
            // 
            // iCollectData
            // 
            this.iCollectData.Caption = "Tổng hợp số liệu";
            this.iCollectData.Id = 28;
            this.iCollectData.Name = "iCollectData";
            // 
            // iViewHistory
            // 
            this.iViewHistory.Caption = "Truy vết số liệu";
            this.iViewHistory.Id = 25;
            this.iViewHistory.ImageIndex = 6;
            this.iViewHistory.Name = "iViewHistory";
            // 
            // iCheckData
            // 
            this.iCheckData.Caption = "Kiểm tra số liệu thô";
            this.iCheckData.Id = 14;
            this.iCheckData.ImageIndex = 0;
            this.iCheckData.Name = "iCheckData";
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiUserName),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiStyle),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiToday)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // bsiUserName
            // 
            this.bsiUserName.Caption = "Người dùng";
            this.bsiUserName.Id = 7;
            this.bsiUserName.Name = "bsiUserName";
            this.bsiUserName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiStyle
            // 
            this.bsiStyle.Caption = "Kiểu giao diện";
            this.bsiStyle.Id = 8;
            this.bsiStyle.Name = "bsiStyle";
            this.bsiStyle.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiToday
            // 
            this.bsiToday.Caption = "Ngày hệ thống";
            this.bsiToday.Id = 9;
            this.bsiToday.Name = "bsiToday";
            this.bsiToday.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dockManagerMain
            // 
            this.dockManagerMain.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManagerMain.Form = this;
            this.dockManagerMain.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManagerMain.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.Controls.Add(this.dockPanel2);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 84);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 304);
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.ID = new System.Guid("7ca4d8b8-03ce-40f0-8c7e-d6a1d6ea2249");
            this.dockPanel2.Location = new System.Drawing.Point(-255, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.SavedIndex = 0;
            this.dockPanel2.Size = new System.Drawing.Size(255, 304);
            this.dockPanel2.Text = "Cây chức năng";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.treeListMain);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(249, 276);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // treeListMain
            // 
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcMenuName});
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.Location = new System.Drawing.Point(0, 0);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.AllowExpandOnDblClick = false;
            this.treeListMain.OptionsBehavior.Editable = false;
            this.treeListMain.Size = new System.Drawing.Size(249, 276);
            this.treeListMain.TabIndex = 5;
            this.treeListMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeListMain_MouseDoubleClick);
            this.treeListMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeListMain_KeyDown);
            // 
            // tlcMenuName
            // 
            this.tlcMenuName.FieldName = "MenuName";
            this.tlcMenuName.Name = "tlcMenuName";
            this.tlcMenuName.Visible = true;
            this.tlcMenuName.VisibleIndex = 0;
            this.tlcMenuName.Width = 174;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("bb1af0ff-1381-421f-a2f8-ad286563238c");
            this.dockPanel1.Location = new System.Drawing.Point(19, 84);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(255, 304);
            this.dockPanel1.Text = "Menu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControlMain);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(249, 276);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControlMain
            // 
            this.navBarControlMain.ActiveGroup = null;
            this.navBarControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControlMain.Location = new System.Drawing.Point(0, 0);
            this.navBarControlMain.Name = "navBarControlMain";
            this.navBarControlMain.OptionsNavPane.ExpandedWidth = 269;
            this.navBarControlMain.Size = new System.Drawing.Size(249, 276);
            this.navBarControlMain.SmallImages = this.imageCollection1;
            this.navBarControlMain.TabIndex = 7;
            this.navBarControlMain.Text = "navBarControl1";
            this.navBarControlMain.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            this.navBarControlMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControlMain_LinkClicked);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // imageCollectionMain
            // 
            this.imageCollectionMain.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollectionMain.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMain.ImageStream")));
            // 
            // iHelpOnline
            // 
            this.iHelpOnline.Caption = "Hỗ trợ trực tuyến";
            this.iHelpOnline.Id = 16;
            this.iHelpOnline.ImageIndex = 1;
            this.iHelpOnline.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10);
            this.iHelpOnline.Name = "iHelpOnline";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "Thông tin phần mềm";
            this.iAbout.Id = 16;
            this.iAbout.Name = "iAbout";
            // 
            // iUserTrace
            // 
            this.iUserTrace.Caption = "Xem lưu vết người dùng";
            this.iUserTrace.Id = 26;
            this.iUserTrace.ImageIndex = 5;
            this.iUserTrace.Name = "iUserTrace";
            // 
            // barSubItemHelp
            // 
            this.barSubItemHelp.Caption = "Giúp đỡ";
            this.barSubItemHelp.Id = 27;
            this.barSubItemHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout),
            new DevExpress.XtraBars.LinkPersistInfo(this.iHelpOnline),
            new DevExpress.XtraBars.LinkPersistInfo(this.iHelp)});
            this.barSubItemHelp.Name = "barSubItemHelp";
            // 
            // mdiTabMain
            // 
            this.mdiTabMain.MdiParent = this;
            // 
            // treeListColumnMenuName
            // 
            this.treeListColumnMenuName.Caption = "Hệ thống chức năng";
            this.treeListColumnMenuName.FieldName = "MenuName";
            this.treeListColumnMenuName.Name = "treeListColumnMenuName";
            this.treeListColumnMenuName.Visible = true;
            this.treeListColumnMenuName.VisibleIndex = 0;
            this.treeListColumnMenuName.Width = 174;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Hệ thống chức năng";
            this.treeListColumn1.FieldName = "MenuName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 174;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(719, 412);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerMain)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar barToolbars;
        private DevExpress.XtraBars.Bar barMainMenu;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollectionMain;
        private DevExpress.XtraBars.BarSubItem barSubItemSystem;
        private DevExpress.XtraBars.BarStaticItem bsiUserName;
        private DevExpress.XtraBars.BarStaticItem bsiStyle;
        private DevExpress.XtraBars.BarStaticItem bsiToday;
        private DevExpress.XtraBars.BarLargeButtonItem iRestart;
        private DevExpress.XtraBars.BarLargeButtonItem iChangePassword;
        private DevExpress.XtraBars.BarLargeButtonItem iCheckData;
        private DevExpress.XtraBars.BarLargeButtonItem iHelp;
        private DevExpress.XtraBars.BarLargeButtonItem iHelpOnline;
        private DevExpress.XtraBars.BarLargeButtonItem iAbout;
        private DevExpress.XtraBars.BarLargeButtonItem iExit;
        private DevExpress.XtraBars.BarLargeButtonItem iBackup;
        private DevExpress.XtraBars.BarLargeButtonItem iRestore;
        private DevExpress.XtraBars.BarLargeButtonItem iUserConfig;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiTabMain;
        private DevExpress.XtraBars.Docking.DockManager dockManagerMain;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControlMain;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcMenuName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenuName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraBars.BarLargeButtonItem iViewHistory;
        private DevExpress.XtraBars.BarLargeButtonItem iUserTrace;
        private DevExpress.XtraBars.BarSubItem barSubItemHelp;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.BarLargeButtonItem iCollectData;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}

