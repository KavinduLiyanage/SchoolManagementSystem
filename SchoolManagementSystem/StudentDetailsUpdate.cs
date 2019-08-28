using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Models;

namespace SchoolManagementSystem
{
    public partial class StudentDetailsUpdate : Form
    {
        protected int sss;

        public StudentDetailsUpdate(int sid)
        {
            InitializeComponent();
            sss = sid;
            
        }
        
        private void StudentDetailsUpdate_Load_1(object sender, EventArgs e)
        {
            Student student1 = new Student();

            using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
            {
                student1 = db.Students.Where(x => x.SID == sss).FirstOrDefault();

                txtName.Text = student1.SNAME;
                txtAddress.Text = student1.SADDRESS;
               
            }

        }
    }
}
