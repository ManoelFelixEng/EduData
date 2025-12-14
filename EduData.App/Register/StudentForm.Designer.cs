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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDATE);
            panel1.Controls.Add(ComboClass);
            panel1.ForeColor = SystemColors.Window;
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
            ComboClass.Size = new Size(564, 36);
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
            lblDATE.Location = new Point(19, 274);
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
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.FromArgb(48, 49, 51);
            txtId.Hint = "ID";
            txtId.Location = new Point(19, 333);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(49, 38);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 40F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(19, 0);
            label1.Name = "label1";
            label1.Size = new Size(446, 67);
            label1.TabIndex = 3;
            label1.Text = "Register Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
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
            lblName.Hint = "NAME";
            lblName.Location = new Point(19, 208);
            lblName.MaxLength = 32767;
            lblName.Multiline = false;
            lblName.Name = "lblName";
            lblName.PasswordChar = '\0';
            lblName.ScrollBars = ScrollBars.None;
            lblName.SelectedText = "";
            lblName.SelectionLength = 0;
            lblName.SelectionStart = 0;
            lblName.Size = new Size(564, 38);
            lblName.TabIndex = 0;
            lblName.TabStop = false;
            lblName.UseSystemPasswordChar = false;
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
            Text = "StudentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}