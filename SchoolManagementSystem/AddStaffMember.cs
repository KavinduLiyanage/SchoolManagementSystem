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
using System.Collections;

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

        private void AddOperation()
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


            cmd.CommandText = "INSERT INTO staff(memberType,accessLevel,fullName,name,gender,NIC,DOB,address,phoneNo,email,subject,pastSchool,serviceYears,salary,password,subject2) VALUES('" + memberTypeValue + "','" + accessLevelValue + "','" + NametextBox1.Text + "','" + nameTextBox2.Text + "','" + genderValue + "','" + NICTextBox.Text + "','" + dateTimePicker1.Value + "','" + addressTextBox.Text + "','" + phNoTextBox.Text + "','" + emailTextBox1.Text + "','" + subTextBox1.Text + "','" + pastSchTextBox.Text + "','" + Int32.Parse(serviceYrsTextBox.Text) + "','" + Convert.ToDouble(salaryTextBox.Text) + "','" + NICTextBox.Text + "','" + subTextBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dlgResult = MessageBox.Show("Do You Want To Add More Staff", "Staff Member Added Succesfully!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlgResult == DialogResult.Yes)
            {
                AddStaffMember addstaffMember = new AddStaffMember();
                this.Hide();
                addstaffMember.ShowDialog();
            }
            else
            {
                ViewStaffMembers viewStaff = new ViewStaffMembers();
                this.Hide();
                viewStaff.ShowDialog();
            }
        }
        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            string memberTypeValue = "";
            bool memberTypeisChecked = adedemicRadio.Checked;
            if (memberTypeisChecked)
            {
                memberTypeValue = adedemicRadio.Text;
            }
            else if(nonAcedemicRadio.Checked)
            {
                memberTypeValue = nonAcedemicRadio.Text;
            }

            string accessLevelValue = "";
            bool accessLevelisChecked = adminRadio.Checked;
            if (accessLevelisChecked)
                accessLevelValue = adminRadio.Text;
            else if(userRadio.Checked)
                accessLevelValue = userRadio.Text;

            string genderValue = "";
            bool genderisChecked = maleRadioButton2.Checked;
            if (genderisChecked)
                genderValue = maleRadioButton2.Text;
            else if(femaleRadioButton1.Checked)
                genderValue = femaleRadioButton1.Text;

            ArrayList errorArr1 = new ArrayList();

            Boolean memTypeCon = true;
            Boolean accessLevelCon = true;
            Boolean genderCon = true;
            Boolean fullNameCon = true;
            Boolean nameCon = true;
            Boolean nicCon = true;
            Boolean addCon = true;
            Boolean addressCon = true;
            Boolean salaryCon = true;
            Boolean phNoCon = true;
            Boolean mailCon = true;
            Boolean emailCheck = true;


            if (memberTypeValue.Equals(""))
            {
                memTypeCon = false;
                errorArr1.Add("Please Choose Member Type!");
            }

            if (accessLevelValue.Equals(""))
            {
                accessLevelCon = false;
                errorArr1.Add("Please Choose Member Type!");
            }

            if (NametextBox1.Text.Equals(""))
            {
                fullNameCon = false;
                errorArr1.Add("Please Enter Full Name!");
            }

            if (nameTextBox2.Text.Equals(""))
            {
                nameCon = false;
                errorArr1.Add("Please Enter Name with Initials!");
            }

            if (genderValue.Equals("")) {
                genderCon = false;
                errorArr1.Add("Please Choose a Gender!");
            }

            if (NICTextBox.Text.Equals("")) {
                nicCon = false;
                errorArr1.Add("Please Enter NIC Number!");
            }

            if (addressTextBox.Text.Equals(""))
            {
                addCon = false;
                errorArr1.Add("Please Enter Address!");
            }

            if (salaryTextBox.Text.Equals(""))
            {
                salaryCon = false;
                errorArr1.Add("Please Enter Salary!");
            }

            if (phNoTextBox.Text.Equals(""))
            {
                phNoCon = false;
                errorArr1.Add("Please Enter a Phone Number!");
            }

            if (emailTextBox1.Text.Equals(""))
            {
                mailCon = false;
                errorArr1.Add("Please Enter a Email Address!");
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(emailTextBox1.Text);
                emailCheck = addr.Address == emailTextBox1.Text;
            }
            catch
            {
                emailCheck = false;
            }
            if (!emailCheck) {
                errorArr1.Add("Enter Valid Email!");
            }
            

            string arrayStr = "";
            foreach (Object obj in errorArr1)
            {
                arrayStr = arrayStr +"\n"+ obj;
            }

            if (emailCheck && memTypeCon && accessLevelCon && genderCon && fullNameCon && nameCon && nicCon && addCon && addressCon && salaryCon && phNoCon && mailCon)
            {
                this.AddOperation();
            }
            else {
                MessageBox.Show(arrayStr);
            }
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void NametextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NameTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void NameTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NICTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void NICTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhNoTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ServiceYrsTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ServiceYrsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmailTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}