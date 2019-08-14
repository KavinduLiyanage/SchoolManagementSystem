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
    public partial class SectionResultSheet : Form
    {
        public SectionResultSheet()
        {
            InitializeComponent();
        }

        private void BtnTeachersHomeCRS_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksCRS_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnAddMarksCRS_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            am.StartPosition = FormStartPosition.CenterScreen;
            am.ShowDialog();
        }

        private void BtnUpdateDeleteCRS_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            ud.StartPosition = FormStartPosition.CenterScreen;
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetCRS_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            stdRS.StartPosition = FormStartPosition.CenterScreen;
            stdRS.ShowDialog();

        }

        private void BtnClassResultSheetCRS_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            clzRS.StartPosition = FormStartPosition.CenterScreen;
            clzRS.ShowDialog();
        }

        private void BtnUpdateTimetableCRS_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            udtt.StartPosition = FormStartPosition.CenterScreen;
            udtt.ShowDialog();
        }

        private void BtnManageTimetableCRS_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            vtt.StartPosition = FormStartPosition.CenterScreen;
            vtt.ShowDialog();
        }
    }
}
