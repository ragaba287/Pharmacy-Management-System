namespace Pharmacy_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.elipse_login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.elipse_user = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_wlcome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_forgot = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.elipse_pass = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.drag_login = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_login
            // 
            this.elipse_login.ElipseRadius = 10;
            this.elipse_login.TargetControl = this;
            // 
            // btn_login
            // 
            this.btn_login.Active = false;
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.BorderRadius = 7;
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Font = new System.Drawing.Font("Cairo", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = null;
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(41, 385);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.DimGray;
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(270, 50);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_username.BorderThickness = 1;
            this.txt_username.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.isPassword = false;
            this.txt_username.Location = new System.Drawing.Point(41, 196);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(270, 50);
            this.txt_username.TabIndex = 5;
            this.txt_username.Text = "Username";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // elipse_user
            // 
            this.elipse_user.ElipseRadius = 5;
            this.elipse_user.TargetControl = this.txt_username;
            // 
            // lbl_wlcome
            // 
            this.lbl_wlcome.AutoSize = true;
            this.lbl_wlcome.Font = new System.Drawing.Font("Cairo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wlcome.Location = new System.Drawing.Point(34, 90);
            this.lbl_wlcome.Name = "lbl_wlcome";
            this.lbl_wlcome.Size = new System.Drawing.Size(200, 50);
            this.lbl_wlcome.TabIndex = 7;
            this.lbl_wlcome.Text = "Welcome Back!";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 128);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(160, 30);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Login to your account";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_password.BorderThickness = 1;
            this.txt_password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Cairo", 8F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.isPassword = true;
            this.txt_password.Location = new System.Drawing.Point(41, 262);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(270, 50);
            this.txt_password.TabIndex = 10;
            this.txt_password.Text = "Username";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgot.Font = new System.Drawing.Font("Cairo Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgot.Location = new System.Drawing.Point(180, 317);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(131, 26);
            this.lbl_forgot.TabIndex = 11;
            this.lbl_forgot.Text = "Forgot password?";
            this.lbl_forgot.Click += new System.EventHandler(this.lbl_forgot_Click);
            // 
            // elipse_pass
            // 
            this.elipse_pass.ElipseRadius = 10;
            this.elipse_pass.TargetControl = this.txt_password;
            // 
            // drag_login
            // 
            this.drag_login.Fixed = true;
            this.drag_login.Horizontal = true;
            this.drag_login.TargetControl = this;
            this.drag_login.Vertical = true;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::Pharmacy_Management_System.Properties.Resources.delete__1_;
            this.btn_exit.ImageActive = global::Pharmacy_Management_System.Properties.Resources.delete__1_;
            this.btn_exit.Location = new System.Drawing.Point(328, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(20, 20);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 9;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 15;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 550);
            this.Controls.Add(this.lbl_forgot);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lbl_wlcome);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse_login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_username;
        private Bunifu.Framework.UI.BunifuElipse elipse_user;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_wlcome;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_forgot;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_password;
        private Bunifu.Framework.UI.BunifuElipse elipse_pass;
        private Bunifu.Framework.UI.BunifuDragControl drag_login;

    }
}

