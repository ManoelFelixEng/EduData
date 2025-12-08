namespace EduData.App.Others
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            btnLogin = new ReaLTaiizor.Controls.MaterialButton();
            btnRegister = new ReaLTaiizor.Controls.MaterialButton();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 41F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(255, 58);
            label1.Name = "label1";
            label1.Size = new Size(239, 68);
            label1.TabIndex = 0;
            label1.Text = "EduData";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLogin.Location = new Point(185, 330);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(64, 36);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.Font = new Font("Segoe UI", 9F);
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRegister.Location = new Point(77, 330);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(89, 36);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "REGISTER";
            btnRegister.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.UseVisualStyleBackColor = true;
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
            hopeTextBox1.Location = new Point(77, 213);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(172, 38);
            hopeTextBox1.TabIndex = 3;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            hopeTextBox1.Click += hopeTextBox1_Click;
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
            hopeTextBox2.Location = new Point(77, 273);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(172, 38);
            hopeTextBox2.TabIndex = 4;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(77, 161);
            label2.Name = "label2";
            label2.Size = new Size(83, 35);
            label2.TabIndex = 5;
            label2.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(hopeTextBox2);
            Controls.Add(hopeTextBox1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnLogin;
        private ReaLTaiizor.Controls.MaterialButton btnRegister;
        public ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private Label label2;
    }
}