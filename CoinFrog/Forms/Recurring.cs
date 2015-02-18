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
        public Recurring(RecurringTransaction rt)
        {
            InitializeComponent();

            txtName.Text = rt.Name;

            if(string.IsNullOrEmpty(rt.Name))
            {
                this.Text = "Add Transaction";
            }
            else
            {
                this.Text = "Edit Transaction";
            }

            cmboRepeat.SelectedIndex = 0;
        }

        private void cmboRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show hide the various panels
            switch((string)cmboRepeat.SelectedValue)
            {
                case "Days":

                    break;
                case "Weeks":

                    break;
                case "Months":

                    break;
                case "Years":

                    break;
            }
        }
    }
}