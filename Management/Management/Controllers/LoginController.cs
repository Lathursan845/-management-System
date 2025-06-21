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
    internal class LoginController
    {
        public void AddLogin(Login login)
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Logins (UserName,Password) VALUES (@UserName,Password)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", login.UserName);
                    cmd.Parameters.AddWithValue("@Password", login.Password);



                }
            }
        }
    }
}
