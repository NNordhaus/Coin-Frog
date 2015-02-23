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
    public partial class Recurring : Form
    {
        public RecurringTransaction Value { get; set; }

        public Recurring(RecurringTransaction rt)
        {
            InitializeComponent();

            Value = rt;

            txtName.Text = rt.Name;

            if(string.IsNullOrEmpty(rt.Name))
            {
                this.Text = "Add Transaction";
            }
            else
            {
                this.Text = "Edit Transaction";
            }

            if (rt.Every == null)
            {
                cmboRepeat.SelectedIndex = 0;
            }
            else
            {
                cmboRepeat.SelectedIndex = cmboRepeat.FindStringExact(rt.Every.ToString());
            }

            nudNum.Value = rt.Num;
            if (rt.BaseTransaction != null)
            {
                dtpFrom.Value = rt.BaseTransaction.Date;
            }
            dtpUntil.Value = new DateTime(Math.Max(rt.Until.Ticks, dtpUntil.MaxDate.Ticks));
        }

        private void cmboRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show hide the various panels
            var type = (string)cmboRepeat.Text;

            pnlWeeks.Visible = type == "Weeks";
            flpMonths.Visible = type == "Months";
            pnlYears.Visible = type == "Years";

            // size the panel
            int flpHeight = 0;
            foreach (Control c in flpMain.Controls)
            {
                if (c.Visible)
                {
                    flpHeight += c.Height;
                }
            }
            flpMain.Height = flpHeight;

            // Size the form
            this.Height = flpMain.Height + 187;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Things to validate:
                - Start date must be before until date
                - Must have a name that doesn't already exist
                - Must have at least one day selected             
            */
        }
    }
}