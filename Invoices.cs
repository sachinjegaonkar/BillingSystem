using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
            Main.SetControlsColor(this);
        }

        private void Invoices_Load(object sender, EventArgs e)
        {

        }
    }
}
