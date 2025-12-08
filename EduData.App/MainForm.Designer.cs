namespace EduData.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            Register = new TabPage();
            Stats = new TabPage();
            Register_Class = new ToolStripButton();
            Registration_CollegeSubject = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            Enrollment_Management = new ToolStripButton();
            Evaluation_Management = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            hopeTabPage1.SuspendLayout();
            Register.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // hopeTabPage1
            // 
            hopeTabPage1.BaseColor = Color.FromArgb(28, 38, 89);
            hopeTabPage1.Controls.Add(Register);
            hopeTabPage1.Controls.Add(Stats);
            hopeTabPage1.Font = new Font("Trebuchet MS", 12.12F, FontStyle.Bold);
            hopeTabPage1.ForeColorA = Color.GhostWhite;
            hopeTabPage1.ForeColorB = Color.Gray;
            hopeTabPage1.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage1.ItemSize = new Size(120, 40);
            hopeTabPage1.Location = new Point(5, 39);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(833, 427);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 0;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.Controls.Add(toolStrip1);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(833, 387);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // Stats
            // 
            Stats.BackColor = Color.FromArgb(11, 24, 87);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(833, 387);
            Stats.TabIndex = 1;
            Stats.Text = "Stats";
            // 
            // Register_Class
            // 
            Register_Class.Font = new Font("Trebuchet MS", 7.7F, FontStyle.Bold);
            Register_Class.Image = (Image)resources.GetObject("Register_Class.Image");
            Register_Class.ImageTransparentColor = Color.Magenta;
            Register_Class.Name = "Register_Class";
            Register_Class.Size = new Size(100, 22);
            Register_Class.Text = "Register Class";
            Register_Class.Click += Register_Class_Click;
            // 
            // Registration_CollegeSubject
            // 
            Registration_CollegeSubject.Font = new Font("Trebuchet MS", 7.7F, FontStyle.Bold);
            Registration_CollegeSubject.Image = (Image)resources.GetObject("Registration_CollegeSubject.Image");
            Registration_CollegeSubject.ImageTransparentColor = Color.Magenta;
            Registration_CollegeSubject.Name = "Registration_CollegeSubject";
            Registration_CollegeSubject.Size = new Size(176, 22);
            Registration_CollegeSubject.Text = "Registration CollegeSubject";
            // 
            // Resgistration_Student
            // 

            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Register_Class, toolStripSeparator1, Registration_CollegeSubject, toolStripSeparator2, toolStripSeparator3, Enrollment_Management, toolStripSeparator4, Evaluation_Management, toolStripSeparator5 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(827, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // Enrollment_Management
            // 
            Enrollment_Management.Font = new Font("Trebuchet MS", 7.7F, FontStyle.Bold);
            Enrollment_Management.Image = (Image)resources.GetObject("Enrollment_Management.Image");
            Enrollment_Management.ImageTransparentColor = Color.Magenta;
            Enrollment_Management.Name = "Enrollment_Management";
            Enrollment_Management.Size = new Size(155, 22);
            Enrollment_Management.Text = "Enrollment Management";
            // 
            // Evaluation_Management
            // 
            Evaluation_Management.Font = new Font("Trebuchet MS", 7.7F, FontStyle.Bold);
            Evaluation_Management.Image = (Image)resources.GetObject("Evaluation_Management.Image");
            Evaluation_Management.ImageTransparentColor = Color.Magenta;
            Evaluation_Management.Name = "Evaluation_Management";
            Evaluation_Management.Size = new Size(152, 22);
            Evaluation_Management.Text = "Evaluation Management";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(843, 478);
            Controls.Add(hopeTabPage1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "MainForm";
            Text = "MainForm";
            hopeTabPage1.ResumeLayout(false);
            Register.ResumeLayout(false);
            Register.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage Register;
        private TabPage Stats;
        private ToolStrip toolStrip1;
        private ToolStripButton Register_Class;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Registration_CollegeSubject;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton Enrollment_Management;
        private ToolStripButton Evaluation_Management;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator3;
    }
}