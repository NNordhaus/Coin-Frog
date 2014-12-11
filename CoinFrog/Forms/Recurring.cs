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
        }
    }
}