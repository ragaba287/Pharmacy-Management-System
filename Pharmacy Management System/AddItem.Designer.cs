namespace Pharmacy_Management_System
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.elipse_exit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipse_login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drag_stor = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txt_1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_6 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_7 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_exit
            // 
            this.elipse_exit.ElipseRadius = 120;
            this.elipse_exit.TargetControl = this.btn_exit;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::Pharmacy_Management_System.Properties.Resources.multiply_32px;
            this.btn_exit.ImageActive = global::Pharmacy_Management_System.Properties.Resources.multiply_32px;
            this.btn_exit.Location = new System.Drawing.Point(628, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // elipse_login
            // 
            this.elipse_login.ElipseRadius = 10;
            this.elipse_login.TargetControl = this;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(259, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(135, 37);
            this.lbl_title.TabIndex = 21;
            this.lbl_title.Text = "Add ItemItem";
            // 
            // drag_stor
            // 
            this.drag_stor.Fixed = true;
            this.drag_stor.Horizontal = true;
            this.drag_stor.TargetControl = this;
            this.drag_stor.Vertical = true;
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_1.BorderThickness = 1;
            this.txt_1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_1.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_1.isPassword = false;
            this.txt_1.Location = new System.Drawing.Point(45, 85);
            this.txt_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_1.MaxLength = 32767;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(270, 50);
            this.txt_1.TabIndex = 22;
            this.txt_1.Text = "Name";
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_4
            // 
            this.txt_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_4.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_4.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_4.BorderThickness = 1;
            this.txt_4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_4.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_4.isPassword = false;
            this.txt_4.Location = new System.Drawing.Point(45, 310);
            this.txt_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_4.MaxLength = 32767;
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(270, 50);
            this.txt_4.TabIndex = 23;
            this.txt_4.Text = "Quality";
            this.txt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_3
            // 
            this.txt_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_3.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_3.BorderThickness = 1;
            this.txt_3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_3.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_3.isPassword = false;
            this.txt_3.Location = new System.Drawing.Point(45, 235);
            this.txt_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_3.MaxLength = 32767;
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(270, 50);
            this.txt_3.TabIndex = 24;
            this.txt_3.Text = "Phone";
            this.txt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_2
            // 
            this.txt_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_2.BorderThickness = 1;
            this.txt_2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_2.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_2.isPassword = false;
            this.txt_2.Location = new System.Drawing.Point(45, 160);
            this.txt_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_2.MaxLength = 32767;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(270, 50);
            this.txt_2.TabIndex = 25;
            this.txt_2.Text = "Address";
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_5
            // 
            this.txt_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_5.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_5.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_5.BorderThickness = 1;
            this.txt_5.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_5.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_5.isPassword = false;
            this.txt_5.Location = new System.Drawing.Point(45, 385);
            this.txt_5.Margin = new System.Windows.Forms.Padding(4);
            this.txt_5.MaxLength = 32767;
            this.txt_5.Name = "txt_5";
            this.txt_5.Size = new System.Drawing.Size(270, 50);
            this.txt_5.TabIndex = 26;
            this.txt_5.Text = "Capabilities";
            this.txt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_add
            // 
            this.btn_add.Active = false;
            this.btn_add.Activecolor = System.Drawing.Color.Silver;
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 7;
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = null;
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 20;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 70D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(509, 452);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(90)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(129, 40);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.txt_1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.txt_2;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.txt_3;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.txt_4;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this.txt_5;
            // 
            // txt_6
            // 
            this.txt_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_6.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_6.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_6.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_6.BorderThickness = 1;
            this.txt_6.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_6.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_6.isPassword = false;
            this.txt_6.Location = new System.Drawing.Point(368, 85);
            this.txt_6.Margin = new System.Windows.Forms.Padding(4);
            this.txt_6.MaxLength = 32767;
            this.txt_6.Name = "txt_6";
            this.txt_6.Size = new System.Drawing.Size(270, 50);
            this.txt_6.TabIndex = 28;
            this.txt_6.Text = "Delivery Speed";
            this.txt_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_6.Visible = false;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 10;
            this.bunifuElipse6.TargetControl = this.txt_6;
            // 
            // txt_7
            // 
            this.txt_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_7.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_7.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_7.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txt_7.BorderThickness = 1;
            this.txt_7.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_7.Font = new System.Drawing.Font("Cairo", 12F);
            this.txt_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_7.isPassword = false;
            this.txt_7.Location = new System.Drawing.Point(368, 160);
            this.txt_7.Margin = new System.Windows.Forms.Padding(4);
            this.txt_7.MaxLength = 32767;
            this.txt_7.Name = "txt_7";
            this.txt_7.Size = new System.Drawing.Size(270, 275);
            this.txt_7.TabIndex = 29;
            this.txt_7.Text = "Notes";
            this.txt_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_7.Visible = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 515);
            this.Controls.Add(this.txt_7);
            this.Controls.Add(this.txt_6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_5);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse_exit;
        private Bunifu.Framework.UI.BunifuElipse elipse_login;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_title;
        private Bunifu.Framework.UI.BunifuDragControl drag_stor;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_7;
    }
}