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
    internal class MarkController
    {
        public void AddMarks(Marks mark)
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Courses (IndexNumber, Marks, StudentName) VALUES (@IndexNumber, @Marks, @StudentName)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IndexNumber", mark.IndexNumber);
                    cmd.Parameters.AddWithValue("@Marks", mark.ExamMarks);
                    cmd.Parameters.AddWithValue("@StudentName", mark.StudentName);


                }
            }

        }
    }
}
