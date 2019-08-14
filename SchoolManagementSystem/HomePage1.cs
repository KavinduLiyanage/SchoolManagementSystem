using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage1 : Form
    {
        public HomePage1()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MngEvtImgBtn_Click(object sender, EventArgs e)
        {

        }

        private void MngStaffBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaff adminHome = new AdminMngStaff();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngStaffImgBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaff adminHome = new AdminMngStaff();
            this.Hide();
            adminHome.ShowDialog();
        }
    }
}
