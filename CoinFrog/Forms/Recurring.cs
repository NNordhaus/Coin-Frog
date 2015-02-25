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
            this.Height = flpMain.Height + 203;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Things to validate:
                - From date must be before until date
                - Must have names
                - Must have a name that doesn't already exist
                - Must have at least one day selected             
            */

            if(dtpFrom.Value > dtpUntil.Value)
            {
                MessageBox.Show("From date must be before Until date");
            }

            Value.Name = txtName.Text;
            Value.BaseTransaction = new Transaction();
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