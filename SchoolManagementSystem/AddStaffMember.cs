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
    public partial class AddStaffMember : Form
    {
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
    }
}
