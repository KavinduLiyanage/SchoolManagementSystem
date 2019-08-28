using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class InventoryDashboard : Form
    {
        public InventoryDashboard()
        {
            InitializeComponent();
        }

        private void BtnLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Laboratory Equipments");
            item.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Moveable Infrastructures");
            item.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Sports Items");
            item.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Music Instruments");
            item.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Teaching Aid");
            item.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Cleaning Items");
            item.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Stationary");
            item.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Electronic Items");
            item.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("View All Items");
            item.Show();
        }
    }
}
