namespace SchoolManagementSystem
{
    partial class StudentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txt111 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.btnEventMHeader = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.NViewStudentBtn = new System.Windows.Forms.Button();
            this.NRemoveStudentBtn = new System.Windows.Forms.Button();
            this.NEditStudentBtn = new System.Windows.Forms.Button();
            this.NAddStudentBtn = new System.Windows.Forms.Button();
            this.NStudentHomeBtn = new System.Windows.Forms.Button();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardianContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel5.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SID,
            this.SNAME,
            this.Gender,
            this.Address,
            this.GuardianName,
            this.GuardianContact});
            this.dgvStudents.Location = new System.Drawing.Point(315, 143);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(892, 477);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.DoubleClick += new System.EventHandler(this.DgvStudents_DoubleClick);
            // 
            // txt111
            // 
            this.txt111.Location = new System.Drawing.Point(97, 351);
            this.txt111.Name = "txt111";
            this.txt111.Size = new System.Drawing.Size(100, 22);
            this.txt111.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.btnLogOutHeader);
            this.panel5.Controls.Add(this.btnNoticeMHeader);
            this.panel5.Controls.Add(this.btnExamMheader);
            this.panel5.Controls.Add(this.btnLibraryMHeader);
            this.panel5.Controls.Add(this.btnStudentMHeader);
            this.panel5.Controls.Add(this.btnResourseMHeader);
            this.panel5.Controls.Add(this.btnInventoryMHeader);
            this.panel5.Controls.Add(this.btnEventMHeader);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 92);
            this.panel5.TabIndex = 46;
            // 
            // btnLogOutHeader
            // 
            this.btnLogOutHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOutHeader.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOutHeader.Location = new System.Drawing.Point(1069, 19);
            this.btnLogOutHeader.Name = "btnLogOutHeader";
            this.btnLogOutHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLogOutHeader.TabIndex = 25;
            this.btnLogOutHeader.Text = "Log Out";
            this.btnLogOutHeader.UseVisualStyleBackColor = true;
            // 
            // btnNoticeMHeader
            // 
            this.btnNoticeMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNoticeMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoticeMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnNoticeMHeader.Location = new System.Drawing.Point(918, 20);
            this.btnNoticeMHeader.Name = "btnNoticeMHeader";
            this.btnNoticeMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnNoticeMHeader.TabIndex = 23;
            this.btnNoticeMHeader.Text = "Notice Management";
            this.btnNoticeMHeader.UseVisualStyleBackColor = false;
            // 
            // btnExamMheader
            // 
            this.btnExamMheader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExamMheader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamMheader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnExamMheader.Location = new System.Drawing.Point(12, 18);
            this.btnExamMheader.Name = "btnExamMheader";
            this.btnExamMheader.Size = new System.Drawing.Size(145, 50);
            this.btnExamMheader.TabIndex = 1;
            this.btnExamMheader.Text = "Exam Management";
            this.btnExamMheader.UseVisualStyleBackColor = false;
            // 
            // btnLibraryMHeader
            // 
            this.btnLibraryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLibraryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnLibraryMHeader.Location = new System.Drawing.Point(767, 20);
            this.btnLibraryMHeader.Name = "btnLibraryMHeader";
            this.btnLibraryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLibraryMHeader.TabIndex = 22;
            this.btnLibraryMHeader.Text = " Library Management";
            this.btnLibraryMHeader.UseVisualStyleBackColor = false;
            // 
            // btnStudentMHeader
            // 
            this.btnStudentMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStudentMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnStudentMHeader.Location = new System.Drawing.Point(163, 19);
            this.btnStudentMHeader.Name = "btnStudentMHeader";
            this.btnStudentMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnStudentMHeader.TabIndex = 18;
            this.btnStudentMHeader.Text = "Student Management";
            this.btnStudentMHeader.UseVisualStyleBackColor = false;
            // 
            // btnResourseMHeader
            // 
            this.btnResourseMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResourseMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourseMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnResourseMHeader.Location = new System.Drawing.Point(616, 19);
            this.btnResourseMHeader.Name = "btnResourseMHeader";
            this.btnResourseMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnResourseMHeader.TabIndex = 21;
            this.btnResourseMHeader.Text = "Resourse Management";
            this.btnResourseMHeader.UseVisualStyleBackColor = false;
            // 
            // btnInventoryMHeader
            // 
            this.btnInventoryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInventoryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnInventoryMHeader.Location = new System.Drawing.Point(314, 19);
            this.btnInventoryMHeader.Name = "btnInventoryMHeader";
            this.btnInventoryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnInventoryMHeader.TabIndex = 19;
            this.btnInventoryMHeader.Text = "Inventory Management";
            this.btnInventoryMHeader.UseVisualStyleBackColor = false;
            // 
            // btnEventMHeader
            // 
            this.btnEventMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnEventMHeader.Location = new System.Drawing.Point(465, 19);
            this.btnEventMHeader.Name = "btnEventMHeader";
            this.btnEventMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnEventMHeader.TabIndex = 20;
            this.btnEventMHeader.Text = "Event Management";
            this.btnEventMHeader.UseVisualStyleBackColor = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.NViewStudentBtn);
            this.ButtonPanel.Controls.Add(this.txt111);
            this.ButtonPanel.Controls.Add(this.NRemoveStudentBtn);
            this.ButtonPanel.Controls.Add(this.NEditStudentBtn);
            this.ButtonPanel.Controls.Add(this.NAddStudentBtn);
            this.ButtonPanel.Controls.Add(this.NStudentHomeBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(12, 127);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(260, 523);
            this.ButtonPanel.TabIndex = 47;
            // 
            // NHomeBtn
            // 
            this.NHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHomeBtn.ForeColor = System.Drawing.Color.Red;
            this.NHomeBtn.Location = new System.Drawing.Point(11, 6);
            this.NHomeBtn.Name = "NHomeBtn";
            this.NHomeBtn.Size = new System.Drawing.Size(235, 35);
            this.NHomeBtn.TabIndex = 24;
            this.NHomeBtn.Text = "Home";
            this.NHomeBtn.UseVisualStyleBackColor = false;
            // 
            // NViewStudentBtn
            // 
            this.NViewStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewStudentBtn.Location = new System.Drawing.Point(11, 115);
            this.NViewStudentBtn.Name = "NViewStudentBtn";
            this.NViewStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NViewStudentBtn.TabIndex = 23;
            this.NViewStudentBtn.Text = "View Student List";
            this.NViewStudentBtn.UseVisualStyleBackColor = false;
            // 
            // NRemoveStudentBtn
            // 
            this.NRemoveStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NRemoveStudentBtn.Location = new System.Drawing.Point(11, 187);
            this.NRemoveStudentBtn.Name = "NRemoveStudentBtn";
            this.NRemoveStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NRemoveStudentBtn.TabIndex = 18;
            this.NRemoveStudentBtn.Text = "Remove Student";
            this.NRemoveStudentBtn.UseVisualStyleBackColor = false;
            // 
            // NEditStudentBtn
            // 
            this.NEditStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NEditStudentBtn.Location = new System.Drawing.Point(11, 151);
            this.NEditStudentBtn.Name = "NEditStudentBtn";
            this.NEditStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NEditStudentBtn.TabIndex = 18;
            this.NEditStudentBtn.Text = "Edit Student Details";
            this.NEditStudentBtn.UseVisualStyleBackColor = false;
            // 
            // NAddStudentBtn
            // 
            this.NAddStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NAddStudentBtn.Location = new System.Drawing.Point(11, 79);
            this.NAddStudentBtn.Name = "NAddStudentBtn";
            this.NAddStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NAddStudentBtn.TabIndex = 17;
            this.NAddStudentBtn.Text = "Add New Student";
            this.NAddStudentBtn.UseVisualStyleBackColor = false;
            // 
            // NStudentHomeBtn
            // 
            this.NStudentHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NStudentHomeBtn.Location = new System.Drawing.Point(11, 42);
            this.NStudentHomeBtn.Name = "NStudentHomeBtn";
            this.NStudentHomeBtn.Size = new System.Drawing.Size(235, 35);
            this.NStudentHomeBtn.TabIndex = 17;
            this.NStudentHomeBtn.Text = "Student Manage Home";
            this.NStudentHomeBtn.UseVisualStyleBackColor = false;
            // 
            // SID
            // 
            this.SID.DataPropertyName = "SID";
            this.SID.HeaderText = "SID";
            this.SID.MinimumWidth = 6;
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Width = 204;
            // 
            // SNAME
            // 
            this.SNAME.DataPropertyName = "SNAME";
            this.SNAME.HeaderText = "Full Name";
            this.SNAME.MinimumWidth = 6;
            this.SNAME.Name = "SNAME";
            this.SNAME.ReadOnly = true;
            this.SNAME.Width = 135;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "SGENDER";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "SADDRESS";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // GuardianName
            // 
            this.GuardianName.DataPropertyName = "SGDNAME";
            this.GuardianName.HeaderText = "Guardian Name";
            this.GuardianName.MinimumWidth = 6;
            this.GuardianName.Name = "GuardianName";
            this.GuardianName.ReadOnly = true;
            this.GuardianName.Width = 125;
            // 
            // GuardianContact
            // 
            this.GuardianContact.DataPropertyName = "SGDCONTACT";
            this.GuardianContact.HeaderText = "Guardian Contact";
            this.GuardianContact.MinimumWidth = 6;
            this.GuardianContact.Name = "GuardianContact";
            this.GuardianContact.ReadOnly = true;
            this.GuardianContact.Width = 125;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvStudents);
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txt111;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.Button btnEventMHeader;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Button NViewStudentBtn;
        private System.Windows.Forms.Button NRemoveStudentBtn;
        private System.Windows.Forms.Button NEditStudentBtn;
        private System.Windows.Forms.Button NAddStudentBtn;
        private System.Windows.Forms.Button NStudentHomeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardianContact;
    }
}