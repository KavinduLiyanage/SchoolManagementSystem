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
    public partial class TeachersHome : Form
    {
        public TeachersHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnManageMarks_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btntimetable_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnTeachersHomeTH_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksTH_Click(object sender, EventArgs e)
        {

            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteTH_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetTH_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetTH_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetTH_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnGetTimetableTH_Click(object sender, EventArgs e)
        {
            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnUpdateTimetableTH_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
