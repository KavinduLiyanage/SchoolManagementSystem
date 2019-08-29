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
    public partial class MngTimeTable : Form
    {
        public MngTimeTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resmngbtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome openForm = new ResourceManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addsubbtn_Click(object sender, EventArgs e)
        {
            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addclassbtn_Click(object sender, EventArgs e)
        {
           MngClassRoom openForm = new MngClassRoom();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Viewtimetablebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }
    }
}
