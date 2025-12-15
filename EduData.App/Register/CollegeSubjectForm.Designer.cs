namespace EduData.App.Register
{
    partial class CollegeSubjectForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeSubjectForm));
            hopeTextBoxID = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxLoad = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxName = new ReaLTaiizor.Controls.HopeTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(hopeTextBoxID);
            panel1.Controls.Add(hopeTextBoxLoad);
            panel1.Controls.Add(hopeTextBoxName);
            panel1.Size = new Size(1305, 541);
            panel1.Controls.SetChildIndex(groupBox1, 0);
            panel1.Controls.SetChildIndex(hopeTextBoxName, 0);
            panel1.Controls.SetChildIndex(hopeTextBoxLoad, 0);
            panel1.Controls.SetChildIndex(hopeTextBoxID, 0);
            panel1.Controls.SetChildIndex(pictureBox1, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 3);
            // 
            // hopeTextBoxID
            // 
            hopeTextBoxID.BackColor = Color.White;
            hopeTextBoxID.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxID.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxID.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxID.Font = new Font("Segoe UI", 12F);
            hopeTextBoxID.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxID.Hint = "ID";
            hopeTextBoxID.Location = new Point(24, 235);
            hopeTextBoxID.MaxLength = 32767;
            hopeTextBoxID.Multiline = false;
            hopeTextBoxID.Name = "hopeTextBoxID";
            hopeTextBoxID.PasswordChar = '\0';
            hopeTextBoxID.ScrollBars = ScrollBars.None;
            hopeTextBoxID.SelectedText = "";
            hopeTextBoxID.SelectionLength = 0;
            hopeTextBoxID.SelectionStart = 0;
            hopeTextBoxID.Size = new Size(143, 38);
            hopeTextBoxID.TabIndex = 0;
            hopeTextBoxID.TabStop = false;
            hopeTextBoxID.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxLoad
            // 
            hopeTextBoxLoad.BackColor = Color.White;
            hopeTextBoxLoad.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxLoad.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxLoad.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxLoad.Font = new Font("Segoe UI", 12F);
            hopeTextBoxLoad.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxLoad.Hint = "COURSE LOAD";
            hopeTextBoxLoad.Location = new Point(24, 171);
            hopeTextBoxLoad.MaxLength = 32767;
            hopeTextBoxLoad.Multiline = false;
            hopeTextBoxLoad.Name = "hopeTextBoxLoad";
            hopeTextBoxLoad.PasswordChar = '\0';
            hopeTextBoxLoad.ScrollBars = ScrollBars.None;
            hopeTextBoxLoad.SelectedText = "";
            hopeTextBoxLoad.SelectionLength = 0;
            hopeTextBoxLoad.SelectionStart = 0;
            hopeTextBoxLoad.Size = new Size(143, 38);
            hopeTextBoxLoad.TabIndex = 1;
            hopeTextBoxLoad.TabStop = false;
            hopeTextBoxLoad.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxName
            // 
            hopeTextBoxName.BackColor = Color.White;
            hopeTextBoxName.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxName.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxName.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxName.Font = new Font("Segoe UI", 12F);
            hopeTextBoxName.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxName.Hint = "NAME";
            hopeTextBoxName.Location = new Point(24, 101);
            hopeTextBoxName.MaxLength = 32767;
            hopeTextBoxName.Multiline = false;
            hopeTextBoxName.Name = "hopeTextBoxName";
            hopeTextBoxName.PasswordChar = '\0';
            hopeTextBoxName.ScrollBars = ScrollBars.None;
            hopeTextBoxName.SelectedText = "";
            hopeTextBoxName.SelectionLength = 0;
            hopeTextBoxName.SelectionStart = 0;
            hopeTextBoxName.Size = new Size(528, 38);
            hopeTextBoxName.TabIndex = 2;
            hopeTextBoxName.TabStop = false;
            hopeTextBoxName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(42, 28);
            label2.Name = "label2";
            label2.Size = new Size(482, 49);
            label2.TabIndex = 3;
            label2.Text = "Register-College-Subject";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(662, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(535, 496);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CollegeSubjectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(1366, 768);
            Location = new Point(0, 0);
            Name = "CollegeSubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CollegeSubjectForm";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label2;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBoxLoad;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBoxName;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBoxID;
        private PictureBox pictureBox1;
    }
}
