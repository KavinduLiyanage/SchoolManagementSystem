using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string text = unTxtBox.Text;

            if (text.Equals("1"))
            {
                HomePage1 Page1 = new HomePage1();
                this.Hide();
                Page1.Show();
            }
            else if (text.Equals("2"))
            {
                HomePage2 Page2 = new HomePage2();
                this.Hide();
                Page2.Show();
            }
            else if (text.Equals("3"))
            {
                HomePage3 Page3 = new HomePage3();
                this.Hide();
                Page3.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}