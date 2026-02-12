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
            this.logout_btn = new System.Windows.Forms.Button();
            this.billing_btn = new System.Windows.Forms.Button();
            this.grade_btn = new System.Windows.Forms.Button();
            this.course_btn = new System.Windows.Forms.Button();
            this.enroll_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.menuButton_panel.SuspendLayout();
            this.sideBar_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
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
            this.menuButton_panel.Size = new System.Drawing.Size(218, 84);
            this.menuButton_panel.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLabel.Location = new System.Drawing.Point(71, 11);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(124, 54);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // sideBar_container
            // 
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
            this.Main_Container.Location = new System.Drawing.Point(68, 0);
            this.Main_Container.Name = "Main_Container";
            this.Main_Container.Size = new System.Drawing.Size(817, 561);
            this.Main_Container.TabIndex = 2;
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
            this.billing_btn.Location = new System.Drawing.Point(0, 402);
            this.billing_btn.Name = "billing_btn";
            this.billing_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.billing_btn.Size = new System.Drawing.Size(215, 43);
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
            this.grade_btn.Location = new System.Drawing.Point(2, 345);
            this.grade_btn.Name = "grade_btn";
            this.grade_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.grade_btn.Size = new System.Drawing.Size(213, 40);
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
            this.course_btn.Location = new System.Drawing.Point(0, 287);
            this.course_btn.Name = "course_btn";
            this.course_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.course_btn.Size = new System.Drawing.Size(215, 40);
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
            this.enroll_btn.Location = new System.Drawing.Point(0, 231);
            this.enroll_btn.Name = "enroll_btn";
            this.enroll_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.enroll_btn.Size = new System.Drawing.Size(215, 40);
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
            this.menu_btn.Location = new System.Drawing.Point(9, 10);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(50, 55);
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
            this.home_btn.Location = new System.Drawing.Point(0, 120);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.home_btn.Size = new System.Drawing.Size(215, 40);
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
            this.profile_btn.Location = new System.Drawing.Point(0, 176);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.profile_btn.Size = new System.Drawing.Size(215, 40);
            this.profile_btn.TabIndex = 1;
            this.profile_btn.Text = "               Profile";
            this.profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
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
    }
}