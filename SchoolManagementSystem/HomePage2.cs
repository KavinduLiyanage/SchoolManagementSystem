using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage2 : Form
    {
        public HomePage2()
        {
            InitializeComponent();
        }

        private void HomePage2_Load(object sender, System.EventArgs e)
        {

        }

        private void ReqLeaveImgBtn_Click(object sender, System.EventArgs e)
        {
            StaffReqLeave reqLeave = new StaffReqLeave();
            this.Hide();
            reqLeave.ShowDialog();
        }

        private void ReqLeaveBtn_Click(object sender, System.EventArgs e)
        {
            StaffReqLeave reqLeave = new StaffReqLeave();
            this.Hide();
            reqLeave.ShowDialog();
        }

        private void MngStaffBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void MngStaffImgBtn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
