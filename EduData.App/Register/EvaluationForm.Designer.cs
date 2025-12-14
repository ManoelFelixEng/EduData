namespace EduData.App.Register
{
    partial class EvaluationForm
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
            BoxClass = new ReaLTaiizor.Controls.HopeComboBox();
            BoxStudent = new ReaLTaiizor.Controls.HopeComboBox();
            BoxSubject = new ReaLTaiizor.Controls.HopeComboBox();
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            txtScore = new ReaLTaiizor.Controls.HopeTextBox();
            txtDate = new ReaLTaiizor.Controls.HopeTextBox();
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
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(txtScore);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(BoxSubject);
            panel1.Controls.Add(BoxStudent);
            panel1.Controls.Add(BoxClass);
            panel1.Controls.Add(txtId);
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(48, 6);
            panel1.Size = new Size(890, 529);
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
            txtId.Location = new Point(24, 467);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(60, 38);
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // BoxClass
            // 
            BoxClass.DrawMode = DrawMode.OwnerDrawFixed;
            BoxClass.FlatStyle = FlatStyle.Flat;
            BoxClass.Font = new Font("Segoe UI", 12F);
            BoxClass.FormattingEnabled = true;
            BoxClass.ItemHeight = 30;
            BoxClass.Location = new Point(24, 120);
            BoxClass.Name = "BoxClass";
            BoxClass.Size = new Size(556, 36);
            BoxClass.TabIndex = 1;
            // 
            // BoxStudent
            // 
            BoxStudent.DrawMode = DrawMode.OwnerDrawFixed;
            BoxStudent.FlatStyle = FlatStyle.Flat;
            BoxStudent.Font = new Font("Segoe UI", 12F);
            BoxStudent.FormattingEnabled = true;
            BoxStudent.ItemHeight = 30;
            BoxStudent.Location = new Point(24, 207);
            BoxStudent.Name = "BoxStudent";
            BoxStudent.Size = new Size(556, 36);
            BoxStudent.TabIndex = 2;
            // 
            // BoxSubject
            // 
            BoxSubject.DrawMode = DrawMode.OwnerDrawFixed;
            BoxSubject.FlatStyle = FlatStyle.Flat;
            BoxSubject.Font = new Font("Segoe UI", 12F);
            BoxSubject.FormattingEnabled = true;
            BoxSubject.ItemHeight = 30;
            BoxSubject.Location = new Point(24, 292);
            BoxSubject.Name = "BoxSubject";
            BoxSubject.Size = new Size(280, 36);
            BoxSubject.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.FromArgb(44, 55, 66);
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(48, 49, 51);
            txtName.Hint = "EVALUATION NAME";
            txtName.Location = new Point(24, 353);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(162, 38);
            txtName.TabIndex = 6;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtScore
            // 
            txtScore.BackColor = SystemColors.Window;
            txtScore.BaseColor = Color.FromArgb(44, 55, 66);
            txtScore.BorderColorA = Color.FromArgb(64, 158, 255);
            txtScore.BorderColorB = Color.FromArgb(220, 223, 230);
            txtScore.Font = new Font("Segoe UI", 12F);
            txtScore.ForeColor = Color.FromArgb(48, 49, 51);
            txtScore.Hint = "SCORE";
            txtScore.Location = new Point(96, 467);
            txtScore.MaxLength = 32767;
            txtScore.Multiline = false;
            txtScore.Name = "txtScore";
            txtScore.PasswordChar = '\0';
            txtScore.ScrollBars = ScrollBars.None;
            txtScore.SelectedText = "";
            txtScore.SelectionLength = 0;
            txtScore.SelectionStart = 0;
            txtScore.Size = new Size(72, 38);
            txtScore.TabIndex = 5;
            txtScore.TabStop = false;
            txtScore.UseSystemPasswordChar = false;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.White;
            txtDate.BaseColor = Color.FromArgb(44, 55, 66);
            txtDate.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDate.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.ForeColor = Color.FromArgb(48, 49, 51);
            txtDate.Hint = "(dd/mm/aaaa)";
            txtDate.Location = new Point(24, 409);
            txtDate.MaxLength = 32767;
            txtDate.Multiline = false;
            txtDate.Name = "txtDate";
            txtDate.PasswordChar = '\0';
            txtDate.ScrollBars = ScrollBars.None;
            txtDate.SelectedText = "";
            txtDate.SelectionLength = 0;
            txtDate.SelectionStart = 0;
            txtDate.Size = new Size(144, 38);
            txtDate.TabIndex = 4;
            txtDate.TabStop = false;
            txtDate.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 40F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(24, -3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 67);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Register Evaluation";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblClass.Location = new Point(24, 85);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(71, 32);
            lblClass.TabIndex = 2;
            lblClass.Text = "Class";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblStudent.Location = new Point(24, 172);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(106, 32);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            lblSubject.Location = new Point(24, 259);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(195, 32);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "College Subject";
            // 
            // EvaluationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Location = new Point(0, 0);
            Name = "EvaluationForm";
            Text = "Evaluation Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtId;
        private ReaLTaiizor.Controls.HopeComboBox BoxClass;
        private ReaLTaiizor.Controls.HopeComboBox BoxStudent;
        private ReaLTaiizor.Controls.HopeComboBox BoxSubject;
        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.HopeTextBox txtScore;
        private ReaLTaiizor.Controls.HopeTextBox txtDate;
        private Label lblTitle;
        private Label lblClass;
        private Label lblStudent;
        private Label lblSubject;
    }
}
