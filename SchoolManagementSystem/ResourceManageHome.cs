using SchoolManagementSystem;
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
    public partial class ResourceManageHome : Form
    {
        public ResourceManageHome()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MngClassRoom openForm = new MngClassRoom();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MngTimeTable openForm = new MngTimeTable();
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

        private void Timetablebtn_Click(object sender, EventArgs e)
        {
            MngTimeTable openForm = new MngTimeTable();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Viewtimetablebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
