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
    internal class UserController
    {
        public void AddUser(User user)
        {
            using (SQLiteConnection conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Users (UserName, Role, PhoneNumber,Email,Password) VALUES (@UserName, @Role, @PhoneNumber,@Email,@Password)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);


                }
            }
        }
    }
}
