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
    public partial class AddExpense_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public AddExpense_form()
        {
            InitializeComponent();
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }

        public void Display_Data()
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Expenses";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

        private void ResetRecords()
        {
            idtextbox.Clear();
            textBoxdet.Clear();
            textBoxAmt.Clear();
        }

        int ExpenseID;
        private void ViewEx_click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            ExpenseID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            idtextbox.Text = selectRow.Cells[1].Value.ToString();
            textBoxdet.Text = selectRow.Cells[2].Value.ToString();
            textBoxAmt.Text = selectRow.Cells[3].Value.ToString();

        }

        private void AddExpense_form_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void back_e_click(object sender, EventArgs e)
        {
            EventDashboard form_back = new EventDashboard();
            this.Hide();
            form_back.Show();
        }

        private void AddEx_click(object sender, EventArgs e)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("set IDENTITY_INSERT ON");
            cmd.CommandText = ("insert into Expenses([Event Id],[Details],[Amount]) values ('" + idtextbox.Text + "','" + textBoxdet.Text+ "','" + textBoxAmt.Text + "')");
            cmd.ExecuteNonQuery();
            CloseConnection();
            this.ResetRecords();



            DialogResult dResult = MessageBox.Show("Add more Expenses", "Record Inserted Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dResult == DialogResult.Yes)
            {
                AddEventform Addevent = new AddEventform();
                this.Hide();
                Addevent.Show();
            }
        }

        private void ViewEx_click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void deleteEx_click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult == DialogResult.Yes)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from Expenses where [Expense Id]= '" + ExpenseID + "'";
                cmd.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Deleted Succesfully");
            }
        }

        private void UpdateEx_click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Update?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("update Expenses set [Event Id]='" + idtextbox.Text + "', [Details] ='" + textBoxdet.Text + "',[Amount]='" + textBoxAmt.Text + "' where [Expense Id]='" + ExpenseID + "'");
                cmd.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Updated Succesfully");
            }
        }

        private void SearchEx_click(object sender, EventArgs e)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Expenses where  [Event Id]='" + textBoxExsearch.Text + "' ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

    }
}
