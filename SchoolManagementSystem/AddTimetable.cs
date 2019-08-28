using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class AddTimetable : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public AddTimetable()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LbTimeATT_Click(object sender, EventArgs e)
        {

        }

        private void BtnTeachersHomeATT_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksATT_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnUpdateDeleteATT_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetATT_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetATT_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }


        private void BtnSectionResultSheetATT_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnAddMarksATT_Click(object sender, EventArgs e)
        {

            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateTimetableATT_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnGetTimetableATT_Click(object sender, EventArgs e)
        {
            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnInsertATT_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry = "INSERT INTO ExamTimeTable(Term,Date,Time,Grade,Subject) VALUES('" + cbTerm.Text + "',  '" + dateTimePicker1.Value + "','" + tbTime.Text + "','" + cbGrade.Text + "','" + cbSubject.Text + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted successfully!!");
            con.Close();
        }

        private void AddTimetable_Load(object sender, EventArgs e)
        {
           // if (con.State == ConnectionState.Open)
           // {
            //    con.Close();
           // }
         //   con.Open();
       }

        public String getIncrTimetblId()
        {
            string query = "SELECT COUNT(*) FROM SExamTimeTable";
            SqlCommand cmd2 = new SqlCommand(query, con);
            //con.Open();
            int t = 10001 + (Int32)cmd2.ExecuteScalar();
            String TId = "T" + t.ToString();
            //con.Close();
            return TId;

        }
    }
}
