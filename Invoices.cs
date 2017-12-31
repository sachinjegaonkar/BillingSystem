using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BillingSystem
{
    // An abastract class that implements the functionality of an image button
    // except for a single abstract method to load the Normal, Hot and Disabled 
    // images that represent the icon that is displayed on the button. The loading
    // of these images is done in each derived concrete class.
    /*public abstract class DataGridViewImageButtonCell : DataGridViewButtonCell
    {
        private bool _enabled;                // Is the button enabled
        private PushButtonState _buttonState; // What is the button state
        protected Image _buttonImageHot;      // The hot image
        protected Image _buttonImageNormal;   // The normal image
        protected Image _buttonImageDisabled; // The disabled image
        private int _buttonImageOffset;       // The amount of offset or border around the image

        protected DataGridViewImageButtonCell()
        {
            // In my project, buttons are disabled by default
            _enabled = false;
            _buttonState = PushButtonState.Disabled;

            // Changing this value affects the appearance of the image on the button.
            _buttonImageOffset = 2;

            // Call the routine to load the images specific to a column.
            LoadImages();
        }

        // Button Enabled Property
        public bool Enabled
        {
            get
            {
                return _enabled;
            }

            set
            {
                _enabled = value;
                _buttonState = value ? PushButtonState.Normal : PushButtonState.Disabled;
            }
        }

        // PushButton State Property
        public PushButtonState ButtonState
        {
            get { return _buttonState; }
            set { _buttonState = value; }
        }

        // Image Property
        // Returns the correct image based on the control's state.
        public Image ButtonImage
        {
            get
            {
                switch (_buttonState)
                {
                    case PushButtonState.Disabled:
                        return _buttonImageDisabled;

                    case PushButtonState.Hot:
                        return _buttonImageHot;

                    case PushButtonState.Normal:
                        return _buttonImageNormal;

                    case PushButtonState.Pressed:
                        return _buttonImageNormal;

                    case PushButtonState.Default:
                        return _buttonImageNormal;

                    default:
                        return _buttonImageNormal;
                }
            }
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            //base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            // Draw the cell background, if specified.
            if ((paintParts & DataGridViewPaintParts.Background) ==
                DataGridViewPaintParts.Background)
            {
                SolidBrush cellBackground =
                    new SolidBrush(cellStyle.BackColor);
                graphics.FillRectangle(cellBackground, cellBounds);
                cellBackground.Dispose();
            }

            // Draw the cell borders, if specified.
            if ((paintParts & DataGridViewPaintParts.Border) ==
                DataGridViewPaintParts.Border)
            {
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                    advancedBorderStyle);
            }

            // Calculate the area in which to draw the button.
            // Adjusting the following algorithm and values affects
            // how the image will appear on the button.
            Rectangle buttonArea = cellBounds;

            Rectangle buttonAdjustment =
                BorderWidths(advancedBorderStyle);

            buttonArea.X += buttonAdjustment.X;
            buttonArea.Y += buttonAdjustment.Y;
            buttonArea.Height -= buttonAdjustment.Height;
            buttonArea.Width -= buttonAdjustment.Width;

            Rectangle imageArea = new Rectangle(
                buttonArea.X + _buttonImageOffset,
                buttonArea.Y + _buttonImageOffset,
                16,
                16);

            ButtonRenderer.DrawButton(graphics, buttonArea, ButtonImage, imageArea, false, ButtonState);
        }

        // An abstract method that must be created in each derived class.
        // The images in the derived class will be loaded here.
        public abstract void LoadImages();
    }

    public class DataGridViewImageButtonDeleteCell : DataGridViewImageButtonCell
    {
        public override void LoadImages()
        {
            // Load the Normal, Hot and Disabled "Delete" images here.
            // Load them from a resource file, local file, hex string, etc.

            //_buttonImageHot = Image.FromFile("C:\\delete_16_h.bmp");
            //_buttonImageNormal = Image.FromFile("C:\\delete_16.bmp");
            //_buttonImageDisabled = Image.FromFile("C:\\delete_d.bmp");
        }
    }
    public class DataGridViewImageButtonDeleteColumn : DataGridViewButtonColumn
    {
        public DataGridViewImageButtonDeleteColumn()
        {
            this.CellTemplate = new DataGridViewImageButtonDeleteCell();
            this.Width = 22;
            this.Resizable = DataGridViewTriState.False;
        }
    }*/

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
        OleDbCommand dbCommand = new OleDbCommand();

        Dictionary<string, string> customerMap = new Dictionary<string, string>();
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
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fine";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fine";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LabourRate";
            this.dataGridViewTextBoxColumn10.HeaderText = "LabourRate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tunch";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tunch";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 50;
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
            this.dataGridViewTextBoxColumn7.HeaderText = "NetWeight";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WtChk";
            this.dataGridViewTextBoxColumn6.HeaderText = "WtChk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GrossWeight";
            this.dataGridViewTextBoxColumn5.HeaderText = "GrossWeight";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 75;
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
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 275;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            billDataGridView.Rows.Add(
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

        private void selectCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle Customer Change event
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
                        }
                    }
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            ClearItemEntry();
        }
        #endregion

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
    }
}
