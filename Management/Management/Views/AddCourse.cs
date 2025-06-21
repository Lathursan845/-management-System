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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.CourseName= cName.Text;
            course.CourseDuration= cDuration.Text;
            course.CourseDescription= cDescription.Text;

            CourseController courseController= new CourseController();
            courseController.AddCourse(course);

            MessageBox.Show("Course Added Successfully");

            cName.Text = "";
            cDuration.Text="";
            cDescription.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
