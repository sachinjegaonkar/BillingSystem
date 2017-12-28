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

        private void Customers_Load(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            buttonDeleteCustomer.Enabled = false;
            buttonUpdateCustomer.Enabled = false;

            // TODO: This line of code loads data into the 'venkateshBillingDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.billingDBDataSet.Customers);

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.AddNew();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.customersTableAdapter.Update(this.billingDBDataSet.Customers);
                MessageBox.Show("Record Updated Successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*
                private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
                {
                    this.Validate();
                    this.customersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.billingDBDataSet);
                }
             */
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersBindingSource.RemoveCurrent();
                this.customersTableAdapter.Update(this.billingDBDataSet.Customers);
                MessageBox.Show("Record Deleted Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            buttonUpdateCustomer.Enabled = true;
            //{
            //    SendKeys.Send("{Tab}");
            //}
        }

        private void customersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.customersDataGridView.SelectedRows.Count >= 1)
            {
                buttonDeleteCustomer.Enabled = true;
            }
            else
            {
                buttonDeleteCustomer.Enabled = false;
            }
        }

        private void customersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true;
            //    SendKeys.Send("{Tab}");
            //}
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int icolumn = customersDataGridView.CurrentCell.ColumnIndex;
            int irow = customersDataGridView.CurrentCell.RowIndex;

            if (keyData == Keys.Enter)
            {
                if (icolumn == customersDataGridView.Columns.Count - 1 && irow < customersDataGridView.Rows.Count - 1)
                {
                    //customersDataGridView.Rows.Add();
                    customersDataGridView.CurrentCell = customersDataGridView[0, irow + 1];
                }
                else if (icolumn != customersDataGridView.Columns.Count - 1)
                {
                    customersDataGridView.CurrentCell = customersDataGridView[icolumn + 1, irow];
                }
                else
                    return base.ProcessCmdKey(ref msg, keyData);

                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
