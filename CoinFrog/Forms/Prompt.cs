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
    public partial class Prompt : Form
    {
        public string Value
        {
            get
            {
                return txtValue.Text;
            }
            set
            {
                txtValue.Text = value;
            }
        }

        public Prompt(string title, string prompt)
        {
            InitializeComponent();

            this.Text = title;
            lblText.Text = prompt;
        }
    }
}