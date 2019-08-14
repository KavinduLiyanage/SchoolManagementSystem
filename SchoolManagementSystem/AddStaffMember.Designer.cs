namespace SchoolManagementSystem
{
    partial class AddStaffMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffMember));
            this.UsrlinkLabel = new System.Windows.Forms.LinkLabel();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.radioPanelType = new System.Windows.Forms.Panel();
            this.memberType = new System.Windows.Forms.Label();
            this.adedemicRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.imgPanel = new System.Windows.Forms.PictureBox();
            this.usrImg = new System.Windows.Forms.PictureBox();
            this.NViewStaffBtn = new System.Windows.Forms.Button();
            this.NViewLeaveBtn = new System.Windows.Forms.Button();
            this.NViewSalaryBtn = new System.Windows.Forms.Button();
            this.NAddStaffBtn = new System.Windows.Forms.Button();
            this.NStaffHomeBtn = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nonAcedemicRadio = new System.Windows.Forms.RadioButton();
            this.raioPanelAccess = new System.Windows.Forms.Panel();
            this.userRadio = new System.Windows.Forms.RadioButton();
            this.accessLabel = new System.Windows.Forms.Label();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.ContentPanel.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.radioPanelType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrImg)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.raioPanelAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsrlinkLabel
            // 
            this.UsrlinkLabel.AutoSize = true;
            this.UsrlinkLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsrlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrlinkLabel.Location = new System.Drawing.Point(61, 272);
            this.UsrlinkLabel.Name = "UsrlinkLabel";
            this.UsrlinkLabel.Size = new System.Drawing.Size(171, 25);
            this.UsrlinkLabel.TabIndex = 32;
            this.UsrlinkLabel.TabStop = true;
            this.UsrlinkLabel.Text = "Milinda Ranawaka";
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
            this.NHomeBtn.Click += new System.EventHandler(this.NHomeBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.addGroupBox);
            this.ContentPanel.Location = new System.Drawing.Point(288, 104);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(962, 561);
            this.ContentPanel.TabIndex = 31;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.raioPanelAccess);
            this.addGroupBox.Controls.Add(this.radioPanelType);
            this.addGroupBox.Controls.Add(this.textBox1);
            this.addGroupBox.Controls.Add(this.nameLabel);
            this.addGroupBox.Location = new System.Drawing.Point(3, 17);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(956, 540);
            this.addGroupBox.TabIndex = 0;
            this.addGroupBox.TabStop = false;
            // 
            // radioPanelType
            // 
            this.radioPanelType.Controls.Add(this.nonAcedemicRadio);
            this.radioPanelType.Controls.Add(this.memberType);
            this.radioPanelType.Controls.Add(this.adedemicRadio);
            this.radioPanelType.Location = new System.Drawing.Point(5, 76);
            this.radioPanelType.Name = "radioPanelType";
            this.radioPanelType.Size = new System.Drawing.Size(250, 76);
            this.radioPanelType.TabIndex = 4;
            // 
            // memberType
            // 
            this.memberType.AutoSize = true;
            this.memberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberType.Location = new System.Drawing.Point(2, 18);
            this.memberType.Name = "memberType";
            this.memberType.Size = new System.Drawing.Size(111, 20);
            this.memberType.TabIndex = 2;
            this.memberType.Text = "Member Type";
            // 
            // adedemicRadio
            // 
            this.adedemicRadio.AutoSize = true;
            this.adedemicRadio.Location = new System.Drawing.Point(128, 17);
            this.adedemicRadio.Name = "adedemicRadio";
            this.adedemicRadio.Size = new System.Drawing.Size(90, 21);
            this.adedemicRadio.TabIndex = 3;
            this.adedemicRadio.TabStop = true;
            this.adedemicRadio.Text = "Acedemic";
            this.adedemicRadio.UseVisualStyleBackColor = true;
            this.adedemicRadio.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(11, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // imgPanel
            // 
            this.imgPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgPanel.Location = new System.Drawing.Point(22, 104);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(260, 220);
            this.imgPanel.TabIndex = 27;
            this.imgPanel.TabStop = false;
            // 
            // usrImg
            // 
            this.usrImg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usrImg.Image = ((System.Drawing.Image)(resources.GetObject("usrImg.Image")));
            this.usrImg.Location = new System.Drawing.Point(56, 122);
            this.usrImg.Name = "usrImg";
            this.usrImg.Size = new System.Drawing.Size(174, 135);
            this.usrImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usrImg.TabIndex = 29;
            this.usrImg.TabStop = false;
            // 
            // NViewStaffBtn
            // 
            this.NViewStaffBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewStaffBtn.Location = new System.Drawing.Point(11, 115);
            this.NViewStaffBtn.Name = "NViewStaffBtn";
            this.NViewStaffBtn.Size = new System.Drawing.Size(235, 35);
            this.NViewStaffBtn.TabIndex = 23;
            this.NViewStaffBtn.Text = "View Staff Member";
            this.NViewStaffBtn.UseVisualStyleBackColor = false;
            // 
            // NViewLeaveBtn
            // 
            this.NViewLeaveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewLeaveBtn.Location = new System.Drawing.Point(11, 187);
            this.NViewLeaveBtn.Name = "NViewLeaveBtn";
            this.NViewLeaveBtn.Size = new System.Drawing.Size(235, 35);
            this.NViewLeaveBtn.TabIndex = 18;
            this.NViewLeaveBtn.Text = "View Staff Leave";
            this.NViewLeaveBtn.UseVisualStyleBackColor = false;
            // 
            // NViewSalaryBtn
            // 
            this.NViewSalaryBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewSalaryBtn.Location = new System.Drawing.Point(11, 151);
            this.NViewSalaryBtn.Name = "NViewSalaryBtn";
            this.NViewSalaryBtn.Size = new System.Drawing.Size(235, 35);
            this.NViewSalaryBtn.TabIndex = 18;
            this.NViewSalaryBtn.Text = "View Salary Info";
            this.NViewSalaryBtn.UseVisualStyleBackColor = false;
            // 
            // NAddStaffBtn
            // 
            this.NAddStaffBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NAddStaffBtn.Location = new System.Drawing.Point(11, 79);
            this.NAddStaffBtn.Name = "NAddStaffBtn";
            this.NAddStaffBtn.Size = new System.Drawing.Size(235, 35);
            this.NAddStaffBtn.TabIndex = 17;
            this.NAddStaffBtn.Text = "Add Staff Member";
            this.NAddStaffBtn.UseVisualStyleBackColor = false;
            // 
            // NStaffHomeBtn
            // 
            this.NStaffHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NStaffHomeBtn.Location = new System.Drawing.Point(11, 42);
            this.NStaffHomeBtn.Name = "NStaffHomeBtn";
            this.NStaffHomeBtn.Size = new System.Drawing.Size(235, 35);
            this.NStaffHomeBtn.TabIndex = 17;
            this.NStaffHomeBtn.Text = "Staff Manage Home";
            this.NStaffHomeBtn.UseVisualStyleBackColor = false;
            this.NStaffHomeBtn.Click += new System.EventHandler(this.NStaffHomeBtn_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.NViewStaffBtn);
            this.ButtonPanel.Controls.Add(this.NViewLeaveBtn);
            this.ButtonPanel.Controls.Add(this.NViewSalaryBtn);
            this.ButtonPanel.Controls.Add(this.NAddStaffBtn);
            this.ButtonPanel.Controls.Add(this.NStaffHomeBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(22, 330);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(260, 335);
            this.ButtonPanel.TabIndex = 28;
            // 
            // headerPanel
            // 
            this.headerPanel.Location = new System.Drawing.Point(22, 6);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1228, 92);
            this.headerPanel.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // nonAcedemicRadio
            // 
            this.nonAcedemicRadio.AutoSize = true;
            this.nonAcedemicRadio.Location = new System.Drawing.Point(128, 44);
            this.nonAcedemicRadio.Name = "nonAcedemicRadio";
            this.nonAcedemicRadio.Size = new System.Drawing.Size(121, 21);
            this.nonAcedemicRadio.TabIndex = 5;
            this.nonAcedemicRadio.TabStop = true;
            this.nonAcedemicRadio.Text = "Non-Acedemic";
            this.nonAcedemicRadio.UseVisualStyleBackColor = true;
            this.nonAcedemicRadio.CheckedChanged += new System.EventHandler(this.NonAcedemicRadio_CheckedChanged);
            // 
            // raioPanelAccess
            // 
            this.raioPanelAccess.Controls.Add(this.userRadio);
            this.raioPanelAccess.Controls.Add(this.accessLabel);
            this.raioPanelAccess.Controls.Add(this.adminRadio);
            this.raioPanelAccess.Location = new System.Drawing.Point(5, 158);
            this.raioPanelAccess.Name = "raioPanelAccess";
            this.raioPanelAccess.Size = new System.Drawing.Size(250, 76);
            this.raioPanelAccess.TabIndex = 5;
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.Location = new System.Drawing.Point(128, 44);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(59, 21);
            this.userRadio.TabIndex = 5;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "User";
            this.userRadio.UseVisualStyleBackColor = true;
            // 
            // accessLabel
            // 
            this.accessLabel.AutoSize = true;
            this.accessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLabel.Location = new System.Drawing.Point(2, 18);
            this.accessLabel.Name = "accessLabel";
            this.accessLabel.Size = new System.Drawing.Size(110, 20);
            this.accessLabel.TabIndex = 2;
            this.accessLabel.Text = "Access Level";
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(128, 17);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(68, 21);
            this.adminRadio.TabIndex = 3;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // AddStaffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsrlinkLabel);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.usrImg);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddStaffMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStaffMember";
            this.ContentPanel.ResumeLayout(false);
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.radioPanelType.ResumeLayout(false);
            this.radioPanelType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrImg)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.raioPanelAccess.ResumeLayout(false);
            this.raioPanelAccess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel UsrlinkLabel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox imgPanel;
        private System.Windows.Forms.Button NViewStaffBtn;
        private System.Windows.Forms.Button NViewLeaveBtn;
        private System.Windows.Forms.Button NViewSalaryBtn;
        private System.Windows.Forms.Button NAddStaffBtn;
        private System.Windows.Forms.Button NStaffHomeBtn;
        private System.Windows.Forms.PictureBox usrImg;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.RadioButton adedemicRadio;
        private System.Windows.Forms.Label memberType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel radioPanelType;
        private System.Windows.Forms.RadioButton nonAcedemicRadio;
        private System.Windows.Forms.Panel raioPanelAccess;
        private System.Windows.Forms.RadioButton userRadio;
        private System.Windows.Forms.Label accessLabel;
        private System.Windows.Forms.RadioButton adminRadio;
    }
}