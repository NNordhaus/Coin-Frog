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
            txtTransName.Text = rt.BaseTransaction.Description;

            if(string.IsNullOrEmpty(rt.Name))
            {
                this.Text = "Add Transaction";
            }
            else
            {
                this.Text = "Edit Transaction";
            }

            cmboRepeat.SelectedIndex = cmboRepeat.FindStringExact(rt.Every.ToString());

            nudNum.Value = rt.Num;
            if (rt.BaseTransaction != null)
            {
                dtpFrom.Value = new DateTime(Math.Max(rt.BaseTransaction.Date.Ticks, dtpFrom.MinDate.Ticks));
            }
            dtpUntil.Value = new DateTime(Math.Max(rt.Until.Ticks, dtpUntil.MaxDate.Ticks));

            txtBaseAmount.Text = rt.BaseTransaction.Amount.ToString("G");

            switch (cmboRepeat.Text)
            {
                case "Weeks":
                    cbSunday.Checked = rt.On.Contains(1);
                    cbMonday.Checked = rt.On.Contains(2);
                    cbTuesday.Checked = rt.On.Contains(3);
                    cbWednesday.Checked = rt.On.Contains(4);
                    cbThursday.Checked = rt.On.Contains(5);
                    cbFriday.Checked = rt.On.Contains(6);
                    cbSaturday.Checked = rt.On.Contains(7);
                    break;
                case "Months":
                    foreach (var c in flpMonths.Controls)
                    {
                        if (c.GetType() == typeof(CheckBox))
                        {
                            var cb = (CheckBox)c;
                            try
                            {
                                cb.Checked = rt.On.Contains(int.Parse(cb.Text));
                            }
                            catch
                            {
                                // and release...
                            }
                        }
                    }
                    break;
                case "Years":
                    txtOn.Text = rt.On.ToString();
                    break;
            }
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
            this.Height = flpMain.Height + 203;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Things to validate:
                - Must have a name that doesn't already exist
                - Must have at least one day selected (except when Every = Days)
            */

            var errors = new List<string>();
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                errors.Add("Recurrence Name cannot be null");
            }

            if (string.IsNullOrWhiteSpace(txtTransName.Text))
            {
                errors.Add("Transaction Name cannot be null");
            }

            if(dtpFrom.Value > dtpUntil.Value)
            {
                errors.Add("From date must be before Until date");
                return;
            }

            Value.Name = txtName.Text;
            Value.BaseTransaction = new Transaction();
            Value.BaseTransaction.Date = dtpFrom.Value;
            Value.BaseTransaction.Description = txtTransName.Text;
            Value.BaseTransaction.Amount = decimal.Parse(txtBaseAmount.Text);
            Value.Num = (int)nudNum.Value;
            Value.Until = dtpUntil.Value;

            switch(cmboRepeat.Text)
            {
                case "Days":
                    Value.Every = PeriodType.Days;
                    break;
                case "Weeks":
                    Value.Every = PeriodType.Weeks;
                    Value.On = new List<int>();
                    #region Add Up days of the week
                    if(cbSunday.Checked)
                    {
                        Value.On.Add(1);
                    }
                    if (cbMonday.Checked)
                    {
                        Value.On.Add(2);
                    }
                    if (cbTuesday.Checked)
                    {
                        Value.On.Add(3);
                    }
                    if (cbWednesday.Checked)
                    {
                        Value.On.Add(4);
                    }
                    if (cbThursday.Checked)
                    {
                        Value.On.Add(5);
                    }
                    if (cbFriday.Checked)
                    {
                        Value.On.Add(6);
                    }
                    if (cbSaturday.Checked)
                    {
                        Value.On.Add(7);
                    }
                    #endregion
                    break;
                case "Months":
                    Value.Every = PeriodType.Months;
                    Value.On = new List<int>();
                    foreach(var c in flpMonths.Controls)
                    {
                        if(c.GetType() == typeof(CheckBox))
                        {
                            var cb = (CheckBox)c;
                            if(cb.Checked)
                            {
                                Value.On.Add(int.Parse(cb.Text));
                            }
                        }
                    }
                    break;
                case "Years":
                    Value.Every = PeriodType.Years;
                    Value.On = txtOn.Text.Split(new char[] { ',' }).Select(a => int.Parse(a)).ToList();
                    break;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}