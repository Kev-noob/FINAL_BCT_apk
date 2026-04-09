using FINAL_BCT_apk.DAL;
using FINAL_BCT_apk.Models;
using MySql.Data.MySqlClient;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FINAL_BCT_apk.DAL;
using FINAL_BCT_apk.Models;

namespace FINAL_BCT_apk
{
    public partial class login_signin_form : Form
    {
        public login_signin_form()
        {
            InitializeComponent();
            
        }

        //CALL THE DATABASE CONNECTION FOLDER (DBHELPER)
        DBHelper dbHelper = new DBHelper();


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

            //COMBOBOX COURSE ITEMS
            courses_comboBox.ForeColor = Color.DarkGray;
            LoadCourses();
        }


        //LOAD COURSES (FROM SUPER ADMIN) TO COMBOBOX (STUDENT REGISTER)
        private void LoadCourses()
        {
            //CALL THE DBHELPER FOLDER TO GET COURSES-->
            try
            {
                List<Courses> courseList = DBHelper.GetCourse();
                courseList.Insert(0, new Courses { Id = 0, Course_name = "Select Course" }); 
                courses_comboBox.DataSource = courseList;
                courses_comboBox.DisplayMember = "Course_name"; 
                courses_comboBox.ValueMember = "Id";
                courses_comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }//<--
           
            
        }


        //SWITCING PANELS (REGISTER AND LOGIN)
        private void panel_switch_btn_register_Click(object sender, EventArgs e)
        {
            register_panel.BringToFront();
            student_reg.BringToFront();
        }
        private void panel_switch_btn_logIn_Click(object sender, EventArgs e)
        {
            login_panel.BringToFront();
        }
        private void BIG_reg_Click(object sender, EventArgs e)
        {
            student_reg.BringToFront();  
        }
        private void BIG_student_reg_Click(object sender, EventArgs e)
        {
            student_login.BringToFront();
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

            //ADMIN LOGIN CHECKER
            if (login_ID_txtbox.Text == "admin" && login_password_txtbox.Text == "admin")
            {
                //ADMIN LOGIN
                Teacher_form teacherForm = new Teacher_form();
                this.Hide();
                teacherForm.Show();
                MessageBox.Show("<--You have entered an Admin Domain.-->");
                return;
            }

            //CHECK FOR EMPTY TEXTBOX---->
            if (studentId == "" || studentId == "Student ID" ||
                password == "" || password == "Enter Password")
            {
                MessageBox.Show("Please complete inputs!");
                return;
            }

            
            //ACCES THE BDHELPER FOLDER
            try
            {
                Student student = DBHelper.GetStudent(studentId, password);
               
                   if (student != null)
                   {
                    //GO TO HOME SCREEN
                    Student_Home loginForm = new Student_Home();
                    loginForm.currentStudent = student;
                    this.Hide();
                    loginForm.Show();
                   }      
                   else
                   {
                     MessageBox.Show("Invalid Student ID or Password!");
                   }
            }//<--
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        //------------------------------------------------------------BOUNDRY OF LOGIN AND REGISTER PANEL------------------------------------------------------------------//


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
            int courseId = courses_comboBox.SelectedValue != null ?
                   Convert.ToInt32(courses_comboBox.SelectedValue) : 0;
            string password = password_txtbox.Text;
            string confirmPassword = conPassword_txtbox.Text;

            //input & placeholder verification-->
            if (fullName_txtbox.Text == "" || fullName_txtbox.Text == "Enter Fullname" ||
                   studentId_txtbox.Text == "" || studentId_txtbox.Text == "Student ID" ||
                   courseId == 0 ||
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


            //CALL THE DBHELPER FOLDER TO ADD STUDENT TO DATABASE -->
            Student InserStudent = new Student
            {
                Student_id = studentId,
                Full_name = fullName,
                Course_id = courseId.ToString(),
                Year_level = yearLevel,
                Password = password
            };
            bool isInserted = DBHelper.AddStudent(InserStudent);
            //<--


            if (isInserted)
            {
                MessageBox.Show("<-Registered Succesfully->");
            }
            else
            {
                MessageBox.Show("ID already exist!");
            }

        }
        //------------------------------------------------------------BOUNDRY OF REGISTER AND INSTRUCTOR PANEL------------------------------------------------------------------//


        private void instructor_reg_Click(object sender, EventArgs e)
        {
            instructor_register.BringToFront();
        }

        private void instructor_login_Click(object sender, EventArgs e)
        {
            instructor_login_.BringToFront();
        }


        //TEXTBOX PLACEHOLDER (REGISTER INSTRUCTOR PANEL)
        private void INS_name_Enter(object sender, EventArgs e)
        {
            if (INS_name.Text == "Enter Fullname")
            {
                INS_name.Text = "";
                INS_name.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void INS_name_Leave(object sender, EventArgs e)
        {
            if (INS_name.Text == "")
            {
                INS_name.Text = "Enter Fullname";
                INS_name.ForeColor = Color.DarkGray;
            }
        }

        private void INS_email_Enter(object sender, EventArgs e)
        {
            if (INS_email.Text == "Email")
            {
                INS_email.Text = "";
                INS_email.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void INS_email_Leave(object sender, EventArgs e)
        {
            if (INS_email.Text == "")
            {
                INS_email.Text = "Email";
                INS_email.ForeColor = Color.DarkGray;
            }
        }

        private void INS_phone_Enter(object sender, EventArgs e)
        {
            if (INS_phone.Text == "Phone")
            {
                INS_phone.Text = "";
                INS_phone.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void INS_phone_Leave(object sender, EventArgs e)
        {
            if (INS_phone.Text == "")
            {
                INS_phone.Text = "Phone";
                INS_phone.ForeColor = Color.DarkGray;
            }
        }

        private void INS_department_Enter(object sender, EventArgs e)
        {
            if (INS_department.Text == "Department")
            {
                INS_department.Text = "";
                INS_department.ForeColor = Color.FromArgb(135, 10, 6);
            }
        }
        private void INS_department_Leave(object sender, EventArgs e)
        {
            if (INS_department.Text == "")
            {
                INS_department.Text = "Department";
                INS_department.ForeColor = Color.DarkGray;
            }
        }

        private void INS_pass_Enter(object sender, EventArgs e)
        {
            if (INS_pass.Text == "Enter Password")
            {
                INS_pass.Text = "";
                INS_pass.ForeColor = Color.FromArgb(135, 10, 6);
                INS_pass.PasswordChar = '•';
            }
        }
        private void INS_pass_Leave(object sender, EventArgs e)
        {
            if (INS_pass.Text == "")
            {
                INS_pass.PasswordChar = '\0';
                INS_pass.Text = "Enter Password";
                INS_pass.ForeColor = Color.DarkGray;
              
            }
        }

        private void INS_cnfrm_pass_Enter(object sender, EventArgs e)
        {
            if (INS_cnfrm_pass.Text == "Confirm Password")
            {
                INS_cnfrm_pass.Text = "";
                INS_cnfrm_pass.ForeColor = Color.FromArgb(135, 10, 6);
                INS_cnfrm_pass.PasswordChar = '•';
            }
        }
        private void INS_cnfrm_pass_Leave(object sender, EventArgs e)
        {
            if (INS_cnfrm_pass.Text == "")
            {
                INS_cnfrm_pass.PasswordChar = '\0';
                INS_cnfrm_pass.Text = "Confirm Password";
                INS_cnfrm_pass.ForeColor = Color.DarkGray;
                
            }
        }


        //SHOW & HIDE PASSWORD (REGISTER PANEL)
        private void enterPass_eye_Click(object sender, EventArgs e)
        {
            if (INS_pass.PasswordChar == '•')
            {
                INS_pass.PasswordChar = '\0';
                enterPass_eye.Image = Properties.Resources.open_eye;
            }
            else
            {
                INS_pass.PasswordChar = '•';
                enterPass_eye.Image = Properties.Resources.eye_22;
            }
        }
        private void conPass_eye_Click(object sender, EventArgs e)
        {
            if (INS_cnfrm_pass.PasswordChar == '•')
            {
                INS_cnfrm_pass.PasswordChar = '\0';
                conPass_eye.Image = Properties.Resources.open_eye;
            }
            else
            {
                INS_cnfrm_pass.PasswordChar = '•';
                conPass_eye.Image = Properties.Resources.eye_22;
            }
        }


        //REGISTER BUTTON (INSTRUCTOR)
        private void INS_signUp_Click(object sender, EventArgs e)
        {
            string Ins_name = INS_name.Text.Trim();
            string Ins_email = INS_email.Text.Trim();
            string Ins_phone = INS_phone.Text.Trim();
            string Ins_department = INS_department.Text.Trim();
            
            string password = INS_pass.Text;
            string confirmPassword = INS_cnfrm_pass.Text;

            //input & placeholder verification-->
            if (INS_name.Text == "" || INS_name.Text == "Enter Fullname" ||
                   INS_email.Text == "" || INS_email.Text == "Email" ||
                   INS_phone.Text == "" || INS_phone.Text == "Phone" ||
                   INS_department.Text == "" || INS_department.Text == "Department" ||

                   INS_pass.Text == "" || INS_pass.Text == "Enter Password" ||
                   INS_cnfrm_pass.Text == "" || INS_cnfrm_pass.Text == "Confirm Password")
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



            Instructor instructor = new Instructor
            {
                FullName = INS_name.Text.Trim(),
                Email = INS_email.Text.Trim(),
                Phone = INS_phone.Text.Trim(),
                Department = INS_department.Text.Trim(),
                Password = INS_pass.Text.Trim()
            };

          DBHelper.PendingINS(instructor);


           
        }
    }
}