namespace Pharmacy_Management_System
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.drag_login = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipse_login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pan_top = new System.Windows.Forms.Panel();
            this.lbl_beta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_settings = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pan_left = new System.Windows.Forms.Panel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_time = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_sales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_suppliers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_storage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_dash = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_profile = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipse_exit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pan_mid = new Bunifu.Framework.UI.BunifuCards();
            this.elipse_profile = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.drag_top = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.drag_left = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.drag_mid = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipse_settings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.elipse_beta = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_empl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pan_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.pan_left.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // drag_login
            // 
            this.drag_login.Fixed = true;
            this.drag_login.Horizontal = true;
            this.drag_login.TargetControl = this;
            this.drag_login.Vertical = true;
            // 
            // elipse_login
            // 
            this.elipse_login.ElipseRadius = 10;
            this.elipse_login.TargetControl = this;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.lbl_beta);
            this.pan_top.Controls.Add(this.btn_settings);
            this.pan_top.Controls.Add(this.lbl_logo);
            this.pan_top.Controls.Add(this.btn_exit);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1200, 80);
            this.pan_top.TabIndex = 1;
            // 
            // lbl_beta
            // 
            this.lbl_beta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.lbl_beta.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_beta.ForeColor = System.Drawing.Color.White;
            this.lbl_beta.Location = new System.Drawing.Point(155, 31);
            this.lbl_beta.Name = "lbl_beta";
            this.lbl_beta.Size = new System.Drawing.Size(54, 26);
            this.lbl_beta.TabIndex = 7;
            this.lbl_beta.Text = "BETA";
            this.lbl_beta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.BackColor = System.Drawing.Color.White;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_settings.ImageActive")));
            this.btn_settings.Location = new System.Drawing.Point(1072, 19);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(40, 40);
            this.btn_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_settings.TabIndex = 5;
            this.btn_settings.TabStop = false;
            this.btn_settings.Zoom = 10;
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Cairo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(22, 14);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(140, 50);
            this.lbl_logo.TabIndex = 4;
            this.lbl_logo.Text = "Pharmacy";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageActive")));
            this.btn_exit.Location = new System.Drawing.Point(1123, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pan_left
            // 
            this.pan_left.Controls.Add(this.btn_empl);
            this.pan_left.Controls.Add(this.bunifuCards2);
            this.pan_left.Controls.Add(this.btn_sales);
            this.pan_left.Controls.Add(this.btn_suppliers);
            this.pan_left.Controls.Add(this.btn_storage);
            this.pan_left.Controls.Add(this.btn_dash);
            this.pan_left.Controls.Add(this.bunifuCustomLabel1);
            this.pan_left.Controls.Add(this.bunifuCustomLabel2);
            this.pan_left.Controls.Add(this.btn_profile);
            this.pan_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_left.Location = new System.Drawing.Point(0, 80);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(245, 670);
            this.pan_left.TabIndex = 2;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.bunifuCards2.BorderRadius = 10;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.bunifuCards2.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards2.Controls.Add(this.lbl_time);
            this.bunifuCards2.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 504);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(212, 151);
            this.bunifuCards2.TabIndex = 11;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = global::Pharmacy_Management_System.Properties.Resources.clock_96px;
            this.bunifuImageButton2.ImageActive = global::Pharmacy_Management_System.Properties.Resources.clock_96px;
            this.bunifuImageButton2.Location = new System.Drawing.Point(15, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 9;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(14, 72);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(183, 69);
            this.lbl_time.TabIndex = 8;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(177, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btn_sales
            // 
            this.btn_sales.Active = false;
            this.btn_sales.Activecolor = System.Drawing.Color.Silver;
            this.btn_sales.BackColor = System.Drawing.Color.Transparent;
            this.btn_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sales.BorderRadius = 7;
            this.btn_sales.ButtonText = "   Sales";
            this.btn_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sales.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sales.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sales.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sales.Iconimage")));
            this.btn_sales.Iconimage_right = null;
            this.btn_sales.Iconimage_right_Selected = null;
            this.btn_sales.Iconimage_Selected = null;
            this.btn_sales.IconMarginLeft = 20;
            this.btn_sales.IconMarginRight = 0;
            this.btn_sales.IconRightVisible = true;
            this.btn_sales.IconRightZoom = 0D;
            this.btn_sales.IconVisible = true;
            this.btn_sales.IconZoom = 70D;
            this.btn_sales.IsTab = true;
            this.btn_sales.Location = new System.Drawing.Point(0, 343);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_sales.OnHovercolor = System.Drawing.Color.White;
            this.btn_sales.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_sales.selected = false;
            this.btn_sales.Size = new System.Drawing.Size(245, 40);
            this.btn_sales.TabIndex = 10;
            this.btn_sales.Text = "   Sales";
            this.btn_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.Textcolor = System.Drawing.Color.DimGray;
            this.btn_sales.TextFont = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.Active = false;
            this.btn_suppliers.Activecolor = System.Drawing.Color.Silver;
            this.btn_suppliers.BackColor = System.Drawing.Color.Transparent;
            this.btn_suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_suppliers.BorderRadius = 7;
            this.btn_suppliers.ButtonText = "   Suppliers";
            this.btn_suppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppliers.DisabledColor = System.Drawing.Color.Gray;
            this.btn_suppliers.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_suppliers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_suppliers.Iconimage")));
            this.btn_suppliers.Iconimage_right = null;
            this.btn_suppliers.Iconimage_right_Selected = null;
            this.btn_suppliers.Iconimage_Selected = null;
            this.btn_suppliers.IconMarginLeft = 20;
            this.btn_suppliers.IconMarginRight = 0;
            this.btn_suppliers.IconRightVisible = true;
            this.btn_suppliers.IconRightZoom = 0D;
            this.btn_suppliers.IconVisible = true;
            this.btn_suppliers.IconZoom = 70D;
            this.btn_suppliers.IsTab = true;
            this.btn_suppliers.Location = new System.Drawing.Point(0, 296);
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_suppliers.OnHovercolor = System.Drawing.Color.White;
            this.btn_suppliers.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_suppliers.selected = false;
            this.btn_suppliers.Size = new System.Drawing.Size(245, 40);
            this.btn_suppliers.TabIndex = 9;
            this.btn_suppliers.Text = "   Suppliers";
            this.btn_suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppliers.Textcolor = System.Drawing.Color.DimGray;
            this.btn_suppliers.TextFont = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers.Click += new System.EventHandler(this.btn_suppliers_Click);
            // 
            // btn_storage
            // 
            this.btn_storage.Active = false;
            this.btn_storage.Activecolor = System.Drawing.Color.Silver;
            this.btn_storage.BackColor = System.Drawing.Color.Transparent;
            this.btn_storage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_storage.BorderRadius = 7;
            this.btn_storage.ButtonText = "   Storage";
            this.btn_storage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_storage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_storage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_storage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_storage.Iconimage")));
            this.btn_storage.Iconimage_right = null;
            this.btn_storage.Iconimage_right_Selected = null;
            this.btn_storage.Iconimage_Selected = null;
            this.btn_storage.IconMarginLeft = 20;
            this.btn_storage.IconMarginRight = 0;
            this.btn_storage.IconRightVisible = true;
            this.btn_storage.IconRightZoom = 0D;
            this.btn_storage.IconVisible = true;
            this.btn_storage.IconZoom = 70D;
            this.btn_storage.IsTab = true;
            this.btn_storage.Location = new System.Drawing.Point(0, 249);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_storage.OnHovercolor = System.Drawing.Color.White;
            this.btn_storage.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_storage.selected = false;
            this.btn_storage.Size = new System.Drawing.Size(245, 40);
            this.btn_storage.TabIndex = 8;
            this.btn_storage.Text = "   Storage";
            this.btn_storage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_storage.Textcolor = System.Drawing.Color.DimGray;
            this.btn_storage.TextFont = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_storage.Click += new System.EventHandler(this.btn_storage_Click);
            // 
            // btn_dash
            // 
            this.btn_dash.Active = false;
            this.btn_dash.Activecolor = System.Drawing.Color.Silver;
            this.btn_dash.BackColor = System.Drawing.Color.Transparent;
            this.btn_dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dash.BorderRadius = 7;
            this.btn_dash.ButtonText = "   Dashboard";
            this.btn_dash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dash.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dash.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dash.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dash.Iconimage")));
            this.btn_dash.Iconimage_right = null;
            this.btn_dash.Iconimage_right_Selected = null;
            this.btn_dash.Iconimage_Selected = null;
            this.btn_dash.IconMarginLeft = 20;
            this.btn_dash.IconMarginRight = 0;
            this.btn_dash.IconRightVisible = true;
            this.btn_dash.IconRightZoom = 0D;
            this.btn_dash.IconVisible = true;
            this.btn_dash.IconZoom = 70D;
            this.btn_dash.IsTab = true;
            this.btn_dash.Location = new System.Drawing.Point(0, 202);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_dash.OnHovercolor = System.Drawing.Color.White;
            this.btn_dash.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_dash.selected = false;
            this.btn_dash.Size = new System.Drawing.Size(245, 40);
            this.btn_dash.TabIndex = 7;
            this.btn_dash.Text = "   Dashboard";
            this.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dash.Textcolor = System.Drawing.Color.DimGray;
            this.btn_dash.TextFont = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(49, 146);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 26);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Pharmacy Manger";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(67, 120);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 33);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Ahmed R";
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.White;
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_profile.ImageActive")));
            this.btn_profile.Location = new System.Drawing.Point(72, 28);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(80, 85);
            this.btn_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_profile.TabIndex = 0;
            this.btn_profile.TabStop = false;
            this.btn_profile.Zoom = 0;
            // 
            // elipse_exit
            // 
            this.elipse_exit.ElipseRadius = 120;
            this.elipse_exit.TargetControl = this.btn_exit;
            // 
            // pan_mid
            // 
            this.pan_mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.pan_mid.BorderRadius = 30;
            this.pan_mid.BottomSahddow = false;
            this.pan_mid.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.pan_mid.LeftSahddow = false;
            this.pan_mid.Location = new System.Drawing.Point(271, 99);
            this.pan_mid.Name = "pan_mid";
            this.pan_mid.RightSahddow = false;
            this.pan_mid.ShadowDepth = 50;
            this.pan_mid.Size = new System.Drawing.Size(903, 636);
            this.pan_mid.TabIndex = 4;
            // 
            // elipse_profile
            // 
            this.elipse_profile.ElipseRadius = 120;
            this.elipse_profile.TargetControl = this.btn_profile;
            // 
            // drag_top
            // 
            this.drag_top.Fixed = true;
            this.drag_top.Horizontal = true;
            this.drag_top.TargetControl = this.pan_top;
            this.drag_top.Vertical = true;
            // 
            // drag_left
            // 
            this.drag_left.Fixed = true;
            this.drag_left.Horizontal = true;
            this.drag_left.TargetControl = this.pan_left;
            this.drag_left.Vertical = true;
            // 
            // drag_mid
            // 
            this.drag_mid.Fixed = true;
            this.drag_mid.Horizontal = true;
            this.drag_mid.TargetControl = this.pan_mid;
            this.drag_mid.Vertical = true;
            // 
            // elipse_settings
            // 
            this.elipse_settings.ElipseRadius = 120;
            this.elipse_settings.TargetControl = this.btn_settings;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // elipse_beta
            // 
            this.elipse_beta.ElipseRadius = 10;
            this.elipse_beta.TargetControl = this.lbl_beta;
            // 
            // btn_empl
            // 
            this.btn_empl.Active = false;
            this.btn_empl.Activecolor = System.Drawing.Color.Silver;
            this.btn_empl.BackColor = System.Drawing.Color.Transparent;
            this.btn_empl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_empl.BorderRadius = 7;
            this.btn_empl.ButtonText = "   Employees";
            this.btn_empl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empl.DisabledColor = System.Drawing.Color.Gray;
            this.btn_empl.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_empl.Iconimage = global::Pharmacy_Management_System.Properties.Resources.management_96px;
            this.btn_empl.Iconimage_right = null;
            this.btn_empl.Iconimage_right_Selected = null;
            this.btn_empl.Iconimage_Selected = null;
            this.btn_empl.IconMarginLeft = 20;
            this.btn_empl.IconMarginRight = 0;
            this.btn_empl.IconRightVisible = true;
            this.btn_empl.IconRightZoom = 0D;
            this.btn_empl.IconVisible = true;
            this.btn_empl.IconZoom = 70D;
            this.btn_empl.IsTab = true;
            this.btn_empl.Location = new System.Drawing.Point(0, 390);
            this.btn_empl.Name = "btn_empl";
            this.btn_empl.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_empl.OnHovercolor = System.Drawing.Color.White;
            this.btn_empl.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_empl.selected = false;
            this.btn_empl.Size = new System.Drawing.Size(245, 40);
            this.btn_empl.TabIndex = 12;
            this.btn_empl.Text = "   Employees";
            this.btn_empl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empl.Textcolor = System.Drawing.Color.DimGray;
            this.btn_empl.TextFont = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empl.Click += new System.EventHandler(this.btn_empl_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pan_mid);
            this.Controls.Add(this.pan_left);
            this.Controls.Add(this.pan_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.main_Load);
            this.pan_top.ResumeLayout(false);
            this.pan_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.pan_left.ResumeLayout(false);
            this.pan_left.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl drag_login;
        private Bunifu.Framework.UI.BunifuElipse elipse_login;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Panel pan_left;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_logo;
        private Bunifu.Framework.UI.BunifuImageButton btn_profile;
        private Bunifu.Framework.UI.BunifuElipse elipse_exit;
        private Bunifu.Framework.UI.BunifuCards pan_mid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dash;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sales;
        private Bunifu.Framework.UI.BunifuFlatButton btn_suppliers;
        private Bunifu.Framework.UI.BunifuFlatButton btn_storage;
        private Bunifu.Framework.UI.BunifuElipse elipse_profile;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_time;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl drag_top;
        private Bunifu.Framework.UI.BunifuDragControl drag_left;
        private Bunifu.Framework.UI.BunifuDragControl drag_mid;
        private Bunifu.Framework.UI.BunifuImageButton btn_settings;
        private Bunifu.Framework.UI.BunifuElipse elipse_settings;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_beta;
        private Bunifu.Framework.UI.BunifuElipse elipse_beta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_empl;
    }
}