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
    public partial class AddMarks : Form
    {
        public AddMarks()
        {
            InitializeComponent();
        }

        private void AddMarks_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LbMarks_Click(object sender, EventArgs e)
        {

        }

        private void LbExam_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TbSubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateTimetableA_Click(object sender, EventArgs e)
        {

        }

        private void BtnTeachersHomeA_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksA_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BtnUpdateDeleteMarksA_Click(object sender, EventArgs e)
        {

            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultsheetA_Click(object sender, EventArgs e)
        {

            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClassResultSheetA_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetA_Click(object sender, EventArgs e)
        {

            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateDeleteTimetableA_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableA_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnAddTimetableA_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
