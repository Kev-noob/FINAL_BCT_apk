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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace FINAL_BCT_apk
{
    public partial class login_signin_form : Form
    {
        public login_signin_form()
        {
            InitializeComponent();
            
        }

        //DATABASE CONNECTION--->
        private MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;" +
                             "port=3306;" +
                             "database=BCT_db;" +
                             "user=root;" +
                             "password=root;";
            return new MySqlConnection(connStr);
        }//<----


        //BUTTON CORNERS METHOD-->
        private void RoundButton(System.Windows.Forms.Button btn, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = radius * 2;

            path.AddArc(0, 0, d, d, 180, 90);                    // top-left
            path.AddArc(btn.Width - d, 0, d, d, 270, 90);        // top-right
            path.AddArc(btn.Width - d, btn.Height - d, d, d, 0, 90); // bottom-right
            path.AddArc(0, btn.Height - d, d, d, 90, 90);        // bottom-left
            path.CloseFigure();

            btn.Region = new Region(path);
            
        }

        //FORM LOAD-->
        private void Form1_Load(object sender, EventArgs e)
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

            //LOG IN UP BUTON CORNERS
            RoundButton(btn_login, 5);
            RoundButton(btn_reg, 5);


        }


        //SWITCING PANELS (REGISTER AND LOGIN)
        private void panel_switch_btn_register_Click(object sender, EventArgs e)
        {
            register_panel.BringToFront();
        }
        private void panel_switch_btn_logIn_Click(object sender, EventArgs e)
        {
            login_panel.BringToFront();
        }



        //MINIMIZE AND CLOSE BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void minimize2_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void close2_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //TEXTBOX PLACEHOLDER (LOGIN PANEL)
        private void login_ID_txtbox_Enter(object sender, EventArgs e)
        {
            if (login_ID_txtbox.Text == "Student ID")
            {
                login_ID_txtbox.Text = "";
                login_ID_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
               
            }
        }
        private void login_ID_txtbox_Leave(object sender, EventArgs e)
        {
            if (login_ID_txtbox.Text == "")
            {
                login_ID_txtbox.Text = "Student ID";
                login_ID_txtbox.ForeColor = Color.DarkGray;

            }
        }

        //TEXTBOX & PASSWORD MASK (LOGIN PANEL)
        private void login_password_txtbox_Enter(object sender, EventArgs e)
        {
            if (login_password_txtbox.Text == "Enter Password")
            {
                login_password_txtbox.Text = "";
                login_password_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
                login_password_txtbox.PasswordChar = '•';
            }
        }
        private void login_password_txtbox_Leave(object sender, EventArgs e)
        {
            if (login_password_txtbox.Text == "")
            {
                login_password_txtbox.PasswordChar = '\0';
                login_password_txtbox.Text = "Enter Password";
                login_password_txtbox.ForeColor = Color.DarkGray;
                loginEye_btn.Image = Properties.Resources.eye_22;
            }
        }
        //SHOW & HIDE PASSWORD (LOGIN PANEL)
        private void loginEye_btn_Click(object sender, EventArgs e)
        {
            if (login_password_txtbox.PasswordChar == '•')
            {
                login_password_txtbox.PasswordChar = '\0';
                loginEye_btn.Image = Properties.Resources.open_eye;
            }
            else
            {
                login_password_txtbox.PasswordChar = '•';
                loginEye_btn.Image = Properties.Resources.eye_22;
            }
        }



        //LOG IN BUTTON (LOGIN PANEL)
        private void btn_login_Click(object sender, EventArgs e)
        {
            string studentId = login_ID_txtbox.Text.Trim();
            string password = login_password_txtbox.Text;

            
            //CHECK FOR EMPTY TEXTBOX---->
            if (studentId == "" || studentId == "Student ID" ||
                password == "" || password == "Enter Password")
            {
                MessageBox.Show("Please complete inputs!");
                return;
            }//<----


            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT student_id, full_name, password FROM inputs WHERE student_id=@student_id AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", studentId);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string id = reader.GetString("student_id");
                                string name = reader.GetString("full_name");


                                //GO TO HOME SCREEN
                                Student_Home loginForm = new Student_Home();
                                loginForm.Name = name;
                                this.Hide();
                                loginForm.Show();
                            }
                            else if (studentId == "admin" && password == "admin")
                            {
                                //ADMIN LOGIN
                                Teacher_form teacherForm = new Teacher_form();
                                this.Hide();
                                teacherForm.Show();
                                MessageBox.Show("<--You have entered an Admin Domain.-->");
                            }
                            else if (studentId == "admin" && password == "superadmin")
                            {
                                //SUPER ADMIN LOGIN
                                Super_admin superForm = new Super_admin();
                                this.Hide();
                                superForm.Show();
                                MessageBox.Show("<--Welcome Super Admin-->.");
                            }
                            else
                            {
                                MessageBox.Show("Invalid Student ID or Password!");
                            }
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }






        //------------------------------BOUNDRY OF LOGIN AND REGISTER PANEL------------------------------//






        //TEXTBOX PLACEHOLDER (REGISTER PANEL)
        private void fullName_txtbox_Enter(object sender, EventArgs e)
        {
            if (fullName_txtbox.Text == "Enter Fullname")
            {
                fullName_txtbox.Text = "";
                fullName_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void fullName_txtbox_Leave(object sender, EventArgs e)
        {
            if (fullName_txtbox.Text == "")
            {
                fullName_txtbox.Text = "Enter Fullname";
                fullName_txtbox.ForeColor = Color.DarkGray;
            }
        }
        private void studentId_txtbox_Enter(object sender, EventArgs e)
        {
            if (studentId_txtbox.Text == "Student ID")
            {
                studentId_txtbox.Text = "";
                studentId_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void studentId_txtbox_Leave(object sender, EventArgs e)
        {
            if (studentId_txtbox.Text == "")
            {
                studentId_txtbox.Text = "Student ID";
                studentId_txtbox.ForeColor = Color.DarkGray;
            }
        }
        private void course_txtbox_Enter(object sender, EventArgs e)
        {
            if (course_txtbox.Text == "Enter Course")
            {
                course_txtbox.Text = "";
                course_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void course_txtbox_Leave(object sender, EventArgs e)
        {
            if (course_txtbox.Text == "")
            {
                course_txtbox.Text = "Enter Course";
                course_txtbox.ForeColor = Color.DarkGray;
            }
        }
        private void yearLv_txtbox_Enter(object sender, EventArgs e)
        {
            if (yearLv_txtbox.Text == "Year Level")
            {
                yearLv_txtbox.Text = "";
                yearLv_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void yearLv_txtbox_Leave(object sender, EventArgs e)
        {
            if (yearLv_txtbox.Text == "")
            {
                yearLv_txtbox.Text = "Year Level";
                yearLv_txtbox.ForeColor = Color.DarkGray;
            }
        }
        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "Enter Password")
            {
                password_txtbox.Text = "";
                password_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
                password_txtbox.PasswordChar = '•';
            }
        }
        private void password_txtbox_Leave(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "")
            {
                password_txtbox.PasswordChar = '\0';
                password_txtbox.Text = "Enter Password";
                password_txtbox.ForeColor = Color.DarkGray;
                enterPass_eyeBtn.Image = Properties.Resources.eye_22;
            }
        }
        private void conPassword_txtbox_Enter(object sender, EventArgs e)
        {
            if (conPassword_txtbox.Text == "Confirm Password")
            {
                conPassword_txtbox.Text = "";
                conPassword_txtbox.ForeColor = Color.FromArgb(135, 10, 6);
                conPassword_txtbox.PasswordChar = '•';
            }
        }
        private void conPassword_txtbox_Leave(object sender, EventArgs e)
        {
            if (conPassword_txtbox.Text == "")
            {
                conPassword_txtbox.PasswordChar = '\0';
                conPassword_txtbox.Text = "Confirm Password";
                conPassword_txtbox.ForeColor = Color.DarkGray;
                conPass_eyeBtn.Image = Properties.Resources.eye_22;
            }
        }



        //SHOW & HIDE PASSWORD (REGISTER PANEL)
        private void enterPass_eyeBtn_Click(object sender, EventArgs e)
        {
            if (password_txtbox.PasswordChar == '•')
            {
                password_txtbox.PasswordChar = '\0';
                enterPass_eyeBtn.Image = Properties.Resources.open_eye;
            }
            else
            {
                password_txtbox.PasswordChar = '•';
                enterPass_eyeBtn.Image = Properties.Resources.eye_22;
            }
        }
        private void conPass_eyeBtn_Click(object sender, EventArgs e)
        {
            if (conPassword_txtbox.PasswordChar == '•')
            {
                conPassword_txtbox.PasswordChar = '\0';
                conPass_eyeBtn.Image = Properties.Resources.open_eye;
            }
            else
            {
                conPassword_txtbox.PasswordChar = '•';
                conPass_eyeBtn.Image = Properties.Resources.eye_22;
            }
        }


        //REGISTER BUTTON (REGISTER PANEL)
        private void btn_reg_Click(object sender, EventArgs e)
        {
            string studentId = studentId_txtbox.Text.Trim();
            string fullName = fullName_txtbox.Text.Trim();
            string course = course_txtbox.Text.Trim();
            string password = password_txtbox.Text;
            string confirmPassword = conPassword_txtbox.Text;

            //input & placeholder verification-->
            if (fullName_txtbox.Text == "" || fullName_txtbox.Text == "Enter Fullname" ||
                   studentId_txtbox.Text == "" || studentId_txtbox.Text == "Student ID" ||
                   course_txtbox.Text == "" || course_txtbox.Text == "Enter Course" ||
                   yearLv_txtbox.Text == "" || yearLv_txtbox.Text == "Year Level" ||
                   password_txtbox.Text == "" || password_txtbox.Text == "Enter Password" ||
                   conPassword_txtbox.Text == "" || conPassword_txtbox.Text == "Confirm Password")
            {
                MessageBox.Show("Please complete inputs!");
                return;
            }//<--


            //PASSWORD CHECKER-->
            if (password != confirmPassword)
            {
                MessageBox.Show("PasswordS does not match!");
                return;
            }//<---


            //YEAR LEVEL CHECKER--->
            int yearLevel;
            if (!int.TryParse(yearLv_txtbox.Text.Trim(), out yearLevel))
            {
                MessageBox.Show("Year level must be a number!");
                return;
            }

            if (yearLevel < 1 || yearLevel > 4)
            {
                MessageBox.Show("Year level must be between 1 and 4.");
                return;
            }//<---



            //INSERT TO DATABASE--->
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                //ID UNIQUENESS CHEKER--->
                string checkSql = "SELECT COUNT(*) FROM inputs WHERE student_id = @studentId";
                using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@studentId", studentId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Student ID already exists!");
                        return;
                    }
                }//<----


                string sql = @"INSERT INTO inputs (student_id, full_name, course, year_level, password)
                             VALUES(@student_id, @full_name, @course, @year_level, @password)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@full_name", fullName);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@year_level", yearLevel);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }

            }//<----
            MessageBox.Show("<-Registered Succesfully->");
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
