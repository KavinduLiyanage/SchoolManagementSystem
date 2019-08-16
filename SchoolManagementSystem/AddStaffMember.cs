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
    public partial class AddStaffMember : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public AddStaffMember()
        {
            InitializeComponent();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 home = new HomePage1();
            this.Hide();
            home.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NonAcedemicRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo newViewSalary = new ViewSalaryInfo();
            this.Hide();
            newViewSalary.ShowDialog();
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            ViewStaffMembers newviewstaff = new ViewStaffMembers();
            this.Hide();
            newviewstaff.ShowDialog();
        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaffMember newStaffPage = new AddStaffMember();
            this.Hide();
            newStaffPage.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves newStffLeave = new ViewStaffLeaves();
            this.Hide();
            newStffLeave.ShowDialog();
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            string memberTypeValue = "";
            bool memberTypeisChecked = adedemicRadio.Checked;
            if (memberTypeisChecked)
            {
                memberTypeValue = adedemicRadio.Text;
            }
            else
            {
                memberTypeValue = nonAcedemicRadio.Text;
            }

            string accessLevelValue = "";
            bool accessLevelisChecked = adminRadio.Checked;
            if (accessLevelisChecked)
                accessLevelValue = adminRadio.Text;
            else
                accessLevelValue = userRadio.Text;

            string genderValue = "";
            bool genderisChecked = maleRadioButton2.Checked;
            if (genderisChecked)
                genderValue = maleRadioButton2.Text;
            else
                genderValue = femaleRadioButton1.Text;


            cmd.CommandText = "INSERT INTO staff(memberType,accessLevel,fullName,name,gender,NIC,DOB,address,phoneNo,email,subject,pastSchool,serviceYears,salary,password) VALUES('" + memberTypeValue + "','" + accessLevelValue + "','" + NametextBox1.Text + "','" + nameTextBox2.Text + "','" + genderValue + "','" + NICTextBox.Text + "','" + dateTimePicker1.Value + "','"+ addressTextBox.Text +"','"+ phNoTextBox.Text +"','"+ emailTextBox1.Text +"','"+ subTextBox1.Text +"','"+ pastSchTextBox.Text +"','"+ Int32.Parse(serviceYrsTextBox.Text) +"','"+ Convert.ToDouble(salaryTextBox.Text)+ "','"+ NICTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dlgResult = MessageBox.Show("Do You Want To Add More Staff", "Staff Member Added Succesfully!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlgResult == DialogResult.Yes)
            {
                AddStaffMember addstaffMember = new AddStaffMember();
                this.Hide();
                addstaffMember.ShowDialog();
            }
            else {
                ViewStaffMembers viewStaff = new ViewStaffMembers();
                this.Hide();
                viewStaff.ShowDialog();
            }
        }
    }
}
//Asani Akkatata Pissu