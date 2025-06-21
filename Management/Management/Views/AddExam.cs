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
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            //exam.IndexNumber = eIndex.Text;
            exam.StudentName = eSName.Text;
            exam.ExamName = eEName.Text;

            ExamController examController = new ExamController();
            examController.AddExam(exam);

            MessageBox.Show(" Added Successfully");

            eIndex.Text = "";
            eSName.Text = "";
            eEName.Text = "";

        }
    }
}
