﻿using System.Windows.Forms;

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

        private void MngNticeBtn_Click(object sender, System.EventArgs e)
        {
            userNoticeView Unv = new userNoticeView();
            this.Hide();
            Unv.ShowDialog();
        }

        private void MngStuImgBtn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
