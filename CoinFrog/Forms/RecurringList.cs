using CoinFrog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoinFrog.Forms
{
    public partial class RecurringList : Form
    {
        public List<RecurringTransaction> Value { get; set; }

        public RecurringList(List<RecurringTransaction> rts)
        {
            InitializeComponent();

            Value = rts;

            RefreshListView();
        }

        public void RefreshListView()
        {
            lvRecurringTransactions.Items.Clear();
            foreach (var rt in Value)
            {
                var item = new ListViewItem(rt.Name);
                item.SubItems.Add(rt.BaseTransaction.Date.ToString("d"));
                item.SubItems.Add(rt.Until.ToString("d"));
                item.SubItems.Add(rt.BaseTransaction.Amount.ToString("c"));
                lvRecurringTransactions.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new Recurring(new RecurringTransaction());
            if(frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                Value.Add(frm.Value);
                RefreshListView();
            }
        }

        private void lvRecurringTransactions_ItemActivate(object sender, EventArgs e)
        {
            var frm = new Recurring(Value[lvRecurringTransactions.SelectedIndices[0]]);
            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                RefreshListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Not Implemented");
            }
        }
    }
}