namespace EduData.App.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            Register = new TabPage();
            panel1 = new Panel();
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
            hopeTabPage1.Location = new Point(5, 50);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(790, 382);
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
            Register.Controls.Add(panel1);
            Register.Controls.Add(btnCreate);
            Register.Controls.Add(btnBack);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(790, 342);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
            Register.Click += Register_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(48, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 247);
            panel1.TabIndex = 21;
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
            btnCreate.Location = new Point(132, 295);
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
            btnCreate.Click += btnCreate_Click;
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
            btnBack.Location = new Point(60, 295);
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
            btnBack.Click += btnBack_Click;
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
            Stats.Size = new Size(790, 342);
            Stats.TabIndex = 1;
            Stats.Text = "LIST";
            // 
            // poisonListView1
            // 
            poisonListView1.Font = new Font("Segoe UI", 12F);
            poisonListView1.FullRowSelect = true;
            poisonListView1.HideSelection = true;
            poisonListView1.Location = new Point(199, 33);
            poisonListView1.Name = "poisonListView1";
            poisonListView1.OwnerDraw = true;
            poisonListView1.Size = new Size(381, 217);
            poisonListView1.TabIndex = 37;
            poisonListView1.UseCompatibleStateImageBehavior = false;
            poisonListView1.UseSelectable = true;
            poisonListView1.View = View.Details;
            poisonListView1.SelectedIndexChanged += poisonListView1_SelectedIndexChanged;
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
            btnClear.Location = new Point(318, 274);
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
            btnClear.Click += btnClear_Click;
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
            btnDelete.Location = new Point(392, 274);
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
            btnDelete.Click += btnDelete_Click;
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
            btnEdit.Location = new Point(516, 274);
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
            btnEdit.Click += btnEdit_Click;
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
            btnBackList.Location = new Point(199, 274);
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
            btnBackList.Click += btnBackList_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 24, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(hopeTabPage1);
            HeaderColor = Color.FromArgb(28, 59, 214);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "BaseForm";
            Text = "BaseForm";
            hopeTabPage1.ResumeLayout(false);
            Register.ResumeLayout(false);
            Register.PerformLayout();
            Stats.ResumeLayout(false);
            Stats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage Register;
        private ReaLTaiizor.Controls.MaterialButton btnCreate;
        private ReaLTaiizor.Controls.MaterialButton btnBack;
        private TabPage Stats;
        private ReaLTaiizor.Controls.MaterialButton btnClear;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnBackList;
        public Panel panel1;
        public ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        public ReaLTaiizor.Controls.PoisonListView poisonListView1;
    }
}