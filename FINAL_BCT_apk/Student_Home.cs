using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FINAL_BCT_apk
{
    public partial class Student_Home : Form
    {
        //GET AND SET VALUES FROM DATABASE
        public string Name { get; set; }

        //COLOR VARIABLE (RED)
        private readonly Color textColor = ColorTranslator.FromHtml("#ECE1D5");

        //BOOLEAN FOR MENU SLIDEBAR
        bool sidebarExpand;

        public Student_Home()
        {
            InitializeComponent();
        }

        //CIRCULAR BUTTON METHOD
        private void MakeButtonCircular(Button btn)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        //FORM LOAD
        private void Student_Home_Load(object sender, EventArgs e)
        {
            //FORM CORNERS-->
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            //SET NAME FROM DATABASE
            userName_label.Text = $"Welcome back, {Name}";
            userName_label.ForeColor = ColorTranslator.FromHtml("#9A1E22");


            //CIRCULAR BUTTON
            MakeButtonCircular(profilePic_btn);
            


            //MENU TEXT COLORS
            menuLabel.ForeColor = textColor;
            home_btn.ForeColor = textColor;
            profile_btn.ForeColor = textColor;
            enroll_btn.ForeColor = textColor;
            course_btn.ForeColor = textColor;
            grade_btn.ForeColor = textColor;
            billing_btn.ForeColor = textColor;
            logout_btn.ForeColor = textColor;

            //HOME PANEL BUTTON COLORS
            bctLabel.ForeColor = textColor;
            home_News_btn.ForeColor = textColor;
            home_About_btn.ForeColor = textColor;
            home_Location_btn.ForeColor = textColor;
            home_Announcement_btn.ForeColor = textColor;


            //AVOID FICKERING WHILE SLIDING THE MENU
            SetDoubleBuffered(sideBar_container);

            //SLIDEBAR COLOR
            sideBar_container.BackColor = ColorTranslator.FromHtml("#9A1E22");
            menuButton_panel.BackColor = ColorTranslator.FromHtml("#7B181B");

            //PANEL COLORS
            profile_background_panel.BackColor = ColorTranslator.FromHtml("#9A1E22");
            main_sidePanel.BackColor = ColorTranslator.FromHtml("#B32428");
            search_panel.BackColor = ColorTranslator.FromHtml("#7B181B");
            Main_Container.BackColor = ColorTranslator.FromHtml("#ECE1D5");
            home_panel.BackColor = ColorTranslator.FromHtml("#FCF7F8");

            
        }

        //AVOID FICKERING WHILE SLIDING THE MENU
        private void SetDoubleBuffered(Control c)
        {
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(c, true, null);
        }


        //TIMER FOR MENU SLIDEBAR
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            { 
                sideBar_container.Width -= 10;
                if(sideBar_container.Width == sideBar_container.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
                
            }
            else
            {
                sideBar_container.Width += 10;
                if (sideBar_container.Width == sideBar_container.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void CollapseSidebar()
        {
            if (sideBar_container.Width <= sideBar_container.MinimumSize.Width)
                return;

            sidebarExpand = true;
            sidebarTimer.Start();
        }
        private void menu_btn_Click(object sender, EventArgs e)
        {
            sideBar_container.BringToFront();
            sidebarTimer.Start();
        }


        //BUTTONS IN THE MENU SLIDEBAR
        private void button5_Click(object sender, EventArgs e)
        {
            //GO BACK TO LOGIN FORM
            login_signin_form loginForm = new login_signin_form();
            this.Hide();
            loginForm.Show();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }
        private void profile_btn_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }
        private void enroll_btn_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }
        private void course_btn_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }
        private void grade_btn_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }
        private void billing_btn_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }
    }
}
