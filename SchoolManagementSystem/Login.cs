using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void getUserData() {
            string name;
            string accessLevel;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT name,accessLevel FROM STAFF WHERE NIC = '" + unTxtBox.Text + "' AND password = '" + pwdTxtBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1) {
                foreach (DataRow dr in dt.Rows)
                {
                    name = dr["name"].ToString();
                    accessLevel = dr["accessLevel"].ToString();
                    MessageBox.Show(name + "\n" + accessLevel);
                }
            }
            con.Close();
        }   

        private void Button1_Click(object sender, EventArgs e)
        {

            string text = unTxtBox.Text;
            this.getUserData();

            if (text.Equals("1"))
            {
                HomePage1 Page1 = new HomePage1();
                this.Hide();
                Page1.ShowDialog();
            }
            else if (text.Equals("2"))
            {
                HomePage2 Page2 = new HomePage2();
                this.Hide();
                Page2.ShowDialog();
            }
            else if (text.Equals("3"))
            {
                HomePage3 Page3 = new HomePage3();
                this.Hide();
                Page3.ShowDialog();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}