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
    public partial class addParticipant_form : Form
    {
        public addParticipant_form()
        {
            InitializeComponent();
        }

        private void DeleteEvent_click(object sender, EventArgs e)
        {

        }

        private void AddParticipant_form_Load(object sender, EventArgs e)
        {

        }

        private void AddNoticebtn_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtonAca_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void back_click(object sender, EventArgs e)
        {
            EventDashboard form_back = new EventDashboard();
            this.Hide();
            form_back.Show();
        }
    }
}
