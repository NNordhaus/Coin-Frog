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

        public AddEditTransaction(Models.Transaction transaction)
        {
            InitializeComponent();

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
                //cmboStatus
            }
        }

        private void txtDate_KeyUp(object sender, KeyEventArgs e)
        {
            // If enter key, validate as date, and reformat
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
            //trans.DescriptionBackColor = 
            trans.AmountFinal = cbAmountFinal.Checked;
            trans.DateFinal = cbDateFinal.Checked;

            this.Transaction = trans;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
