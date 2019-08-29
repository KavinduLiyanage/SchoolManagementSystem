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
    public partial class LibraryHome : Form
    {
        public LibraryHome()
        {
            InitializeComponent();
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LibraryAddBook libraryAddBook = new LibraryAddBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LibraryAddBook libraryAddBook = new LibraryAddBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LibrarySearchBook libraryAddBook = new LibrarySearchBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            IssueBook libraryAddBook = new IssueBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ReturnBook retBook = new ReturnBook();
            this.Hide();
            retBook.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }
    }
}
