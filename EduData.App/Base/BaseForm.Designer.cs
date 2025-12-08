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
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
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
            hopeTabPage1.Location = new Point(5, 39);
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
            Register.Controls.Add(materialButton2);
            Register.Controls.Add(materialButton1);
            Register.ForeColor = SystemColors.ControlText;
            Register.Location = new Point(0, 40);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(790, 366);
            Register.TabIndex = 0;
            Register.Text = "RESGISTER";
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
            materialButton2.Location = new Point(176, 295);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(76, 36);
            materialButton2.TabIndex = 20;
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
            materialButton1.Location = new Point(60, 295);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 19;
            materialButton1.Text = "Back";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
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
            poisonListView1.Location = new Point(199, 33);
            poisonListView1.Name = "poisonListView1";
            poisonListView1.OwnerDraw = true;
            poisonListView1.Size = new Size(381, 217);
            poisonListView1.TabIndex = 37;
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

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage Register;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private TabPage Stats;
        private ReaLTaiizor.Controls.PoisonListView poisonListView1;
        private ReaLTaiizor.Controls.MaterialButton materialButton6;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private ReaLTaiizor.Controls.MaterialButton materialButton7;
        private ReaLTaiizor.Controls.MaterialButton materialButton8;
    }
}