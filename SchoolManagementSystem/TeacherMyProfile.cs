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
    public partial class TeacherMyProfile : Form
    {
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
    }
}
