using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();
            UiDesign.ApplyShadow(this);
            DisplayTransactions();
        }
        //enable window buffering (para ma smooth ang pag render)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void DisplayTransactions()
        {
            // Clear existing controls (if any)
            panel5.Controls.Clear();

            // Get dummy data
            List<Transaction> transactions = Transaction.GetAllTransactions();

            int y = 10; // Vertical spacing for each label

            foreach (var t in transactions)
            {
                // Create a Label for each transaction
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lbl.ForeColor = Color.Black;
                lbl.Location = new Point(10, y);
                lbl.Text = $"Date: {t.transaction_date:MMM dd, yyyy} | Desc: {t.transaction_desc}";

                // Add the label to the panel
                panel5.Controls.Add(lbl);

                // Move down for the next label
                y += 30;
            }
        }
        public class Transaction
        {
            public int transaction_id { get; set; }
            public DateTime transaction_date { get; set; }
            public string? transaction_desc { get; set; }

            // Holds all transactions (acts like an in-memory list)
            public static List<Transaction> oldTransactions { get;  set; } = new List<Transaction>();

            // Initialize with dummy data once
            static Transaction()
            {
                oldTransactions = new List<Transaction>
            {
                new Transaction {  transaction_date = DateTime.Now.AddDays(-10), transaction_desc = "Membership payment" },
                new Transaction {  transaction_date = DateTime.Now.AddDays(-9), transaction_desc = "Purchase of PSITS hoodie" },
                new Transaction {  transaction_date = DateTime.Now.AddDays(-8), transaction_desc = "Event registration fee" },
                new Transaction {  transaction_date = DateTime.Now.AddDays(-7), transaction_desc = "Donation for outreach program" },
                new Transaction {  transaction_date = DateTime.Now.AddDays(-6), transaction_desc = "Payment for ID replacement" },
                new Transaction {  transaction_date = DateTime.Now.AddDays(-5), transaction_desc = "Purchase of organization shirt" },
                new Transaction { transaction_date = DateTime.Now.AddDays(-4), transaction_desc = "Payment for seminar materials" },
                new Transaction { transaction_date = DateTime.Now.AddDays(-3), transaction_desc = "Payment for PSITS mug" },
                new Transaction { transaction_date = DateTime.Now.AddDays(-2), transaction_desc = "Membership renewal fee" },
                new Transaction { transaction_date = DateTime.Now.AddDays(-1), transaction_desc = "Payment for club event ticket" }
            };
            }
         

            // Method to get all current transactions
            public static List<Transaction> GetAllTransactions()
            {
                return oldTransactions;
            }

            // Method to add a new transaction dynamically
            public static void AddTransaction(Transaction newTransaction)
            {
                oldTransactions.Add(newTransaction);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1352, 746); // set size again ( kay nay bug usahay )

            //display ang note
            NoteControl notes = new NoteControl();
            notes.Dock = DockStyle.Fill;
            notes.Margin = new Padding(0);
            this.Controls.Add(notes);
            notes.BringToFront();

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to exit the application?",
             "Exit Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm.welcomeForm.Show();

        }

        private void BtnNewTransactions_Click(object sender, EventArgs e)
        {
            btnNewTransactions.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnNewTransactions.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);

            tabHolder.SelectedTab = tabNewTransactions;
        }
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            //DialogAddTransactions addTransactions = new DialogAddTransactions();
            //UiDesign.ShowDialogDimBackground(this, addTransactions, 15);

            Transaction.AddTransaction(new Transaction
            {
                
                transaction_date = DateTime.Now,
                transaction_desc = textBox2.Text
            });
            DisplayTransactions();
            textBox2.Text = "";

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            btnTransaction.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnTransaction.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabTransactions;

        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            btnAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnAccounts.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabAccounts;
        }
        private void btnGeneralJournal_Click(object sender, EventArgs e)
        {
            btnGeneralJournal.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralJournal.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabGeneralJournal;

        }
        private void btnGeneralLedger_Click(object sender, EventArgs e)
        {
            btnGeneralLedger.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnGeneralLedger.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabGeneralLedger;

        }

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            btnBalanceSheet.OverrideDefault.Back.Color1 = Color.FromArgb(34, 82, 133);
            btnBalanceSheet.OverrideDefault.Back.Color2 = Color.FromArgb(34, 82, 133);
            tabHolder.SelectedTab = tabBalanceSheet;

        }

        private void tableTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
