using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoursesLibNS;

namespace WindowsFormsAppProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCourseNameButton_Click(object sender, EventArgs e)
        {
            CoursesLibClass course = new CoursesLibClass();

            courseNameLabel.Text = course.ShowCourseName(int.Parse(codeCourseTextBox.Text));
        }

        private void showMsgBox(object sender, EventArgs e)
        {
            MessageBox.Show("Teste", "Nome do curso: ");
        }
    }
}