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
    public partial class StudentResultSheet : Form
    {
        public StudentResultSheet()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LbYear_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTeachersHomeSRS_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksSRS_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksSRS_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteSRS_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnClassResultSheetSRS_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetSRS_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableSRS_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableSRS_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnAddTimetableSRS_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }
    }
}
