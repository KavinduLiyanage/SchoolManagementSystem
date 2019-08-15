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
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksUD_Click_1(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksUD_Click_1(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnStudentResultSheetUD_Click_1(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetUD_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetUD_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableUD_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableUD_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnAddTimetableUD_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }
    }
}
