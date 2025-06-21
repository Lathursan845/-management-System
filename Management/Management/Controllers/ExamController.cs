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
    internal class ExamController
    {
        public void AddExam(Exam exam)
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Exams (IndexNumber, StudentName, ExamName) VALUES (@IndexNumber, @StudentName, @ExamName)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IndexNumber", exam.IndexNumber);
                    cmd.Parameters.AddWithValue("@StudentName", exam.StudentName);
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);


                }
            }
        }
    }
}
