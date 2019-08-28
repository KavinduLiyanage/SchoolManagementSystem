using System;
using System.Collections;
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
            cmd.CommandText = "delete from Classroom where ClassId='" + classid.Text + "'";
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
            cmd.CommandText = "update Classroom set ClassId = '" + classid.Text + "' ,ClassName = '"+classname.Text+"',ClassCapacity='"+capacity.Text+"'where ClassId='" + classid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Record Updated Successfully");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList array1 = new ArrayList();

            Boolean classidCon = true;
            Boolean classnameCon = true;
            Boolean gradeCon = true;
            Boolean capacityCon = true;

            if(classid.Text.Equals(""))
            {
                classidCon = false;
                array1.Add("Please Enter Class Id");
            }

            if (classname.Text.Equals(""))
            {
                classnameCon = false;
                array1.Add("Please Enter Class Name");
            }

            if (grade.Text.Equals(""))
            {
                gradeCon = false;
                array1.Add("Please Enter Grade");
            }

            if (capacity.Text.Equals(""))
            {
                capacityCon = false;
                array1.Add("Please Enter Class Capacity");
            }

            string arrayStr = "";
            foreach (Object obj in array1)
            {
                arrayStr = arrayStr + "\n" + obj;
            }

            if (classidCon && classnameCon && gradeCon && capacityCon )
            {
                this.insertOperation();
            }
            else
            {
                MessageBox.Show(arrayStr);
            }

        }

        private void insertOperation()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Classroom values('" + classid.Text + "','" + classname.Text + "','" + grade.Text + "','" + capacity.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            classid.Text = "";
            classname.Text = "";
            grade.Text = "";
            capacity.Text = "";
            display_details();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Classroom where ClassId = '" + classid.Text + "'";
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

        private void ResmngHome_Click(object sender, EventArgs e)
        {
            ResourceManageHome resmng = new ResourceManageHome();
            this.Hide();
            resmng.ShowDialog();
        }

        private void Addsubjectbtn_Click(object sender, EventArgs e)
        {
            ManageSubject addsub = new ManageSubject();
            this.Hide();
            addsub.ShowDialog();
        }

        private void Timetablebtn_Click(object sender, EventArgs e)
        {
            MngTimeTable mngtimetable = new MngTimeTable();
            this.Hide();
            mngtimetable.ShowDialog();
        }

        private void Viewtimetable_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            classid.Text = selectRow.Cells[0].Value.ToString();
            classname.Text = selectRow.Cells[1].Value.ToString();
            grade.Text = selectRow.Cells[2].Value.ToString();
            capacity.Text = selectRow.Cells[3].Value.ToString();
        }
    }
}
