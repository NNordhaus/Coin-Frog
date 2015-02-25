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
    public partial class Settings : Form
    {
        public Models.Ledger ledgerRef { get; set; }

        public Settings(Models.Ledger ledger)
        {
            InitializeComponent();

            ledgerRef = ledger;

            nudDaysToForecast.Value = ledger.DaysToForecast;
            nudDaysToCalculate.Value = ledger.DaysToCalculate;

            foreach(var s in ledger.Statuses)
            {
                var item = new ListViewItem(s.Name);
                item.ForeColor = Color.FromArgb(s.ForeColor);
                item.BackColor = Color.FromArgb(s.BackColor);
                lvStatuses.Items.Add(item);
            }

            lvStatuses.Columns[0].Width = lvStatuses.Width-4;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ledgerRef.DaysToForecast = (int)nudDaysToForecast.Value;
            ledgerRef.DaysToCalculate = (int)nudDaysToCalculate.Value;

            ledgerRef.Statuses = new List<Status>(lvStatuses.Items.Count);
            foreach(ListViewItem item in lvStatuses.Items)
            {
                ledgerRef.Statuses.Add(new Status()
                    {
                        Name = item.Text,
                        ForeColor = item.ForeColor.ToArgb(),
                        BackColor = item.BackColor.ToArgb()
                    });
            }
        }

        private void btnSetTextColor_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvStatuses.SelectedItems[0];
            
            var cd = new ColorDialog() { Color = item.ForeColor };
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                item.ForeColor = cd.Color;
            }
        }

        private void btnSetBackColor_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvStatuses.SelectedItems[0];

            var cd = new ColorDialog() { Color = item.BackColor };
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                item.BackColor = cd.Color;
            }
        }

        private void lvStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool on = lvStatuses.SelectedItems.Count > 0;

            btnSetTextColor.Enabled = on;
            btnSetBackColor.Enabled = on;
            btnDelete.Enabled = on;

            btnMoveUp.Enabled = on && lvStatuses.SelectedIndices[0] != 0;
            btnMoveDown.Enabled = on && lvStatuses.SelectedIndices[0] != lvStatuses.Items.Count - 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new Prompt("New Status", "Status text:");
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lvStatuses.Items.Add(frm.Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Status?", "Confirm Delete", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                lvStatuses.Items.RemoveAt(lvStatuses.SelectedIndices[0]);
            }
        }
    }
}