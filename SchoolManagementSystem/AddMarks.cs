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
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksA_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BtnUpdateDeleteMarksA_Click(object sender, EventArgs e)
        {

            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            ud.StartPosition = FormStartPosition.CenterScreen;
            ud.ShowDialog();
        }

        private void BtnStudentResultsheetA_Click(object sender, EventArgs e)
        {

            StudentResultSheet stdRS = new StudentResultSheet();
            stdRS.StartPosition = FormStartPosition.CenterScreen;
            stdRS.ShowDialog();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClassResultSheetA_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            clzRS.StartPosition = FormStartPosition.CenterScreen;
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetA_Click(object sender, EventArgs e)
        {

            SectionResultSheet secRS = new SectionResultSheet();
            secRS.StartPosition = FormStartPosition.CenterScreen;
            secRS.ShowDialog();
        }

        private void BtnUpdateDeleteTimetableA_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }

        private void BtnManageTimetableA_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            vtt.StartPosition = FormStartPosition.CenterScreen;
            vtt.ShowDialog();
        }
    }
}
