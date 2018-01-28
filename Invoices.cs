using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BillingSystem
{
    public partial class Invoices : Form
    {
        #region Member Variables
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BillingDB.accdb");
        OleDbTransaction transaction = null;

        int newInvoiceID = -1;
        Dictionary<string, string> customerMap = new Dictionary<string, string>();
        string selectedCustomerID = string.Empty;
        Dictionary<string, string> itemMap = new Dictionary<string, string>();
        string selectedItemName = string.Empty;

        #endregion

        #region Constructor
        public Invoices()
        {
            InitializeComponent();
            SetupDataGridView();
            Main.SetControlsColor(this);
        }

        private void SetupDataGridView()
        {
            this.dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new DataGridViewButtonColumn();

            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                                                        this.dataGridViewButtonColumn1,
                                                        this.dataGridViewTextBoxColumn2,
                                                        this.dataGridViewTextBoxColumn3,
                                                        this.dataGridViewTextBoxColumn4,
                                                        this.dataGridViewTextBoxColumn5,
                                                        this.dataGridViewTextBoxColumn6,
                                                        this.dataGridViewTextBoxColumn7,
                                                        this.dataGridViewTextBoxColumn8,
                                                        this.dataGridViewTextBoxColumn9,
                                                        this.dataGridViewTextBoxColumn10,
                                                        this.dataGridViewTextBoxColumn11,
                                                        this.dataGridViewTextBoxColumn12});

            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Labour";
            this.dataGridViewTextBoxColumn12.HeaderText = "Labour";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fine";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fine";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LabourRate";
            this.dataGridViewTextBoxColumn10.HeaderText = "Labour-Rate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tunch";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tunch %";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 55;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Hishob";
            this.dataGridViewTextBoxColumn8.HeaderText = "Hishob";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NetWeight";
            this.dataGridViewTextBoxColumn7.HeaderText = "Net-Weight";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WtChk";
            this.dataGridViewTextBoxColumn6.HeaderText = "Wt Chk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GrossWeight";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gross-Weight";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pcs";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pcs";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 275;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 100;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Text = "";
            this.dataGridViewButtonColumn1.DataPropertyName = "Delete";
            this.dataGridViewButtonColumn1.Width = 25;
            //this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        }
        #endregion

        #region Database
        private void LoadAllCustomers()
        {
            selectCustomerComboBox.Items.Clear();
            customerMap.Clear();
            foreach (DataRow row in this.billingDBDataSet.Customers.Rows)
            {
                var customer = row["FirstName"].ToString() + " " + row["LastName"].ToString() + " - [" + row["Organisation"].ToString() + " " + row["Phone"].ToString() + "]";
                customerMap.Add(row["ID"].ToString(), customer);
                selectCustomerComboBox.Items.Add(customer);
            }
        }
        private void LoadAllItems()
        {
            selectItemsComboBox.Items.Clear();
            itemMap.Clear();
            foreach (DataRow row in this.billingDBDataSet.Items.Rows)
            {
                var item = row["ItemName"].ToString() + "[" + row["ID"].ToString() + "] - Size: " + row["Size"].ToString() + ", Hishob: " + row["Hishob"].ToString();
                itemMap.Add(row["ItemCode"].ToString(), item);
                selectItemsComboBox.Items.Add(item);
            }
        }
        #endregion

        #region Event Handlers
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

            // Load all available customers into combobox
            LoadAllCustomers();
            LoadAllItems();
            netWeightTextBox.BackColor = Color.LightGray;
            fineTextBox.BackColor = Color.LightGray;
            labourTextBox.BackColor = Color.LightGray;

            invoiceDateTimePicker.MaxDate = DateTime.Today;

            invoicesTableAdapter.SubscribeRowUpdatedEvent(true);
            itemsSoldTableAdapter.SubscribeRowUpdatedEvent(true);

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private bool ValideItemEntries()
        {
            if (itemCodeTextBox.Text != string.Empty &&
                pcsTextBox.Text != string.Empty &&
                grossWeightTextBox.Text != string.Empty &&
                wtChkTextBox.Text != string.Empty &&
                netWeightTextBox.Text != string.Empty &&
                hishobTextBox.Text != string.Empty &&
                //tunchTextBox.Text != string.Empty &&
                labourRateTextBox.Text != string.Empty &&
                fineTextBox.Text != string.Empty &&
                labourTextBox.Text != string.Empty
                )
                return true;

            return false;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (ValideItemEntries())
            {
                billDataGridView.Rows.Add(
                    "",
                    itemCodeTextBox.Text,
                    selectedItemName,
                    pcsTextBox.Text,
                    grossWeightTextBox.Text,
                    wtChkTextBox.Text,
                    netWeightTextBox.Text,
                    hishobTextBox.Text,
                    tunchTextBox.Text,
                    labourRateTextBox.Text,
                    fineTextBox.Text,
                    labourTextBox.Text
                    );
            }
            else
            {
                MessageBox.Show("Please enter all the required fields in the 'Item Entry' section above and then press Add button.");
            }
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsCurrentRowValid())
                {
                    MessageBox.Show("Please select a valid row.");
                    return;
                }

                if (ValideItemEntries())
                {
                    var row = billDataGridView.CurrentRow;

                    row.Cells[1].Value = itemCodeTextBox.Text;
                    row.Cells[2].Value = selectedItemName;
                    row.Cells[3].Value = pcsTextBox.Text;
                    row.Cells[4].Value = grossWeightTextBox.Text;
                    row.Cells[5].Value = wtChkTextBox.Text;
                    row.Cells[6].Value = netWeightTextBox.Text;
                    row.Cells[7].Value = hishobTextBox.Text;
                    row.Cells[8].Value = tunchTextBox.Text;
                    row.Cells[9].Value = labourRateTextBox.Text;
                    row.Cells[10].Value = fineTextBox.Text;
                    row.Cells[11].Value = labourTextBox.Text;

                    DisplayTotals();

                    MessageBox.Show("Record Updated Successfully.");
                }
                else
                {
                    MessageBox.Show("Please enter all the required fields in the 'Item Entry' section above and then press Add button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle Customer Change event
            selectedCustomerID = string.Empty;
            if (selectCustomerComboBox.SelectedIndex != -1)
            {
                var selectedItem = selectCustomerComboBox.SelectedItem.ToString();
                // => Targeting to .net v2.0. Dictionary FirstOrDefault or Linq support to dictionary is available since from .net 3.5.
                // Hence iterate through KeyValuePair to identify the item code associated to selected item in dropdown.
                if (!string.IsNullOrEmpty(selectedItem))
                    foreach (KeyValuePair<string, string> pair in customerMap)
                    {
                        if (pair.Value == selectedItem)
                        {
                            selectedCustomerID = pair.Key;
                        }
                    }
            }
        }

        private void OnRadioButtonStateChanged()
        {
            if (radioButtonPerPcs.Checked || radioButtonPerKg.Checked)
            {
                netWeightTextBox.Enabled = false;
                netWeightTextBox.BackColor = Color.LightGray;

                fineTextBox.Enabled = false;
                fineTextBox.BackColor = Color.LightGray;

                labourTextBox.Enabled = false;
                labourTextBox.BackColor = Color.LightGray;

                wtChkTextBox.Enabled = true;
                wtChkTextBox.BackColor = Main.yellowColor;
            }
            else if (radioButtonRegular.Checked)
            {
                netWeightTextBox.Enabled = true;
                netWeightTextBox.BackColor = Main.yellowColor;

                fineTextBox.Enabled = false;
                fineTextBox.BackColor = Color.LightGray;

                labourTextBox.Enabled = false;
                labourTextBox.BackColor = Color.LightGray;

                wtChkTextBox.Enabled = false;
                wtChkTextBox.BackColor = Color.LightGray;
            }
            else
            {
                // This should not be the case anyway!
            }

            CalculateNetWeight();
            CalculateFineAndLabour();
        }

        private void radioButtonPerPcs_CheckedChanged(object sender, EventArgs e)
        {
            // ToDo: Handle event
            OnRadioButtonStateChanged();
        }

        private void radioButtonPerKg_CheckedChanged(object sender, EventArgs e)
        {
            // ToDo: Handle event
            OnRadioButtonStateChanged();
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            // ToDo: Handle event
            OnRadioButtonStateChanged();
        }

        string backupItemCodeText = string.Empty;
        private void itemCodeTextBox_Enter(object sender, EventArgs e)
        {
            backupItemCodeText = itemCodeTextBox.Text;
        }

        private void FindItemByCode(string itemCode, bool setComboBoxValue = true)
        {
            var queryString = $"select ItemName, Hishob, Tunch, LabourRate from Items where ItemCode = \"{itemCode}\"";

            OleDbCommand command = new OleDbCommand(queryString, dbConnection);
            dbConnection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (setComboBoxValue && itemMap.ContainsKey(itemCode))
                {
                    selectItemsComboBox.SelectedIndexChanged -= selectItemsComboBox_SelectedIndexChanged;
                    selectItemsComboBox.SelectedItem = itemMap[itemCode];
                    selectItemsComboBox.SelectedIndexChanged += selectItemsComboBox_SelectedIndexChanged;
                }
                selectedItemName = reader[0].ToString();
                hishobTextBox.Text = reader[1].ToString();
                tunchTextBox.Text = reader[2].ToString();
                labourRateTextBox.Text = reader[3].ToString();
                break;
            }
            reader.Close();
            dbConnection.Close();
        }

        private void itemCodeTextBox_Leave(object sender, EventArgs e)
        {
            if (itemCodeTextBox.Text.Trim() != string.Empty && backupItemCodeText.Trim() != itemCodeTextBox.Text)
            {
                // ToDo: Update other fields according to which radio button is selected.
                selectedItemName = string.Empty;
                FindItemByCode(itemCodeTextBox.Text.Trim());
                CalculateFineAndLabour();
            }
        }

        private void CalculateNetWeight()
        {
            if (radioButtonPerPcs.Checked || radioButtonPerKg.Checked)
            {
                if (pcsTextBox.Text.Trim() != string.Empty &&
                    wtChkTextBox.Text.Trim() != string.Empty &&
                    grossWeightTextBox.Text.Trim() != string.Empty)
                {
                    var pieces = Convert.ToDouble(pcsTextBox.Text.Trim());
                    var wtchk = Convert.ToDouble(wtChkTextBox.Text.Trim());
                    var grossweight = Convert.ToDouble(grossWeightTextBox.Text.Trim());

                    netWeightTextBox.Text = (grossweight - (pieces * wtchk)).ToString();
                }
                else if (grossWeightTextBox.Text.Trim() != string.Empty)
                {
                    netWeightTextBox.Text = grossWeightTextBox.Text.Trim();
                }
            }
            else
            {
                // Do Nothing
            }
        }

        private void CalculateLabour()
        {
            if (radioButtonPerPcs.Checked)
            {
                if (pcsTextBox.Text.Trim() != string.Empty &&
                    labourRateTextBox.Text.Trim() != string.Empty)
                {
                    var pieces = Convert.ToDouble(pcsTextBox.Text.Trim());
                    var labourrate = Convert.ToDouble(labourRateTextBox.Text.Trim());

                    labourTextBox.Text = (pieces * labourrate).ToString();
                }
            }
            else
            {
                // Do Nothing
            }
        }

        private void pcsTextBox_Leave(object sender, EventArgs e)
        {
            // ToDo: Do Something
            CalculateNetWeight();
            CalculateLabour();
        }

        private void grossWeightTextBox_Leave(object sender, EventArgs e)
        {
            // ToDo: Do Something
            CalculateNetWeight();
        }

        private void wtChkTextBox_Leave(object sender, EventArgs e)
        {
            // ToDo: Do Something
            CalculateNetWeight();
        }

        private void CalculateFineAndLabour()
        {
            if (radioButtonPerPcs.Checked)
            {
                if (netWeightTextBox.Text.Trim() != string.Empty &&
                    hishobTextBox.Text.Trim() != string.Empty)
                {
                    var netweight = Convert.ToDouble(netWeightTextBox.Text.Trim());
                    var hishob = Convert.ToDouble(hishobTextBox.Text.Trim());

                    fineTextBox.Text = ((netweight * hishob)/100).ToString();
                }

                if (pcsTextBox.Text.Trim() != string.Empty &&
                    labourRateTextBox.Text.Trim() != string.Empty)
                {
                    var pieces = Convert.ToDouble(pcsTextBox.Text.Trim());
                    var labourrate = Convert.ToDouble(labourRateTextBox.Text.Trim());

                    labourTextBox.Text = (pieces * labourrate).ToString();
                }
            }
            else if (radioButtonPerKg.Checked || radioButtonRegular.Checked)
            {
                if (netWeightTextBox.Text.Trim() != string.Empty &&
                    hishobTextBox.Text.Trim() != string.Empty)
                {
                    var netweight = Convert.ToDouble(netWeightTextBox.Text.Trim());
                    var hishob = Convert.ToDouble(hishobTextBox.Text.Trim());

                    fineTextBox.Text = ((netweight * hishob) / 100).ToString();
                }

                if (netWeightTextBox.Text.Trim() != string.Empty &&
                    labourRateTextBox.Text.Trim() != string.Empty)
                {
                    var netweight = Convert.ToDouble(netWeightTextBox.Text.Trim());
                    var labourrate = Convert.ToDouble(labourRateTextBox.Text.Trim());

                    labourTextBox.Text = ((netweight * labourrate) / 1000).ToString();
                }
            }
        }

        private void netWeightTextBox_Leave(object sender, EventArgs e)
        {
            // ToDo: Do Something
            CalculateFineAndLabour();
        }

        private void hishobTextBox_Leave(object sender, EventArgs e)
        {
            // ToDo: Do Something
            CalculateFineAndLabour();
        }

        private void tunchTextBox_Leave(object sender, EventArgs e)
        {
            // Do Nothing
        }

        private void labourRateTextBox_Leave(object sender, EventArgs e)
        {
            // ToDo: Do Something
            CalculateFineAndLabour();
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            Items itemsForm = new Items();
            itemsForm.ShowDialog();
            LoadAllItems();
            ClearItemEntry();
        }

        private void ClearItemEntry()
        {
            itemCodeTextBox.Text = string.Empty;
            selectItemsComboBox.SelectedIndex = -1;
            hishobTextBox.Text = tunchTextBox.Text = labourRateTextBox.Text = string.Empty;
            pcsTextBox.Text = grossWeightTextBox.Text = wtChkTextBox.Text = string.Empty;
            netWeightTextBox.Text = fineTextBox.Text = labourTextBox.Text = string.Empty;
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.ShowDialog();
            LoadAllCustomers();
        }

        private void selectItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItemName = string.Empty;
            if (selectItemsComboBox.SelectedIndex != -1)
            {
                var selectedItem = selectItemsComboBox.SelectedItem.ToString();
                // => Targeting to .net v2.0. Dictionary FirstOrDefault or Linq support to dictionary is available since from .net 3.5.
                // Hence iterate through KeyValuePair to identify the item code associated to selected item in dropdown.
                if (!string.IsNullOrEmpty(selectedItem))
                    foreach (KeyValuePair<string, string> pair in itemMap)
                    {
                        if (pair.Value == selectedItem)
                        {
                            FindItemByCode(pair.Key, false);
                            itemCodeTextBox.Text = pair.Key;
                            CalculateFineAndLabour();
                        }
                    }
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            ClearItemEntry();
        }

        private void billDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == billDataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == billDataGridView.Columns["dataGridViewButtonColumn1"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                billDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void billDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /*if (e.RowIndex == billDataGridView.NewRowIndex || e.RowIndex < 0)
            {
                e.Handled = true;
                return;
            }*/

            if (e.RowIndex >= 0 && e.ColumnIndex == billDataGridView.Columns["dataGridViewButtonColumn1"].Index)
            {
                var image = Properties.Resources.Delete; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private bool IsCurrentRowValid()
        {
            var row = billDataGridView.CurrentRow;
            if (row != null)
            {
                return (
                    row.Cells[1].Value != null &&
                    row.Cells[2].Value != null &&
                    row.Cells[3].Value != null &&
                    row.Cells[4].Value != null &&
                    row.Cells[5].Value != null &&
                    row.Cells[6].Value != null &&
                    row.Cells[7].Value != null &&
                    //row.Cells[8].Value != null &&
                    row.Cells[9].Value != null &&
                    row.Cells[10].Value != null &&
                    row.Cells[11].Value != null
                        );
            }
            return false;
        }

        private void billDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (IsCurrentRowValid())
            {
                buttonUpdateItem.Enabled = true;
                buttonDeleteSelected.Enabled = true;

                var row = billDataGridView.CurrentRow;
                itemCodeTextBox.Text = row.Cells[1].Value.ToString();
                selectItemsComboBox.Text = itemMap[itemCodeTextBox.Text];
                pcsTextBox.Text = row.Cells[3].Value.ToString();
                grossWeightTextBox.Text = row.Cells[4].Value.ToString();
                wtChkTextBox.Text = row.Cells[5].Value.ToString();
                netWeightTextBox.Text = row.Cells[6].Value.ToString();
                hishobTextBox.Text = row.Cells[7].Value.ToString();
                tunchTextBox.Text = row.Cells[8].Value.ToString();
                labourRateTextBox.Text = row.Cells[9].Value.ToString();
                fineTextBox.Text = row.Cells[10].Value.ToString();
                labourTextBox.Text = row.Cells[11].Value.ToString();
            }
            else
            {
                buttonUpdateItem.Enabled = false;
                buttonDeleteSelected.Enabled = false;
                ClearItemEntry();
            }
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in billDataGridView.SelectedRows)
            {
                if (row != null)
                {
                    billDataGridView.Rows.RemoveAt(row.Index);
                }
            }

            buttonUpdateItem.Enabled = false;
            buttonDeleteSelected.Enabled = false;
        }

        private void DisplayTotals()
        {
            if (billDataGridView.Rows.Count > 0)
            {
                double totalGrossWeigth, totalNetWeight, totalFine, totalLabour;
                totalGrossWeigth = totalNetWeight = totalFine = totalLabour = 0;

                for (int i = 0; i < billDataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = billDataGridView.Rows[i];
                    if (row == null)
                        continue;

                    double val = 0;
                    if (double.TryParse(row.Cells[4].Value?.ToString(), out val))
                    {
                        totalGrossWeigth += val;
                    }
                    if (double.TryParse(row.Cells[6].Value?.ToString(), out val))
                    {
                        totalNetWeight += val;
                    }
                    if (double.TryParse(row.Cells[10].Value?.ToString(), out val))
                    {
                        totalFine += val;
                    }
                    if (double.TryParse(row.Cells[11].Value?.ToString(), out val))
                    {
                        totalLabour += val;
                    }
                }

                textBoxTotalGrossWeight.Text = totalGrossWeigth.ToString();
                textBoxTotalNetWeight.Text = totalNetWeight.ToString();
                textBoxTotalFine.Text = totalFine.ToString();
                textBoxTotalLabour.Text = totalLabour.ToString();
            }
        }

        private void billDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DisplayTotals();
            if (billDataGridView.Rows.Count > 1)
            {
                buttonSaveInvoice.Enabled = true;
                buttonPrint.Enabled = true;
                buttonExportToExcel.Enabled = true;
            }
        }

        private void billDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DisplayTotals();
            if (billDataGridView.Rows.Count <= 1)
            {
                buttonSaveInvoice.Enabled = false;
                buttonPrint.Enabled = false;
                buttonExportToExcel.Enabled = false;
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // ToDo: Move these two functions from this form to PrintPreview form by passing grid items as a listview
            // to PrintPreview Form.
            var listView = GetItemsDataAsListView();

            if (listView.Items.Count > 0)
            {
                var selectedCustomer = selectCustomerComboBox.SelectedItem.ToString();
                PrintInvoice printPreviewForm = new PrintInvoice(listView,
                    selectedCustomer,
                    textBoxTotalGrossWeight.Text,
                    textBoxTotalNetWeight.Text,
                    textBoxTotalFine.Text,
                    textBoxTotalLabour.Text
                    );
                printPreviewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Items to be shown in print privew.");
            }
        }

        private ListView GetItemsDataAsListView()
        {
            ListView listView = new ListView();
            try
            {
                if (billDataGridView.Rows.Count > 1)
                {
                    listView.BeginUpdate();
                    listView.Clear();

                    listView.Items.Clear();
                    for (int i = 0; i < billDataGridView.Rows.Count; i++)
                    {
                        DataGridViewRow row = billDataGridView.Rows[i];
                        if (row == null)
                            continue;

                        ListViewItem lvi = new ListViewItem();
                        for (int j = 1; j < billDataGridView.Columns.Count; j++)
                        {
                            if (j != 1)
                                lvi.SubItems.Add(row.Cells[j].Value?.ToString());
                            else
                                lvi.SubItems[0].Text = row.Cells[j].Value?.ToString();
                        }
                        listView.Items.Add(lvi);
                    }
                    listView.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listView;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close this form?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectCustomerComboBox.Text))
            {
                MessageBox.Show("Please select customer to export data for.");
                return;
            }

            ExportToExcel();
        }

        private void ExportToExcel()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var customerName = selectCustomerComboBox.Text.Substring(0, selectCustomerComboBox.Text.IndexOf(" - "));
                var mobileNumber = selectCustomerComboBox.Text.Substring(selectCustomerComboBox.Text.IndexOf(" - ") + 3);

                var date = invoiceDateTimePicker.Value.ToString("yyyyMMddHHmmss");

                string templateExcel = $"{Directory.GetCurrentDirectory()}\\template.xlsx";
                string workbookPath = $"{Directory.GetCurrentDirectory()}\\CustomerInvoices\\{customerName}_{date}.xlsx";

                if (File.Exists(workbookPath)) File.Delete(workbookPath);
                File.Copy(templateExcel, workbookPath);

                //Creae an Excel application instance
                Excel.Application excelApp = new Excel.Application();

                //Create an Excel workbook instance and open it from the predefined location
                Excel.Workbook excelWorkBook = 
                    excelApp.Workbooks.Open(workbookPath);

                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = "Invoice";

                for (int k = 1; k < billDataGridView.Columns.Count; k++)
                {
                    switch (k)
                    {
                        case 1:
                        case 2:
                            excelWorkSheet.Cells[1, k] = "";
                            break;
                        case 3:
                            excelWorkSheet.Cells[1, k] = customerName;
                            break;
                        case 4:
                            excelWorkSheet.Cells[1, k] = "";
                            break;
                        case 5:
                            excelWorkSheet.Cells[1, k] = mobileNumber;
                            break;
                        case 6:
                        case 7:
                            excelWorkSheet.Cells[1, k] = "";
                            break;
                        case 8:
                            excelWorkSheet.Cells[1, k] = "Invoice Date: ";
                            break;
                        case 9:
                            excelWorkSheet.Cells[1, k] = "";
                            break;
                        case 10:
                            excelWorkSheet.Cells[1, k] = invoiceDateTimePicker.Value.Date;
                            break;
                        case 11:
                            excelWorkSheet.Cells[1, k] = "";
                            break;
                        default:
                            break;
                    }
                }

                for (int i = 0; i < billDataGridView.Columns.Count - 1; i++)
                {
                    excelWorkSheet.Cells[3, i + 1] = billDataGridView.Columns[i + 1].HeaderText;
                }

                for (int j = 0; j < billDataGridView.Rows.Count - 1; j++)
                {
                    for (int k = 1; k < billDataGridView.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 4, k] = billDataGridView.Rows[j].Cells[k].Value.ToString();
                    }
                }

                var lastRow = billDataGridView.Rows.Count + 4;
                for (int k = 1; k < billDataGridView.Columns.Count; k++)
                {
                    switch(k)
                    {
                        case 1:
                            excelWorkSheet.Cells[lastRow, k] = "Total: ";
                            break;
                        case 2:
                        case 3:
                            excelWorkSheet.Cells[lastRow, k] = "";
                            break;
                        case 4:
                            excelWorkSheet.Cells[lastRow, k] = textBoxTotalGrossWeight.Text;
                            break;
                        case 5:
                            break;
                        case 6:
                            excelWorkSheet.Cells[lastRow, k] = textBoxTotalNetWeight.Text;
                            break;
                        case 7:
                        case 8:
                        case 9:
                            excelWorkSheet.Cells[lastRow, k] = "";
                            break;
                        case 10:
                            excelWorkSheet.Cells[lastRow, k] = textBoxTotalFine.Text;
                            break;
                        case 11:
                            excelWorkSheet.Cells[lastRow, k] = textBoxTotalLabour.Text;
                            break;
                        default:
                            break;
                    }
                }

                excelWorkBook.Save();
                excelWorkBook.Close();
                excelApp.Quit();
                Cursor = Cursors.Default;

                if (MessageBox.Show("Data exported to excel successfully. Do you want to open the workbook ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    System.Diagnostics.Process.Start(workbookPath);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }

        private void CreateNewInvoice()
        {
            try
            {
                var queryString = $"insert into Invoices(CustomerID, InvoiceDate) values({selectedCustomerID}, \"{GetDateWithoutMilliseconds(invoiceDateTimePicker.Value)}\")";

                OleDbCommand command = new OleDbCommand(queryString, dbConnection);
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                command.CommandText = "Select @@Identity";
                newInvoiceID = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void AddAllInvoiceItems()
        {
            try
            {
                if (billDataGridView.Rows.Count > 1)
                {
                    OleDbCommand command = new OleDbCommand("", dbConnection);
                    command.Transaction = transaction;

                    for (int i = 0; i < billDataGridView.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = billDataGridView.Rows[i];
                        if (row == null)
                            continue;

                        StringBuilder queryString = 
                            new StringBuilder("insert into ItemsSold (InvoiceNo, ItemID, Pcs, GrossWeight, WtChk, NetWeight, Hishob, Tunch, LabourRate, Fine, Labour) ");

                        queryString.Append($"Values ({newInvoiceID}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[1].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[3].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[4].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[5].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[6].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[7].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[8].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[9].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[10].Value?.ToString())}, ");
                        queryString.Append($"{Convert.ToDouble(row.Cells[11].Value?.ToString())});");

                        command.CommandText = queryString.ToString();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void DeleteAllInvoiceItems()
        {
            try
            {
                OleDbCommand command = new OleDbCommand($"Delete from ItemsSold where InvoiceNo = {newInvoiceID}", dbConnection);
                command.Transaction = transaction;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ExecuteInvoiceTransaction()
        {
            try
            {
                dbConnection.Open();
                transaction = dbConnection.BeginTransaction();
                if (buttonSaveInvoice.Text == "Save Invoice")
                {
                    if (!string.IsNullOrEmpty(selectedCustomerID))
                    {
                        CreateNewInvoice();

                        buttonSaveInvoice.Text = "Update Invoice";
                        selectCustomerComboBox.Enabled = false;

                        AddAllInvoiceItems();
                        MessageBox.Show("Invoice Created Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please select the valid customer.");
                    }
                }
                else
                {
                    // ToDo: Remove all the related items from the ItemsSold table and 
                    // add the new set into the table.
                    DeleteAllInvoiceItems();
                    AddAllInvoiceItems();
                    MessageBox.Show("Invoice Updated Successfully!");
                }
                transaction.Commit();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    transaction.Rollback();
                    dbConnection.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void buttonSaveInvoice_Click(object sender, EventArgs e)
        {
            ExecuteInvoiceTransaction();
        }
        #endregion
    }
}
