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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSubject);
            panel1.Controls.Add(lblStudent);
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(txtFinalScore);
            panel1.Controls.Add(cboSubject);
            panel1.Controls.Add(cboStudent);
            panel1.Controls.Add(cboClass);
            panel1.Controls.Add(txtId);
            panel1.ForeColor = SystemColors.Window;
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
            txtId.Location = new Point(422, 368);
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
            cboClass.Size = new Size(550, 36);
            cboClass.TabIndex = 1;
            // 
            // cboStudent
            // 
            cboStudent.DrawMode = DrawMode.OwnerDrawFixed;
            cboStudent.FlatStyle = FlatStyle.Flat;
            cboStudent.Font = new Font("Segoe UI", 12F);
            cboStudent.FormattingEnabled = true;
            cboStudent.ItemHeight = 30;
            cboStudent.Location = new Point(20, 222);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(550, 36);
            cboStudent.TabIndex = 2;
            // 
            // cboSubject
            // 
            cboSubject.DrawMode = DrawMode.OwnerDrawFixed;
            cboSubject.FlatStyle = FlatStyle.Flat;
            cboSubject.Font = new Font("Segoe UI", 12F);
            cboSubject.FormattingEnabled = true;
            cboSubject.ItemHeight = 30;
            cboSubject.Location = new Point(20, 309);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(550, 36);
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
            txtFinalScore.Location = new Point(510, 368);
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
            lblTitle.Location = new Point(20, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(512, 67);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Manage Enrollment";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblClass.Location = new Point(24, 104);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(150, 32);
            lblClass.TabIndex = 2;
            lblClass.Text = "Select Class";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblStudent.Location = new Point(20, 187);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(106, 32);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblSubject.Location = new Point(20, 274);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(195, 32);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "College Subject";
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Location = new Point(0, 0);
            Name = "EnrollmentForm";
            Text = "Enrollment Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
