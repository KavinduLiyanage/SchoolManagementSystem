using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class CreateStudentAccount : Form
    {
        public CreateStudentAccount()
        {
            InitializeComponent();
        }

        private void Save()
        {
            try
            {
                var student = new StudentModel()
                {
                    SName = txtName.Text,
                    SEmail = txtEmail.Text,
                    SAddress = txtAddress.Text,
                    SGDName = txtGDName.Text,
                    SGDContact = txtGDContact.Text,
                    SDob = dateTimePickerDOB.Value,
                    SGender = gender

                };

                ValidationContext context = new ValidationContext(student);
                List<ValidationResult> errorList = new List<ValidationResult>();
                var error = string.Empty;
                if(!Validator.TryValidateObject(student, context, errorList, true))
                {
                    foreach(ValidationResult result1 in errorList)
                    {
                        error = error + result1.ErrorMessage + "\r\n";
                    }
                    MessageBox.Show(error);
                    return;
                }

                var data = new StudentData();
                bool result = data.SaveStudent(student);
                if(result)
                {
                    MessageBox.Show("Student Account Added Sucessfully");
                }
                else
                {
                    MessageBox.Show("Student Account Added unsucessfully");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Clear()
        {
            txtName.Text = txtAddress.Text = txtEmail.Text = txtGDName.Text = txtGDContact.Text = "";
        }


        private void BtnSubmit_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void TableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        string gender;
        private void RbtnMale_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void RbtnFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }
    }
}
