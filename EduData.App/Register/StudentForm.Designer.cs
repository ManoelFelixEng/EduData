namespace EduData.App.Register
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            Register = new TabPage();
            Stats = new TabPage();
            ComboClass = new ReaLTaiizor.Controls.HopeComboBox();
            lblDATE = new ReaLTaiizor.Controls.HopeTextBox();
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            label3 = new Label();
            lblName = new ReaLTaiizor.Controls.HopeTextBox();
            lblIdClass = new ReaLTaiizor.Controls.HopeTextBox();
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
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblDATE);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(ComboClass);
            panel1.ForeColor = SystemColors.Window;
            panel1.Size = new Size(1302, 541);
            panel1.Controls.SetChildIndex(groupBox1, 0);
            panel1.Controls.SetChildIndex(ComboClass, 0);
            panel1.Controls.SetChildIndex(lblName, 0);
            panel1.Controls.SetChildIndex(lblDATE, 0);
            panel1.Controls.SetChildIndex(txtId, 0);
            panel1.Controls.SetChildIndex(pictureBox1, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblIdClass);
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(790, 398);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // Stats
            // 
            Stats.BackColor = Color.FromArgb(11, 24, 87);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(790, 398);
            Stats.TabIndex = 1;
            Stats.Text = "LIST";
            // 
            // ComboClass
            // 
            ComboClass.DrawMode = DrawMode.OwnerDrawFixed;
            ComboClass.FlatStyle = FlatStyle.Flat;
            ComboClass.Font = new Font("Segoe UI", 12F);
            ComboClass.FormattingEnabled = true;
            ComboClass.ItemHeight = 30;
            ComboClass.Location = new Point(19, 149);
            ComboClass.Name = "ComboClass";
            ComboClass.Size = new Size(531, 36);
            ComboClass.TabIndex = 2;
            // 
            // lblDATE
            // 
            lblDATE.BackColor = Color.White;
            lblDATE.BaseColor = Color.FromArgb(44, 55, 66);
            lblDATE.BorderColorA = Color.FromArgb(64, 158, 255);
            lblDATE.BorderColorB = Color.FromArgb(220, 223, 230);
            lblDATE.Font = new Font("Segoe UI", 12F);
            lblDATE.ForeColor = Color.FromArgb(48, 49, 51);
            lblDATE.Hint = "(dd/mm/aaaa)";
            lblDATE.Location = new Point(19, 344);
            lblDATE.MaxLength = 32767;
            lblDATE.Multiline = false;
            lblDATE.Name = "lblDATE";
            lblDATE.PasswordChar = '\0';
            lblDATE.ScrollBars = ScrollBars.None;
            lblDATE.SelectedText = "";
            lblDATE.SelectionLength = 0;
            lblDATE.SelectionStart = 0;
            lblDATE.Size = new Size(134, 38);
            lblDATE.TabIndex = 1;
            lblDATE.TabStop = false;
            lblDATE.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BaseColor = Color.FromArgb(44, 55, 66);
            txtId.BorderColorA = Color.FromArgb(64, 158, 255);
            txtId.BorderColorB = Color.FromArgb(220, 223, 230);
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.FromArgb(48, 49, 51);
            txtId.Hint = "ID STUDENT";
            txtId.Location = new Point(19, 401);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(134, 38);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 40F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(446, 67);
            label1.TabIndex = 3;
            label1.Text = "Register Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 5;
            label3.Text = "Class";
            // 
            // lblName
            // 
            lblName.BackColor = Color.White;
            lblName.BaseColor = Color.FromArgb(44, 55, 66);
            lblName.BorderColorA = Color.FromArgb(64, 158, 255);
            lblName.BorderColorB = Color.FromArgb(220, 223, 230);
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.ForeColor = Color.FromArgb(48, 49, 51);
            lblName.Hint = "NAME STUDENT";
            lblName.Location = new Point(19, 283);
            lblName.MaxLength = 32767;
            lblName.Multiline = false;
            lblName.Name = "lblName";
            lblName.PasswordChar = '\0';
            lblName.ScrollBars = ScrollBars.None;
            lblName.SelectedText = "";
            lblName.SelectionLength = 0;
            lblName.SelectionStart = 0;
            lblName.Size = new Size(531, 38);
            lblName.TabIndex = 0;
            lblName.TabStop = false;
            lblName.UseSystemPasswordChar = false;
            // 
            // lblIdClass
            // 
            lblIdClass.BackColor = Color.White;
            lblIdClass.BaseColor = Color.FromArgb(44, 55, 66);
            lblIdClass.BorderColorA = Color.FromArgb(64, 158, 255);
            lblIdClass.BorderColorB = Color.FromArgb(220, 223, 230);
            lblIdClass.Enabled = false;
            lblIdClass.Font = new Font("Segoe UI", 12F);
            lblIdClass.ForeColor = Color.FromArgb(48, 49, 51);
            lblIdClass.Hint = "ID CLASS";
            lblIdClass.Location = new Point(19, 230);
            lblIdClass.MaxLength = 32767;
            lblIdClass.Multiline = false;
            lblIdClass.Name = "lblIdClass";
            lblIdClass.PasswordChar = '\0';
            lblIdClass.ScrollBars = ScrollBars.None;
            lblIdClass.SelectedText = "";
            lblIdClass.SelectionLength = 0;
            lblIdClass.SelectionStart = 0;
            lblIdClass.Size = new Size(102, 38);
            lblIdClass.TabIndex = 11;
            lblIdClass.TabStop = false;
            lblIdClass.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(19, 195);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 12;
            label2.Text = "ID Class";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(1366, 768);
            ForeColor = SystemColors.ActiveCaptionText;
            Image = (Image)resources.GetObject("$this.Image");
            Location = new Point(0, 0);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox txtId;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage Register;
        private TabPage Stats;
        private ReaLTaiizor.Controls.HopeTextBox lblDATE;
        private ReaLTaiizor.Controls.HopeComboBox ComboClass;
        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.HopeTextBox lblName;
        private ReaLTaiizor.Controls.HopeTextBox lblIdClass;
        private Label label2;
        private PictureBox pictureBox1;
    }
}