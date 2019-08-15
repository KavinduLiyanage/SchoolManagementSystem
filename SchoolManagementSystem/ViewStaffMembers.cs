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
    public partial class ViewStaffMembers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public ViewStaffMembers()
        {
            InitializeComponent();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 home = new HomePage1();
            this.Hide();
            home.ShowDialog();
        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaffMember newStaffPage = new AddStaffMember();
            this.Hide();
            newStaffPage.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            ViewStaffMembers newViewStaff = new ViewStaffMembers();
            this.Hide();
            newViewStaff.ShowDialog();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo newViewSalary = new ViewSalaryInfo();
            this.Hide();
            newViewSalary.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves newStffLeave = new ViewStaffLeaves();
            this.Hide();
            newStffLeave.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where name like '%"+ searchTextBox1.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ViewStaffMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementSystemDBDataSet1.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.schoolManagementSystemDBDataSet1.staff);

        }

        private void NonAcedemicRadio_CheckedChanged(object sender, EventArgs e)
        {
            //nonAcedemicRadio
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            int staffID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            string memType = selectRow.Cells[1].Value.ToString();

            if (memType.Equals("Acedemic"))
            {
                adedemicRadio.Checked = true;
            }
            else if (memType.Equals("Non-Acedemic"))
            {
                nonAcedemicRadio.Checked = true;
            }
            string accLvl = selectRow.Cells[2].Value.ToString();

            if (accLvl.Equals("Admin"))
            {
                adminRadio.Checked = true;
            }
            else if (accLvl.Equals("User"))
            {
                userRadio.Checked = true;
            }

            NametextBox1.Text = selectRow.Cells[3].Value.ToString();
            nameTextBox2.Text = selectRow.Cells[4].Value.ToString();

            string gender = selectRow.Cells[5].Value.ToString();

            if (gender.Equals("Male"))
            {
                maleRadioButton2.Checked = true;
            }
            else if (gender.Equals("Female"))
            {
                femaleRadioButton1.Checked = true;
            }

            NICTextBox.Text = selectRow.Cells[6].Value.ToString();

            string date = selectRow.Cells[7].Value.ToString();
            try
            {
                DateTime oDate = Convert.ToDateTime(date);
                dateTimePicker1.Value = new System.DateTime(oDate.Year, oDate.Month, oDate.Day, 0, 0, 0, 0);
            }
            catch (Exception) {
                DateTime newdate = DateTime.Now;
                dateTimePicker1.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
            }

            addressTextBox.Text = selectRow.Cells[8].Value.ToString();
            phNoTextBox.Text = selectRow.Cells[9].Value.ToString();
            emailTextBox1.Text = selectRow.Cells[10].Value.ToString();
            subTextBox1.Text = selectRow.Cells[11].Value.ToString();
            pastSchTextBox.Text = selectRow.Cells[12].Value.ToString();
            serviceYrsTextBox.Text = selectRow.Cells[13].Value.ToString();
            salaryTextBox.Text = selectRow.Cells[15].Value.ToString();


            pwdtextBox2.Text = selectRow.Cells[16].Value.ToString();
            ConfirmPwdtextBox2.Text = selectRow.Cells[16].Value.ToString();
        }

        private void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where name like '%" + searchTextBox1.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void SearchTextBox1_Click(object sender, EventArgs e)
        {
            searchTextBox1.Text = "";
            searchTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }
    }
}
