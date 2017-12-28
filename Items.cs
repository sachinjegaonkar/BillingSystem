using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            Main.SetControlsColor(this);
        }

        private void Items_Load(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            // TODO: Do Something here...

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }
    }
}
