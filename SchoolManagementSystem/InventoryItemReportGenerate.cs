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
    public partial class InventoryItemReportGenerate : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public InventoryItemReportGenerate()
        {
            InitializeComponent();
        }

        private void InventoryItemReportGenerate_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\Tharika\source\repos\MilindaRanawaka\SchoolManagementSystem\SchoolManagementSystem\cristalReportItem.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Items]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
