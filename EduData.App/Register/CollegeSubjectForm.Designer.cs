namespace EduData.App.Register
{
    partial class CollegeSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeSubjectForm));
            Register = new TabPage();
            Stats = new TabPage();
            btnClear = new ReaLTaiizor.Controls.MaterialButton();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            btnBackList = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            label2 = new Label();
            hopeTextBoxName = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxLoad = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxID = new ReaLTaiizor.Controls.HopeTextBox();
            panel1.SuspendLayout();
            Stats.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(hopeTextBoxID);
            panel1.Controls.Add(hopeTextBoxLoad);
            panel1.Controls.Add(hopeTextBoxName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 24);
            panel1.Paint += panel1_Paint;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(11, 24, 87);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(786, 398);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            // 
            // Stats
            // 
            Stats.BackColor = Color.FromArgb(11, 24, 87);
            Stats.Controls.Add(poisonListView1);
            Stats.Location = new Point(0, 40);
            Stats.Name = "Stats";
            Stats.Padding = new Padding(3);
            Stats.Size = new Size(786, 398);
            Stats.TabIndex = 1;
            Stats.Text = "LIST";
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
            btnClear.Location = new Point(310, 302);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(66, 36);
            btnClear.TabIndex = 40;
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
            btnDelete.Location = new Point(402, 302);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 39;
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
            btnEdit.Location = new Point(515, 302);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(64, 36);
            btnEdit.TabIndex = 37;
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
            btnBackList.Location = new Point(207, 302);
            btnBackList.Margin = new Padding(4, 6, 4, 6);
            btnBackList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnBackList.Name = "btnBackList";
            btnBackList.NoAccentTextColor = Color.Empty;
            btnBackList.Size = new Size(64, 36);
            btnBackList.TabIndex = 36;
            btnBackList.Text = "BACK";
            btnBackList.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBackList.UseAccentColor = false;
            btnBackList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(241, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(332, 35);
            label2.TabIndex = 0;
            label2.Text = "Register-College-Subject";
            // 
            // hopeTextBoxName
            // 
            hopeTextBoxName.BackColor = Color.White;
            hopeTextBoxName.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxName.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxName.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxName.Font = new Font("Segoe UI", 12F);
            hopeTextBoxName.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxName.Hint = "NAME";
            hopeTextBoxName.Location = new Point(37, 60);
            hopeTextBoxName.MaxLength = 32767;
            hopeTextBoxName.Multiline = false;
            hopeTextBoxName.Name = "hopeTextBoxName";
            hopeTextBoxName.PasswordChar = '\0';
            hopeTextBoxName.ScrollBars = ScrollBars.None;
            hopeTextBoxName.SelectedText = "";
            hopeTextBoxName.SelectionLength = 0;
            hopeTextBoxName.SelectionStart = 0;
            hopeTextBoxName.Size = new Size(207, 38);
            hopeTextBoxName.TabIndex = 1;
            hopeTextBoxName.TabStop = false;
            hopeTextBoxName.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxLoad
            // 
            hopeTextBoxLoad.BackColor = Color.White;
            hopeTextBoxLoad.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxLoad.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxLoad.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxLoad.Font = new Font("Segoe UI", 12F);
            hopeTextBoxLoad.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxLoad.Hint = "COURSE LOAD";
            hopeTextBoxLoad.Location = new Point(37, 118);
            hopeTextBoxLoad.MaxLength = 32767;
            hopeTextBoxLoad.Multiline = false;
            hopeTextBoxLoad.Name = "hopeTextBoxLoad";
            hopeTextBoxLoad.PasswordChar = '\0';
            hopeTextBoxLoad.ScrollBars = ScrollBars.None;
            hopeTextBoxLoad.SelectedText = "";
            hopeTextBoxLoad.SelectionLength = 0;
            hopeTextBoxLoad.SelectionStart = 0;
            hopeTextBoxLoad.Size = new Size(207, 38);
            hopeTextBoxLoad.TabIndex = 2;
            hopeTextBoxLoad.TabStop = false;
            hopeTextBoxLoad.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxID
            // 
            hopeTextBoxID.BackColor = Color.White;
            hopeTextBoxID.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxID.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxID.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxID.Font = new Font("Segoe UI", 12F);
            hopeTextBoxID.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxID.Hint = "ID";
            hopeTextBoxID.Location = new Point(96, 179);
            hopeTextBoxID.MaxLength = 32767;
            hopeTextBoxID.Multiline = false;
            hopeTextBoxID.Name = "hopeTextBoxID";
            hopeTextBoxID.PasswordChar = '\0';
            hopeTextBoxID.ScrollBars = ScrollBars.None;
            hopeTextBoxID.SelectedText = "";
            hopeTextBoxID.SelectionLength = 0;
            hopeTextBoxID.SelectionStart = 0;
            hopeTextBoxID.Size = new Size(47, 38);
            hopeTextBoxID.TabIndex = 3;
            hopeTextBoxID.TabStop = false;
            hopeTextBoxID.UseSystemPasswordChar = false;
            // 
            // CollegeSubjectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(791, 450);
            Controls.Add(label1);
            Image = (Image)resources.GetObject("$this.Image");
            Location = new Point(0, 0);
            Name = "CollegeSubjectForm";
            Text = "CollegeSubjectForm";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(hopeTabPage1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Stats.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage Register;
        private TabPage Stats;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnClear;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnBackList;
        private ReaLTaiizor.Controls.PoisonListView poisonListView1;
        private Label label2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxLoad;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxName;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxID;
    }
}