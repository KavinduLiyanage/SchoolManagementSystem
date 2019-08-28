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
    public partial class UpdateOrDeleteTimetable : Form
    {
        public UpdateOrDeleteTimetable()
        {
            InitializeComponent();
        }

        private void BtnTeachersHomeUDTT_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksUDTT_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksUDTT_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteUDTT_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetUDTT_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetUDTT_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetUDTT_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableUDTT_Click(object sender, EventArgs e)
        {
            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void BtnGetTimetableUDTT_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnViewUDTT_Click(object sender, EventArgs e)
        {
            ViewTimetable viewtble = new ViewTimetable();
            this.Hide();
            viewtble.ShowDialog();
        }

        private void UpdateOrDeleteTimetable_Load(object sender, EventArgs e)
        {
            
        }
    }
}
