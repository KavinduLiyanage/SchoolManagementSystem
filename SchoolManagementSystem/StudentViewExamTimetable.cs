using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StudentViewExamTimetable : Form
    {
        public StudentViewExamTimetable()
        {
            InitializeComponent();
        }

        private void BtnStudentHomeETT_Click(object sender, EventArgs e)
        {
            StudentExam seh = new StudentExam();
            this.Hide();
            seh.ShowDialog();
        }

        private void BtnStudentHome_Click(object sender, EventArgs e)
        {
            HomePage3 hp3 = new HomePage3();
            this.Hide();
            hp3.ShowDialog();
        }
    }
}
