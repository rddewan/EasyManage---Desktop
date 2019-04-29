namespace EasyManage
{
    partial class MainForm
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse_main = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.side_menu = new System.Windows.Forms.Panel();
            this.menu_setting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.menu_grid = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header = new System.Windows.Forms.Panel();
            this.lb_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDrag_header = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.side_menu_transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lb_vendId = new System.Windows.Forms.Label();
            this.lb_vendName = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.companyDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_company = new System.Windows.Forms.Label();
            this.btn_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.warrentyEndDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lb_warrentyEnd = new System.Windows.Forms.Label();
            this.txt_note = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_note = new System.Windows.Forms.Label();
            this.statusDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_user = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_user = new System.Windows.Forms.Label();
            this.departmentDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_location = new System.Windows.Forms.Label();
            this.locationDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_department = new System.Windows.Forms.Label();
            this.productTypeDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_productType = new System.Windows.Forms.Label();
            this.warrentyDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_warrenty = new System.Windows.Forms.Label();
            this.lb_IMEI = new System.Windows.Forms.Label();
            this.txt_IMEI = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_serialNumber = new System.Windows.Forms.Label();
            this.txt_serialNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_model = new System.Windows.Forms.Label();
            this.txt_model = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_productName = new System.Windows.Forms.Label();
            this.txt_productName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_PONumber = new System.Windows.Forms.Label();
            this.txt_PONumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_deliveryDate = new System.Windows.Forms.Label();
            this.deliveryDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lb_PRFNumber = new System.Windows.Forms.Label();
            this.txt_PRFNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_vendorName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_vendorId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_maximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.side_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.main_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse_main
            // 
            this.bunifuElipse_main.ElipseRadius = 5;
            this.bunifuElipse_main.TargetControl = this;
            // 
            // side_menu
            // 
            this.side_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.side_menu.Controls.Add(this.menu_setting);
            this.side_menu.Controls.Add(this.panel1);
            this.side_menu.Controls.Add(this.menu_grid);
            this.side_menu.Controls.Add(this.menu_add);
            this.side_menu.Controls.Add(this.menu_dashboard);
            this.side_menu_transition.SetDecoration(this.side_menu, BunifuAnimatorNS.DecorationType.None);
            this.side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_menu.Location = new System.Drawing.Point(0, 47);
            this.side_menu.Name = "side_menu";
            this.side_menu.Size = new System.Drawing.Size(207, 733);
            this.side_menu.TabIndex = 0;
            // 
            // menu_setting
            // 
            this.menu_setting.Active = false;
            this.menu_setting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menu_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_setting.BorderRadius = 0;
            this.menu_setting.ButtonText = "Setting";
            this.menu_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.side_menu_transition.SetDecoration(this.menu_setting, BunifuAnimatorNS.DecorationType.None);
            this.menu_setting.DisabledColor = System.Drawing.Color.Gray;
            this.menu_setting.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_setting.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_setting.Iconimage")));
            this.menu_setting.Iconimage_right = null;
            this.menu_setting.Iconimage_right_Selected = null;
            this.menu_setting.Iconimage_Selected = null;
            this.menu_setting.IconMarginLeft = 0;
            this.menu_setting.IconMarginRight = 0;
            this.menu_setting.IconRightVisible = true;
            this.menu_setting.IconRightZoom = 0D;
            this.menu_setting.IconVisible = true;
            this.menu_setting.IconZoom = 90D;
            this.menu_setting.IsTab = false;
            this.menu_setting.Location = new System.Drawing.Point(9, 312);
            this.menu_setting.Name = "menu_setting";
            this.menu_setting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_setting.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.menu_setting.OnHoverTextColor = System.Drawing.Color.White;
            this.menu_setting.selected = false;
            this.menu_setting.Size = new System.Drawing.Size(191, 48);
            this.menu_setting.TabIndex = 5;
            this.menu_setting.Text = "Setting";
            this.menu_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_setting.Textcolor = System.Drawing.Color.Silver;
            this.menu_setting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_menu);
            this.side_menu_transition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 46);
            this.panel1.TabIndex = 2;
            // 
            // btn_menu
            // 
            this.side_menu_transition.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageActive = null;
            this.btn_menu.Location = new System.Drawing.Point(169, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(38, 46);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 1;
            this.btn_menu.TabStop = false;
            this.btn_menu.Zoom = 10;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // menu_grid
            // 
            this.menu_grid.Active = false;
            this.menu_grid.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menu_grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_grid.BorderRadius = 0;
            this.menu_grid.ButtonText = "Grid View";
            this.menu_grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.side_menu_transition.SetDecoration(this.menu_grid, BunifuAnimatorNS.DecorationType.None);
            this.menu_grid.DisabledColor = System.Drawing.Color.Gray;
            this.menu_grid.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_grid.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_grid.Iconimage")));
            this.menu_grid.Iconimage_right = null;
            this.menu_grid.Iconimage_right_Selected = null;
            this.menu_grid.Iconimage_Selected = null;
            this.menu_grid.IconMarginLeft = 0;
            this.menu_grid.IconMarginRight = 0;
            this.menu_grid.IconRightVisible = true;
            this.menu_grid.IconRightZoom = 0D;
            this.menu_grid.IconVisible = true;
            this.menu_grid.IconZoom = 90D;
            this.menu_grid.IsTab = false;
            this.menu_grid.Location = new System.Drawing.Point(12, 258);
            this.menu_grid.Name = "menu_grid";
            this.menu_grid.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_grid.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.menu_grid.OnHoverTextColor = System.Drawing.Color.White;
            this.menu_grid.selected = false;
            this.menu_grid.Size = new System.Drawing.Size(191, 48);
            this.menu_grid.TabIndex = 4;
            this.menu_grid.Text = "Grid View";
            this.menu_grid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_grid.Textcolor = System.Drawing.Color.Silver;
            this.menu_grid.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_grid.Click += new System.EventHandler(this.menu_grid_Click);
            // 
            // menu_add
            // 
            this.menu_add.Active = false;
            this.menu_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menu_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_add.BorderRadius = 0;
            this.menu_add.ButtonText = "Add Record";
            this.menu_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.side_menu_transition.SetDecoration(this.menu_add, BunifuAnimatorNS.DecorationType.None);
            this.menu_add.DisabledColor = System.Drawing.Color.Gray;
            this.menu_add.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_add.Iconimage")));
            this.menu_add.Iconimage_right = null;
            this.menu_add.Iconimage_right_Selected = null;
            this.menu_add.Iconimage_Selected = null;
            this.menu_add.IconMarginLeft = 0;
            this.menu_add.IconMarginRight = 0;
            this.menu_add.IconRightVisible = true;
            this.menu_add.IconRightZoom = 0D;
            this.menu_add.IconVisible = true;
            this.menu_add.IconZoom = 90D;
            this.menu_add.IsTab = false;
            this.menu_add.Location = new System.Drawing.Point(12, 204);
            this.menu_add.Name = "menu_add";
            this.menu_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_add.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.menu_add.OnHoverTextColor = System.Drawing.Color.White;
            this.menu_add.selected = false;
            this.menu_add.Size = new System.Drawing.Size(191, 48);
            this.menu_add.TabIndex = 3;
            this.menu_add.Text = "Add Record";
            this.menu_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_add.Textcolor = System.Drawing.Color.Silver;
            this.menu_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_add.Click += new System.EventHandler(this.menu_add_Click);
            // 
            // menu_dashboard
            // 
            this.menu_dashboard.Active = true;
            this.menu_dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menu_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_dashboard.BorderRadius = 0;
            this.menu_dashboard.ButtonText = "Dashboard";
            this.menu_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.side_menu_transition.SetDecoration(this.menu_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.menu_dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.menu_dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu_dashboard.Iconimage")));
            this.menu_dashboard.Iconimage_right = null;
            this.menu_dashboard.Iconimage_right_Selected = null;
            this.menu_dashboard.Iconimage_Selected = null;
            this.menu_dashboard.IconMarginLeft = 0;
            this.menu_dashboard.IconMarginRight = 0;
            this.menu_dashboard.IconRightVisible = true;
            this.menu_dashboard.IconRightZoom = 0D;
            this.menu_dashboard.IconVisible = true;
            this.menu_dashboard.IconZoom = 90D;
            this.menu_dashboard.IsTab = false;
            this.menu_dashboard.Location = new System.Drawing.Point(12, 150);
            this.menu_dashboard.Name = "menu_dashboard";
            this.menu_dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu_dashboard.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.menu_dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.menu_dashboard.selected = true;
            this.menu_dashboard.Size = new System.Drawing.Size(188, 48);
            this.menu_dashboard.TabIndex = 2;
            this.menu_dashboard.Text = "Dashboard";
            this.menu_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_dashboard.Textcolor = System.Drawing.Color.Silver;
            this.menu_dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.btn_minimize);
            this.header.Controls.Add(this.btn_maximize);
            this.header.Controls.Add(this.lb_title);
            this.header.Controls.Add(this.btn_close);
            this.side_menu_transition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1400, 47);
            this.header.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.side_menu_transition.SetDecoration(this.lb_title, BunifuAnimatorNS.DecorationType.None);
            this.lb_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(13, 13);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(116, 21);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Easy Manage";
            // 
            // btn_close
            // 
            this.side_menu_transition.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(1362, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(38, 47);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // bunifuDrag_header
            // 
            this.bunifuDrag_header.Fixed = true;
            this.bunifuDrag_header.Horizontal = true;
            this.bunifuDrag_header.TargetControl = this.header;
            this.bunifuDrag_header.Vertical = true;
            // 
            // side_menu_transition
            // 
            this.side_menu_transition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.side_menu_transition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.side_menu_transition.DefaultAnimation = animation3;
            // 
            // lb_vendId
            // 
            this.side_menu_transition.SetDecoration(this.lb_vendId, BunifuAnimatorNS.DecorationType.None);
            this.lb_vendId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vendId.ForeColor = System.Drawing.Color.Silver;
            this.lb_vendId.Location = new System.Drawing.Point(4, 10);
            this.lb_vendId.Name = "lb_vendId";
            this.lb_vendId.Size = new System.Drawing.Size(158, 48);
            this.lb_vendId.TabIndex = 2;
            this.lb_vendId.Text = "Vendor Id";
            this.lb_vendId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_vendName
            // 
            this.side_menu_transition.SetDecoration(this.lb_vendName, BunifuAnimatorNS.DecorationType.None);
            this.lb_vendName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vendName.ForeColor = System.Drawing.Color.Silver;
            this.lb_vendName.Location = new System.Drawing.Point(6, 65);
            this.lb_vendName.Name = "lb_vendName";
            this.lb_vendName.Size = new System.Drawing.Size(158, 48);
            this.lb_vendName.TabIndex = 3;
            this.lb_vendName.Text = "Vendor Name";
            this.lb_vendName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.companyDropdown);
            this.main_panel.Controls.Add(this.lb_company);
            this.main_panel.Controls.Add(this.btn_Save);
            this.main_panel.Controls.Add(this.warrentyEndDatepicker);
            this.main_panel.Controls.Add(this.lb_warrentyEnd);
            this.main_panel.Controls.Add(this.txt_note);
            this.main_panel.Controls.Add(this.lb_note);
            this.main_panel.Controls.Add(this.statusDropdown);
            this.main_panel.Controls.Add(this.lb_status);
            this.main_panel.Controls.Add(this.txt_user);
            this.main_panel.Controls.Add(this.lb_user);
            this.main_panel.Controls.Add(this.departmentDropdown);
            this.main_panel.Controls.Add(this.lb_location);
            this.main_panel.Controls.Add(this.locationDropdown);
            this.main_panel.Controls.Add(this.lb_department);
            this.main_panel.Controls.Add(this.productTypeDropdown);
            this.main_panel.Controls.Add(this.lb_productType);
            this.main_panel.Controls.Add(this.warrentyDropdown);
            this.main_panel.Controls.Add(this.lb_warrenty);
            this.main_panel.Controls.Add(this.lb_IMEI);
            this.main_panel.Controls.Add(this.txt_IMEI);
            this.main_panel.Controls.Add(this.lb_serialNumber);
            this.main_panel.Controls.Add(this.txt_serialNumber);
            this.main_panel.Controls.Add(this.lb_model);
            this.main_panel.Controls.Add(this.txt_model);
            this.main_panel.Controls.Add(this.lb_productName);
            this.main_panel.Controls.Add(this.txt_productName);
            this.main_panel.Controls.Add(this.lb_PONumber);
            this.main_panel.Controls.Add(this.txt_PONumber);
            this.main_panel.Controls.Add(this.lb_deliveryDate);
            this.main_panel.Controls.Add(this.deliveryDatepicker);
            this.main_panel.Controls.Add(this.lb_PRFNumber);
            this.main_panel.Controls.Add(this.txt_PRFNumber);
            this.main_panel.Controls.Add(this.txt_vendorName);
            this.main_panel.Controls.Add(this.txt_vendorId);
            this.main_panel.Controls.Add(this.lb_vendId);
            this.main_panel.Controls.Add(this.lb_vendName);
            this.side_menu_transition.SetDecoration(this.main_panel, BunifuAnimatorNS.DecorationType.None);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_panel.Location = new System.Drawing.Point(207, 101);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1193, 679);
            this.main_panel.TabIndex = 3;
            // 
            // companyDropdown
            // 
            this.companyDropdown.BackColor = System.Drawing.Color.Transparent;
            this.companyDropdown.BorderRadius = 3;
            this.side_menu_transition.SetDecoration(this.companyDropdown, BunifuAnimatorNS.DecorationType.None);
            this.companyDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.companyDropdown.ForeColor = System.Drawing.Color.White;
            this.companyDropdown.Location = new System.Drawing.Point(742, 296);
            this.companyDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.companyDropdown.Name = "companyDropdown";
            this.companyDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.companyDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.companyDropdown.selectedIndex = -1;
            this.companyDropdown.Size = new System.Drawing.Size(355, 48);
            this.companyDropdown.TabIndex = 17;
            // 
            // lb_company
            // 
            this.side_menu_transition.SetDecoration(this.lb_company, BunifuAnimatorNS.DecorationType.None);
            this.lb_company.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_company.ForeColor = System.Drawing.Color.Silver;
            this.lb_company.Location = new System.Drawing.Point(567, 296);
            this.lb_company.Name = "lb_company";
            this.lb_company.Size = new System.Drawing.Size(158, 48);
            this.lb_company.TabIndex = 38;
            this.lb_company.Text = "Company";
            this.lb_company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Save
            // 
            this.btn_Save.Active = false;
            this.btn_Save.Activecolor = System.Drawing.Color.Red;
            this.btn_Save.BackColor = System.Drawing.Color.Red;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Save.BorderRadius = 0;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.side_menu_transition.SetDecoration(this.btn_Save, BunifuAnimatorNS.DecorationType.None);
            this.btn_Save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Save.Iconimage")));
            this.btn_Save.Iconimage_right = null;
            this.btn_Save.Iconimage_right_Selected = null;
            this.btn_Save.Iconimage_Selected = null;
            this.btn_Save.IconMarginLeft = 80;
            this.btn_Save.IconMarginRight = 0;
            this.btn_Save.IconRightVisible = true;
            this.btn_Save.IconRightZoom = 0D;
            this.btn_Save.IconVisible = true;
            this.btn_Save.IconZoom = 110D;
            this.btn_Save.IsTab = false;
            this.btn_Save.Location = new System.Drawing.Point(742, 584);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Normalcolor = System.Drawing.Color.Red;
            this.btn_Save.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Save.selected = false;
            this.btn_Save.Size = new System.Drawing.Size(355, 50);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Textcolor = System.Drawing.Color.White;
            this.btn_Save.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // warrentyEndDatepicker
            // 
            this.warrentyEndDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.warrentyEndDatepicker.BorderRadius = 0;
            this.side_menu_transition.SetDecoration(this.warrentyEndDatepicker, BunifuAnimatorNS.DecorationType.None);
            this.warrentyEndDatepicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warrentyEndDatepicker.ForeColor = System.Drawing.Color.White;
            this.warrentyEndDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.warrentyEndDatepicker.FormatCustom = "dd/MM/yyyy";
            this.warrentyEndDatepicker.Location = new System.Drawing.Point(742, 10);
            this.warrentyEndDatepicker.Margin = new System.Windows.Forms.Padding(5);
            this.warrentyEndDatepicker.Name = "warrentyEndDatepicker";
            this.warrentyEndDatepicker.Size = new System.Drawing.Size(355, 48);
            this.warrentyEndDatepicker.TabIndex = 12;
            this.warrentyEndDatepicker.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // lb_warrentyEnd
            // 
            this.side_menu_transition.SetDecoration(this.lb_warrentyEnd, BunifuAnimatorNS.DecorationType.None);
            this.lb_warrentyEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warrentyEnd.ForeColor = System.Drawing.Color.Silver;
            this.lb_warrentyEnd.Location = new System.Drawing.Point(576, 10);
            this.lb_warrentyEnd.Name = "lb_warrentyEnd";
            this.lb_warrentyEnd.Size = new System.Drawing.Size(158, 48);
            this.lb_warrentyEnd.TabIndex = 35;
            this.lb_warrentyEnd.Text = "Warrenty End";
            this.lb_warrentyEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_note
            // 
            this.txt_note.BorderColor = System.Drawing.Color.SeaGreen;
            this.side_menu_transition.SetDecoration(this.txt_note, BunifuAnimatorNS.DecorationType.None);
            this.txt_note.Location = new System.Drawing.Point(742, 354);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(355, 164);
            this.txt_note.TabIndex = 18;
            // 
            // lb_note
            // 
            this.side_menu_transition.SetDecoration(this.lb_note, BunifuAnimatorNS.DecorationType.None);
            this.lb_note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.ForeColor = System.Drawing.Color.Silver;
            this.lb_note.Location = new System.Drawing.Point(576, 358);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(158, 48);
            this.lb_note.TabIndex = 33;
            this.lb_note.Text = "Note";
            this.lb_note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusDropdown
            // 
            this.statusDropdown.BackColor = System.Drawing.Color.Transparent;
            this.statusDropdown.BorderRadius = 3;
            this.side_menu_transition.SetDecoration(this.statusDropdown, BunifuAnimatorNS.DecorationType.None);
            this.statusDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.statusDropdown.ForeColor = System.Drawing.Color.White;
            this.statusDropdown.Location = new System.Drawing.Point(742, 237);
            this.statusDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.statusDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.statusDropdown.selectedIndex = -1;
            this.statusDropdown.Size = new System.Drawing.Size(355, 48);
            this.statusDropdown.TabIndex = 16;
            // 
            // lb_status
            // 
            this.side_menu_transition.SetDecoration(this.lb_status, BunifuAnimatorNS.DecorationType.None);
            this.lb_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Silver;
            this.lb_status.Location = new System.Drawing.Point(576, 238);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(158, 48);
            this.lb_status.TabIndex = 31;
            this.lb_status.Text = "Status";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_user
            // 
            this.txt_user.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_user.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_user.BorderThickness = 3;
            this.txt_user.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_user, BunifuAnimatorNS.DecorationType.None);
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Silver;
            this.txt_user.isPassword = false;
            this.txt_user.Location = new System.Drawing.Point(742, 181);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(355, 48);
            this.txt_user.TabIndex = 15;
            this.txt_user.Tag = "";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_user
            // 
            this.side_menu_transition.SetDecoration(this.lb_user, BunifuAnimatorNS.DecorationType.None);
            this.lb_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.Silver;
            this.lb_user.Location = new System.Drawing.Point(576, 183);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(158, 48);
            this.lb_user.TabIndex = 29;
            this.lb_user.Text = "User";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // departmentDropdown
            // 
            this.departmentDropdown.BackColor = System.Drawing.Color.Transparent;
            this.departmentDropdown.BorderRadius = 3;
            this.side_menu_transition.SetDecoration(this.departmentDropdown, BunifuAnimatorNS.DecorationType.None);
            this.departmentDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.departmentDropdown.ForeColor = System.Drawing.Color.White;
            this.departmentDropdown.Location = new System.Drawing.Point(742, 126);
            this.departmentDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.departmentDropdown.Name = "departmentDropdown";
            this.departmentDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.departmentDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.departmentDropdown.selectedIndex = -1;
            this.departmentDropdown.Size = new System.Drawing.Size(355, 48);
            this.departmentDropdown.TabIndex = 14;
            // 
            // lb_location
            // 
            this.side_menu_transition.SetDecoration(this.lb_location, BunifuAnimatorNS.DecorationType.None);
            this.lb_location.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_location.ForeColor = System.Drawing.Color.Silver;
            this.lb_location.Location = new System.Drawing.Point(576, 68);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(158, 48);
            this.lb_location.TabIndex = 27;
            this.lb_location.Text = "Location";
            this.lb_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationDropdown
            // 
            this.locationDropdown.BackColor = System.Drawing.Color.Transparent;
            this.locationDropdown.BorderRadius = 3;
            this.side_menu_transition.SetDecoration(this.locationDropdown, BunifuAnimatorNS.DecorationType.None);
            this.locationDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.locationDropdown.ForeColor = System.Drawing.Color.White;
            this.locationDropdown.Location = new System.Drawing.Point(742, 68);
            this.locationDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.locationDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.locationDropdown.selectedIndex = -1;
            this.locationDropdown.Size = new System.Drawing.Size(355, 48);
            this.locationDropdown.TabIndex = 13;
            // 
            // lb_department
            // 
            this.side_menu_transition.SetDecoration(this.lb_department, BunifuAnimatorNS.DecorationType.None);
            this.lb_department.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_department.ForeColor = System.Drawing.Color.Silver;
            this.lb_department.Location = new System.Drawing.Point(576, 126);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(158, 48);
            this.lb_department.TabIndex = 25;
            this.lb_department.Text = "Department";
            this.lb_department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productTypeDropdown
            // 
            this.productTypeDropdown.BackColor = System.Drawing.Color.Transparent;
            this.productTypeDropdown.BorderRadius = 3;
            this.side_menu_transition.SetDecoration(this.productTypeDropdown, BunifuAnimatorNS.DecorationType.None);
            this.productTypeDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.productTypeDropdown.ForeColor = System.Drawing.Color.White;
            this.productTypeDropdown.Location = new System.Drawing.Point(172, 296);
            this.productTypeDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.productTypeDropdown.Name = "productTypeDropdown";
            this.productTypeDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.productTypeDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.productTypeDropdown.selectedIndex = -1;
            this.productTypeDropdown.Size = new System.Drawing.Size(355, 48);
            this.productTypeDropdown.TabIndex = 6;
            // 
            // lb_productType
            // 
            this.side_menu_transition.SetDecoration(this.lb_productType, BunifuAnimatorNS.DecorationType.None);
            this.lb_productType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productType.ForeColor = System.Drawing.Color.Silver;
            this.lb_productType.Location = new System.Drawing.Point(6, 296);
            this.lb_productType.Name = "lb_productType";
            this.lb_productType.Size = new System.Drawing.Size(158, 48);
            this.lb_productType.TabIndex = 23;
            this.lb_productType.Text = "Product Type";
            this.lb_productType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // warrentyDropdown
            // 
            this.warrentyDropdown.AutoSize = true;
            this.warrentyDropdown.BackColor = System.Drawing.Color.Transparent;
            this.warrentyDropdown.BorderRadius = 3;
            this.side_menu_transition.SetDecoration(this.warrentyDropdown, BunifuAnimatorNS.DecorationType.None);
            this.warrentyDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.warrentyDropdown.ForeColor = System.Drawing.Color.White;
            this.warrentyDropdown.Location = new System.Drawing.Point(172, 586);
            this.warrentyDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.warrentyDropdown.Name = "warrentyDropdown";
            this.warrentyDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.warrentyDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.warrentyDropdown.selectedIndex = -1;
            this.warrentyDropdown.Size = new System.Drawing.Size(355, 48);
            this.warrentyDropdown.TabIndex = 11;
            this.warrentyDropdown.onItemSelected += new System.EventHandler(this.warrentyDropdown_onItemSelected);
            // 
            // lb_warrenty
            // 
            this.side_menu_transition.SetDecoration(this.lb_warrenty, BunifuAnimatorNS.DecorationType.None);
            this.lb_warrenty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warrenty.ForeColor = System.Drawing.Color.Silver;
            this.lb_warrenty.Location = new System.Drawing.Point(6, 584);
            this.lb_warrenty.Name = "lb_warrenty";
            this.lb_warrenty.Size = new System.Drawing.Size(158, 48);
            this.lb_warrenty.TabIndex = 22;
            this.lb_warrenty.Text = "Warrenty";
            this.lb_warrenty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_IMEI
            // 
            this.side_menu_transition.SetDecoration(this.lb_IMEI, BunifuAnimatorNS.DecorationType.None);
            this.lb_IMEI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IMEI.ForeColor = System.Drawing.Color.Silver;
            this.lb_IMEI.Location = new System.Drawing.Point(6, 526);
            this.lb_IMEI.Name = "lb_IMEI";
            this.lb_IMEI.Size = new System.Drawing.Size(158, 48);
            this.lb_IMEI.TabIndex = 20;
            this.lb_IMEI.Text = "IMEI";
            this.lb_IMEI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_IMEI
            // 
            this.txt_IMEI.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_IMEI.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_IMEI.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_IMEI.BorderThickness = 3;
            this.txt_IMEI.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_IMEI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_IMEI, BunifuAnimatorNS.DecorationType.None);
            this.txt_IMEI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IMEI.ForeColor = System.Drawing.Color.Silver;
            this.txt_IMEI.isPassword = false;
            this.txt_IMEI.Location = new System.Drawing.Point(172, 528);
            this.txt_IMEI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IMEI.MaxLength = 32767;
            this.txt_IMEI.Name = "txt_IMEI";
            this.txt_IMEI.Size = new System.Drawing.Size(355, 48);
            this.txt_IMEI.TabIndex = 10;
            this.txt_IMEI.Tag = "";
            this.txt_IMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_serialNumber
            // 
            this.side_menu_transition.SetDecoration(this.lb_serialNumber, BunifuAnimatorNS.DecorationType.None);
            this.lb_serialNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serialNumber.ForeColor = System.Drawing.Color.Silver;
            this.lb_serialNumber.Location = new System.Drawing.Point(6, 468);
            this.lb_serialNumber.Name = "lb_serialNumber";
            this.lb_serialNumber.Size = new System.Drawing.Size(158, 48);
            this.lb_serialNumber.TabIndex = 18;
            this.lb_serialNumber.Text = "Serial Number";
            this.lb_serialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_serialNumber
            // 
            this.txt_serialNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_serialNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_serialNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_serialNumber.BorderThickness = 3;
            this.txt_serialNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_serialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_serialNumber, BunifuAnimatorNS.DecorationType.None);
            this.txt_serialNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serialNumber.ForeColor = System.Drawing.Color.Silver;
            this.txt_serialNumber.isPassword = false;
            this.txt_serialNumber.Location = new System.Drawing.Point(172, 470);
            this.txt_serialNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_serialNumber.MaxLength = 32767;
            this.txt_serialNumber.Name = "txt_serialNumber";
            this.txt_serialNumber.Size = new System.Drawing.Size(355, 48);
            this.txt_serialNumber.TabIndex = 9;
            this.txt_serialNumber.Tag = "";
            this.txt_serialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_model
            // 
            this.side_menu_transition.SetDecoration(this.lb_model, BunifuAnimatorNS.DecorationType.None);
            this.lb_model.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_model.ForeColor = System.Drawing.Color.Silver;
            this.lb_model.Location = new System.Drawing.Point(6, 410);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(158, 48);
            this.lb_model.TabIndex = 16;
            this.lb_model.Text = "Model";
            this.lb_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_model
            // 
            this.txt_model.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_model.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_model.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_model.BorderThickness = 3;
            this.txt_model.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_model, BunifuAnimatorNS.DecorationType.None);
            this.txt_model.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.ForeColor = System.Drawing.Color.Silver;
            this.txt_model.isPassword = false;
            this.txt_model.Location = new System.Drawing.Point(172, 412);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(355, 48);
            this.txt_model.TabIndex = 8;
            this.txt_model.Tag = "";
            this.txt_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_productName
            // 
            this.side_menu_transition.SetDecoration(this.lb_productName, BunifuAnimatorNS.DecorationType.None);
            this.lb_productName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productName.ForeColor = System.Drawing.Color.Silver;
            this.lb_productName.Location = new System.Drawing.Point(6, 352);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(158, 48);
            this.lb_productName.TabIndex = 14;
            this.lb_productName.Text = "Product Name";
            this.lb_productName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_productName
            // 
            this.txt_productName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_productName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_productName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_productName.BorderThickness = 3;
            this.txt_productName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_productName, BunifuAnimatorNS.DecorationType.None);
            this.txt_productName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.Color.Silver;
            this.txt_productName.isPassword = false;
            this.txt_productName.Location = new System.Drawing.Point(172, 354);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_productName.MaxLength = 32767;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(355, 48);
            this.txt_productName.TabIndex = 7;
            this.txt_productName.Tag = "";
            this.txt_productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_PONumber
            // 
            this.side_menu_transition.SetDecoration(this.lb_PONumber, BunifuAnimatorNS.DecorationType.None);
            this.lb_PONumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PONumber.ForeColor = System.Drawing.Color.Silver;
            this.lb_PONumber.Location = new System.Drawing.Point(6, 178);
            this.lb_PONumber.Name = "lb_PONumber";
            this.lb_PONumber.Size = new System.Drawing.Size(158, 48);
            this.lb_PONumber.TabIndex = 12;
            this.lb_PONumber.Text = "PO Number";
            this.lb_PONumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_PONumber
            // 
            this.txt_PONumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_PONumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PONumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_PONumber.BorderThickness = 3;
            this.txt_PONumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_PONumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_PONumber, BunifuAnimatorNS.DecorationType.None);
            this.txt_PONumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PONumber.ForeColor = System.Drawing.Color.Silver;
            this.txt_PONumber.isPassword = false;
            this.txt_PONumber.Location = new System.Drawing.Point(172, 180);
            this.txt_PONumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PONumber.MaxLength = 32767;
            this.txt_PONumber.Name = "txt_PONumber";
            this.txt_PONumber.Size = new System.Drawing.Size(355, 48);
            this.txt_PONumber.TabIndex = 4;
            this.txt_PONumber.Tag = "";
            this.txt_PONumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_deliveryDate
            // 
            this.side_menu_transition.SetDecoration(this.lb_deliveryDate, BunifuAnimatorNS.DecorationType.None);
            this.lb_deliveryDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deliveryDate.ForeColor = System.Drawing.Color.Silver;
            this.lb_deliveryDate.Location = new System.Drawing.Point(6, 240);
            this.lb_deliveryDate.Name = "lb_deliveryDate";
            this.lb_deliveryDate.Size = new System.Drawing.Size(158, 48);
            this.lb_deliveryDate.TabIndex = 10;
            this.lb_deliveryDate.Text = "Delivery Date";
            this.lb_deliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deliveryDatepicker
            // 
            this.deliveryDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.deliveryDatepicker.BorderRadius = 0;
            this.side_menu_transition.SetDecoration(this.deliveryDatepicker, BunifuAnimatorNS.DecorationType.None);
            this.deliveryDatepicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDatepicker.ForeColor = System.Drawing.Color.White;
            this.deliveryDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliveryDatepicker.FormatCustom = "dd/MM/yyyy";
            this.deliveryDatepicker.Location = new System.Drawing.Point(172, 238);
            this.deliveryDatepicker.Margin = new System.Windows.Forms.Padding(5);
            this.deliveryDatepicker.Name = "deliveryDatepicker";
            this.deliveryDatepicker.Size = new System.Drawing.Size(355, 48);
            this.deliveryDatepicker.TabIndex = 5;
            this.deliveryDatepicker.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // lb_PRFNumber
            // 
            this.side_menu_transition.SetDecoration(this.lb_PRFNumber, BunifuAnimatorNS.DecorationType.None);
            this.lb_PRFNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PRFNumber.ForeColor = System.Drawing.Color.Silver;
            this.lb_PRFNumber.Location = new System.Drawing.Point(6, 123);
            this.lb_PRFNumber.Name = "lb_PRFNumber";
            this.lb_PRFNumber.Size = new System.Drawing.Size(158, 48);
            this.lb_PRFNumber.TabIndex = 8;
            this.lb_PRFNumber.Text = "PRF Number";
            this.lb_PRFNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_PRFNumber
            // 
            this.txt_PRFNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_PRFNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PRFNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_PRFNumber.BorderThickness = 3;
            this.txt_PRFNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_PRFNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_PRFNumber, BunifuAnimatorNS.DecorationType.None);
            this.txt_PRFNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PRFNumber.ForeColor = System.Drawing.Color.Silver;
            this.txt_PRFNumber.isPassword = false;
            this.txt_PRFNumber.Location = new System.Drawing.Point(172, 125);
            this.txt_PRFNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PRFNumber.MaxLength = 32767;
            this.txt_PRFNumber.Name = "txt_PRFNumber";
            this.txt_PRFNumber.Size = new System.Drawing.Size(355, 48);
            this.txt_PRFNumber.TabIndex = 3;
            this.txt_PRFNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_vendorName
            // 
            this.txt_vendorName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_vendorName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_vendorName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_vendorName.BorderThickness = 3;
            this.txt_vendorName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_vendorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_vendorName, BunifuAnimatorNS.DecorationType.None);
            this.txt_vendorName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendorName.ForeColor = System.Drawing.Color.Silver;
            this.txt_vendorName.isPassword = false;
            this.txt_vendorName.Location = new System.Drawing.Point(172, 68);
            this.txt_vendorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vendorName.MaxLength = 32767;
            this.txt_vendorName.Name = "txt_vendorName";
            this.txt_vendorName.Size = new System.Drawing.Size(355, 48);
            this.txt_vendorName.TabIndex = 2;
            this.txt_vendorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_vendorId
            // 
            this.txt_vendorId.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_vendorId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_vendorId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_vendorId.BorderThickness = 3;
            this.txt_vendorId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_vendorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.txt_vendorId, BunifuAnimatorNS.DecorationType.None);
            this.txt_vendorId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendorId.ForeColor = System.Drawing.Color.Silver;
            this.txt_vendorId.isPassword = false;
            this.txt_vendorId.Location = new System.Drawing.Point(172, 8);
            this.txt_vendorId.Margin = new System.Windows.Forms.Padding(5);
            this.txt_vendorId.MaxLength = 32767;
            this.txt_vendorId.Name = "txt_vendorId";
            this.txt_vendorId.Size = new System.Drawing.Size(355, 50);
            this.txt_vendorId.TabIndex = 1;
            this.txt_vendorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.label1);
            this.search_panel.Controls.Add(this.bunifuMetroTextbox1);
            this.side_menu_transition.SetDecoration(this.search_panel, BunifuAnimatorNS.DecorationType.None);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_panel.Location = new System.Drawing.Point(207, 47);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1193, 54);
            this.search_panel.TabIndex = 2;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.side_menu_transition.SetDecoration(this.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(174, 5);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuMetroTextbox1.MaxLength = 32767;
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(355, 41);
            this.bunifuMetroTextbox1.TabIndex = 2;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.side_menu_transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "Search :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_maximize
            // 
            this.side_menu_transition.SetDecoration(this.btn_maximize, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.ImageActive = null;
            this.btn_maximize.Location = new System.Drawing.Point(1324, 0);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(38, 47);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximize.TabIndex = 2;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Zoom = 10;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.side_menu_transition.SetDecoration(this.btn_minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(1286, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(38, 47);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Zoom = 10;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.side_menu);
            this.Controls.Add(this.header);
            this.side_menu_transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Easy Manage";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.side_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_main;
        private System.Windows.Forms.Panel side_menu;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_menu;
        private Bunifu.Framework.UI.BunifuFlatButton menu_grid;
        private Bunifu.Framework.UI.BunifuFlatButton menu_add;
        private Bunifu.Framework.UI.BunifuFlatButton menu_dashboard;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_title;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDrag_header;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition side_menu_transition;
        private Bunifu.Framework.UI.BunifuFlatButton menu_setting;
        private System.Windows.Forms.Label lb_vendId;
        private System.Windows.Forms.Label lb_vendName;
        private System.Windows.Forms.Panel main_panel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_vendorId;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_vendorName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_PRFNumber;
        private System.Windows.Forms.Label lb_PRFNumber;
        private Bunifu.Framework.UI.BunifuDatepicker deliveryDatepicker;
        private System.Windows.Forms.Label lb_deliveryDate;
        private Bunifu.Framework.UI.BunifuDropdown warrentyDropdown;
        private System.Windows.Forms.Label lb_warrenty;
        private System.Windows.Forms.Label lb_IMEI;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_IMEI;
        private System.Windows.Forms.Label lb_serialNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_serialNumber;
        private System.Windows.Forms.Label lb_model;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_model;
        private System.Windows.Forms.Label lb_productName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_productName;
        private System.Windows.Forms.Label lb_PONumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_PONumber;
        private Bunifu.Framework.UI.BunifuDropdown productTypeDropdown;
        private System.Windows.Forms.Label lb_productType;
        private Bunifu.Framework.UI.BunifuDropdown locationDropdown;
        private System.Windows.Forms.Label lb_department;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_note;
        private System.Windows.Forms.Label lb_note;
        private Bunifu.Framework.UI.BunifuDropdown statusDropdown;
        private System.Windows.Forms.Label lb_status;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_user;
        private System.Windows.Forms.Label lb_user;
        private Bunifu.Framework.UI.BunifuDropdown departmentDropdown;
        private System.Windows.Forms.Label lb_location;
        private Bunifu.Framework.UI.BunifuDatepicker warrentyEndDatepicker;
        private System.Windows.Forms.Label lb_warrentyEnd;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Save;
        private Bunifu.Framework.UI.BunifuDropdown companyDropdown;
        private System.Windows.Forms.Label lb_company;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_maximize;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
    }
}

