namespace FINAL_BCT_apk
{
    partial class Student_Home
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.menuButton_panel = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.sideBar_container = new System.Windows.Forms.Panel();
            this.Main_Container = new System.Windows.Forms.Panel();
            this.main_sidePanel = new System.Windows.Forms.Panel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.home_panel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.billing_btn = new System.Windows.Forms.Button();
            this.grade_btn = new System.Windows.Forms.Button();
            this.course_btn = new System.Windows.Forms.Button();
            this.enroll_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.profilePic_btn = new System.Windows.Forms.Button();
            this.userName_label = new System.Windows.Forms.Label();
            this.profile_background_panel = new System.Windows.Forms.Panel();
            this.home_News_btn = new System.Windows.Forms.Button();
            this.home_Announcement_btn = new System.Windows.Forms.Button();
            this.home_About_btn = new System.Windows.Forms.Button();
            this.home_Location_btn = new System.Windows.Forms.Button();
            this.bctLabel = new System.Windows.Forms.Label();
            this.menuButton_panel.SuspendLayout();
            this.sideBar_container.SuspendLayout();
            this.Main_Container.SuspendLayout();
            this.main_sidePanel.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.home_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            this.profile_background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // menuButton_panel
            // 
            this.menuButton_panel.BackColor = System.Drawing.Color.Transparent;
            this.menuButton_panel.Controls.Add(this.menu_btn);
            this.menuButton_panel.Controls.Add(this.menuLabel);
            this.menuButton_panel.Location = new System.Drawing.Point(0, 0);
            this.menuButton_panel.Name = "menuButton_panel";
            this.menuButton_panel.Size = new System.Drawing.Size(218, 42);
            this.menuButton_panel.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Noto Sans JP", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLabel.Location = new System.Drawing.Point(84, -4);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(107, 46);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // sideBar_container
            // 
            this.sideBar_container.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sideBar_container.Controls.Add(this.logout_btn);
            this.sideBar_container.Controls.Add(this.billing_btn);
            this.sideBar_container.Controls.Add(this.grade_btn);
            this.sideBar_container.Controls.Add(this.course_btn);
            this.sideBar_container.Controls.Add(this.enroll_btn);
            this.sideBar_container.Controls.Add(this.menuButton_panel);
            this.sideBar_container.Controls.Add(this.home_btn);
            this.sideBar_container.Controls.Add(this.profile_btn);
            this.sideBar_container.Location = new System.Drawing.Point(0, 0);
            this.sideBar_container.MaximumSize = new System.Drawing.Size(218, 561);
            this.sideBar_container.MinimumSize = new System.Drawing.Size(68, 561);
            this.sideBar_container.Name = "sideBar_container";
            this.sideBar_container.Size = new System.Drawing.Size(218, 561);
            this.sideBar_container.TabIndex = 0;
            // 
            // Main_Container
            // 
            this.Main_Container.BackColor = System.Drawing.Color.White;
            this.Main_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Container.Controls.Add(this.search_panel);
            this.Main_Container.Controls.Add(this.home_panel);
            this.Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Container.Location = new System.Drawing.Point(0, 0);
            this.Main_Container.Name = "Main_Container";
            this.Main_Container.Size = new System.Drawing.Size(884, 561);
            this.Main_Container.TabIndex = 2;
            // 
            // main_sidePanel
            // 
            this.main_sidePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.main_sidePanel.Controls.Add(this.bctLabel);
            this.main_sidePanel.Controls.Add(this.home_Location_btn);
            this.main_sidePanel.Controls.Add(this.home_About_btn);
            this.main_sidePanel.Controls.Add(this.home_Announcement_btn);
            this.main_sidePanel.Controls.Add(this.home_News_btn);
            this.main_sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_sidePanel.Location = new System.Drawing.Point(0, 0);
            this.main_sidePanel.Name = "main_sidePanel";
            this.main_sidePanel.Size = new System.Drawing.Size(219, 561);
            this.main_sidePanel.TabIndex = 0;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.search_panel.Controls.Add(this.search_btn);
            this.search_panel.Location = new System.Drawing.Point(65, 0);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(819, 42);
            this.search_panel.TabIndex = 1;
            // 
            // home_panel
            // 
            this.home_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.home_panel.Controls.Add(this.userName_label);
            this.home_panel.Controls.Add(this.profile_background_panel);
            this.home_panel.Controls.Add(this.main_sidePanel);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_panel.Location = new System.Drawing.Point(0, 0);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(884, 561);
            this.home_panel.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Noto Sans JP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout_btn.Image = global::FINAL_BCT_apk.Properties.Resources.logOut;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(0, 507);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.logout_btn.Size = new System.Drawing.Size(215, 42);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "                 Log Out";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // billing_btn
            // 
            this.billing_btn.BackColor = System.Drawing.Color.Transparent;
            this.billing_btn.FlatAppearance.BorderSize = 0;
            this.billing_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.billing_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.billing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billing_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.billing_btn.Image = global::FINAL_BCT_apk.Properties.Resources.billing;
            this.billing_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billing_btn.Location = new System.Drawing.Point(-5, 362);
            this.billing_btn.Name = "billing_btn";
            this.billing_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.billing_btn.Size = new System.Drawing.Size(223, 43);
            this.billing_btn.TabIndex = 5;
            this.billing_btn.Text = "               Billing";
            this.billing_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billing_btn.UseVisualStyleBackColor = false;
            this.billing_btn.Click += new System.EventHandler(this.billing_btn_Click);
            // 
            // grade_btn
            // 
            this.grade_btn.BackColor = System.Drawing.Color.Transparent;
            this.grade_btn.FlatAppearance.BorderSize = 0;
            this.grade_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.grade_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.grade_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grade_btn.Image = global::FINAL_BCT_apk.Properties.Resources.grades;
            this.grade_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grade_btn.Location = new System.Drawing.Point(-3, 305);
            this.grade_btn.Name = "grade_btn";
            this.grade_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.grade_btn.Size = new System.Drawing.Size(221, 40);
            this.grade_btn.TabIndex = 4;
            this.grade_btn.Text = "               Grade";
            this.grade_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grade_btn.UseVisualStyleBackColor = false;
            this.grade_btn.Click += new System.EventHandler(this.grade_btn_Click);
            // 
            // course_btn
            // 
            this.course_btn.BackColor = System.Drawing.Color.Transparent;
            this.course_btn.FlatAppearance.BorderSize = 0;
            this.course_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.course_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.course_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.course_btn.Image = global::FINAL_BCT_apk.Properties.Resources.courses;
            this.course_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course_btn.Location = new System.Drawing.Point(-5, 247);
            this.course_btn.Name = "course_btn";
            this.course_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.course_btn.Size = new System.Drawing.Size(223, 40);
            this.course_btn.TabIndex = 3;
            this.course_btn.Text = "               Courses";
            this.course_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course_btn.UseVisualStyleBackColor = false;
            this.course_btn.Click += new System.EventHandler(this.course_btn_Click);
            // 
            // enroll_btn
            // 
            this.enroll_btn.BackColor = System.Drawing.Color.Transparent;
            this.enroll_btn.FlatAppearance.BorderSize = 0;
            this.enroll_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.enroll_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.enroll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enroll_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enroll_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enroll_btn.Image = global::FINAL_BCT_apk.Properties.Resources.enroll;
            this.enroll_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enroll_btn.Location = new System.Drawing.Point(-5, 191);
            this.enroll_btn.Name = "enroll_btn";
            this.enroll_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.enroll_btn.Size = new System.Drawing.Size(223, 40);
            this.enroll_btn.TabIndex = 2;
            this.enroll_btn.Text = "               Enroll";
            this.enroll_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enroll_btn.UseVisualStyleBackColor = false;
            this.enroll_btn.Click += new System.EventHandler(this.enroll_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.menu_btn.Image = global::FINAL_BCT_apk.Properties.Resources.white_menu;
            this.menu_btn.Location = new System.Drawing.Point(12, 3);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(38, 32);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_btn.TabIndex = 1;
            this.menu_btn.TabStop = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_btn.Image = global::FINAL_BCT_apk.Properties.Resources.home;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(-5, 80);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.home_btn.Size = new System.Drawing.Size(223, 40);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "               Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.Transparent;
            this.profile_btn.FlatAppearance.BorderSize = 0;
            this.profile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.profile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profile_btn.Image = global::FINAL_BCT_apk.Properties.Resources.profile;
            this.profile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.Location = new System.Drawing.Point(-5, 136);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.profile_btn.Size = new System.Drawing.Size(223, 40);
            this.profile_btn.TabIndex = 1;
            this.profile_btn.Text = "               Profile";
            this.profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Noto Sans JP Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_btn.Image = global::FINAL_BCT_apk.Properties.Resources.search;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(3, 0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.search_btn.Size = new System.Drawing.Size(150, 40);
            this.search_btn.TabIndex = 2;
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // profilePic_btn
            // 
            this.profilePic_btn.BackColor = System.Drawing.Color.Black;
            this.profilePic_btn.BackgroundImage = global::FINAL_BCT_apk.Properties.Resources.profileSAMPLE;
            this.profilePic_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePic_btn.FlatAppearance.BorderSize = 0;
            this.profilePic_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.profilePic_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.profilePic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilePic_btn.ForeColor = System.Drawing.Color.Black;
            this.profilePic_btn.Location = new System.Drawing.Point(24, 13);
            this.profilePic_btn.Name = "profilePic_btn";
            this.profilePic_btn.Size = new System.Drawing.Size(102, 84);
            this.profilePic_btn.TabIndex = 2;
            this.profilePic_btn.UseVisualStyleBackColor = false;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userName_label.Font = new System.Drawing.Font("Noto Sans JP", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userName_label.Location = new System.Drawing.Point(225, 53);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(305, 102);
            this.userName_label.TabIndex = 2;
            this.userName_label.Text = "Welcome back,\r\n            User Name";
            this.userName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile_background_panel
            // 
            this.profile_background_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.profile_background_panel.Controls.Add(this.profilePic_btn);
            this.profile_background_panel.Location = new System.Drawing.Point(65, 40);
            this.profile_background_panel.Name = "profile_background_panel";
            this.profile_background_panel.Size = new System.Drawing.Size(154, 109);
            this.profile_background_panel.TabIndex = 2;
            // 
            // home_News_btn
            // 
            this.home_News_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_News_btn.FlatAppearance.BorderSize = 0;
            this.home_News_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.home_News_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.home_News_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_News_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_News_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_News_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_News_btn.Location = new System.Drawing.Point(67, 229);
            this.home_News_btn.Name = "home_News_btn";
            this.home_News_btn.Size = new System.Drawing.Size(151, 36);
            this.home_News_btn.TabIndex = 3;
            this.home_News_btn.Text = "News";
            this.home_News_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_News_btn.UseVisualStyleBackColor = false;
            // 
            // home_Announcement_btn
            // 
            this.home_Announcement_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_Announcement_btn.FlatAppearance.BorderSize = 0;
            this.home_Announcement_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.home_Announcement_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.home_Announcement_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Announcement_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_Announcement_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_Announcement_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Announcement_btn.Location = new System.Drawing.Point(68, 355);
            this.home_Announcement_btn.Name = "home_Announcement_btn";
            this.home_Announcement_btn.Size = new System.Drawing.Size(151, 36);
            this.home_Announcement_btn.TabIndex = 4;
            this.home_Announcement_btn.Text = "Announcement";
            this.home_Announcement_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Announcement_btn.UseVisualStyleBackColor = false;
            // 
            // home_About_btn
            // 
            this.home_About_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_About_btn.FlatAppearance.BorderSize = 0;
            this.home_About_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.home_About_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.home_About_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_About_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_About_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_About_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_About_btn.Location = new System.Drawing.Point(67, 271);
            this.home_About_btn.Name = "home_About_btn";
            this.home_About_btn.Size = new System.Drawing.Size(151, 36);
            this.home_About_btn.TabIndex = 5;
            this.home_About_btn.Text = "About";
            this.home_About_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_About_btn.UseVisualStyleBackColor = false;
            // 
            // home_Location_btn
            // 
            this.home_Location_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_Location_btn.FlatAppearance.BorderSize = 0;
            this.home_Location_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.home_Location_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.home_Location_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Location_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_Location_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_Location_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Location_btn.Location = new System.Drawing.Point(67, 313);
            this.home_Location_btn.Name = "home_Location_btn";
            this.home_Location_btn.Size = new System.Drawing.Size(151, 36);
            this.home_Location_btn.TabIndex = 6;
            this.home_Location_btn.Text = "Location";
            this.home_Location_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Location_btn.UseVisualStyleBackColor = false;
            // 
            // bctLabel
            // 
            this.bctLabel.AutoSize = true;
            this.bctLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bctLabel.Font = new System.Drawing.Font("Noto Sans JP", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bctLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bctLabel.Location = new System.Drawing.Point(63, 163);
            this.bctLabel.Name = "bctLabel";
            this.bctLabel.Size = new System.Drawing.Size(90, 51);
            this.bctLabel.TabIndex = 3;
            this.bctLabel.Text = "BCT";
            this.bctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.sideBar_container);
            this.Controls.Add(this.Main_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Home";
            this.Load += new System.EventHandler(this.Student_Home_Load);
            this.menuButton_panel.ResumeLayout(false);
            this.menuButton_panel.PerformLayout();
            this.sideBar_container.ResumeLayout(false);
            this.Main_Container.ResumeLayout(false);
            this.main_sidePanel.ResumeLayout(false);
            this.main_sidePanel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            this.profile_background_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel Main_Container;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel menuButton_panel;
        private System.Windows.Forms.PictureBox menu_btn;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button enroll_btn;
        private System.Windows.Forms.Button course_btn;
        private System.Windows.Forms.Panel sideBar_container;
        private System.Windows.Forms.Button grade_btn;
        private System.Windows.Forms.Button billing_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel main_sidePanel;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button profilePic_btn;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Panel profile_background_panel;
        private System.Windows.Forms.Button home_News_btn;
        private System.Windows.Forms.Label bctLabel;
        private System.Windows.Forms.Button home_Location_btn;
        private System.Windows.Forms.Button home_About_btn;
        private System.Windows.Forms.Button home_Announcement_btn;
    }
}