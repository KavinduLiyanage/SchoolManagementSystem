using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // tbTimeTablID.Text = getIncrTimetblId();
            var boxes = Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the Required fields!!!");
                    return;
                }
                else if (cbTerm.Text == "")
                {
                    errorProvider1.SetError(cbTerm, "Please fill empty filelds");
                    return;
                }

                else
                {
                    errorProvider1.Clear();
                }
            }

            SqlCommand check = new SqlCommand("SELECT * FROM ExamTimeTable WHERE Grade = '" + cbGrade.Text + "' AND Subject = '" + cbSubject.Text + "' AND Term = '" + cbTerm.Text + "' AND Date =  '" + dateTimePicker1.Value + "' AND StartTime = '" + tbStartTime.Text + "' ", con);
            SqlDataAdapter checkDa = new SqlDataAdapter(check);
            DataSet ds = new DataSet();
            checkDa.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                errorProvider1.SetError(cbTerm, "This already Exist!!!!");
                errorProvider1.SetError(dateTimePicker1, "This already Exist!!!!");
                errorProvider1.SetError(tbStartTime, "This already Exist!!!!");
                errorProvider1.SetError(cbGrade, "This already Exist!!!!");
                errorProvider1.SetError(cbSubject, "This already Exist!!!!");


                MessageBox.Show("This already Exist!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // con.Close();
            }
            if (tbStartTime.Text == "")
            {
                errorProvider1.SetError(tbStartTime, "please fill required areas!!");
            }

            else
            {
                errorProvider1.Clear();



                try
                {


                    string qry = "INSERT INTO ExamTimeTable(Term,Date,StartTime,EndTime,Grade,Subject,ClassName) VALUES('" + cbTerm.Text + "',  '" + dateTimePicker1.Value + "','" + tbStartTime.Text + "','" + tbStartTime.Text + "','" + cbGrade.Text + "','" + cbSubject.Text + "','" + tbClass.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted successfully!!");
                    // con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                tbTimeTablID.Text = "";
                // cbTerm.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
                tbStartTime.Text = "";
                tbEndTime.Text = "";
                cbGrade.SelectedIndex = -1;
                cbSubject.SelectedIndex = -1;
                displayData();
            }
        }

        /*public String getIncrTimetblId()
        {
            string query = "SELECT COUNT(*) FROM ExamTimeTable";
            SqlCommand cmd2 = new SqlCommand(query, con);
            //con.Open();
            int t = 10001 + (Int32)cmd2.ExecuteScalar();
            String TimetableID = "T" + t.ToString();
            //con.Close();
            return TimetableID;

        }*/

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayData()
        {
            try
            {
                //con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ExamTimeTable  ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewTimeTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // con.Close();
            }

        }

        void FillGradeCombo()
        {
            DataSet ds = new DataSet();
            try
            {

                string query = "select distinct grade from classroom ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                //con.Open();

                da.Fill(ds);
                cbGrade.DataSource = ds.Tables[0];
                cbGrade.DisplayMember = "grade";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                //con.Close();
            }
        }

        void FillSubjectCombo()
        {
            //TYP 01 fill combo box...get data from db
            cbSubject.Items.Clear();

            DataSet ds = new DataSet();
            try
            {

                string query = "select * from Subject";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                //con.Open();

                da.Fill(ds);

                cbSubject.DataSource = ds.Tables[0];
                cbSubject.DisplayMember = "SubjectName";
                cbSubject.ValueMember = "SubjectID";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // con.Close();
            }

        }

        private void AddTimetable_Load(object sender, EventArgs e)
        {
            FillGradeCombo();
            FillSubjectCombo();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void TbTimeTablID_TextChanged(object sender, EventArgs e)
        {
            //tbTimeTablID.ReadOnly = true;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            AddTimetable newAddTT = new AddTimetable();
            this.Hide();
            newAddTT.ShowDialog();
        }
    }
}
