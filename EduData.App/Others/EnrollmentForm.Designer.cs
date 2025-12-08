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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollmentForm));
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            Register = new TabPage();
            hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
            label4 = new Label();
            hopeComboBox2 = new ReaLTaiizor.Controls.HopeComboBox();
            label3 = new Label();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            label2 = new Label();
            btnCreate = new ReaLTaiizor.Controls.MaterialButton();
            btnBack = new ReaLTaiizor.Controls.MaterialButton();
            Stats = new TabPage();
            poisonListView1 = new ReaLTaiizor.Controls.PoisonListView();
            materialButton6 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton5 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton7 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton8 = new ReaLTaiizor.Controls.MaterialButton();
            hopeTabPage1.SuspendLayout();
            Register.SuspendLayout();
            Stats.SuspendLayout();
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
            hopeTabPage1.Location = new Point(5, 53);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(790, 406);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 24;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.Controls.Add(hopeTextBox3);
            Register.Controls.Add(label4);
            Register.Controls.Add(hopeComboBox2);
            Register.Controls.Add(label3);
            Register.Controls.Add(hopeComboBox1);
            Register.Controls.Add(label2);
            Register.Controls.Add(btnCreate);
            Register.Controls.Add(btnBack);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(790, 366);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // hopeTextBox3
            // 
            hopeTextBox3.BackColor = Color.White;
            hopeTextBox3.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox3.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox3.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox3.Font = new Font("Segoe UI", 12F);
            hopeTextBox3.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox3.Hint = "id";
            hopeTextBox3.Location = new Point(457, 144);
            hopeTextBox3.MaxLength = 32767;
            hopeTextBox3.Multiline = false;
            hopeTextBox3.Name = "hopeTextBox3";
            hopeTextBox3.PasswordChar = '\0';
            hopeTextBox3.ScrollBars = ScrollBars.None;
            hopeTextBox3.SelectedText = "";
            hopeTextBox3.SelectionLength = 0;
            hopeTextBox3.SelectionStart = 0;
            hopeTextBox3.Size = new Size(42, 38);
            hopeTextBox3.TabIndex = 41;
            hopeTextBox3.TabStop = false;
            hopeTextBox3.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 15.15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(64, 116);
            label4.Name = "label4";
            label4.Size = new Size(87, 27);
            label4.TabIndex = 40;
            label4.Text = "Student";
            // 
            // hopeComboBox2
            // 
            hopeComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox2.FlatStyle = FlatStyle.Flat;
            hopeComboBox2.Font = new Font("Segoe UI", 12F);
            hopeComboBox2.FormattingEnabled = true;
            hopeComboBox2.ItemHeight = 30;
            hopeComboBox2.Location = new Point(60, 146);
            hopeComboBox2.Name = "hopeComboBox2";
            hopeComboBox2.Size = new Size(172, 36);
            hopeComboBox2.TabIndex = 39;
            hopeComboBox2.SelectedIndexChanged += hopeComboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 15.15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(254, 116);
            label3.Name = "label3";
            label3.Size = new Size(158, 27);
            label3.TabIndex = 36;
            label3.Text = "CollegeSubject";
            label3.Click += label3_Click;
            // 
            // hopeComboBox1
            // 
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Segoe UI", 12F);
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Location = new Point(254, 146);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(172, 36);
            hopeComboBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(60, 60);
            label2.Name = "label2";
            label2.Size = new Size(323, 35);
            label2.TabIndex = 14;
            label2.Text = "Enrollment Management";
            label2.Click += label2_Click;
            // 
            // btnCreate
            // 
            btnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreate.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreate.Depth = 0;
            btnCreate.Font = new Font("Segoe UI", 9F);
            btnCreate.HighEmphasis = true;
            btnCreate.Icon = null;
            btnCreate.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCreate.Location = new Point(156, 239);
            btnCreate.Margin = new Padding(4, 6, 4, 6);
            btnCreate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCreate.Name = "btnCreate";
            btnCreate.NoAccentTextColor = Color.Empty;
            btnCreate.Size = new Size(76, 36);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "CREATE";
            btnCreate.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreate.UseAccentColor = false;
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBack.Depth = 0;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.HighEmphasis = true;
            btnBack.Icon = null;
            btnBack.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnBack.Location = new Point(60, 239);
            btnBack.Margin = new Padding(4, 6, 4, 6);
            btnBack.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnBack.Name = "btnBack";
            btnBack.NoAccentTextColor = Color.Empty;
            btnBack.Size = new Size(64, 36);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBack.UseAccentColor = false;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            Stats.BackColor = Color.FromArgb(11, 24, 87);
            Stats.Controls.Add(poisonListView1);
            Stats.Controls.Add(materialButton6);
            Stats.Controls.Add(materialButton5);
            Stats.Controls.Add(materialButton7);
            Stats.Controls.Add(materialButton8);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(790, 366);
            Stats.TabIndex = 1;
            Stats.Text = "LIST";
            // 
            // poisonListView1
            // 
            poisonListView1.Font = new Font("Segoe UI", 12F);
            poisonListView1.FullRowSelect = true;
            poisonListView1.HideSelection = true;
            poisonListView1.Location = new Point(202, 40);
            poisonListView1.Name = "poisonListView1";
            poisonListView1.OwnerDraw = true;
            poisonListView1.Size = new Size(381, 217);
            poisonListView1.TabIndex = 36;
            poisonListView1.UseCompatibleStateImageBehavior = false;
            poisonListView1.UseSelectable = true;
            // 
            // materialButton6
            // 
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.Font = new Font("Segoe UI", 9F);
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = null;
            materialButton6.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton6.Location = new Point(314, 296);
            materialButton6.Margin = new Padding(4, 6, 4, 6);
            materialButton6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(66, 36);
            materialButton6.TabIndex = 35;
            materialButton6.Text = "CLEAR";
            materialButton6.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.Font = new Font("Segoe UI", 9F);
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton5.Location = new Point(406, 296);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(73, 36);
            materialButton5.TabIndex = 34;
            materialButton5.Text = "DELETE";
            materialButton5.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialButton7
            // 
            materialButton7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton7.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton7.Depth = 0;
            materialButton7.Font = new Font("Segoe UI", 9F);
            materialButton7.HighEmphasis = true;
            materialButton7.Icon = null;
            materialButton7.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton7.Location = new Point(519, 296);
            materialButton7.Margin = new Padding(4, 6, 4, 6);
            materialButton7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton7.Name = "materialButton7";
            materialButton7.NoAccentTextColor = Color.Empty;
            materialButton7.Size = new Size(64, 36);
            materialButton7.TabIndex = 32;
            materialButton7.Text = "EDIT";
            materialButton7.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton7.UseAccentColor = false;
            materialButton7.UseVisualStyleBackColor = true;
            // 
            // materialButton8
            // 
            materialButton8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton8.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton8.Depth = 0;
            materialButton8.Font = new Font("Segoe UI", 9F);
            materialButton8.HighEmphasis = true;
            materialButton8.Icon = null;
            materialButton8.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton8.Location = new Point(211, 296);
            materialButton8.Margin = new Padding(4, 6, 4, 6);
            materialButton8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton8.Name = "materialButton8";
            materialButton8.NoAccentTextColor = Color.Empty;
            materialButton8.Size = new Size(64, 36);
            materialButton8.TabIndex = 31;
            materialButton8.Text = "BACK";
            materialButton8.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton8.UseAccentColor = false;
            materialButton8.UseVisualStyleBackColor = true;
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(hopeTabPage1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "EnrollmentForm";
            Text = "EnrollmentForm";
            hopeTabPage1.ResumeLayout(false);
            Register.ResumeLayout(false);
            Register.PerformLayout();
            Stats.ResumeLayout(false);
            Stats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage Register;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnCreate;
        private ReaLTaiizor.Controls.MaterialButton btnBack;
        private TabPage Stats;
        private ReaLTaiizor.Controls.MaterialButton materialButton6;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private ReaLTaiizor.Controls.MaterialButton materialButton7;
        private ReaLTaiizor.Controls.MaterialButton materialButton8;
        private Label label3;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox2;
        private Label label4;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
        private ReaLTaiizor.Controls.PoisonListView poisonListView1;
    }
}