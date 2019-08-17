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
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngStaffImgBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngExmBtn_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void MngExmImgBtn_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void MngResrceImgBtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome resMngHome = new ResourceManageHome();
            this.Hide();
            resMngHome.ShowDialog();
        }

        private void MngResrceBtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome resMngHome = new ResourceManageHome();
            this.Hide();
            resMngHome.ShowDialog();
        }
    }
}
