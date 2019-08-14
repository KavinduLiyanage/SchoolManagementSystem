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
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksSRS_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnAddMarksSRS_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            am.StartPosition = FormStartPosition.CenterScreen;
            am.ShowDialog();
        }

        private void BtnUpdateDeleteSRS_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            ud.StartPosition = FormStartPosition.CenterScreen;
            ud.ShowDialog();
        }

        private void BtnClassResultSheetSRS_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            clzRS.StartPosition = FormStartPosition.CenterScreen;
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetSRS_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            secRS.StartPosition = FormStartPosition.CenterScreen;
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableSRS_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }

        private void BtnManageTimetableSRS_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            vtt.StartPosition = FormStartPosition.CenterScreen;
            vtt.ShowDialog();
        }
    }
}
