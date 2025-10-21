namespace AccountingSystemWinForms
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginControl = new LoginControl();
            closeButton = new Krypton.Toolkit.ButtonSpecAny();
            signUpControl = new SignUpControl();
            SuspendLayout();
            // 
            // loginControl
            // 
            loginControl.BackColor = Color.FromArgb(7, 67, 130);
            loginControl.Location = new Point(743, 4);
            loginControl.Name = "loginControl";
            loginControl.Size = new Size(560, 680);
            loginControl.TabIndex = 3;
            loginControl.Load += loginControl1_Load;
            // 
            // closeButton
            // 
            closeButton.Image = Properties.Resources.exit_google;
            closeButton.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            closeButton.UniqueName = "b2ecc761f8e04e839387be0f7f1dbcdc";
            // 
            // signUpControl
            // 
            signUpControl.BackColor = Color.FromArgb(7, 67, 130);
            signUpControl.Location = new Point(32, 4);
            signUpControl.Name = "signUpControl";
            signUpControl.Size = new Size(563, 688);
            signUpControl.TabIndex = 5;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            ButtonSpecs.Add(closeButton);
            ClientSize = new Size(1330, 708);
            CloseBox = false;
            Controls.Add(signUpControl);
            Controls.Add(loginControl);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            StateCommon.Border.Rounding = 20F;
            StateCommon.Header.Back.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Back.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            StateCommon.Header.Border.Rounding = 10F;
            StateCommon.Header.ButtonEdgeInset = 20;
            StateCommon.Header.Content.Padding = new Padding(20, 0, 0, 0);
            TransparencyKey = Color.Silver;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        public LoginControl loginControl;
        private Krypton.Toolkit.ButtonSpecAny closeButton;
        public SignUpControl signUpControl;
    }
}
