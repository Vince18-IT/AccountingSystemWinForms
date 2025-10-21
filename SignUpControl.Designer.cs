namespace AccountingSystemWinForms
{
    partial class SignUpControl
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
            label2 = new Label();
            panel1 = new Panel();
            btnBackToLogin = new Krypton.Toolkit.KryptonButton();
            btnCreateAccount = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox4 = new Krypton.Toolkit.KryptonTextBox();
            panel2 = new Panel();
            kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1.Panel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(7, 67, 130);
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(206, 65);
            label1.TabIndex = 9;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(140, 140, 140);
            label2.Location = new Point(194, 485);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 10, 0);
            label2.Size = new Size(45, 19);
            label2.TabIndex = 21;
            label2.Text = "Or";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(37, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 1);
            panel1.TabIndex = 20;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Cursor = Cursors.Hand;
            btnBackToLogin.Location = new Point(37, 516);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.OverrideDefault.Back.Color1 = SystemColors.ActiveBorder;
            btnBackToLogin.OverrideDefault.Back.Color2 = SystemColors.ActiveBorder;
            btnBackToLogin.OverrideFocus.Back.Color1 = Color.FromArgb(190, 190, 190);
            btnBackToLogin.OverrideFocus.Back.Color2 = Color.FromArgb(190, 190, 190);
            btnBackToLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBackToLogin.Size = new Size(355, 51);
            btnBackToLogin.StateCommon.Back.Color1 = SystemColors.ActiveBorder;
            btnBackToLogin.StateCommon.Back.Color2 = SystemColors.ActiveBorder;
            btnBackToLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBackToLogin.StateCommon.Border.Rounding = 20F;
            btnBackToLogin.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnBackToLogin.StateCommon.Content.ShortText.Color2 = SystemColors.ScrollBar;
            btnBackToLogin.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToLogin.StateNormal.Back.Color1 = SystemColors.ActiveBorder;
            btnBackToLogin.StateNormal.Back.Color2 = SystemColors.ActiveBorder;
            btnBackToLogin.StatePressed.Back.Color1 = Color.FromArgb(190, 190, 190);
            btnBackToLogin.StatePressed.Back.Color2 = Color.FromArgb(190, 190, 190);
            btnBackToLogin.StateTracking.Back.Color1 = Color.FromArgb(190, 190, 190);
            btnBackToLogin.StateTracking.Back.Color2 = Color.FromArgb(190, 190, 190);
            btnBackToLogin.TabIndex = 19;
            btnBackToLogin.Values.DropDownArrowColor = Color.Empty;
            btnBackToLogin.Values.Text = "Login";
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.Location = new Point(33, 416);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCreateAccount.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCreateAccount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCreateAccount.Size = new Size(357, 51);
            btnCreateAccount.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCreateAccount.StateCommon.Border.Rounding = 20F;
            btnCreateAccount.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCreateAccount.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCreateAccount.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnCreateAccount.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCreateAccount.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCreateAccount.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnCreateAccount.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnCreateAccount.TabIndex = 18;
            btnCreateAccount.Values.DropDownArrowColor = Color.Empty;
            btnCreateAccount.Values.Text = "Create Account";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.CueHint.Color1 = Color.FromArgb(150, 150, 150);
            kryptonTextBox2.CueHint.CueHintText = "Username";
            kryptonTextBox2.CueHint.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            kryptonTextBox2.Location = new Point(35, 102);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(355, 52);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            kryptonTextBox2.StateCommon.Content.Padding = new Padding(50, 8, 10, 8);
            kryptonTextBox2.StateNormal.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.TabIndex = 22;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.CueHint.Color1 = Color.FromArgb(150, 150, 150);
            kryptonTextBox1.CueHint.CueHintText = "Username";
            kryptonTextBox1.CueHint.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            kryptonTextBox1.Location = new Point(35, 179);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(355, 52);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            kryptonTextBox1.StateCommon.Content.Padding = new Padding(50, 8, 10, 8);
            kryptonTextBox1.StateNormal.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.TabIndex = 23;
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.CueHint.Color1 = Color.FromArgb(150, 150, 150);
            kryptonTextBox3.CueHint.CueHintText = "Password";
            kryptonTextBox3.CueHint.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox3.Location = new Point(35, 259);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.PasswordChar = '*';
            kryptonTextBox3.Size = new Size(353, 52);
            kryptonTextBox3.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox3.StateCommon.Border.Rounding = 20F;
            kryptonTextBox3.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox3.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            kryptonTextBox3.StateCommon.Content.Padding = new Padding(50, 8, 10, 8);
            kryptonTextBox3.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonTextBox3.TabIndex = 24;
            // 
            // kryptonTextBox4
            // 
            kryptonTextBox4.CueHint.Color1 = Color.FromArgb(150, 150, 150);
            kryptonTextBox4.CueHint.CueHintText = "Password";
            kryptonTextBox4.CueHint.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox4.Location = new Point(33, 332);
            kryptonTextBox4.Name = "kryptonTextBox4";
            kryptonTextBox4.PasswordChar = '*';
            kryptonTextBox4.Size = new Size(353, 52);
            kryptonTextBox4.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox4.StateCommon.Border.Rounding = 20F;
            kryptonTextBox4.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox4.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            kryptonTextBox4.StateCommon.Content.Padding = new Padding(50, 8, 10, 8);
            kryptonTextBox4.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonTextBox4.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(kryptonTextBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(kryptonTextBox1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnCreateAccount);
            panel2.Controls.Add(kryptonTextBox4);
            panel2.Controls.Add(btnBackToLogin);
            panel2.Controls.Add(kryptonTextBox3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(46, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 599);
            panel2.TabIndex = 26;
            // 
            // kryptonGroup1
            // 
            kryptonGroup1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            kryptonGroup1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormMain;
            kryptonGroup1.Location = new Point(3, 3);
            kryptonGroup1.Size = new Size(554, 665);
            kryptonGroup1.StateCommon.Back.Color1 = Color.White;
            kryptonGroup1.StateCommon.Border.Rounding = 25F;
            kryptonGroup1.TabIndex = 27;
            // 
            // SignUpControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            Controls.Add(panel2);
            Controls.Add(kryptonGroup1);
            Name = "SignUpControl";
            Size = new Size(560, 680);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroup1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        public Krypton.Toolkit.KryptonButton btnBackToLogin;
        public Krypton.Toolkit.KryptonButton btnCreateAccount;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Panel panel2;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
    }
}
