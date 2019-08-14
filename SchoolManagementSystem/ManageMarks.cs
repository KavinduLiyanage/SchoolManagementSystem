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
    public partial class ManageMarks : Form
    {
        public ManageMarks()
        {
            InitializeComponent();
        }

        private void BtnAddMarks_Click(object sender, EventArgs e)
        {

            AddMarks addMarks = new AddMarks();
            addMarks.StartPosition = FormStartPosition.CenterScreen;
            addMarks.ShowDialog();
        }

        private void BtnTeachersHomeM_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnAddTimetableM_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDeleteUpdate_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            ud.StartPosition = FormStartPosition.CenterScreen;
            ud.ShowDialog();
        }

        private void BtnUpdateTimeTable_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }

        private void BtnRSstudent_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            stdRS.StartPosition = FormStartPosition.CenterScreen;
            stdRS.ShowDialog();
        }

        private void BtnRSclass_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            clzRS.StartPosition = FormStartPosition.CenterScreen;
            clzRS.ShowDialog();

        }

        private void BtnRSsection_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            secRS.StartPosition = FormStartPosition.CenterScreen;
            secRS.ShowDialog();
        }

        private void BtnDeleteTimetableM_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }

        private void BtnManageTimetableM_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            vtt.StartPosition = FormStartPosition.CenterScreen;
            vtt.ShowDialog();
        }
    }
}
