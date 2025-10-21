namespace AccountingSystemWinForms
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            pictureBox2 = new PictureBox();
            btnSignUp = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            label2 = new Label();
            kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1.Panel).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(7, 67, 130);
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(168, 65);
            label1.TabIndex = 8;
            label1.Text = "Log in";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.CueHint.Color1 = Color.FromArgb(150, 150, 150);
            kryptonTextBox2.CueHint.CueHintText = "Username";
            kryptonTextBox2.CueHint.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            kryptonTextBox2.Location = new Point(17, 118);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(355, 52);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            kryptonTextBox2.StateCommon.Content.Padding = new Padding(50, 8, 10, 8);
            kryptonTextBox2.StateNormal.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.TabIndex = 9;
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.CueHint.Color1 = Color.FromArgb(150, 150, 150);
            kryptonTextBox3.CueHint.CueHintText = "Password";
            kryptonTextBox3.CueHint.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox3.Location = new Point(17, 188);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.PasswordChar = '*';
            kryptonTextBox3.Size = new Size(355, 52);
            kryptonTextBox3.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox3.StateCommon.Border.Rounding = 20F;
            kryptonTextBox3.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox3.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            kryptonTextBox3.StateCommon.Content.Padding = new Padding(50, 8, 10, 8);
            kryptonTextBox3.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonTextBox3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BackgroundImage = Properties.Resources.user_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(33, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(15, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnLogin.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnLogin.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLogin.Size = new Size(357, 51);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateCommon.Border.Rounding = 20F;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnLogin.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnLogin.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnLogin.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnLogin.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnLogin.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnLogin.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnLogin.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnLogin.TabIndex = 12;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImage = Properties.Resources.password_freepik;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(32, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Location = new Point(17, 379);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.OverrideDefault.Back.Color1 = SystemColors.ActiveBorder;
            btnSignUp.OverrideDefault.Back.Color2 = SystemColors.ActiveBorder;
            btnSignUp.OverrideFocus.Back.Color1 = Color.FromArgb(190, 190, 190);
            btnSignUp.OverrideFocus.Back.Color2 = Color.FromArgb(190, 190, 190);
            btnSignUp.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSignUp.Size = new Size(355, 51);
            btnSignUp.StateCommon.Back.Color1 = SystemColors.ActiveBorder;
            btnSignUp.StateCommon.Back.Color2 = SystemColors.ActiveBorder;
            btnSignUp.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSignUp.StateCommon.Border.Rounding = 20F;
            btnSignUp.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnSignUp.StateCommon.Content.ShortText.Color2 = SystemColors.ScrollBar;
            btnSignUp.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.StateNormal.Back.Color1 = SystemColors.ActiveBorder;
            btnSignUp.StateNormal.Back.Color2 = SystemColors.ActiveBorder;
            btnSignUp.StatePressed.Back.Color1 = Color.FromArgb(190, 190, 190);
            btnSignUp.StatePressed.Back.Color2 = Color.FromArgb(190, 190, 190);
            btnSignUp.StateTracking.Back.Color1 = Color.FromArgb(190, 190, 190);
            btnSignUp.StateTracking.Back.Color2 = Color.FromArgb(190, 190, 190);
            btnSignUp.TabIndex = 14;
            btnSignUp.Values.DropDownArrowColor = Color.Empty;
            btnSignUp.Values.Text = "Sign-up";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(17, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 1);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(140, 140, 140);
            label2.Location = new Point(174, 346);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 10, 0);
            label2.Size = new Size(45, 19);
            label2.TabIndex = 17;
            label2.Text = "Or";
            // 
            // kryptonGroup1
            // 
            kryptonGroup1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            kryptonGroup1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            kryptonGroup1.Location = new Point(3, 3);
            kryptonGroup1.Size = new Size(551, 665);
            kryptonGroup1.StateCommon.Back.Color1 = Color.White;
            kryptonGroup1.StateCommon.Border.Rounding = 25F;
            kryptonGroup1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnSignUp);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(kryptonTextBox2);
            panel2.Controls.Add(kryptonTextBox3);
            panel2.Location = new Point(85, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 443);
            panel2.TabIndex = 19;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            Controls.Add(panel2);
            Controls.Add(kryptonGroup1);
            Name = "LoginControl";
            Size = new Size(560, 680);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private PictureBox pictureBox1;
        public Krypton.Toolkit.KryptonButton btnLogin;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonButton btnSignUp;
        private Panel panel1;
        private Label label2;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Panel panel2;
    }
}
