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
    public partial class ViewTimetable : Form
    {
        public ViewTimetable()
        {
            InitializeComponent();
        }

        private void BtnTeachersHomeGTT_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksGTT_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksGTT_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteGTT_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetGTT_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetGTT_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetGTT_Click(object sender, EventArgs e)
        {

            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableGTT_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnAddTimetableGTT_Click(object sender, EventArgs e)
        {
            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }
    }
}
