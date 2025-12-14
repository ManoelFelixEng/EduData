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
            pictureBox1 = new PictureBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            btnCreate = new ReaLTaiizor.Controls.MaterialButton();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            label3 = new Label();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            btnExit = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_user;
            pictureBox1.Location = new Point(737, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 563);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
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
            hopeTextBox2.Location = new Point(161, 420);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '*';
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
            btnCreate.Location = new Point(235, 484);
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
            // hopeComboBox1
            // 
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Trebuchet MS", 15.15F, FontStyle.Bold);
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Items.AddRange(new object[] { "Administrator", "Professor", "Student" });
            hopeComboBox1.Location = new Point(161, 283);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(150, 36);
            hopeComboBox1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18.18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(200, 248);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 37;
            label3.Text = "Role";
            label3.Click += label3_Click;
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
            hopeTextBox1.Location = new Point(161, 351);
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
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExit.Location = new Point(163, 484);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 40F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(48, 152);
            label1.Name = "label1";
            label1.Size = new Size(416, 67);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(1366, 768);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(hopeTextBox1);
            Controls.Add(label3);
            Controls.Add(hopeTextBox2);
            Controls.Add(hopeComboBox1);
            Controls.Add(btnCreate);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.MaterialButton btnCreate;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private Label label3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.MaterialButton btnExit;
        private Label label1;
    }
}