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
            txtExit = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            toolStrip1 = new ToolStrip();
            Register_Class = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Registration_CollegeSubject = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Register_Student = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            Enrollment_Management = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Evaluation_Management = new ToolStripButton();
            Stats = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            pictureBox1 = new PictureBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            hopeTabPage1.SuspendLayout();
            Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            hopeTabPage1.Click += hopeTabPage1_Click;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.Controls.Add(txtExit);
            Register.Controls.Add(pictureBox2);
            Register.Controls.Add(label10);
            Register.Controls.Add(label9);
            Register.Controls.Add(toolStrip1);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(1356, 684);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // txtExit
            // 
            txtExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtExit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtExit.Depth = 0;
            txtExit.HighEmphasis = true;
            txtExit.Icon = null;
            txtExit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtExit.Location = new Point(25, 639);
            txtExit.Margin = new Padding(4, 6, 4, 6);
            txtExit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtExit.Name = "txtExit";
            txtExit.NoAccentTextColor = Color.Empty;
            txtExit.Size = new Size(64, 36);
            txtExit.TabIndex = 9;
            txtExit.Text = "Exit";
            txtExit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtExit.UseAccentColor = false;
            txtExit.UseVisualStyleBackColor = true;
            txtExit.Click += txtExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Data_rafiki;
            pictureBox2.Location = new Point(601, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(762, 609);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.Font = new Font("Trebuchet MS", 20.12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(82, 242);
            label10.Name = "label10";
            label10.Size = new Size(513, 353);
            label10.TabIndex = 7;
            label10.Text = resources.GetString("label10.Text");
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 100F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(57, 74);
            label9.Name = "label9";
            label9.Size = new Size(584, 168);
            label9.TabIndex = 6;
            label9.Text = "EduData";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Register_Class, toolStripSeparator1, Registration_CollegeSubject, toolStripSeparator2, Register_Student, toolStripSeparator5, Enrollment_Management, toolStripSeparator4, Evaluation_Management });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1350, 50);
            toolStrip1.TabIndex = 0;
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
            // toolStripSeparator5
            // 
            toolStripSeparator5.AutoSize = false;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(100, 50);
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
            // Stats
            // 
            Stats.AutoScroll = true;
            Stats.BackColor = Color.FromArgb(11, 24, 87);
            Stats.Controls.Add(label8);
            Stats.Controls.Add(label7);
            Stats.Controls.Add(label6);
            Stats.Controls.Add(label5);
            Stats.Controls.Add(label4);
            Stats.Controls.Add(label3);
            Stats.Controls.Add(label2);
            Stats.Controls.Add(label1);
            Stats.Controls.Add(formsPlot3);
            Stats.Controls.Add(formsPlot2);
            Stats.Controls.Add(pictureBox1);
            Stats.Controls.Add(formsPlot1);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(1356, 684);
            Stats.TabIndex = 1;
            Stats.Text = "Stats";
            // 
            // label8
            // 
            label8.ForeColor = Color.White;
            label8.Location = new Point(733, 581);
            label8.Name = "label8";
            label8.Size = new Size(574, 44);
            label8.TabIndex = 12;
            label8.Text = "Shows the total number of classes opened for each academic subject.";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(44, 581);
            label7.Name = "label7";
            label7.Size = new Size(547, 44);
            label7.TabIndex = 11;
            label7.Text = "Percentage of students who passed (score ≥ 6.0) in each class.\"";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(744, 1235);
            label6.Name = "label6";
            label6.Size = new Size(547, 48);
            label6.TabIndex = 10;
            label6.Text = "Displays the student with the highest final score in each class";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(744, 1639);
            label5.Name = "label5";
            label5.Size = new Size(547, 127);
            label5.TabIndex = 9;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(733, 987);
            label4.Name = "label4";
            label4.Size = new Size(547, 127);
            label4.TabIndex = 8;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 987);
            label3.Name = "label3";
            label3.Size = new Size(547, 127);
            label3.TabIndex = 7;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 265);
            label2.Name = "label2";
            label2.Size = new Size(513, 127);
            label2.TabIndex = 6;
            label2.Text = "This dashboard represents the project's baseline, featuring charts for Grade Averages, Top Students, and Approval Rates. New visualizations and metrics will be implemented in future updates.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 50F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(167, 120);
            label1.Name = "label1";
            label1.Size = new Size(324, 84);
            label1.TabIndex = 5;
            label1.Text = "ANALYSIS";
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(44, 628);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(547, 356);
            formsPlot3.TabIndex = 3;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(744, 1286);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(547, 350);
            formsPlot2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Analysis_amico;
            pictureBox1.Location = new Point(744, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(733, 628);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(547, 356);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            Stats.ResumeLayout(false);
            Stats.PerformLayout();
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
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MaterialButton txtExit;
    }
}