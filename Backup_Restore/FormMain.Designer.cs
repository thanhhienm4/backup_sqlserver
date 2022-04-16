namespace Backup_Restore
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuuAd = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThamsotime = new DevExpress.XtraBars.BarCheckItem();
            this.btnDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnsao = new DevExpress.XtraBars.BarButtonItem();
            this.pnelCSDL = new System.Windows.Forms.Panel();
            this.gcDatabase = new DevExpress.XtraGrid.GridControl();
            this.grvDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDatabase = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Backup_Restore.DS();
            this.databasesTableAdapter = new Backup_Restore.DSTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new Backup_Restore.DSTableAdapters.TableAdapterManager();
            this.bdsBackup = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Backup_Restore.DSTableAdapters.DataTable1TableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtTenDB = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtSoLuongBackup = new System.Windows.Forms.ToolStripTextBox();
            this.lblDevice = new System.Windows.Forms.ToolStripLabel();
            this.txtTenDevice = new System.Windows.Forms.ToolStripTextBox();
            this.gcBackup = new DevExpress.XtraGrid.GridControl();
            this.grvBackup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckiNit = new System.Windows.Forms.CheckBox();
            this.bdsBackup_device = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new Backup_Restore.DSTableAdapters.backup_devicesTableAdapter();
            this.Prg = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.ColorEdit();
            this.PrgLoad = new System.Windows.Forms.ProgressBar();
            this.lblinfo = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtInfoPhucHoi = new System.Windows.Forms.TextBox();
            this.dtptTimeStop = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pnelCSDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup_device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuuAd,
            this.btnPhucHoi,
            this.btnThamsotime,
            this.btnDevice,
            this.btnThoat,
            this.btnsao});
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.btnSaoLuuAd, "Sao Lưu", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThamsotime, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSaoLuuAd
            // 
            this.btnSaoLuuAd.Caption = "Sao Lưu";
            this.btnSaoLuuAd.Enabled = false;
            this.btnSaoLuuAd.Id = 0;
            this.btnSaoLuuAd.ImageOptions.Image = global::Backup_Restore.Properties.Resources.Franksouza183_Fs_Places_folder_backup;
            this.btnSaoLuuAd.Name = "btnSaoLuuAd";
            this.btnSaoLuuAd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuuAd_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Id = 1;
            this.btnPhucHoi.ImageOptions.Image = global::Backup_Restore.Properties.Resources.Custom_Icon_Design_Flatastic_9_Backup_restore;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnThamsotime
            // 
            this.btnThamsotime.Caption = "Tham số theo thời gian";
            this.btnThamsotime.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btnThamsotime.Enabled = false;
            this.btnThamsotime.Id = 2;
            this.btnThamsotime.ImageOptions.Image = global::Backup_Restore.Properties.Resources.Aha_Soft_Large_Time_Time;
            this.btnThamsotime.Name = "btnThamsotime";
            this.btnThamsotime.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThamsotime_CheckedChanged);
            // 
            // btnDevice
            // 
            this.btnDevice.Caption = "Tạo device sao lưu";
            this.btnDevice.Enabled = false;
            this.btnDevice.Id = 3;
            this.btnDevice.ImageOptions.Image = global::Backup_Restore.Properties.Resources.Hopstarter_Soft_Scraps_Button_Add;
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.AllowAllUp = true;
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = global::Backup_Restore.Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_1;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(988, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 803);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(988, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 733);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(988, 70);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 733);
            // 
            // btnsao
            // 
            this.btnsao.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.btnsao.Caption = "Sao lưu";
            this.btnsao.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Stretch;
            this.btnsao.Enabled = false;
            this.btnsao.Id = 5;
            this.btnsao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsao.ImageOptions.SvgImage")));
            this.btnsao.Name = "btnsao";
            this.btnsao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // pnelCSDL
            // 
            this.pnelCSDL.Controls.Add(this.gcDatabase);
            this.pnelCSDL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnelCSDL.Location = new System.Drawing.Point(0, 70);
            this.pnelCSDL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnelCSDL.Name = "pnelCSDL";
            this.pnelCSDL.Size = new System.Drawing.Size(300, 733);
            this.pnelCSDL.TabIndex = 4;
            // 
            // gcDatabase
            // 
            this.gcDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcDatabase.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDatabase.Location = new System.Drawing.Point(0, 0);
            this.gcDatabase.MainView = this.grvDatabase;
            this.gcDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDatabase.MenuManager = this.barManager1;
            this.gcDatabase.Name = "gcDatabase";
            this.gcDatabase.Size = new System.Drawing.Size(297, 733);
            this.gcDatabase.TabIndex = 0;
            this.gcDatabase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDatabase});
            this.gcDatabase.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // grvDatabase
            // 
            this.grvDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.coldatabase_id});
            this.grvDatabase.DetailHeight = 431;
            this.grvDatabase.GridControl = this.gcDatabase;
            this.grvDatabase.Name = "grvDatabase";
            this.grvDatabase.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvDatabase_RowClick);
            // 
            // colname
            // 
            this.colname.Caption = "Danh sách cơ sở dữ liệu";
            this.colname.FieldName = "Name";
            this.colname.MinWidth = 23;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsFilter.AllowFilter = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 87;
            // 
            // coldatabase_id
            // 
            this.coldatabase_id.FieldName = "Database_Id";
            this.coldatabase_id.MinWidth = 23;
            this.coldatabase_id.Name = "coldatabase_id";
            this.coldatabase_id.Width = 87;
            // 
            // bdsDatabase
            // 
            this.bdsDatabase.DataMember = "databases";
            this.bdsDatabase.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Backup_Restore.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsBackup
            // 
            this.bdsBackup.DataMember = "DataTable1";
            this.bdsBackup.DataSource = this.DS;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.txtTenDB,
            this.fillToolStripButton,
            this.txtSoLuongBackup,
            this.lblDevice,
            this.txtTenDevice});
            this.fillToolStrip.Location = new System.Drawing.Point(300, 70);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(688, 27);
            this.fillToolStrip.TabIndex = 9;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillToolStrip_ItemClicked);
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(78, 24);
            this.dBNAMEToolStripLabel.Text = "Tên CSDL :";
            // 
            // txtTenDB
            // 
            this.txtTenDB.Enabled = false;
            this.txtTenDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDB.Name = "txtTenDB";
            this.txtTenDB.Size = new System.Drawing.Size(151, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(73, 24);
            this.fillToolStripButton.Text = "Số lượng";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // txtSoLuongBackup
            // 
            this.txtSoLuongBackup.Enabled = false;
            this.txtSoLuongBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongBackup.Name = "txtSoLuongBackup";
            this.txtSoLuongBackup.Size = new System.Drawing.Size(58, 27);
            // 
            // lblDevice
            // 
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(81, 24);
            this.lblDevice.Text = "Tên Device";
            // 
            // txtTenDevice
            // 
            this.txtTenDevice.Enabled = false;
            this.txtTenDevice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDevice.Name = "txtTenDevice";
            this.txtTenDevice.Size = new System.Drawing.Size(186, 27);
            // 
            // gcBackup
            // 
            this.gcBackup.DataSource = this.bdsBackup;
            this.gcBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBackup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcBackup.Location = new System.Drawing.Point(300, 97);
            this.gcBackup.MainView = this.grvBackup;
            this.gcBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcBackup.MenuManager = this.barManager1;
            this.gcBackup.Name = "gcBackup";
            this.gcBackup.Size = new System.Drawing.Size(688, 274);
            this.gcBackup.TabIndex = 9;
            this.gcBackup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBackup});
            this.gcBackup.Click += new System.EventHandler(this.dataTable1GridControl_Click);
            // 
            // grvBackup
            // 
            this.grvBackup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.grvBackup.DetailHeight = 431;
            this.grvBackup.GridControl = this.gcBackup;
            this.grvBackup.Name = "grvBackup";
            this.grvBackup.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvBackup_RowClick);
            // 
            // colposition
            // 
            this.colposition.Caption = "Thứ tự";
            this.colposition.FieldName = "Position";
            this.colposition.MinWidth = 23;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.OptionsFilter.AllowAutoFilter = false;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 87;
            // 
            // colname1
            // 
            this.colname1.Caption = "Tên";
            this.colname1.FieldName = "Name";
            this.colname1.MinWidth = 23;
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.AllowEdit = false;
            this.colname1.OptionsFilter.AllowAutoFilter = false;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 87;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Thời gian";
            this.colbackup_start_date.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "Backup_Start_Date";
            this.colbackup_start_date.MinWidth = 23;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.AllowEdit = false;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 87;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "Tên User";
            this.coluser_name.FieldName = "User_Name";
            this.coluser_name.MinWidth = 23;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.AllowEdit = false;
            this.coluser_name.OptionsFilter.AllowFilter = false;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 87;
            // 
            // ckiNit
            // 
            this.ckiNit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckiNit.Location = new System.Drawing.Point(440, 398);
            this.ckiNit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckiNit.Name = "ckiNit";
            this.ckiNit.Size = new System.Drawing.Size(230, 21);
            this.ckiNit.TabIndex = 24;
            this.ckiNit.Text = "Xóa tất cả các bản sao lưu trước đó";
            this.ckiNit.UseVisualStyleBackColor = true;
            // 
            // bdsBackup_device
            // 
            this.bdsBackup_device.DataMember = "backup_devices";
            this.bdsBackup_device.DataSource = this.DS;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // Prg
            // 
            this.Prg.EditValue = 0;
            this.Prg.Location = new System.Drawing.Point(395, 73);
            this.Prg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Prg.MenuManager = this.barManager1;
            this.Prg.Name = "Prg";
            this.Prg.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Prg.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Prg.Properties.ShowTitle = true;
            this.Prg.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Prg.Size = new System.Drawing.Size(236, 33);
            this.Prg.TabIndex = 39;
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = System.Drawing.Color.Empty;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(395, 73);
            this.marqueeProgressBarControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marqueeProgressBarControl1.MenuManager = this.barManager1;
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.AutoHeight = false;
            this.marqueeProgressBarControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(183, 32);
            this.marqueeProgressBarControl1.TabIndex = 44;
            this.marqueeProgressBarControl1.TabStop = false;
            // 
            // PrgLoad
            // 
            this.PrgLoad.Enabled = false;
            this.PrgLoad.Location = new System.Drawing.Point(395, 92);
            this.PrgLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrgLoad.MarqueeAnimationSpeed = 200;
            this.PrgLoad.Maximum = 200;
            this.PrgLoad.Name = "PrgLoad";
            this.PrgLoad.Size = new System.Drawing.Size(225, 32);
            this.PrgLoad.Step = 5;
            this.PrgLoad.TabIndex = 54;
            this.PrgLoad.Visible = false;
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(341, 486);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(268, 31);
            this.lblinfo.TabIndex = 59;
            this.lblinfo.Text = "Ngày giờ phục hồi tới thời điểm đó";
            this.lblinfo.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(618, 484);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(170, 23);
            this.dtpDate.TabIndex = 60;
            this.dtpDate.Visible = false;
            // 
            // txtInfoPhucHoi
            // 
            this.txtInfoPhucHoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPhucHoi.Location = new System.Drawing.Point(344, 571);
            this.txtInfoPhucHoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfoPhucHoi.Multiline = true;
            this.txtInfoPhucHoi.Name = "txtInfoPhucHoi";
            this.txtInfoPhucHoi.Size = new System.Drawing.Size(572, 116);
            this.txtInfoPhucHoi.TabIndex = 62;
            this.txtInfoPhucHoi.Text = resources.GetString("txtInfoPhucHoi.Text");
            this.txtInfoPhucHoi.Visible = false;
            // 
            // dtptTimeStop
            // 
            this.dtptTimeStop.CustomFormat = "HH:mm:ss";
            this.dtptTimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptTimeStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtptTimeStop.Location = new System.Drawing.Point(827, 484);
            this.dtptTimeStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtptTimeStop.Name = "dtptTimeStop";
            this.dtptTimeStop.ShowUpDown = true;
            this.dtptTimeStop.Size = new System.Drawing.Size(121, 23);
            this.dtptTimeStop.TabIndex = 67;
            this.dtptTimeStop.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 823);
            this.Controls.Add(this.dtptTimeStop);
            this.Controls.Add(this.txtInfoPhucHoi);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.PrgLoad);
            this.Controls.Add(this.ckiNit);
            this.Controls.Add(this.gcBackup);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.pnelCSDL);
            this.Controls.Add(this.Prg);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormMain.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup - Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pnelCSDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup_device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuuAd;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem btnThamsotime;
        private DevExpress.XtraBars.BarButtonItem btnDevice;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
   
        private System.Windows.Forms.Panel pnelCSDL;
        private DevExpress.XtraBars.BarButtonItem btnsao;
        private System.Windows.Forms.BindingSource bdsDatabase;
        private DS DS;
        private DSTableAdapters.databasesTableAdapter databasesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDatabase;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dBNAMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtTenDB;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource bdsBackup;
        private DSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DevExpress.XtraGrid.GridControl gcBackup;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBackup;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.ToolStripTextBox txtSoLuongBackup;
        private System.Windows.Forms.CheckBox ckiNit;
        private System.Windows.Forms.BindingSource bdsBackup_device;
        private DSTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private System.Windows.Forms.ToolStripLabel lblDevice;
        private System.Windows.Forms.ToolStripTextBox txtTenDevice;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl Prg;
        private DevExpress.XtraEditors.ColorEdit marqueeProgressBarControl1;
        private System.Windows.Forms.ProgressBar PrgLoad;
        private System.Windows.Forms.TextBox txtInfoPhucHoi;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.DateTimePicker dtptTimeStop;
    }
}