
namespace connection
{
    partial class Form1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.Maximize = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_signout = new FontAwesome.Sharp.IconButton();
            this.btn_Sitting = new FontAwesome.Sharp.IconButton();
            this.btn_Local = new FontAwesome.Sharp.IconButton();
            this.btn_Telegram = new FontAwesome.Sharp.IconButton();
            this.btn_Phone = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.btn_Menus = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 45);
            this.panel1.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimize.IconColor = System.Drawing.Color.DarkCyan;
            this.Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimize.IconSize = 40;
            this.Minimize.Location = new System.Drawing.Point(750, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(45, 40);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseVisualStyleBackColor = true;
            // 
            // Maximize
            // 
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.Maximize.IconColor = System.Drawing.Color.DarkCyan;
            this.Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Maximize.IconSize = 40;
            this.Maximize.Location = new System.Drawing.Point(801, 2);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(45, 40);
            this.Maximize.TabIndex = 2;
            this.Maximize.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.close.IconColor = System.Drawing.Color.DarkCyan;
            this.close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close.IconSize = 40;
            this.close.Location = new System.Drawing.Point(852, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 40);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.btn_signout);
            this.panel2.Controls.Add(this.btn_Sitting);
            this.panel2.Controls.Add(this.btn_Local);
            this.panel2.Controls.Add(this.btn_Telegram);
            this.panel2.Controls.Add(this.btn_Phone);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Controls.Add(this.btn_Menus);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 455);
            this.panel2.TabIndex = 1;
            // 
            // btn_signout
            // 
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.ForeColor = System.Drawing.Color.DimGray;
            this.btn_signout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_signout.IconColor = System.Drawing.Color.DimGray;
            this.btn_signout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_signout.IconSize = 40;
            this.btn_signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signout.Location = new System.Drawing.Point(32, 372);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(165, 40);
            this.btn_signout.TabIndex = 7;
            this.btn_signout.Text = "Leave";
            this.btn_signout.UseVisualStyleBackColor = true;
            // 
            // btn_Sitting
            // 
            this.btn_Sitting.FlatAppearance.BorderSize = 0;
            this.btn_Sitting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sitting.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sitting.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Sitting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btn_Sitting.IconColor = System.Drawing.Color.DimGray;
            this.btn_Sitting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sitting.IconSize = 40;
            this.btn_Sitting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sitting.Location = new System.Drawing.Point(32, 326);
            this.btn_Sitting.Name = "btn_Sitting";
            this.btn_Sitting.Size = new System.Drawing.Size(165, 40);
            this.btn_Sitting.TabIndex = 6;
            this.btn_Sitting.Text = "Sitting";
            this.btn_Sitting.UseVisualStyleBackColor = true;
            // 
            // btn_Local
            // 
            this.btn_Local.FlatAppearance.BorderSize = 0;
            this.btn_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Local.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Local.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Local.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btn_Local.IconColor = System.Drawing.Color.DimGray;
            this.btn_Local.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Local.IconSize = 40;
            this.btn_Local.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Local.Location = new System.Drawing.Point(32, 280);
            this.btn_Local.Name = "btn_Local";
            this.btn_Local.Size = new System.Drawing.Size(165, 40);
            this.btn_Local.TabIndex = 5;
            this.btn_Local.Text = "Location";
            this.btn_Local.UseVisualStyleBackColor = true;
            // 
            // btn_Telegram
            // 
            this.btn_Telegram.FlatAppearance.BorderSize = 0;
            this.btn_Telegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Telegram.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Telegram.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Telegram.IconChar = FontAwesome.Sharp.IconChar.Telegram;
            this.btn_Telegram.IconColor = System.Drawing.Color.DimGray;
            this.btn_Telegram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Telegram.IconSize = 40;
            this.btn_Telegram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Telegram.Location = new System.Drawing.Point(32, 234);
            this.btn_Telegram.Name = "btn_Telegram";
            this.btn_Telegram.Size = new System.Drawing.Size(165, 40);
            this.btn_Telegram.TabIndex = 4;
            this.btn_Telegram.Text = "Telegram";
            this.btn_Telegram.UseVisualStyleBackColor = true;
            // 
            // btn_Phone
            // 
            this.btn_Phone.FlatAppearance.BorderSize = 0;
            this.btn_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Phone.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phone.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Phone.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt;
            this.btn_Phone.IconColor = System.Drawing.Color.DimGray;
            this.btn_Phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Phone.IconSize = 40;
            this.btn_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Phone.Location = new System.Drawing.Point(32, 188);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(165, 40);
            this.btn_Phone.TabIndex = 3;
            this.btn_Phone.Text = "Contact";
            this.btn_Phone.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.DimGray;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 40;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(32, 142);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(165, 40);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // btn_Menus
            // 
            this.btn_Menus.FlatAppearance.BorderSize = 0;
            this.btn_Menus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menus.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_Menus.IconColor = System.Drawing.Color.DimGray;
            this.btn_Menus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menus.IconSize = 40;
            this.btn_Menus.Location = new System.Drawing.Point(249, 6);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.Size = new System.Drawing.Size(45, 40);
            this.btn_Menus.TabIndex = 1;
            this.btn_Menus.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 107;
            this.iconPictureBox1.Location = new System.Drawing.Point(90, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(107, 108);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 455);
            this.panel3.TabIndex = 2;
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Khmer OS Siemreap", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(161, 82);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(197, 86);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.Text = "Connection";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "frm_dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_signout;
        private FontAwesome.Sharp.IconButton btn_Sitting;
        private FontAwesome.Sharp.IconButton btn_Local;
        private FontAwesome.Sharp.IconButton btn_Telegram;
        private FontAwesome.Sharp.IconButton btn_Phone;
        private FontAwesome.Sharp.IconButton btn_Home;
        private FontAwesome.Sharp.IconButton btn_Menus;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Minimize;
        private FontAwesome.Sharp.IconButton Maximize;
        private FontAwesome.Sharp.IconButton close;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void initializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.Maximize = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_signout = new FontAwesome.Sharp.IconButton();
            this.btn_Sitting = new FontAwesome.Sharp.IconButton();
            this.btn_Local = new FontAwesome.Sharp.IconButton();
            this.btn_Telegram = new FontAwesome.Sharp.IconButton();
            this.btn_Phone = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.btn_Menus = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 45);
            this.panel1.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimize.IconColor = System.Drawing.Color.DarkCyan;
            this.Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimize.IconSize = 40;
            this.Minimize.Location = new System.Drawing.Point(750, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(45, 40);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseVisualStyleBackColor = true;
            // 
            // Maximize
            // 
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.Maximize.IconColor = System.Drawing.Color.DarkCyan;
            this.Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Maximize.IconSize = 40;
            this.Maximize.Location = new System.Drawing.Point(801, 2);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(45, 40);
            this.Maximize.TabIndex = 2;
            this.Maximize.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.close.IconColor = System.Drawing.Color.DarkCyan;
            this.close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close.IconSize = 40;
            this.close.Location = new System.Drawing.Point(852, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 40);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.btn_signout);
            this.panel2.Controls.Add(this.btn_Sitting);
            this.panel2.Controls.Add(this.btn_Local);
            this.panel2.Controls.Add(this.btn_Telegram);
            this.panel2.Controls.Add(this.btn_Phone);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Controls.Add(this.btn_Menus);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 455);
            this.panel2.TabIndex = 1;
            // 
            // btn_signout
            // 
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.ForeColor = System.Drawing.Color.DimGray;
            this.btn_signout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_signout.IconColor = System.Drawing.Color.DimGray;
            this.btn_signout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_signout.IconSize = 40;
            this.btn_signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signout.Location = new System.Drawing.Point(32, 372);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(165, 40);
            this.btn_signout.TabIndex = 7;
            this.btn_signout.Text = "Leave";
            this.btn_signout.UseVisualStyleBackColor = true;
            // 
            // btn_Sitting
            // 
            this.btn_Sitting.FlatAppearance.BorderSize = 0;
            this.btn_Sitting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sitting.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sitting.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Sitting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btn_Sitting.IconColor = System.Drawing.Color.DimGray;
            this.btn_Sitting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sitting.IconSize = 40;
            this.btn_Sitting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sitting.Location = new System.Drawing.Point(32, 326);
            this.btn_Sitting.Name = "btn_Sitting";
            this.btn_Sitting.Size = new System.Drawing.Size(165, 40);
            this.btn_Sitting.TabIndex = 6;
            this.btn_Sitting.Text = "Sitting";
            this.btn_Sitting.UseVisualStyleBackColor = true;
            // 
            // btn_Local
            // 
            this.btn_Local.FlatAppearance.BorderSize = 0;
            this.btn_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Local.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Local.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Local.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btn_Local.IconColor = System.Drawing.Color.DimGray;
            this.btn_Local.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Local.IconSize = 40;
            this.btn_Local.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Local.Location = new System.Drawing.Point(32, 280);
            this.btn_Local.Name = "btn_Local";
            this.btn_Local.Size = new System.Drawing.Size(165, 40);
            this.btn_Local.TabIndex = 5;
            this.btn_Local.Text = "Location";
            this.btn_Local.UseVisualStyleBackColor = true;
            // 
            // btn_Telegram
            // 
            this.btn_Telegram.FlatAppearance.BorderSize = 0;
            this.btn_Telegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Telegram.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Telegram.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Telegram.IconChar = FontAwesome.Sharp.IconChar.Telegram;
            this.btn_Telegram.IconColor = System.Drawing.Color.DimGray;
            this.btn_Telegram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Telegram.IconSize = 40;
            this.btn_Telegram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Telegram.Location = new System.Drawing.Point(32, 234);
            this.btn_Telegram.Name = "btn_Telegram";
            this.btn_Telegram.Size = new System.Drawing.Size(165, 40);
            this.btn_Telegram.TabIndex = 4;
            this.btn_Telegram.Text = "Telegram";
            this.btn_Telegram.UseVisualStyleBackColor = true;
            // 
            // btn_Phone
            // 
            this.btn_Phone.FlatAppearance.BorderSize = 0;
            this.btn_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Phone.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phone.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Phone.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt;
            this.btn_Phone.IconColor = System.Drawing.Color.DimGray;
            this.btn_Phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Phone.IconSize = 40;
            this.btn_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Phone.Location = new System.Drawing.Point(32, 188);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(165, 40);
            this.btn_Phone.TabIndex = 3;
            this.btn_Phone.Text = "Contact";
            this.btn_Phone.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.DimGray;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 40;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(32, 142);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(165, 40);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // btn_Menus
            // 
            this.btn_Menus.FlatAppearance.BorderSize = 0;
            this.btn_Menus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menus.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_Menus.IconColor = System.Drawing.Color.DimGray;
            this.btn_Menus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menus.IconSize = 40;
            this.btn_Menus.Location = new System.Drawing.Point(249, 6);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.Size = new System.Drawing.Size(45, 40);
            this.btn_Menus.TabIndex = 1;
            this.btn_Menus.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 107;
            this.iconPictureBox1.Location = new System.Drawing.Point(90, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(107, 108);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 455);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "frm_dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton3;
    }
}

