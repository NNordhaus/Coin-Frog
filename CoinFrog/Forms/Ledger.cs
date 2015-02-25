using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

using CoinFrog.Models;
using System.IO;
using CoinFrog.Forms;

namespace CoinFrog
{
    public partial class Ledger : Form
    {
        private Models.Ledger ledger = new Models.Ledger() { Name = "Checking" };

        string currentFilePath = "";
        bool isCurrentFileSaved = true;

        public Ledger()
        {
            InitializeComponent();

            // add some test data
            ledger.AddTransactions(new List<Transaction>()
            {
                new Transaction(){ Date = DateTime.Parse("1/1/2014"), DateFinal = true, Description = "Starting Balance", Amount = 1000, AmountFinal = true, Status = "Completed" },
                new Transaction(){ Date = DateTime.Parse("1/10/2014"), DateFinal = true, Description = "Rent", Amount = -750, AmountFinal = true, Status = "Completed" },
                new Transaction(){ Date = DateTime.Parse("1/12/2014"), DateFinal = true, Description = "Paycheck", DescriptionBackColor = Color.Purple.ToArgb(), DescriptionForeColor = Color.White.ToArgb(),
                    Amount = 995.23m, AmountFinal = true, Status = "Completed" },
                new Transaction(){ Date = DateTime.Parse("12/23/2014"), Description = "Visa Card", Amount = -221.57m, Status = "To Do" },
            });

            PopulateListView();
        }

        void PopulateListView()
        {
            lblLedgerName.Text = ledger.Name;
            SuspendLayout();
            lvTrans.Items.Clear();

            foreach (var t in ledger.LedgerTransactions)
            {
                var lvi = new ListViewItem(t.Date.ToShortDateString());
                lvi.Tag = t;
                lvi.UseItemStyleForSubItems = false;
                if(!t.DateFinal)
                {
                    lvi.SubItems[0].ForeColor = Color.Red;
                }
                lvi.SubItems.Add(t.Description);
                lvi.SubItems[1].BackColor = Color.FromArgb(t.DescriptionBackColor);
                lvi.SubItems[1].ForeColor = Color.FromArgb(t.DescriptionForeColor);
                lvi.SubItems.Add(t.Amount.ToString("$#,##0.00"));
                if (!t.AmountFinal)
                {
                    lvi.SubItems[2].ForeColor = Color.Red;
                }
                lvi.SubItems.Add(t.Balance.ToString("$#,##0.00"));
                lvi.SubItems.Add(t.Status);
                SetStatusColor(lvi.SubItems[4], t.Status);
                lvTrans.Items.Add(lvi);
            }

            // ToDo: scroll to the first non-complete transaction, since the list could be very long

            ResumeLayout();
        }

        private void SetStatusColor(ListViewItem.ListViewSubItem item, string status)
        {
            var statusDef = ledger.Statuses.FirstOrDefault(s => s.Name == status);
            if (statusDef != null)
            {
                item.ForeColor = Color.FromArgb(statusDef.ForeColor);
                item.BackColor = Color.FromArgb(statusDef.BackColor);
            }
        }

        private void lvTrans_DoubleClick(object sender, EventArgs e)
        {
            // If a single row is selected, open it in the Transaction Add/Edit form
            if (lvTrans.SelectedIndices.Count == 1)
            {
                var index = lvTrans.SelectedIndices[0];
                var frm = new AddEditTransaction(ledger.LedgerTransactions[index], ledger.Statuses);
                if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ledger.Transactions.RemoveAt(index);
                    ledger.AddTransaction(frm.Transaction);
                    PopulateListView();
                }
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var frm = new AddEditTransaction(null, ledger.Statuses);

            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // add it
                ledger.AddTransaction(frm.Transaction);
                PopulateListView();
                isCurrentFileSaved = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentFilePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }

            File.WriteAllText(currentFilePath, ledger.ToJson());
            isCurrentFileSaved = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sd = new SaveFileDialog();

            if (sd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                currentFilePath = sd.FileName;
                saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAndSaveCurrentFile();

            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var settings = new JsonSerializerSettings()
                {
                     NullValueHandling = NullValueHandling.Include
                };
                ledger = JsonConvert.DeserializeObject<Models.Ledger>(File.ReadAllText(ofd.FileName), settings);
                PopulateListView();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAndSaveCurrentFile();

            ledger = new Models.Ledger();

            PopulateListView();
        }

        void CheckAndSaveCurrentFile()
        {
            if (!isCurrentFileSaved)
            {
                if (MessageBox.Show("The current ledger has unsaved changes.  Would you like to save it now before opening a new ledger?", "Save current ledger?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Settings(ledger);
            frm.ShowDialog(this);
            PopulateListView();
        }

        private void btnRecurring_Click(object sender, EventArgs e)
        {
            var frm = new RecurringList(ledger.RecurringTransactions);
            frm.ShowDialog(this);
            PopulateListView();
        }

        private void lvTrans_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lvTrans.SelectedIndices.Count == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    // Delete the item from the ledger AND the list view
                }
            }
        }
    }
}