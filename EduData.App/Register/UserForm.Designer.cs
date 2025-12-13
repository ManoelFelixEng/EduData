namespace EduData.App.Register
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            label1 = new Label();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            btnCreate = new ReaLTaiizor.Controls.MaterialButton();
            btnExit = new ReaLTaiizor.Controls.MaterialButton();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            label3 = new Label();
            hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox4 = new ReaLTaiizor.Controls.HopeTextBox();
            label2 = new Label();
            hopeTextBox5 = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(266, 81);
            label1.Name = "label1";
            label1.Size = new Size(232, 38);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
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
            hopeTextBox1.Location = new Point(223, 160);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(150, 38);
            hopeTextBox1.TabIndex = 1;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.White;
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox2.Hint = "PASSWORD";
            hopeTextBox2.Location = new Point(223, 213);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(150, 38);
            hopeTextBox2.TabIndex = 2;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // btnCreate
            // 
            btnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreate.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreate.Depth = 0;
            btnCreate.HighEmphasis = true;
            btnCreate.Icon = null;
            btnCreate.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCreate.Location = new Point(372, 308);
            btnCreate.Margin = new Padding(4, 6, 4, 6);
            btnCreate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCreate.Name = "btnCreate";
            btnCreate.NoAccentTextColor = Color.Empty;
            btnCreate.Size = new Size(76, 36);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreate.UseAccentColor = false;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExit.Location = new Point(298, 308);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(64, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // hopeComboBox1
            // 
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Trebuchet MS", 15.15F, FontStyle.Bold);
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Items.AddRange(new object[] { "Administrator", "Professor", "Student" });
            hopeComboBox1.Location = new Point(427, 213);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(172, 36);
            hopeComboBox1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(476, 166);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 37;
            label3.Text = "Role";
            label3.Click += label3_Click;
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
            hopeTextBox3.Location = new Point(639, 418);
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
            hopeTextBox3.Click += this.hopeTextBox3_Click;
            // 
            // hopeTextBox4
            // 
            hopeTextBox4.BackColor = Color.White;
            hopeTextBox4.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox4.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox4.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox4.Font = new Font("Segoe UI", 12F);
            hopeTextBox4.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox4.Hint = "COURSE LOAD";
            hopeTextBox4.Location = new Point(639, 365);
            hopeTextBox4.MaxLength = 32767;
            hopeTextBox4.Multiline = false;
            hopeTextBox4.Name = "hopeTextBox4";
            hopeTextBox4.PasswordChar = '\0';
            hopeTextBox4.ScrollBars = ScrollBars.None;
            hopeTextBox4.SelectedText = "";
            hopeTextBox4.SelectionLength = 0;
            hopeTextBox4.SelectionStart = 0;
            hopeTextBox4.Size = new Size(172, 38);
            hopeTextBox4.TabIndex = 40;
            hopeTextBox4.TabStop = false;
            hopeTextBox4.UseSystemPasswordChar = false;
            hopeTextBox4.Click += this.hopeTextBox4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(639, 247);
            label2.Name = "label2";
            label2.Size = new Size(332, 35);
            label2.TabIndex = 39;
            label2.Text = "Register-College-Subject";
            label2.Click += this.label2_Click;
            // 
            // hopeTextBox5
            // 
            hopeTextBox5.BackColor = Color.White;
            hopeTextBox5.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox5.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox5.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox5.Font = new Font("Segoe UI", 12F);
            hopeTextBox5.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox5.Hint = "NAME";
            hopeTextBox5.Location = new Point(639, 308);
            hopeTextBox5.MaxLength = 32767;
            hopeTextBox5.Multiline = false;
            hopeTextBox5.Name = "hopeTextBox5";
            hopeTextBox5.PasswordChar = '\0';
            hopeTextBox5.ScrollBars = ScrollBars.None;
            hopeTextBox5.SelectedText = "";
            hopeTextBox5.SelectionLength = 0;
            hopeTextBox5.SelectionStart = 0;
            hopeTextBox5.Size = new Size(172, 38);
            hopeTextBox5.TabIndex = 38;
            hopeTextBox5.TabStop = false;
            hopeTextBox5.UseSystemPasswordChar = false;
            hopeTextBox5.Click += hopeTextBox5_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(hopeTextBox3);
            Controls.Add(hopeTextBox4);
            Controls.Add(label2);
            Controls.Add(hopeTextBox5);
            Controls.Add(label3);
            Controls.Add(hopeComboBox1);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(hopeTextBox2);
            Controls.Add(hopeTextBox1);
            Controls.Add(label1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.MaterialButton btnCreate;
        private ReaLTaiizor.Controls.MaterialButton btnExit;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private Label label3;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox4;
        private Label label2;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox5;
    }
}