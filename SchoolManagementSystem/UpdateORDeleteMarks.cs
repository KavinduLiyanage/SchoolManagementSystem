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
    public partial class UpdateORDeleteMarks : Form
    {
        public UpdateORDeleteMarks()
        {
            InitializeComponent();
        }

        private void UpdateORDeleteMarks_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddMarksUD_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            am.StartPosition = FormStartPosition.CenterScreen;
            am.ShowDialog();
        }

        private void BtnTeachersHomeUD_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksUD_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnUpdateDeleteTimetableA_Click(object sender, EventArgs e)
        {

        }

        private void BtnStudentResultSheetUD_Click(object sender, EventArgs e)
        {

        }

        private void BtnTeachersHomeUD_Click_1(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksUD_Click_1(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnAddMarksUD_Click_1(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            am.StartPosition = FormStartPosition.CenterScreen;
            am.ShowDialog();
        }

        private void BtnStudentResultSheetUD_Click_1(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            stdRS.StartPosition = FormStartPosition.CenterScreen;
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetUD_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            clzRS.StartPosition = FormStartPosition.CenterScreen;
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetUD_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            secRS.StartPosition = FormStartPosition.CenterScreen;
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableUD_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }

        private void BtnManageTimetableUD_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            vtt.StartPosition = FormStartPosition.CenterScreen;
            vtt.ShowDialog();
        }
    }
}
