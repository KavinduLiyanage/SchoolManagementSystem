using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class MngClassRoom : Form
    {
       

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManegementSystemDB;Integrated Security=True");
        public MngClassRoom()
        {
            InitializeComponent();
            display_details();
        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Classroom where ClassId='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Classroom set ClassId = '" + textBox1.Text + "' ,ClassName = '"+textBox2.Text+"',ClassCapacity='"+textBox3.Text+"'where ClassId='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Record Updated Successfully");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Classroom values('" + textBox1.Text + "','" + textBox2.Text + "','"+ comboBox1.Text + "','"+textBox3.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            display_details();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Classroom where ClassId = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
     
        }

        public void display_details()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Classroom";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
