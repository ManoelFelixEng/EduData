namespace EduData.App.Others
{
    partial class EnrollmentForm
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
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            cboClass = new ReaLTaiizor.Controls.HopeComboBox();
            cboStudent = new ReaLTaiizor.Controls.HopeComboBox();
            cboSubject = new ReaLTaiizor.Controls.HopeComboBox();
            txtFinalScore = new ReaLTaiizor.Controls.HopeTextBox();
            lblTitle = new Label();
            lblClass = new Label();
            lblStudent = new Label();
            lblSubject = new Label();
            label1 = new Label();
            label2 = new Label();
            txtIdClass = new ReaLTaiizor.Controls.HopeTextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtFinalScore);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(cboSubject);
            panel1.Controls.Add(txtIdClass);
            panel1.Controls.Add(cboClass);
            panel1.ForeColor = SystemColors.Window;
            panel1.Size = new Size(1302, 541);
            panel1.Controls.SetChildIndex(groupBox1, 0);
            panel1.Controls.SetChildIndex(cboClass, 0);
            panel1.Controls.SetChildIndex(txtIdClass, 0);
            panel1.Controls.SetChildIndex(cboSubject, 0);
            panel1.Controls.SetChildIndex(txtId, 0);
            panel1.Controls.SetChildIndex(txtFinalScore, 0);
            panel1.Controls.SetChildIndex(pictureBox1, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblClass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblStudent);
            groupBox1.Controls.Add(lblSubject);
            groupBox1.Controls.Add(cboStudent);
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BaseColor = Color.FromArgb(44, 55, 66);
            txtId.BorderColorA = Color.FromArgb(64, 158, 255);
            txtId.BorderColorB = Color.FromArgb(220, 223, 230);
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.FromArgb(48, 49, 51);
            txtId.Hint = "ID";
            txtId.Location = new Point(24, 483);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(60, 38);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboClass
            // 
            cboClass.DrawMode = DrawMode.OwnerDrawFixed;
            cboClass.FlatStyle = FlatStyle.Flat;
            cboClass.Font = new Font("Segoe UI", 12F);
            cboClass.FormattingEnabled = true;
            cboClass.ItemHeight = 30;
            cboClass.Location = new Point(20, 139);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(530, 36);
            cboClass.TabIndex = 1;
            // 
            // cboStudent
            // 
            cboStudent.DrawMode = DrawMode.OwnerDrawFixed;
            cboStudent.FlatStyle = FlatStyle.Flat;
            cboStudent.Font = new Font("Segoe UI", 12F);
            cboStudent.FormattingEnabled = true;
            cboStudent.ItemHeight = 30;
            cboStudent.Location = new Point(20, 301);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(530, 36);
            cboStudent.TabIndex = 2;
            // 
            // cboSubject
            // 
            cboSubject.DrawMode = DrawMode.OwnerDrawFixed;
            cboSubject.FlatStyle = FlatStyle.Flat;
            cboSubject.Font = new Font("Segoe UI", 12F);
            cboSubject.FormattingEnabled = true;
            cboSubject.ItemHeight = 30;
            cboSubject.Location = new Point(20, 388);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(530, 36);
            cboSubject.TabIndex = 3;
            // 
            // txtFinalScore
            // 
            txtFinalScore.BackColor = Color.White;
            txtFinalScore.BaseColor = Color.FromArgb(44, 55, 66);
            txtFinalScore.BorderColorA = Color.FromArgb(64, 158, 255);
            txtFinalScore.BorderColorB = Color.FromArgb(220, 223, 230);
            txtFinalScore.Enabled = false;
            txtFinalScore.Font = new Font("Segoe UI", 12F);
            txtFinalScore.ForeColor = Color.FromArgb(48, 49, 51);
            txtFinalScore.Hint = "FINAL SCORE";
            txtFinalScore.Location = new Point(210, 483);
            txtFinalScore.MaxLength = 32767;
            txtFinalScore.Multiline = false;
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.PasswordChar = '\0';
            txtFinalScore.ScrollBars = ScrollBars.None;
            txtFinalScore.SelectedText = "";
            txtFinalScore.SelectionLength = 0;
            txtFinalScore.SelectionStart = 0;
            txtFinalScore.Size = new Size(60, 38);
            txtFinalScore.TabIndex = 4;
            txtFinalScore.TabStop = false;
            txtFinalScore.Text = "0";
            txtFinalScore.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 40F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(20, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(512, 67);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Manage Enrollment";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblClass.ForeColor = SystemColors.Window;
            lblClass.Location = new Point(20, 104);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(150, 32);
            lblClass.TabIndex = 2;
            lblClass.Text = "Select Class";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblStudent.ForeColor = Color.White;
            lblStudent.Location = new Point(24, 266);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(106, 32);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblSubject.ForeColor = Color.White;
            lblSubject.Location = new Point(24, 353);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(195, 32);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "College Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 437);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 6;
            label1.Text = "Id Enrollment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(210, 437);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 7;
            label2.Text = "Final Score";
            // 
            // txtIdClass
            // 
            txtIdClass.BackColor = Color.White;
            txtIdClass.BaseColor = Color.FromArgb(44, 55, 66);
            txtIdClass.BorderColorA = Color.FromArgb(64, 158, 255);
            txtIdClass.BorderColorB = Color.FromArgb(220, 223, 230);
            txtIdClass.Enabled = false;
            txtIdClass.Font = new Font("Segoe UI", 12F);
            txtIdClass.ForeColor = Color.FromArgb(48, 49, 51);
            txtIdClass.Hint = "ID";
            txtIdClass.Location = new Point(24, 225);
            txtIdClass.MaxLength = 32767;
            txtIdClass.Multiline = false;
            txtIdClass.Name = "txtIdClass";
            txtIdClass.PasswordChar = '\0';
            txtIdClass.ScrollBars = ScrollBars.None;
            txtIdClass.SelectedText = "";
            txtIdClass.SelectionLength = 0;
            txtIdClass.SelectionStart = 0;
            txtIdClass.Size = new Size(60, 38);
            txtIdClass.TabIndex = 8;
            txtIdClass.TabStop = false;
            txtIdClass.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 190);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 9;
            label3.Text = "ID CLASS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Filing_system_amico1;
            pictureBox1.Location = new Point(650, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Location = new Point(0, 0);
            Name = "EnrollmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment Form";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtId;
        private ReaLTaiizor.Controls.HopeComboBox cboClass;
        private ReaLTaiizor.Controls.HopeComboBox cboStudent;
        private ReaLTaiizor.Controls.HopeComboBox cboSubject;
        private ReaLTaiizor.Controls.HopeTextBox txtFinalScore;
        private Label lblTitle;
        private Label lblClass;
        private Label lblStudent;
        private Label lblSubject;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox txtIdClass;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
