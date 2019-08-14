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
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksGTT_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnAddMarksGTT_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            am.StartPosition = FormStartPosition.CenterScreen;
            am.ShowDialog();
        }

        private void BtnUpdateDeleteGTT_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            ud.StartPosition = FormStartPosition.CenterScreen;
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetGTT_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            stdRS.StartPosition = FormStartPosition.CenterScreen;
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetGTT_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            clzRS.StartPosition = FormStartPosition.CenterScreen;
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetGTT_Click(object sender, EventArgs e)
        {

            SectionResultSheet secRS = new SectionResultSheet();
            secRS.StartPosition = FormStartPosition.CenterScreen;
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableGTT_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }
    }
}
