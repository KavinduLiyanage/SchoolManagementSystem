using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class AcadNotice_board : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public AcadNotice_board()
        {
            InitializeComponent();
        }

        public void Display_Data()
        {
            conn.Open();
            SqlCommand cmd= conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Published Date] ,[Details]  from Notices where [Category] ='Academic'  ORDER BY [Notice Id] DESC";
            
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void AcadNotice_board_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Notice_Dashboard form_back = new Notice_Dashboard();
            this.Hide();
            form_back.Show();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
