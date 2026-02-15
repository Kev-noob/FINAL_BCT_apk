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
            this.menu_btn = new System.Windows.Forms.PictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.sideBar_container = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.billing_btn = new System.Windows.Forms.Button();
            this.grade_btn = new System.Windows.Forms.Button();
            this.course_btn = new System.Windows.Forms.Button();
            this.enroll_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.home_panel = new System.Windows.Forms.Panel();
            this.userName_label = new System.Windows.Forms.Label();
            this.profilePic_btn = new System.Windows.Forms.Button();
            this.main_sidePanel = new System.Windows.Forms.Panel();
            this.home_Location_btn = new System.Windows.Forms.Button();
            this.home_About_btn = new System.Windows.Forms.Button();
            this.home_Announcement_btn = new System.Windows.Forms.Button();
            this.home_News_btn = new System.Windows.Forms.Button();
            this.Profile_panel = new System.Windows.Forms.Panel();
            this.Enroll_panel = new System.Windows.Forms.Panel();
            this.Home_label = new System.Windows.Forms.Label();
            this.Courses_panel = new System.Windows.Forms.Panel();
            this.Grades_panel = new System.Windows.Forms.Panel();
            this.Billing_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MAIN_CONTAINER = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuButton_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            this.sideBar_container.SuspendLayout();
            this.home_panel.SuspendLayout();
            this.main_sidePanel.SuspendLayout();
            this.Profile_panel.SuspendLayout();
            this.Enroll_panel.SuspendLayout();
            this.Courses_panel.SuspendLayout();
            this.Grades_panel.SuspendLayout();
            this.Billing_panel.SuspendLayout();
            this.MAIN_CONTAINER.SuspendLayout();
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
            this.menuButton_panel.Size = new System.Drawing.Size(218, 51);
            this.menuButton_panel.TabIndex = 1;
            // 
            // menu_btn
            // 
            this.menu_btn.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.menu_btn.Image = global::FINAL_BCT_apk.Properties.Resources.white_menu;
            this.menu_btn.Location = new System.Drawing.Point(12, 12);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(38, 32);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_btn.TabIndex = 1;
            this.menu_btn.TabStop = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Noto Sans JP", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLabel.Location = new System.Drawing.Point(84, 3);
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
            this.sideBar_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar_container.Location = new System.Drawing.Point(0, 0);
            this.sideBar_container.MaximumSize = new System.Drawing.Size(218, 600);
            this.sideBar_container.MinimumSize = new System.Drawing.Size(68, 600);
            this.sideBar_container.Name = "sideBar_container";
            this.sideBar_container.Size = new System.Drawing.Size(218, 600);
            this.sideBar_container.TabIndex = 0;
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
            this.logout_btn.Location = new System.Drawing.Point(0, 555);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.logout_btn.Size = new System.Drawing.Size(215, 45);
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
            // home_panel
            // 
            this.home_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.home_panel.Controls.Add(this.profilePic_btn);
            this.home_panel.Controls.Add(this.userName_label);
            this.home_panel.Controls.Add(this.main_sidePanel);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_panel.Location = new System.Drawing.Point(0, 0);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(832, 600);
            this.home_panel.TabIndex = 1;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userName_label.Font = new System.Drawing.Font("Noto Sans JP", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userName_label.Location = new System.Drawing.Point(225, 80);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(305, 102);
            this.userName_label.TabIndex = 2;
            this.userName_label.Text = "Welcome back,\r\n            User Name";
            this.userName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.profilePic_btn.Location = new System.Drawing.Point(499, 158);
            this.profilePic_btn.Name = "profilePic_btn";
            this.profilePic_btn.Size = new System.Drawing.Size(102, 84);
            this.profilePic_btn.TabIndex = 2;
            this.profilePic_btn.UseVisualStyleBackColor = false;
            // 
            // main_sidePanel
            // 
            this.main_sidePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.main_sidePanel.Controls.Add(this.Home_label);
            this.main_sidePanel.Controls.Add(this.home_Location_btn);
            this.main_sidePanel.Controls.Add(this.home_About_btn);
            this.main_sidePanel.Controls.Add(this.home_Announcement_btn);
            this.main_sidePanel.Controls.Add(this.home_News_btn);
            this.main_sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_sidePanel.Location = new System.Drawing.Point(0, 0);
            this.main_sidePanel.Name = "main_sidePanel";
            this.main_sidePanel.Size = new System.Drawing.Size(150, 600);
            this.main_sidePanel.TabIndex = 0;
            // 
            // home_Location_btn
            // 
            this.home_Location_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_Location_btn.FlatAppearance.BorderSize = 0;
            this.home_Location_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.home_Location_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.home_Location_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Location_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_Location_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_Location_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Location_btn.Location = new System.Drawing.Point(0, 237);
            this.home_Location_btn.Name = "home_Location_btn";
            this.home_Location_btn.Size = new System.Drawing.Size(151, 36);
            this.home_Location_btn.TabIndex = 6;
            this.home_Location_btn.Text = "Location";
            this.home_Location_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Location_btn.UseVisualStyleBackColor = false;
            // 
            // home_About_btn
            // 
            this.home_About_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_About_btn.FlatAppearance.BorderSize = 0;
            this.home_About_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.home_About_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.home_About_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_About_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_About_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_About_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_About_btn.Location = new System.Drawing.Point(0, 195);
            this.home_About_btn.Name = "home_About_btn";
            this.home_About_btn.Size = new System.Drawing.Size(151, 36);
            this.home_About_btn.TabIndex = 5;
            this.home_About_btn.Text = "About";
            this.home_About_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_About_btn.UseVisualStyleBackColor = false;
            // 
            // home_Announcement_btn
            // 
            this.home_Announcement_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_Announcement_btn.FlatAppearance.BorderSize = 0;
            this.home_Announcement_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.home_Announcement_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.home_Announcement_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Announcement_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_Announcement_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_Announcement_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Announcement_btn.Location = new System.Drawing.Point(1, 279);
            this.home_Announcement_btn.Name = "home_Announcement_btn";
            this.home_Announcement_btn.Size = new System.Drawing.Size(151, 36);
            this.home_Announcement_btn.TabIndex = 4;
            this.home_Announcement_btn.Text = "Announcement";
            this.home_Announcement_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Announcement_btn.UseVisualStyleBackColor = false;
            // 
            // home_News_btn
            // 
            this.home_News_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_News_btn.FlatAppearance.BorderSize = 0;
            this.home_News_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.home_News_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.home_News_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_News_btn.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.home_News_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_News_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_News_btn.Location = new System.Drawing.Point(0, 153);
            this.home_News_btn.Name = "home_News_btn";
            this.home_News_btn.Size = new System.Drawing.Size(151, 36);
            this.home_News_btn.TabIndex = 3;
            this.home_News_btn.Text = "News";
            this.home_News_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_News_btn.UseVisualStyleBackColor = false;
            // 
            // Profile_panel
            // 
            this.Profile_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Profile_panel.Controls.Add(this.label1);
            this.Profile_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Profile_panel.Location = new System.Drawing.Point(0, 0);
            this.Profile_panel.Name = "Profile_panel";
            this.Profile_panel.Size = new System.Drawing.Size(832, 600);
            this.Profile_panel.TabIndex = 3;
            // 
            // Enroll_panel
            // 
            this.Enroll_panel.BackColor = System.Drawing.Color.RosyBrown;
            this.Enroll_panel.Controls.Add(this.label2);
            this.Enroll_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enroll_panel.Location = new System.Drawing.Point(0, 0);
            this.Enroll_panel.Name = "Enroll_panel";
            this.Enroll_panel.Size = new System.Drawing.Size(832, 600);
            this.Enroll_panel.TabIndex = 4;
            // 
            // Home_label
            // 
            this.Home_label.AutoSize = true;
            this.Home_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_label.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Home_label.Location = new System.Drawing.Point(6, 3);
            this.Home_label.Name = "Home_label";
            this.Home_label.Size = new System.Drawing.Size(131, 54);
            this.Home_label.TabIndex = 3;
            this.Home_label.Text = "Home";
            this.Home_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Courses_panel
            // 
            this.Courses_panel.BackColor = System.Drawing.Color.Peru;
            this.Courses_panel.Controls.Add(this.label3);
            this.Courses_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Courses_panel.Location = new System.Drawing.Point(0, 0);
            this.Courses_panel.Name = "Courses_panel";
            this.Courses_panel.Size = new System.Drawing.Size(832, 600);
            this.Courses_panel.TabIndex = 5;
            // 
            // Grades_panel
            // 
            this.Grades_panel.BackColor = System.Drawing.Color.Khaki;
            this.Grades_panel.Controls.Add(this.label4);
            this.Grades_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grades_panel.Location = new System.Drawing.Point(0, 0);
            this.Grades_panel.Name = "Grades_panel";
            this.Grades_panel.Size = new System.Drawing.Size(832, 600);
            this.Grades_panel.TabIndex = 6;
            // 
            // Billing_panel
            // 
            this.Billing_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.Billing_panel.Controls.Add(this.label5);
            this.Billing_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Billing_panel.Location = new System.Drawing.Point(0, 0);
            this.Billing_panel.Name = "Billing_panel";
            this.Billing_panel.Size = new System.Drawing.Size(832, 600);
            this.Billing_panel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // MAIN_CONTAINER
            // 
            this.MAIN_CONTAINER.Controls.Add(this.Billing_panel);
            this.MAIN_CONTAINER.Controls.Add(this.Grades_panel);
            this.MAIN_CONTAINER.Controls.Add(this.Courses_panel);
            this.MAIN_CONTAINER.Controls.Add(this.Enroll_panel);
            this.MAIN_CONTAINER.Controls.Add(this.Profile_panel);
            this.MAIN_CONTAINER.Controls.Add(this.home_panel);
            this.MAIN_CONTAINER.Location = new System.Drawing.Point(68, 0);
            this.MAIN_CONTAINER.Name = "MAIN_CONTAINER";
            this.MAIN_CONTAINER.Size = new System.Drawing.Size(832, 600);
            this.MAIN_CONTAINER.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enroll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 54);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "Billing";
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.sideBar_container);
            this.Controls.Add(this.MAIN_CONTAINER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Home";
            this.Load += new System.EventHandler(this.Student_Home_Load);
            this.menuButton_panel.ResumeLayout(false);
            this.menuButton_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            this.sideBar_container.ResumeLayout(false);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.main_sidePanel.ResumeLayout(false);
            this.main_sidePanel.PerformLayout();
            this.Profile_panel.ResumeLayout(false);
            this.Profile_panel.PerformLayout();
            this.Enroll_panel.ResumeLayout(false);
            this.Enroll_panel.PerformLayout();
            this.Courses_panel.ResumeLayout(false);
            this.Courses_panel.PerformLayout();
            this.Grades_panel.ResumeLayout(false);
            this.Grades_panel.PerformLayout();
            this.Billing_panel.ResumeLayout(false);
            this.Billing_panel.PerformLayout();
            this.MAIN_CONTAINER.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
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
        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Button profilePic_btn;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Button home_News_btn;
        private System.Windows.Forms.Button home_Location_btn;
        private System.Windows.Forms.Button home_About_btn;
        private System.Windows.Forms.Button home_Announcement_btn;
        private System.Windows.Forms.Panel Profile_panel;
        private System.Windows.Forms.Panel Enroll_panel;
        private System.Windows.Forms.Label Home_label;
        private System.Windows.Forms.Panel Courses_panel;
        private System.Windows.Forms.Panel Grades_panel;
        private System.Windows.Forms.Panel Billing_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MAIN_CONTAINER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}