using CrystalDecisions.CrystalReports.Engine;
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

    public partial class InventoryProductReportGenerate : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public InventoryProductReportGenerate()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //comboBox1
        private void Button1_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\Tharika\source\repos\MilindaRanawaka\SchoolManagementSystem\SchoolManagementSystem\CrystalReportStock.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [stockTable] where [Category]='" + comboBox1.Text + "'", con);
            sda.Fill(dst,"StockTable");
            cryrpt.SetDataSource(dst);
            cryrpt.SetParameterValue("@Category", comboBox1.Text);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();
        }

        private void InventoryProductReportGenerate_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\Tharika\source\repos\MilindaRanawaka\SchoolManagementSystem\SchoolManagementSystem\CrystalReportStock.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [stockTable]", con);
            sda.Fill(dst, "StockTable");
            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();
        }
    }
}
