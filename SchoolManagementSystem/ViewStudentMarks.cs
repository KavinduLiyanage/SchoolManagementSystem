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
using System.Data.Entity;

namespace SchoolManagementSystem
{
    public partial class ViewStudentMarks : Form
    {
        ExamMark examMark = new ExamMark();

        public ViewStudentMarks()
        {
            InitializeComponent();
        }

        private void ViewStudentMarks_Load(object sender, EventArgs e)
        {
            using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
            {
                examMark = db.ExamMarks.Where(x => x.SID == GetSetInfo.getsetusrId).FirstOrDefault();


                /*
                txtName.Text = student1.SNAME;
                txtAddress.Text = student1.SADDRESS;
                txtEmail.Text = student1.SEMAIL;
                txtGDName.Text = student1.SGDNAME;
                txtGDContact.Text = student1.SGDCONTACT;
                dateTimePickerDOB.Value = (DateTime)student1.SDOB;
                comboBoxGrade.Text = student1.Grade;
                comboBoxClass.Text = student1.ClassName;*/
            }
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage3 h3 = new HomePage3();
            h3.ShowDialog();
        }

        private void NAddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudentMarks vsm = new ViewStudentMarks();
            vsm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAppointment sappointment = new StudentAppointment();
            sappointment.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAppointmentEdit sappointmentedit = new StudentAppointmentEdit();
            sappointmentedit.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentReports.StudentMarksReport studentMarksReport = new StudentReports.StudentMarksReport();
            this.Hide();
            studentMarksReport.ShowDialog();
        }
    }
}
