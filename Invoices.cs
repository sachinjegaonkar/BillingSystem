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
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            // TODO: This line of code loads data into the 'billingDBDataSet.ItemsSold' table. You can move, or remove it, as needed.
            this.itemsSoldTableAdapter.Fill(this.billingDBDataSet.ItemsSold);
            // TODO: This line of code loads data into the 'billingDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.billingDBDataSet.Items);
            // TODO: This line of code loads data into the 'billingDBDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.billingDBDataSet.Invoices);
            // TODO: This line of code loads data into the 'billingDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.billingDBDataSet.Customers);
            // TODO: Do Something here...
            // TODO: This line of code loads data into the 'billingDBDataSet.Items' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.billingDBDataSet.Bill);

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            this.billBindingSource.AddNew();
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                this.itemsBindingSource.EndEdit();
                this.itemsTableAdapter.Update(this.billingDBDataSet.Items);
                this.itemsSoldBindingSource.EndEdit();
                this.itemsSoldTableAdapter.Update(this.billingDBDataSet.ItemsSold);
                this.customersBindingSource.EndEdit();
                this.customersTableAdapter.Update(this.billingDBDataSet.Customers);
                this.invoicesBindingSource.EndEdit();
                this.invoicesTableAdapter.Update(this.billingDBDataSet.Invoices);

                this.billBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.billingDBDataSet);
                MessageBox.Show("Record Updated Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.billBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.billingDBDataSet);
                MessageBox.Show("Record Deleted Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
