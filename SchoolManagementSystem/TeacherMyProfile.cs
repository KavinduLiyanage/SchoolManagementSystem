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
    public partial class TeacherMyProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public TeacherMyProfile()
        {
            InitializeComponent();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {

        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            TeacherMyProfile tchrProfile = new TeacherMyProfile();
            this.Hide();
            tchrProfile.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage2 newHome = new HomePage2();
            this.Hide();
            newHome.ShowDialog();
        }

        private void TeacherMyProfile_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = LoginInfo.userName;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where staffID = '"+LoginInfo.getsetusrId+"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                linkLabel1.Text = dr["name"].ToString();
                NametextBox1.Text = dr["fullName"].ToString();
                nameTextBox2.Text = dr["name"].ToString();

                string gender = dr["gender"].ToString();

                if (gender.Equals("Male"))
                {
                    maleRadioButton2.Checked = true;
                }
                else if (gender.Equals("Female"))
                {
                    femaleRadioButton1.Checked = true;
                }

                NICTextBox.Text = dr["NIC"].ToString();

                string date = dr["DOB"].ToString();
                try
                {
                    DateTime oDate = Convert.ToDateTime(date);
                    dateTimePicker1.Value = new System.DateTime(oDate.Year, oDate.Month, oDate.Day, 0, 0, 0, 0);
                }
                catch (Exception)
                {
                    DateTime newdate = DateTime.Now;
                    dateTimePicker1.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
                }

                addressTextBox.Text = dr["address"].ToString();
                phNoTextBox.Text = dr["phoneNo"].ToString();
                emailTextBox1.Text = dr["email"].ToString();
                subTextBox1.Text = dr["subject"].ToString();
                pastSchTextBox.Text = dr["pastSchool"].ToString();
                serviceYrsTextBox.Text = dr["serviceYears"].ToString();
                salaryTextBox.Text = dr["salary"].ToString();
                subTextBox2.Text = dr["subject2"].ToString();
            }

        }
    }
}
