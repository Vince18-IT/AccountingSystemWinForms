using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AccountingSystemWinForms
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();

            // Call the method to display the transactions
            DisplayTransactions();
        }

        private void DisplayTransactions()
        {
            // Clear existing controls (if any)
            panel1.Controls.Clear();

            // Get dummy data
            List<Transaction> transactions = Transaction.getAllTransaction();

            int y = 10; // Vertical spacing for each label

            foreach (var t in transactions)
            {
                // Create a Label for each transaction
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lbl.ForeColor = Color.Black;
                lbl.Location = new Point(10, y);
                lbl.Text = $"ID: {t.transaction_id} | Date: {t.transaction_date:MMM dd, yyyy} | Desc: {t.transaction_desc}";

                // Add the label to the panel
                panel1.Controls.Add(lbl);

                // Move down for the next label
                y += 30;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }

    public class Transaction
    {
        public int transaction_id { get; set; }
        public DateTime transaction_date { get; set; }
        public string? transaction_desc { get; set; }

        public static List<Transaction> getAllTransaction()
        {
            return new List<Transaction>
            {
                new Transaction { transaction_id = 1, transaction_date = DateTime.Now.AddDays(-10), transaction_desc = "Membership payment" },
                new Transaction { transaction_id = 2, transaction_date = DateTime.Now.AddDays(-9), transaction_desc = "Purchase of PSITS hoodie" },
                new Transaction { transaction_id = 3, transaction_date = DateTime.Now.AddDays(-8), transaction_desc = "Event registration fee" },
                new Transaction { transaction_id = 4, transaction_date = DateTime.Now.AddDays(-7), transaction_desc = "Donation for outreach program" },
                new Transaction { transaction_id = 5, transaction_date = DateTime.Now.AddDays(-6), transaction_desc = "Payment for ID replacement" },
                new Transaction { transaction_id = 6, transaction_date = DateTime.Now.AddDays(-5), transaction_desc = "Purchase of organization shirt" },
                new Transaction { transaction_id = 7, transaction_date = DateTime.Now.AddDays(-4), transaction_desc = "Payment for seminar materials" },
                new Transaction { transaction_id = 8, transaction_date = DateTime.Now.AddDays(-3), transaction_desc = "Payment for PSITS mug" },
                new Transaction { transaction_id = 9, transaction_date = DateTime.Now.AddDays(-2), transaction_desc = "Membership renewal fee" },
                new Transaction { transaction_id = 10, transaction_date = DateTime.Now.AddDays(-1), transaction_desc = "Payment for club event ticket" }
            };
        }
    }
}
