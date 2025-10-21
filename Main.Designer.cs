namespace AccountingSystemWinForms
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabHolder = new TabControl();
            tabNewTransactions = new TabPage();
            btnAddTransaction = new Krypton.Toolkit.KryptonButton();
            btnClearForm = new Krypton.Toolkit.KryptonButton();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tabTransactions = new TabPage();
            panel5 = new Panel();
            textBox8 = new TextBox();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            label6 = new Label();
            tabAccounts = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            tabGeneralJournal = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tabGeneralLedger = new TabPage();
            textBox6 = new TextBox();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            tabBalanceSheet = new TabPage();
            label5 = new Label();
            pnlContent1 = new Krypton.Toolkit.KryptonGroup();
            pnlCover = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnNewTransactions = new Krypton.Toolkit.KryptonButton();
            btnTransaction = new Krypton.Toolkit.KryptonButton();
            btnAccounts = new Krypton.Toolkit.KryptonButton();
            btnGeneralJournal = new Krypton.Toolkit.KryptonButton();
            btnGeneralLedger = new Krypton.Toolkit.KryptonButton();
            btnBalanceSheet = new Krypton.Toolkit.KryptonButton();
            btnLogOut = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            btnClose = new PictureBox();
            tabHolder.SuspendLayout();
            tabNewTransactions.SuspendLayout();
            tabTransactions.SuspendLayout();
            tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabGeneralJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabGeneralLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabBalanceSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlContent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlContent1.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // tabHolder
            // 
            tabHolder.Appearance = TabAppearance.FlatButtons;
            tabHolder.Controls.Add(tabNewTransactions);
            tabHolder.Controls.Add(tabTransactions);
            tabHolder.Controls.Add(tabAccounts);
            tabHolder.Controls.Add(tabGeneralJournal);
            tabHolder.Controls.Add(tabGeneralLedger);
            tabHolder.Controls.Add(tabBalanceSheet);
            tabHolder.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabHolder.Location = new Point(207, 59);
            tabHolder.Name = "tabHolder";
            tabHolder.Padding = new Point(0, 0);
            tabHolder.SelectedIndex = 0;
            tabHolder.Size = new Size(1118, 664);
            tabHolder.TabIndex = 0;
            // 
            // tabNewTransactions
            // 
            tabNewTransactions.BackColor = Color.White;
            tabNewTransactions.Controls.Add(btnAddTransaction);
            tabNewTransactions.Controls.Add(btnClearForm);
            tabNewTransactions.Controls.Add(textBox5);
            tabNewTransactions.Controls.Add(textBox3);
            tabNewTransactions.Controls.Add(label12);
            tabNewTransactions.Controls.Add(label11);
            tabNewTransactions.Controls.Add(textBox1);
            tabNewTransactions.Controls.Add(textBox4);
            tabNewTransactions.Controls.Add(label10);
            tabNewTransactions.Controls.Add(textBox2);
            tabNewTransactions.Controls.Add(label9);
            tabNewTransactions.Controls.Add(label8);
            tabNewTransactions.Location = new Point(4, 27);
            tabNewTransactions.Name = "tabNewTransactions";
            tabNewTransactions.Padding = new Padding(3);
            tabNewTransactions.Size = new Size(1110, 633);
            tabNewTransactions.TabIndex = 0;
            tabNewTransactions.Text = "tabPage1";
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.Location = new Point(581, 457);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAddTransaction.Size = new Size(216, 51);
            btnAddTransaction.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAddTransaction.StateCommon.Border.Rounding = 50F;
            btnAddTransaction.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddTransaction.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddTransaction.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAddTransaction.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAddTransaction.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnAddTransaction.TabIndex = 14;
            btnAddTransaction.Values.DropDownArrowColor = Color.Empty;
            btnAddTransaction.Values.Text = "ADD TRANSACTION";
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Cursor = Cursors.Hand;
            btnClearForm.Location = new Point(340, 457);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.OverrideDefault.Back.Color1 = Color.White;
            btnClearForm.OverrideDefault.Back.Color2 = Color.White;
            btnClearForm.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnClearForm.Size = new Size(216, 51);
            btnClearForm.StateCommon.Back.Color1 = Color.White;
            btnClearForm.StateCommon.Back.Color2 = Color.White;
            btnClearForm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnClearForm.StateCommon.Border.Rounding = 50F;
            btnClearForm.StateCommon.Content.ShortText.Color1 = Color.White;
            btnClearForm.StateCommon.Content.ShortText.Color2 = Color.White;
            btnClearForm.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClearForm.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnClearForm.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnClearForm.StateNormal.Back.Color1 = Color.White;
            btnClearForm.StateNormal.Back.Color2 = Color.White;
            btnClearForm.StateNormal.Border.Color1 = Color.Black;
            btnClearForm.StateNormal.Border.Color2 = Color.Black;
            btnClearForm.StateNormal.Border.Width = 1;
            btnClearForm.StateNormal.Content.ShortText.Color1 = Color.Black;
            btnClearForm.StateNormal.Content.ShortText.Color2 = Color.Black;
            btnClearForm.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            btnClearForm.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            btnClearForm.TabIndex = 13;
            btnClearForm.Values.DropDownArrowColor = Color.Empty;
            btnClearForm.Values.Text = "CLEAR FORM";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(593, 365);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(436, 29);
            textBox5.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(593, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(436, 29);
            textBox3.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(589, 330);
            label12.Name = "label12";
            label12.Size = new Size(73, 21);
            label12.TabIndex = 10;
            label12.Text = "Amount:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(588, 233);
            label11.Name = "label11";
            label11.Size = new Size(124, 21);
            label11.TabIndex = 9;
            label11.Text = "Credit Account:";
            label11.Click += label11_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(593, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 29);
            textBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(85, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(436, 29);
            textBox4.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(589, 125);
            label10.Name = "label10";
            label10.Size = new Size(119, 21);
            label10.TabIndex = 5;
            label10.Text = "Debit Account:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(84, 271);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(437, 123);
            textBox2.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(81, 233);
            label9.Name = "label9";
            label9.Size = new Size(98, 21);
            label9.TabIndex = 3;
            label9.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(81, 125);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 1;
            label8.Text = "Date (DD-MM-YYYY):";
            // 
            // tabTransactions
            // 
            tabTransactions.BackColor = Color.White;
            tabTransactions.Controls.Add(panel5);
            tabTransactions.Controls.Add(textBox8);
            tabTransactions.Controls.Add(kryptonButton3);
            tabTransactions.Controls.Add(label6);
            tabTransactions.Location = new Point(4, 27);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Padding = new Padding(3);
            tabTransactions.Size = new Size(1110, 633);
            tabTransactions.TabIndex = 1;
            tabTransactions.Text = "tabPage2";
            // 
            // panel5
            // 
            panel5.Location = new Point(35, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(827, 326);
            panel5.TabIndex = 25;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Segoe UI", 12F);
            textBox8.Location = new Point(35, 37);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(366, 38);
            textBox8.TabIndex = 24;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Cursor = Cursors.Hand;
            kryptonButton3.Location = new Point(413, 37);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton3.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            kryptonButton3.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton3.Size = new Size(78, 38);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            kryptonButton3.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton3.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton3.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton3.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton3.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            kryptonButton3.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            kryptonButton3.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            kryptonButton3.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            kryptonButton3.TabIndex = 23;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "FIND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 4);
            label6.Name = "label6";
            label6.Size = new Size(213, 30);
            label6.TabIndex = 22;
            label6.Text = "Search Transaction:";
            // 
            // tabAccounts
            // 
            tabAccounts.BackColor = Color.White;
            tabAccounts.Controls.Add(dataGridView1);
            tabAccounts.Controls.Add(label3);
            tabAccounts.Location = new Point(4, 27);
            tabAccounts.Name = "tabAccounts";
            tabAccounts.Padding = new Padding(3);
            tabAccounts.Size = new Size(1110, 633);
            tabAccounts.TabIndex = 2;
            tabAccounts.Text = "tabPage3";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.Location = new Point(32, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1046, 603);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Account";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Type";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Balance";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(529, 339);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 1;
            label3.Text = "Accounts";
            // 
            // tabGeneralJournal
            // 
            tabGeneralJournal.BackColor = Color.White;
            tabGeneralJournal.Controls.Add(dataGridView2);
            tabGeneralJournal.Location = new Point(4, 27);
            tabGeneralJournal.Name = "tabGeneralJournal";
            tabGeneralJournal.Padding = new Padding(3);
            tabGeneralJournal.Size = new Size(1110, 633);
            tabGeneralJournal.TabIndex = 3;
            tabGeneralJournal.Text = "white";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column1, Column2 });
            dataGridView2.Location = new Point(32, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(1046, 603);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Type";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Description";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Account";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Debit";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Credit";
            Column2.Name = "Column2";
            // 
            // tabGeneralLedger
            // 
            tabGeneralLedger.BackColor = Color.White;
            tabGeneralLedger.Controls.Add(textBox6);
            tabGeneralLedger.Controls.Add(kryptonButton2);
            tabGeneralLedger.Controls.Add(label1);
            tabGeneralLedger.Controls.Add(dataGridView4);
            tabGeneralLedger.Location = new Point(4, 27);
            tabGeneralLedger.Name = "tabGeneralLedger";
            tabGeneralLedger.Padding = new Padding(3);
            tabGeneralLedger.Size = new Size(1110, 633);
            tabGeneralLedger.TabIndex = 4;
            tabGeneralLedger.Text = "tabPage5";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(35, 37);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(366, 38);
            textBox6.TabIndex = 30;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Cursor = Cursors.Hand;
            kryptonButton2.Location = new Point(413, 37);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton2.OverrideFocus.Back.Color1 = Color.FromArgb(0, 124, 255);
            kryptonButton2.OverrideFocus.Back.Color2 = Color.FromArgb(0, 124, 255);
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton2.Size = new Size(78, 38);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            kryptonButton2.StateDisabled.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton2.StateDisabled.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton2.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            kryptonButton2.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(0, 124, 255);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(0, 124, 255);
            kryptonButton2.StateTracking.Back.Color1 = Color.FromArgb(0, 124, 255);
            kryptonButton2.StateTracking.Back.Color2 = Color.FromArgb(0, 124, 255);
            kryptonButton2.TabIndex = 29;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "FIND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 4);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 28;
            label1.Text = "Filter:";
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView4.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView4.ColumnHeadersHeight = 35;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            dataGridView4.Location = new Point(35, 123);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.Size = new Size(1046, 480);
            dataGridView4.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Date";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn15.HeaderText = "Description";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Debit Account";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Credit Account";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.Width = 200;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Amount";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.Width = 150;
            // 
            // tabBalanceSheet
            // 
            tabBalanceSheet.BackColor = Color.White;
            tabBalanceSheet.Controls.Add(label5);
            tabBalanceSheet.Location = new Point(4, 27);
            tabBalanceSheet.Name = "tabBalanceSheet";
            tabBalanceSheet.Padding = new Padding(3);
            tabBalanceSheet.Size = new Size(1110, 633);
            tabBalanceSheet.TabIndex = 5;
            tabBalanceSheet.Text = "tabPage6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(417, 248);
            label5.Name = "label5";
            label5.Size = new Size(181, 37);
            label5.TabIndex = 1;
            label5.Text = "Balance Sheet";
            // 
            // pnlContent1
            // 
            pnlContent1.Location = new Point(196, 42);
            pnlContent1.Size = new Size(1141, 691);
            pnlContent1.StateCommon.Back.Color1 = Color.White;
            pnlContent1.StateCommon.Border.Rounding = 25F;
            pnlContent1.TabIndex = 6;
            // 
            // pnlCover
            // 
            pnlCover.BackColor = Color.White;
            pnlCover.Location = new Point(205, 54);
            pnlCover.Name = "pnlCover";
            pnlCover.Size = new Size(1120, 35);
            pnlCover.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(204, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 661);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(205, 710);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 14);
            panel2.TabIndex = 9;
            // 
            // btnNewTransactions
            // 
            btnNewTransactions.Cursor = Cursors.Hand;
            btnNewTransactions.Location = new Point(12, 168);
            btnNewTransactions.Name = "btnNewTransactions";
            btnNewTransactions.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNewTransactions.Size = new Size(167, 37);
            btnNewTransactions.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNewTransactions.StateCommon.Border.Rounding = 20F;
            btnNewTransactions.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNewTransactions.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNewTransactions.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewTransactions.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnNewTransactions.TabIndex = 34;
            btnNewTransactions.Values.DropDownArrowColor = Color.Empty;
            btnNewTransactions.Values.Text = "New Transactions";
            btnNewTransactions.Click += BtnNewTransactions_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Cursor = Cursors.Hand;
            btnTransaction.Location = new Point(12, 211);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTransaction.Size = new Size(167, 37);
            btnTransaction.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTransaction.StateCommon.Border.Rounding = 20F;
            btnTransaction.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTransaction.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTransaction.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnTransaction.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnTransaction.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnTransaction.TabIndex = 35;
            btnTransaction.Values.DropDownArrowColor = Color.Empty;
            btnTransaction.Values.Text = "Transactions";
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.Cursor = Cursors.Hand;
            btnAccounts.Location = new Point(12, 254);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAccounts.Size = new Size(167, 37);
            btnAccounts.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAccounts.StateCommon.Border.Rounding = 20F;
            btnAccounts.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccounts.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAccounts.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccounts.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnAccounts.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnAccounts.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnAccounts.TabIndex = 36;
            btnAccounts.Values.DropDownArrowColor = Color.Empty;
            btnAccounts.Values.Text = "Accounts";
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnGeneralJournal
            // 
            btnGeneralJournal.Cursor = Cursors.Hand;
            btnGeneralJournal.Location = new Point(12, 297);
            btnGeneralJournal.Name = "btnGeneralJournal";
            btnGeneralJournal.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGeneralJournal.Size = new Size(167, 37);
            btnGeneralJournal.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGeneralJournal.StateCommon.Border.Rounding = 20F;
            btnGeneralJournal.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGeneralJournal.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGeneralJournal.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneralJournal.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralJournal.TabIndex = 37;
            btnGeneralJournal.Values.DropDownArrowColor = Color.Empty;
            btnGeneralJournal.Values.Text = "General Journal";
            btnGeneralJournal.Click += btnGeneralJournal_Click;
            // 
            // btnGeneralLedger
            // 
            btnGeneralLedger.Cursor = Cursors.Hand;
            btnGeneralLedger.Location = new Point(12, 340);
            btnGeneralLedger.Name = "btnGeneralLedger";
            btnGeneralLedger.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGeneralLedger.Size = new Size(167, 37);
            btnGeneralLedger.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGeneralLedger.StateCommon.Border.Rounding = 20F;
            btnGeneralLedger.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGeneralLedger.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGeneralLedger.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneralLedger.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnGeneralLedger.TabIndex = 38;
            btnGeneralLedger.Values.DropDownArrowColor = Color.Empty;
            btnGeneralLedger.Values.Text = "General Ledger";
            btnGeneralLedger.Click += btnGeneralLedger_Click;
            // 
            // btnBalanceSheet
            // 
            btnBalanceSheet.Cursor = Cursors.Hand;
            btnBalanceSheet.Location = new Point(12, 383);
            btnBalanceSheet.Name = "btnBalanceSheet";
            btnBalanceSheet.OverrideDefault.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideDefault.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideDefault.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideDefault.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideFocus.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.OverrideFocus.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.OverrideFocus.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.OverrideFocus.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBalanceSheet.Size = new Size(167, 37);
            btnBalanceSheet.StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBalanceSheet.StateCommon.Border.Rounding = 20F;
            btnBalanceSheet.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBalanceSheet.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBalanceSheet.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalanceSheet.StateDisabled.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateDisabled.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateNormal.Back.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateNormal.Back.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateNormal.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateNormal.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StatePressed.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StatePressed.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StatePressed.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StatePressed.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateTracking.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateTracking.Back.Color2 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.StateTracking.Border.Color1 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.StateTracking.Border.Color2 = Color.FromArgb(7, 67, 130);
            btnBalanceSheet.TabIndex = 39;
            btnBalanceSheet.Values.DropDownArrowColor = Color.Empty;
            btnBalanceSheet.Values.Text = "Balance Sheet";
            btnBalanceSheet.Click += btnBalanceSheet_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Font = new Font("Segoe UI", 10F);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(62, 575);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(57, 19);
            btnLogOut.TabIndex = 40;
            btnLogOut.Text = "Log out";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(150, 150, 150);
            panel4.Location = new Point(21, 557);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 1);
            panel4.TabIndex = 41;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 30);
            label7.Name = "label7";
            label7.Size = new Size(178, 110);
            label7.TabIndex = 1;
            label7.Text = "Accounting System";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(1317, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 658);
            panel3.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.exit_google;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(1313, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 42;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 67, 130);
            ClientSize = new Size(1283, 680);
            CloseBox = false;
            Controls.Add(btnClose);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(btnLogOut);
            Controls.Add(btnBalanceSheet);
            Controls.Add(btnGeneralLedger);
            Controls.Add(btnGeneralJournal);
            Controls.Add(btnAccounts);
            Controls.Add(btnTransaction);
            Controls.Add(btnNewTransactions);
            Controls.Add(panel1);
            Controls.Add(pnlCover);
            Controls.Add(tabHolder);
            Controls.Add(pnlContent1);
            ForeColor = Color.FromArgb(7, 67, 130);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Back.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Border.Color1 = Color.White;
            StateCommon.Border.Color2 = Color.White;
            StateCommon.Border.Rounding = 20F;
            StateCommon.Border.Width = 0;
            StateCommon.Header.Back.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Back.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Border.Color1 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.Border.Color2 = Color.FromArgb(7, 67, 130);
            StateCommon.Header.ButtonEdgeInset = 0;
            Load += Main_Load;
            tabHolder.ResumeLayout(false);
            tabNewTransactions.ResumeLayout(false);
            tabNewTransactions.PerformLayout();
            tabTransactions.ResumeLayout(false);
            tabTransactions.PerformLayout();
            tabAccounts.ResumeLayout(false);
            tabAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabGeneralJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabGeneralLedger.ResumeLayout(false);
            tabGeneralLedger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabBalanceSheet.ResumeLayout(false);
            tabBalanceSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlContent1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlContent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabHolder;
        private TabPage tabNewTransactions;
        private TabPage tabAccounts;
        private TabPage tabGeneralJournal;
        private TabPage tabGeneralLedger;
        private TabPage tabBalanceSheet;
        private Krypton.Toolkit.KryptonGroup pnlContent1;
        private Panel pnlCover;
        private Panel panel1;
        private Panel panel2;
        public Krypton.Toolkit.KryptonButton btnNewTransactions;
        public Krypton.Toolkit.KryptonButton btnTransaction;
        public Krypton.Toolkit.KryptonButton btnAccounts;
        public Krypton.Toolkit.KryptonButton btnGeneralJournal;
        public Krypton.Toolkit.KryptonButton btnGeneralLedger;
        public Krypton.Toolkit.KryptonButton btnBalanceSheet;
        private Label btnLogOut;
        private Panel panel4;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private Label label9;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label12;
        public Krypton.Toolkit.KryptonButton btnAddTransaction;
        public Krypton.Toolkit.KryptonButton btnClearForm;
        private Panel panel3;
        private PictureBox btnClose;
        private DataGridView dataGridView1;
        private TabPage tabTransactions;
        private TextBox textBox8;
        public Krypton.Toolkit.KryptonButton kryptonButton3;
        private Label label6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TextBox textBox6;
        public Krypton.Toolkit.KryptonButton kryptonButton2;
        private Label label1;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel5;
    }
}