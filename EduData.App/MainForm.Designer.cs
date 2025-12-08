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
            Registration_CollegeSubject = new ToolStripButton();
            Stats = new TabPage();
            toolStripSeparator1 = new ToolStripSeparator();
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
            hopeTabPage1.Location = new Point(0, 50);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(802, 427);
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
            Register.Size = new Size(802, 387);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Register_Class, toolStripSeparator1, Registration_CollegeSubject });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(796, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // Register_Class
            // 
            Register_Class.Font = new Font("Trebuchet MS", 12.12F);
            Register_Class.Image = (Image)resources.GetObject("Register_Class.Image");
            Register_Class.ImageTransparentColor = Color.Magenta;
            Register_Class.Name = "Register_Class";
            Register_Class.Size = new Size(138, 27);
            Register_Class.Text = "Register Class";
            // 
            // Registration_CollegeSubject
            // 
            Registration_CollegeSubject.Font = new Font("Trebuchet MS", 12.12F, FontStyle.Bold);
            Registration_CollegeSubject.Image = (Image)resources.GetObject("Registration_CollegeSubject.Image");
            Registration_CollegeSubject.ImageTransparentColor = Color.Magenta;
            Registration_CollegeSubject.Name = "Registration_CollegeSubject";
            Registration_CollegeSubject.Size = new Size(250, 27);
            Registration_CollegeSubject.Text = "Registration CollegeSubject";
            // 
            // Stats
            // 
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(802, 387);
            Stats.TabIndex = 1;
            Stats.Text = "Stats";
            Stats.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Overflow = ToolStripItemOverflow.Never;
            toolStripSeparator1.Size = new Size(60, 30);
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
        private ToolStripButton Registration_CollegeSubject;
        private ToolStripSeparator toolStripSeparator1;
    }
}