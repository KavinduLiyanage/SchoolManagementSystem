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
    public partial class DeleteStatus : Form
    {
        public DeleteStatus(string code,string name,string cat)
        {
            InitializeComponent();
            code1Text.Text = code;
            name1Box.Text = name;
            catBox1.Text = cat;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Are you sure to delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgresult == DialogResult.Yes) {
                SqlConnection con = new SqlConnection("Data Source=msi\\sqlexpress;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO[dbo].[DeletedStatus] VALUES('" +code1Text.Text + "','" + name1Box.Text + "','" + catBox1.Text + "','" + richDiscription.Text + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "delete from [dbo].[stockTable] where [ItemCode]='"+Int32.Parse(code1Text.Text)+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();


            }
        }
    }
}
