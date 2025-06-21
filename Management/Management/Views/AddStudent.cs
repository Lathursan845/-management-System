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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Management.Views
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentName = sName.Text;
            student.UTNumber = sUT.Text;
            //student.PhoneNumber = sNum.Text;
            student.Email = sEmail.Text;
            student.Password = sPassword.Text;

            StudentController studentController = new StudentController();
            studentController.AddStudent(student);

            MessageBox.Show("Student Added Successfully");

            sName.Text = "";
            sUT.Text = "";
            sNum.Text = "";
            sEmail.Text = "";
            sPassword.Text ="";

        }
    }
}
