﻿using System;
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
    public partial class IssueBook : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public IssueBook()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where SNAME='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i ==0)
            {
                MessageBox.Show("This Name is not found");

            }
            else
            {
                foreach(DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["Grade"].ToString();
                    textBox3.Text = dr["ClassName"].ToString();
                    textBox4.Text = dr["SGDCONTACT"].ToString();
                    textBox5.Text = dr["SADDRESS"].ToString();




                }
            }
        }

        private void TextBox6_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            if (e.KeyCode != Keys.Enter)
            {

                listBox1.Items.Clear();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%" + textBox6.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {

                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"].ToString());
                    }
                }
            }
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void ListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox6.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into book_issue (SNAME,Grade,ClassName,SGDCONTACT,SADDRESS,books_name,book_issue_date) values('" + textBox1.Text +"','" +textBox2.Text +"','" +textBox3.Text +"','" +textBox4.Text +"','" +textBox5.Text +"','" +textBox6.Text +"','" +dateTimePicker1.Value.ToShortDateString() +"')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Books Issued Successfully");
        }
    }
}