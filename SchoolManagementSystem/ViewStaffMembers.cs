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
            else {
                nonAcedemicRadio.Checked = true;
            }
            string accLvl = selectRow.Cells[2].ToString();

            if (accLvl.Equals("Admin"))
            {
                adminRadio.Checked = true;
            }
            else
            {
                userRadio.Checked = true;
            }
        }
    }
}
