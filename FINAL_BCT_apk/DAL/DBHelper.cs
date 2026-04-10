using FINAL_BCT_apk.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_BCT_apk.DAL
{
    public class DBHelper
    {
        //DATABASE CONNECTION--->
        private static MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;" +
                             "port=3306;" +
                             "database=BCT_db;" +
                             "user=root;" +
                             "password=;";
            return new MySqlConnection(connStr);
        }//<----

        //--------------------------------------------------------------------LOGIN--------------------------------------------------------------------//

        //GET STUDENT INFO FOR LOGIN--->
        public static Student GetStudent(string Student_id, string Password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT student_id, full_name, password FROM inputs WHERE student_id=@student_id AND password=@password";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@student_id", Student_id);
                    cmd.Parameters.AddWithValue("@password", Password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                Student_id = reader.GetString("student_id"),
                                Full_name = reader.GetString("full_name")
                            };
                        }
                        return null;
                    }
                }
            }
        }

        //----------------------------------------------------REGISTRATION-------------------------------------------------------------------------------//


        //ADD STUDENT INFO TO DATABASE--->
        public static bool AddStudent(Student student)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                //ID UNIQUENESS CHEKER--->
                string checkSql = "SELECT COUNT(*) FROM inputs WHERE student_id = @studentId";
                using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@studentId", student.Student_id);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Student ID already exists!");
                        return false;
                    }
                }//<----

                //INSERTING STUDENT INFO TO DATABASE--->
                string sql = "INSERT INTO inputs (student_id, full_name, course_id, year_level, password) VALUES (@student_id, @full_name, @course_id, @year_level, @password)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@student_id", student.Student_id);
                    cmd.Parameters.AddWithValue("@full_name", student.Full_name);
                    cmd.Parameters.AddWithValue("@course_id", student.Course_id);
                    cmd.Parameters.AddWithValue("@year_level", student.Year_level);
                    cmd.Parameters.AddWithValue("@password", student.Password);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //-------------------------------------------LOAD COURSES TO THE COMBOBOX FROM THE COURSES TABLW (SUPER ADMIN)-------------------------------------------------------//


        //GET COURSES FROM SUPER ADMIN TABLE
        public static List<Courses> GetCourse()
        {
            List<Courses> courseList = new List<Courses>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT id, course_name FROM courses ORDER BY course_name";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // loop through each row
                        {
                            courseList.Add(new Courses
                            {
                                Id = reader.GetInt32("id"),
                                Course_name = reader.GetString("course_name")
                            });
                        }
                    }
                }
            }
            return courseList;
        }


        //----------------------------------------------------REGISTRATION, PENDING INS-------------------------------------------------------------------------------//



        public static bool PendingINS(Instructor instructor)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    string query = @"INSERT INTO pendinginstructor (FullName, Email, Phone, Department, Password) 
                             VALUES (@name, @email, @phone, @department, @password)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", instructor.FullName);
                    cmd.Parameters.AddWithValue("@email", instructor.Email);
                    cmd.Parameters.AddWithValue("@phone", instructor.Phone);
                    cmd.Parameters.AddWithValue("@department", instructor.Department);
                    cmd.Parameters.AddWithValue("@password", instructor.Password);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration submitted! Awaiting admin approval.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true; 
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("That email is already registered.", "Duplicate",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Database error: " + ex.Message);

                return false;  
            }
        }








    }
}
