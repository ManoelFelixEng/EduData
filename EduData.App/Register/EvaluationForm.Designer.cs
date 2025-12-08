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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationForm));
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            Register = new TabPage();
            hopeTextBox4 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
            label3 = new Label();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            label2 = new Label();
            btnCreate = new ReaLTaiizor.Controls.MaterialButton();
            btnBack = new ReaLTaiizor.Controls.MaterialButton();
            Stats = new TabPage();
            poisonListView1 = new ReaLTaiizor.Controls.PoisonListView();
            btnClear = new ReaLTaiizor.Controls.MaterialButton();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            btnBackList = new ReaLTaiizor.Controls.MaterialButton();
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
            hopeTabPage1.Location = new Point(5, 39);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(790, 406);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 25;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.Controls.Add(hopeTextBox4);
            Register.Controls.Add(hopeTextBox2);
            Register.Controls.Add(hopeTextBox1);
            Register.Controls.Add(hopeTextBox3);
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
            // hopeTextBox4
            // 
            hopeTextBox4.BackColor = Color.White;
            hopeTextBox4.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox4.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox4.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox4.Font = new Font("Segoe UI", 12F);
            hopeTextBox4.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox4.Hint = "DATE";
            hopeTextBox4.Location = new Point(301, 176);
            hopeTextBox4.MaxLength = 32767;
            hopeTextBox4.Multiline = false;
            hopeTextBox4.Name = "hopeTextBox4";
            hopeTextBox4.PasswordChar = '\0';
            hopeTextBox4.ScrollBars = ScrollBars.None;
            hopeTextBox4.SelectedText = "";
            hopeTextBox4.SelectionLength = 0;
            hopeTextBox4.SelectionStart = 0;
            hopeTextBox4.Size = new Size(154, 38);
            hopeTextBox4.TabIndex = 44;
            hopeTextBox4.TabStop = false;
            hopeTextBox4.UseSystemPasswordChar = false;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.White;
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox2.Hint = "SCORE";
            hopeTextBox2.Location = new Point(301, 90);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(154, 38);
            hopeTextBox2.TabIndex = 43;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
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
            hopeTextBox1.Location = new Point(60, 90);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(154, 38);
            hopeTextBox1.TabIndex = 42;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
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
            hopeTextBox3.Location = new Point(237, 90);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 15.15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(60, 144);
            label3.Name = "label3";
            label3.Size = new Size(119, 27);
            label3.TabIndex = 36;
            label3.Text = "Enrollment";
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
            hopeComboBox1.Location = new Point(63, 176);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(216, 36);
            hopeComboBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(60, 32);
            label2.Name = "label2";
            label2.Size = new Size(314, 35);
            label2.TabIndex = 14;
            label2.Text = "Evaluation Management";
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
            btnCreate.Location = new Point(159, 242);
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
            btnBack.Location = new Point(63, 242);
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
            Stats.Controls.Add(btnClear);
            Stats.Controls.Add(btnDelete);
            Stats.Controls.Add(btnEdit);
            Stats.Controls.Add(btnBackList);
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
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnClear.Location = new Point(317, 299);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(66, 36);
            btnClear.TabIndex = 35;
            btnClear.Text = "CLEAR";
            btnClear.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(409, 299);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "DELETE";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEdit.Location = new Point(522, 299);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(64, 36);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "EDIT";
            btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBackList
            // 
            btnBackList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBackList.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBackList.Depth = 0;
            btnBackList.Font = new Font("Segoe UI", 9F);
            btnBackList.HighEmphasis = true;
            btnBackList.Icon = null;
            btnBackList.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnBackList.Location = new Point(214, 299);
            btnBackList.Margin = new Padding(4, 6, 4, 6);
            btnBackList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnBackList.Name = "btnBackList";
            btnBackList.NoAccentTextColor = Color.Empty;
            btnBackList.Size = new Size(64, 36);
            btnBackList.TabIndex = 31;
            btnBackList.Text = "BACK";
            btnBackList.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBackList.UseAccentColor = false;
            btnBackList.UseVisualStyleBackColor = true;
            // 
            // EvaluationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(hopeTabPage1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "EvaluationForm";
            Text = "EvaluationForm";
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
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
        private Label label3;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnCreate;
        private ReaLTaiizor.Controls.MaterialButton btnBack;
        private TabPage Stats;
        private ReaLTaiizor.Controls.PoisonListView poisonListView1;
        private ReaLTaiizor.Controls.MaterialButton btnClear;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnBackList;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox4;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
    }
}