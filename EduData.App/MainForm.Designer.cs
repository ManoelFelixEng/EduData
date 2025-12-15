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
            toolStrip1 = new ToolStrip();
            Register_Class = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Registration_CollegeSubject = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Enrollment_Management = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Evaluation_Management = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            Register_Student = new ToolStripButton();
            Stats = new TabPage();
            pictureBox1 = new PictureBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            hopeTabPage1.SuspendLayout();
            Register.SuspendLayout();
            toolStrip1.SuspendLayout();
            Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            hopeTabPage1.Size = new Size(1356, 724);
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
            Register.Size = new Size(1356, 684);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Register_Class, toolStripSeparator1, Registration_CollegeSubject, toolStripSeparator2, Enrollment_Management, toolStripSeparator4, Evaluation_Management, toolStripSeparator5, Register_Student });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1350, 50);
            toolStrip1.TabIndex = 0;
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // Register_Class
            // 
            Register_Class.Font = new Font("Trebuchet MS", 9.9F, FontStyle.Bold);
            Register_Class.Image = (Image)resources.GetObject("Register_Class.Image");
            Register_Class.ImageTransparentColor = Color.Magenta;
            Register_Class.Name = "Register_Class";
            Register_Class.Size = new Size(118, 47);
            Register_Class.Text = "Register Class";
            Register_Class.Click += Register_Class_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(100, 50);
            // 
            // Registration_CollegeSubject
            // 
            Registration_CollegeSubject.Font = new Font("Trebuchet MS", 9.9F, FontStyle.Bold);
            Registration_CollegeSubject.Image = (Image)resources.GetObject("Registration_CollegeSubject.Image");
            Registration_CollegeSubject.ImageTransparentColor = Color.Magenta;
            Registration_CollegeSubject.Name = "Registration_CollegeSubject";
            Registration_CollegeSubject.Size = new Size(208, 47);
            Registration_CollegeSubject.Text = "Registration CollegeSubject";
            Registration_CollegeSubject.Click += Registration_CollegeSubject_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.AutoSize = false;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(100, 50);
            // 
            // Enrollment_Management
            // 
            Enrollment_Management.Font = new Font("Trebuchet MS", 9.9F, FontStyle.Bold);
            Enrollment_Management.Image = (Image)resources.GetObject("Enrollment_Management.Image");
            Enrollment_Management.ImageTransparentColor = Color.Magenta;
            Enrollment_Management.Name = "Enrollment_Management";
            Enrollment_Management.Size = new Size(185, 47);
            Enrollment_Management.Text = "Enrollment Management";
            Enrollment_Management.Click += Enrollment_Management_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.AutoSize = false;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(100, 50);
            // 
            // Evaluation_Management
            // 
            Evaluation_Management.Font = new Font("Trebuchet MS", 9.9F, FontStyle.Bold);
            Evaluation_Management.Image = (Image)resources.GetObject("Evaluation_Management.Image");
            Evaluation_Management.ImageTransparentColor = Color.Magenta;
            Evaluation_Management.Name = "Evaluation_Management";
            Evaluation_Management.Size = new Size(180, 47);
            Evaluation_Management.Text = "Evaluation Management";
            Evaluation_Management.Click += Evaluation_Management_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.AutoSize = false;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(100, 50);
            // 
            // Register_Student
            // 
            Register_Student.Font = new Font("Trebuchet MS", 9.9F, FontStyle.Bold);
            Register_Student.Image = (Image)resources.GetObject("Register_Student.Image");
            Register_Student.ImageTransparentColor = Color.Magenta;
            Register_Student.Name = "Register_Student";
            Register_Student.Size = new Size(137, 47);
            Register_Student.Text = "Register Student";
            Register_Student.Click += Register_Student_Click;
            // 
            // Stats
            // 
            Stats.AutoScroll = true;
            Stats.AutoScrollMargin = new Size(0, 10000);
            Stats.BackColor = Color.FromArgb(11, 24, 87);
            Stats.Controls.Add(pictureBox1);
            Stats.Controls.Add(formsPlot1);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(1356, 684);
            Stats.TabIndex = 1;
            Stats.Text = "Stats";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Analysis_amico;
            pictureBox1.Location = new Point(701, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(135, 72);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(476, 356);
            formsPlot1.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(1366, 768);
            Controls.Add(hopeTabPage1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            hopeTabPage1.ResumeLayout(false);
            Register.ResumeLayout(false);
            Register.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripButton Register_Student;
        private ToolStripButton Enrollment_Management;
        private ToolStripButton Evaluation_Management;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private PictureBox pictureBox1;
    }
}