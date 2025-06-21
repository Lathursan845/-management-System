using Management.Controllers;
using Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.Views
{
    public partial class AddLogin : Form
    {
        public AddLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.UserName = lName.Text;
            login.Password = lPassword.Text;


            LoginController loginController = new LoginController();
            loginController.AddLogin(login);

            MessageBox.Show("Login Successfully");

            lName.Text = "";
            lPassword.Text = "";
            
        }

        private void AddLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
