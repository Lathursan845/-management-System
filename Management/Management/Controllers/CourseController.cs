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
    internal class CourseController
    {


        /*public List<Course> GetAllCourse()
        {
            var course = new List<Course>();    

            using(var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FORM course ",conn);
                var reader =cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course Course = new Course
                    {
                        Id=reader.GetInt32()
                    };
                }
            }
        }*/
        public void AddCourse(Course course)
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Courses (CourseName, CourseDuration, CourseDescription) VALUES (@CourseName, @CourseDuration, @CourseDescription)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                    cmd.Parameters.AddWithValue("@CourseDuration", course.CourseDuration);
                    cmd.Parameters.AddWithValue("@CourseDescription", course.CourseDescription);

                    
                }
            }
        }
    }
}
