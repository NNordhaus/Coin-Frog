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
        public RecurringList(List<RecurringTransaction> rts)
        {
            InitializeComponent();

            foreach(var rt in rts)
            {
                var item = new ListViewItem(rt.Name);
                item.SubItems.Add(rt.BaseTransaction.Date.ToString("g"));
                item.SubItems.Add(rt.Until.ToString("g"));
                item.SubItems.Add(rt.BaseTransaction.Amount.ToString("c"));
            }
        }
    }
}