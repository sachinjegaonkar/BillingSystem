using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Main.SetControlsColor(this);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.venkateshBillingDBDataSet);
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'venkateshBillingDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.venkateshBillingDBDataSet.Customers);

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxNewCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void organisationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void organisationLabel_Click(object sender, EventArgs e)
        {

        }

        private void customersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
