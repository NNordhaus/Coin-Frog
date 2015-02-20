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

            foreach(var rt in rts)
            {
                var item = new ListViewItem(rt.Name);
                item.SubItems.Add(rt.BaseTransaction.Date.ToString("g"));
                item.SubItems.Add(rt.Until.ToString("g"));
                item.SubItems.Add(rt.BaseTransaction.Amount.ToString("c"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new Recurring(new RecurringTransaction());
            if(frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                Value.Add(frm.Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}