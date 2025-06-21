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
using System.Xml.Linq;

namespace Management.Views
{
    public partial class AddMark : Form
    {
        public AddMark()
        {
            InitializeComponent();
        }

        private void eIndex_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marks mark = new Marks();
            //mark.IndexNumber = lathu.Text;
            mark.ExamMarks = mMarks.Text;
            mark.StudentName = mStudent.Text;

            MarkController markController = new MarkController();
            markController.AddMarks(mark);

            MessageBox.Show("Course Added Successfully");

            lathu.Text = "";
            mMarks.Text = "";
            mStudent.Text = "";
        }
    }
}
