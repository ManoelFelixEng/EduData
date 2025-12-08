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
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            Register = new TabPage();
            Stats = new TabPage();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            label2 = new Label();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton4 = new ReaLTaiizor.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            materialButton5 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton6 = new ReaLTaiizor.Controls.MaterialButton();
            hopeTabPage1.SuspendLayout();
            Register.SuspendLayout();
            Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            hopeTabPage1.Size = new Size(790, 438);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 22;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.Controls.Add(materialButton2);
            Register.Controls.Add(label2);
            Register.Controls.Add(materialButton1);
            Register.Controls.Add(hopeTextBox1);
            Register.Controls.Add(label1);
            Register.Controls.Add(hopeTextBox2);
            Register.Controls.Add(hopeComboBox1);
            Register.Controls.Add(hopeTextBox3);
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
            Stats.Controls.Add(materialButton6);
            Stats.Controls.Add(materialButton5);
            Stats.Controls.Add(dataGridView1);
            Stats.Controls.Add(materialButton3);
            Stats.Controls.Add(materialButton4);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(790, 398);
            Stats.TabIndex = 1;
            Stats.Text = "LIST";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Segoe UI", 9F);
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(165, 305);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(76, 36);
            materialButton2.TabIndex = 30;
            materialButton2.Text = "CREATE";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 9F);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(69, 305);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 29;
            materialButton1.Text = "BACK";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(69, 209);
            label1.Name = "label1";
            label1.Size = new Size(60, 27);
            label1.TabIndex = 28;
            label1.Text = "Class";
            // 
            // hopeComboBox1
            // 
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Segoe UI", 12F);
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Location = new Point(69, 239);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(172, 36);
            hopeComboBox1.TabIndex = 27;
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
            hopeTextBox3.Location = new Point(199, 152);
            hopeTextBox3.MaxLength = 32767;
            hopeTextBox3.Multiline = false;
            hopeTextBox3.Name = "hopeTextBox3";
            hopeTextBox3.PasswordChar = '\0';
            hopeTextBox3.ScrollBars = ScrollBars.None;
            hopeTextBox3.SelectedText = "";
            hopeTextBox3.SelectionLength = 0;
            hopeTextBox3.SelectionStart = 0;
            hopeTextBox3.Size = new Size(42, 38);
            hopeTextBox3.TabIndex = 26;
            hopeTextBox3.TabStop = false;
            hopeTextBox3.UseSystemPasswordChar = false;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.White;
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox2.Hint = "DATE BIRTH";
            hopeTextBox2.Location = new Point(69, 152);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(108, 38);
            hopeTextBox2.TabIndex = 25;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(69, 34);
            label2.Name = "label2";
            label2.Size = new Size(231, 35);
            label2.TabIndex = 24;
            label2.Text = "Register-Student";
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Segoe UI", 12F);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "NAME";
            hopeTextBox1.Location = new Point(69, 95);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(172, 38);
            hopeTextBox1.TabIndex = 23;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Font = new Font("Segoe UI", 9F);
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton3.Location = new Point(513, 290);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(64, 36);
            materialButton3.TabIndex = 32;
            materialButton3.Text = "EDIT";
            materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.Font = new Font("Segoe UI", 9F);
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton4.Location = new Point(205, 290);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(64, 36);
            materialButton4.TabIndex = 31;
            materialButton4.Text = "BACK";
            materialButton4.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(372, 213);
            dataGridView1.TabIndex = 33;
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
            materialButton5.Location = new Point(400, 290);
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
            // materialButton6
            // 
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.Font = new Font("Segoe UI", 9F);
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = null;
            materialButton6.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton6.Location = new Point(308, 290);
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
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(hopeTabPage1);
            ForeColor = SystemColors.ActiveCaptionText;
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "StudentForm";
            Text = "StudentForm";
            hopeTabPage1.ResumeLayout(false);
            Register.ResumeLayout(false);
            Register.PerformLayout();
            Stats.ResumeLayout(false);
            Stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage Register;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private Label label1;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
        private TabPage Stats;
        private ReaLTaiizor.Controls.MaterialButton materialButton6;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
    }
}