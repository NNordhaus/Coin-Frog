using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CoinFrog.Models;

namespace CoinFrog
{
    public partial class AddEditTransaction : Form
    {
        public Transaction Transaction;

        private Transaction trans;

        public AddEditTransaction(Models.Transaction transaction, List<Status> statuses)
        {
            InitializeComponent();

            cmboStatus.Items.AddRange(statuses.Select(s => s.Name).ToArray());
            
            if (transaction == null)
            {
                trans = new Transaction();
                this.Text = "Add Transaction";
                this.txtDate.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                this.Text = "Edit Transaction";
                trans = transaction;

                txtAmount.Text = trans.Amount.ToString("#,##0.00");
                cbAmountFinal.Checked = trans.AmountFinal;
                txtDate.Text = trans.Date.ToShortDateString();
                cbDateFinal.Checked = trans.DateFinal;
                txtDescription.Text = trans.Description;
                txtDescription.ForeColor = Color.FromArgb(trans.DescriptionForeColor);
                txtDescription.BackColor = Color.FromArgb(trans.DescriptionBackColor);
                cmboStatus.Text = transaction.Status;
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            DateTime date;
            if (DateTime.TryParse(txtDate.Text, out date))
            {
                txtDate.Text = date.ToShortDateString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Amount must not be blank
            decimal amount;
            if(!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Amount invalid");
            }

            // Re-populate the return object
            trans.Amount = amount;
            trans.Date = DateTime.Parse(txtDate.Text);
            trans.Description = txtDescription.Text;
            trans.DescriptionForeColor = txtDescription.ForeColor.ToArgb();
            trans.DescriptionBackColor = txtDescription.BackColor.ToArgb();
            trans.AmountFinal = cbAmountFinal.Checked;
            trans.DateFinal = cbDateFinal.Checked;
            trans.Status = cmboStatus.Text;

            this.Transaction = trans;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog() { Color = txtDescription.ForeColor };
            if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDescription.ForeColor = cd.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog() { Color = txtDescription.BackColor };
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDescription.BackColor = cd.Color;
            }
        }

        private void cbDateFinal_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDateFinal.Checked)
            {
                txtDate.ForeColor = Color.Black;
            }
            else
            {
                txtDate.ForeColor = Color.Red;
            }
        }

        private void cbAmountFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAmountFinal.Checked)
            {
                txtAmount.ForeColor = Color.Black;
            }
            else
            {
                txtAmount.ForeColor = Color.Red;
            }
        }
    }
}