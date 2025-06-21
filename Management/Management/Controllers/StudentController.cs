using Management.Data;
using Management.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Controllers
{
    internal class StudentController
    {
        public void AddStudent(Student student)
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Students (StudentName, UTNumber, PhoneNumber,Email,Password) VALUES (@StudentName,@UTNumber,@PhoneNumber,@EMail,@Password)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                    cmd.Parameters.AddWithValue("@ UTNumber", student.UTNumber);
                    cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email",   student.Email);
                    cmd.Parameters.AddWithValue("@Password", student.Password);



                }
            }
        }
    }
}


