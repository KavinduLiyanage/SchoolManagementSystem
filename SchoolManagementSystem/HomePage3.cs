using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage3 : Form
    {
        public HomePage3()
        {
            InitializeComponent();
        }

        private void HomePage3_Load(object sender, System.EventArgs e)
        {

        }

        private void DomainUpDown1_SelectedItemChanged(object sender, System.EventArgs e)
        {

        }

        private void MngExmBtn_Click(object sender, System.EventArgs e)
        {
            StudentExam seh = new StudentExam();
            this.Hide();
            seh.ShowDialog();
        }

        private void MngLibImgBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void MngLibBtn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
