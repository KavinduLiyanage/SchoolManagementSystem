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
    public partial class LibraryAddBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public LibraryAddBook()
        {
            InitializeComponent();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
            con.Close();
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox8.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = "";


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
