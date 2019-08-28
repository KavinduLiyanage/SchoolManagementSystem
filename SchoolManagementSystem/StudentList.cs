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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentDetailsDataGridView()
        {
            dgvStudents.AutoGenerateColumns = false;
            using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
            {
                dgvStudents.DataSource = db.Students.ToList<Student>();
            }
        }

        private void DgvStudents_DoubleClick(object sender, EventArgs e)
        {
            Student student1 = new Student();

            if (dgvStudents.CurrentRow.Index != -1)
            {
                student1.SID = Convert.ToInt32(dgvStudents.CurrentRow.Cells["SID"].Value);
                
            }

            this.Hide();
            StudentDetailsUpdate supdate = new StudentDetailsUpdate(student1.SID);
            supdate.ShowDialog();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            StudentDetailsDataGridView();
        }
    }
}
