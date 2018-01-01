namespace BillingSystem
{
    partial class Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label itemCodeLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label pcsLabel;
            System.Windows.Forms.Label grossWeightLabel;
            System.Windows.Forms.Label wtChkLabel;
            System.Windows.Forms.Label netWeightLabel;
            System.Windows.Forms.Label hishobLabel;
            System.Windows.Forms.Label tunchLabel;
            System.Windows.Forms.Label labourRateLabel;
            System.Windows.Forms.Label fineLabel;
            System.Windows.Forms.Label labourLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingDBDataSet = new BillingSystem.BillingDBDataSet();
            this.billTableAdapter = new BillingSystem.BillingDBDataSetTableAdapters.BillTableAdapter();
            this.tableAdapterManager = new BillingSystem.BillingDBDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new BillingSystem.BillingDBDataSetTableAdapters.CustomersTableAdapter();
            this.invoicesTableAdapter = new BillingSystem.BillingDBDataSetTableAdapters.InvoicesTableAdapter();
            this.itemsSoldTableAdapter = new BillingSystem.BillingDBDataSetTableAdapters.ItemsSoldTableAdapter();
            this.itemsTableAdapter = new BillingSystem.BillingDBDataSetTableAdapters.ItemsTableAdapter();
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.pcsTextBox = new System.Windows.Forms.TextBox();
            this.grossWeightTextBox = new System.Windows.Forms.TextBox();
            this.wtChkTextBox = new System.Windows.Forms.TextBox();
            this.netWeightTextBox = new System.Windows.Forms.TextBox();
            this.hishobTextBox = new System.Windows.Forms.TextBox();
            this.tunchTextBox = new System.Windows.Forms.TextBox();
            this.labourRateTextBox = new System.Windows.Forms.TextBox();
            this.fineTextBox = new System.Windows.Forms.TextBox();
            this.labourTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxNewItem = new System.Windows.Forms.GroupBox();
            this.selectItemsComboBox = new System.Windows.Forms.ComboBox();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.selectCustomerLabel = new System.Windows.Forms.Label();
            this.groupBoxItemEntryMode = new System.Windows.Forms.GroupBox();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonPerKg = new System.Windows.Forms.RadioButton();
            this.radioButtonPerPcs = new System.Windows.Forms.RadioButton();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.invoiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotalGrossWeight = new System.Windows.Forms.TextBox();
            this.labelDummy1 = new System.Windows.Forms.Label();
            this.textBoxTotalNetWeight = new System.Windows.Forms.TextBox();
            this.labelDummy2 = new System.Windows.Forms.Label();
            this.textBoxTotalFine = new System.Windows.Forms.TextBox();
            this.textBoxTotalLabour = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.buttonSaveInvoice = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            itemCodeLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            pcsLabel = new System.Windows.Forms.Label();
            grossWeightLabel = new System.Windows.Forms.Label();
            wtChkLabel = new System.Windows.Forms.Label();
            netWeightLabel = new System.Windows.Forms.Label();
            hishobLabel = new System.Windows.Forms.Label();
            tunchLabel = new System.Windows.Forms.Label();
            labourRateLabel = new System.Windows.Forms.Label();
            fineLabel = new System.Windows.Forms.Label();
            labourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBoxNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSoldBindingSource)).BeginInit();
            this.groupBoxItemEntryMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(32, 22);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(58, 13);
            itemCodeLabel.TabIndex = 4;
            itemCodeLabel.Text = "Item Code:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(238, 22);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 5;
            itemNameLabel.Text = "Item Name:";
            // 
            // pcsLabel
            // 
            pcsLabel.AutoSize = true;
            pcsLabel.Location = new System.Drawing.Point(62, 67);
            pcsLabel.Name = "pcsLabel";
            pcsLabel.Size = new System.Drawing.Size(28, 13);
            pcsLabel.TabIndex = 6;
            pcsLabel.Text = "Pcs:";
            // 
            // grossWeightLabel
            // 
            grossWeightLabel.AutoSize = true;
            grossWeightLabel.Location = new System.Drawing.Point(225, 66);
            grossWeightLabel.Name = "grossWeightLabel";
            grossWeightLabel.Size = new System.Drawing.Size(74, 13);
            grossWeightLabel.TabIndex = 8;
            grossWeightLabel.Text = "Gross Weight:";
            // 
            // wtChkLabel
            // 
            wtChkLabel.AutoSize = true;
            wtChkLabel.Location = new System.Drawing.Point(462, 67);
            wtChkLabel.Name = "wtChkLabel";
            wtChkLabel.Size = new System.Drawing.Size(46, 13);
            wtChkLabel.TabIndex = 10;
            wtChkLabel.Text = "Wt Chk:";
            // 
            // netWeightLabel
            // 
            netWeightLabel.AutoSize = true;
            netWeightLabel.Location = new System.Drawing.Point(645, 67);
            netWeightLabel.Name = "netWeightLabel";
            netWeightLabel.Size = new System.Drawing.Size(64, 13);
            netWeightLabel.TabIndex = 12;
            netWeightLabel.Text = "Net Weight:";
            // 
            // hishobLabel
            // 
            hishobLabel.AutoSize = true;
            hishobLabel.Location = new System.Drawing.Point(47, 109);
            hishobLabel.Name = "hishobLabel";
            hishobLabel.Size = new System.Drawing.Size(43, 13);
            hishobLabel.TabIndex = 14;
            hishobLabel.Text = "Hishob:";
            // 
            // tunchLabel
            // 
            tunchLabel.AutoSize = true;
            tunchLabel.Location = new System.Drawing.Point(247, 112);
            tunchLabel.Name = "tunchLabel";
            tunchLabel.Size = new System.Drawing.Size(52, 13);
            tunchLabel.TabIndex = 16;
            tunchLabel.Text = "Tunch %:";
            // 
            // labourRateLabel
            // 
            labourRateLabel.AutoSize = true;
            labourRateLabel.Location = new System.Drawing.Point(439, 112);
            labourRateLabel.Name = "labourRateLabel";
            labourRateLabel.Size = new System.Drawing.Size(69, 13);
            labourRateLabel.TabIndex = 18;
            labourRateLabel.Text = "Labour Rate:";
            // 
            // fineLabel
            // 
            fineLabel.AutoSize = true;
            fineLabel.Location = new System.Drawing.Point(679, 111);
            fineLabel.Name = "fineLabel";
            fineLabel.Size = new System.Drawing.Size(30, 13);
            fineLabel.TabIndex = 20;
            fineLabel.Text = "Fine:";
            // 
            // labourLabel
            // 
            labourLabel.AutoSize = true;
            labourLabel.Location = new System.Drawing.Point(666, 151);
            labourLabel.Name = "labourLabel";
            labourLabel.Size = new System.Drawing.Size(43, 13);
            labourLabel.TabIndex = 22;
            labourLabel.Text = "Labour:";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.billingDBDataSet;
            // 
            // billingDBDataSet
            // 
            this.billingDBDataSet.DataSetName = "BillingDBDataSet";
            this.billingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.ItemsSoldTableAdapter = this.itemsSoldTableAdapter;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.BillingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // itemsSoldTableAdapter
            // 
            this.itemsSoldTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // billDataGridView
            // 
            this.billDataGridView.AllowUserToResizeColumns = false;
            this.billDataGridView.AllowUserToResizeRows = false;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Location = new System.Drawing.Point(13, 273);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.ReadOnly = true;
            this.billDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.billDataGridView.Size = new System.Drawing.Size(1093, 216);
            this.billDataGridView.TabIndex = 4;
            this.billDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDataGridView_CellClick);
            this.billDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.billDataGridView_CellPainting);
            this.billDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.billDataGridView_RowsAdded);
            this.billDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.billDataGridView_RowsRemoved);
            this.billDataGridView.SelectionChanged += new System.EventHandler(this.billDataGridView_SelectionChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.billingDBDataSet;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(96, 19);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCodeTextBox.TabIndex = 5;
            this.itemCodeTextBox.Enter += new System.EventHandler(this.itemCodeTextBox_Enter);
            this.itemCodeTextBox.Leave += new System.EventHandler(this.itemCodeTextBox_Leave);
            // 
            // pcsTextBox
            // 
            this.pcsTextBox.Location = new System.Drawing.Point(96, 63);
            this.pcsTextBox.Name = "pcsTextBox";
            this.pcsTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcsTextBox.TabIndex = 7;
            this.pcsTextBox.Leave += new System.EventHandler(this.pcsTextBox_Leave);
            // 
            // grossWeightTextBox
            // 
            this.grossWeightTextBox.Location = new System.Drawing.Point(305, 63);
            this.grossWeightTextBox.Name = "grossWeightTextBox";
            this.grossWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossWeightTextBox.TabIndex = 9;
            this.grossWeightTextBox.Leave += new System.EventHandler(this.grossWeightTextBox_Leave);
            // 
            // wtChkTextBox
            // 
            this.wtChkTextBox.Location = new System.Drawing.Point(514, 64);
            this.wtChkTextBox.Name = "wtChkTextBox";
            this.wtChkTextBox.Size = new System.Drawing.Size(100, 20);
            this.wtChkTextBox.TabIndex = 11;
            this.wtChkTextBox.Leave += new System.EventHandler(this.wtChkTextBox_Leave);
            // 
            // netWeightTextBox
            // 
            this.netWeightTextBox.Enabled = false;
            this.netWeightTextBox.Location = new System.Drawing.Point(715, 64);
            this.netWeightTextBox.Name = "netWeightTextBox";
            this.netWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.netWeightTextBox.TabIndex = 13;
            this.netWeightTextBox.Leave += new System.EventHandler(this.netWeightTextBox_Leave);
            // 
            // hishobTextBox
            // 
            this.hishobTextBox.Location = new System.Drawing.Point(96, 106);
            this.hishobTextBox.Name = "hishobTextBox";
            this.hishobTextBox.Size = new System.Drawing.Size(100, 20);
            this.hishobTextBox.TabIndex = 15;
            this.hishobTextBox.Leave += new System.EventHandler(this.hishobTextBox_Leave);
            // 
            // tunchTextBox
            // 
            this.tunchTextBox.Location = new System.Drawing.Point(305, 107);
            this.tunchTextBox.Name = "tunchTextBox";
            this.tunchTextBox.Size = new System.Drawing.Size(100, 20);
            this.tunchTextBox.TabIndex = 17;
            this.tunchTextBox.Leave += new System.EventHandler(this.tunchTextBox_Leave);
            // 
            // labourRateTextBox
            // 
            this.labourRateTextBox.Location = new System.Drawing.Point(514, 106);
            this.labourRateTextBox.Name = "labourRateTextBox";
            this.labourRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.labourRateTextBox.TabIndex = 19;
            this.labourRateTextBox.Leave += new System.EventHandler(this.labourRateTextBox_Leave);
            // 
            // fineTextBox
            // 
            this.fineTextBox.Enabled = false;
            this.fineTextBox.Location = new System.Drawing.Point(715, 106);
            this.fineTextBox.Name = "fineTextBox";
            this.fineTextBox.Size = new System.Drawing.Size(100, 20);
            this.fineTextBox.TabIndex = 21;
            // 
            // labourTextBox
            // 
            this.labourTextBox.Enabled = false;
            this.labourTextBox.Location = new System.Drawing.Point(715, 148);
            this.labourTextBox.Name = "labourTextBox";
            this.labourTextBox.Size = new System.Drawing.Size(100, 20);
            this.labourTextBox.TabIndex = 23;
            // 
            // groupBoxNewItem
            // 
            this.groupBoxNewItem.Controls.Add(this.selectItemsComboBox);
            this.groupBoxNewItem.Controls.Add(this.buttonNewItem);
            this.groupBoxNewItem.Controls.Add(labourLabel);
            this.groupBoxNewItem.Controls.Add(itemCodeLabel);
            this.groupBoxNewItem.Controls.Add(this.labourTextBox);
            this.groupBoxNewItem.Controls.Add(fineLabel);
            this.groupBoxNewItem.Controls.Add(this.fineTextBox);
            this.groupBoxNewItem.Controls.Add(labourRateLabel);
            this.groupBoxNewItem.Controls.Add(this.labourRateTextBox);
            this.groupBoxNewItem.Controls.Add(tunchLabel);
            this.groupBoxNewItem.Controls.Add(this.tunchTextBox);
            this.groupBoxNewItem.Controls.Add(hishobLabel);
            this.groupBoxNewItem.Controls.Add(this.hishobTextBox);
            this.groupBoxNewItem.Controls.Add(netWeightLabel);
            this.groupBoxNewItem.Controls.Add(this.netWeightTextBox);
            this.groupBoxNewItem.Controls.Add(wtChkLabel);
            this.groupBoxNewItem.Controls.Add(this.wtChkTextBox);
            this.groupBoxNewItem.Controls.Add(grossWeightLabel);
            this.groupBoxNewItem.Controls.Add(this.grossWeightTextBox);
            this.groupBoxNewItem.Controls.Add(pcsLabel);
            this.groupBoxNewItem.Controls.Add(this.pcsTextBox);
            this.groupBoxNewItem.Controls.Add(itemNameLabel);
            this.groupBoxNewItem.Controls.Add(this.itemCodeTextBox);
            this.groupBoxNewItem.Location = new System.Drawing.Point(213, 44);
            this.groupBoxNewItem.Name = "groupBoxNewItem";
            this.groupBoxNewItem.Size = new System.Drawing.Size(831, 181);
            this.groupBoxNewItem.TabIndex = 24;
            this.groupBoxNewItem.TabStop = false;
            this.groupBoxNewItem.Text = "Item Entry";
            // 
            // selectItemsComboBox
            // 
            this.selectItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectItemsComboBox.FormattingEnabled = true;
            this.selectItemsComboBox.Location = new System.Drawing.Point(305, 19);
            this.selectItemsComboBox.Name = "selectItemsComboBox";
            this.selectItemsComboBox.Size = new System.Drawing.Size(309, 21);
            this.selectItemsComboBox.Sorted = true;
            this.selectItemsComboBox.TabIndex = 25;
            this.selectItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.selectItemsComboBox_SelectedIndexChanged);
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.Location = new System.Drawing.Point(620, 17);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(26, 23);
            this.buttonNewItem.TabIndex = 24;
            this.buttonNewItem.Text = "...";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(383, 234);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(100, 32);
            this.buttonAddItem.TabIndex = 25;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.billingDBDataSet;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.billingDBDataSet;
            // 
            // itemsSoldBindingSource
            // 
            this.itemsSoldBindingSource.DataMember = "ItemsSold";
            this.itemsSoldBindingSource.DataSource = this.billingDBDataSet;
            // 
            // selectCustomerComboBox
            // 
            this.selectCustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCustomerComboBox.FormattingEnabled = true;
            this.selectCustomerComboBox.Location = new System.Drawing.Point(409, 15);
            this.selectCustomerComboBox.Name = "selectCustomerComboBox";
            this.selectCustomerComboBox.Size = new System.Drawing.Size(309, 21);
            this.selectCustomerComboBox.Sorted = true;
            this.selectCustomerComboBox.TabIndex = 29;
            this.selectCustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCustomerComboBox_SelectedIndexChanged);
            // 
            // selectCustomerLabel
            // 
            this.selectCustomerLabel.AutoSize = true;
            this.selectCustomerLabel.Location = new System.Drawing.Point(313, 18);
            this.selectCustomerLabel.Name = "selectCustomerLabel";
            this.selectCustomerLabel.Size = new System.Drawing.Size(90, 13);
            this.selectCustomerLabel.TabIndex = 30;
            this.selectCustomerLabel.Text = "Select Customer: ";
            // 
            // groupBoxItemEntryMode
            // 
            this.groupBoxItemEntryMode.Controls.Add(this.radioButtonRegular);
            this.groupBoxItemEntryMode.Controls.Add(this.radioButtonPerKg);
            this.groupBoxItemEntryMode.Controls.Add(this.radioButtonPerPcs);
            this.groupBoxItemEntryMode.Location = new System.Drawing.Point(71, 44);
            this.groupBoxItemEntryMode.Name = "groupBoxItemEntryMode";
            this.groupBoxItemEntryMode.Size = new System.Drawing.Size(136, 181);
            this.groupBoxItemEntryMode.TabIndex = 32;
            this.groupBoxItemEntryMode.TabStop = false;
            this.groupBoxItemEntryMode.Text = "Select Mode";
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(38, 129);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRegular.TabIndex = 30;
            this.radioButtonRegular.Text = "Ragular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            this.radioButtonRegular.CheckedChanged += new System.EventHandler(this.radioButtonRegular_CheckedChanged);
            // 
            // radioButtonPerKg
            // 
            this.radioButtonPerKg.AutoSize = true;
            this.radioButtonPerKg.Location = new System.Drawing.Point(38, 87);
            this.radioButtonPerKg.Name = "radioButtonPerKg";
            this.radioButtonPerKg.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPerKg.TabIndex = 29;
            this.radioButtonPerKg.Text = "Per Kg";
            this.radioButtonPerKg.UseVisualStyleBackColor = true;
            this.radioButtonPerKg.CheckedChanged += new System.EventHandler(this.radioButtonPerKg_CheckedChanged);
            // 
            // radioButtonPerPcs
            // 
            this.radioButtonPerPcs.AutoSize = true;
            this.radioButtonPerPcs.Checked = true;
            this.radioButtonPerPcs.Location = new System.Drawing.Point(38, 42);
            this.radioButtonPerPcs.Name = "radioButtonPerPcs";
            this.radioButtonPerPcs.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPerPcs.TabIndex = 0;
            this.radioButtonPerPcs.TabStop = true;
            this.radioButtonPerPcs.Text = "Per Pices";
            this.radioButtonPerPcs.UseVisualStyleBackColor = true;
            this.radioButtonPerPcs.CheckedChanged += new System.EventHandler(this.radioButtonPerPcs_CheckedChanged);
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(724, 13);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(24, 23);
            this.buttonAddNewCustomer.TabIndex = 33;
            this.buttonAddNewCustomer.Text = "...";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = true;
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Location = new System.Drawing.Point(701, 234);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(100, 32);
            this.clearEntryButton.TabIndex = 34;
            this.clearEntryButton.Text = "Clear Entry";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Enabled = false;
            this.buttonUpdateItem.Location = new System.Drawing.Point(489, 234);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(100, 32);
            this.buttonUpdateItem.TabIndex = 35;
            this.buttonUpdateItem.Text = "Update";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(595, 234);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(100, 32);
            this.buttonDeleteSelected.TabIndex = 36;
            this.buttonDeleteSelected.Text = "Delete Selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // invoiceDateTimePicker
            // 
            this.invoiceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateTimePicker.Location = new System.Drawing.Point(844, 15);
            this.invoiceDateTimePicker.Name = "invoiceDateTimePicker";
            this.invoiceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateTimePicker.TabIndex = 37;
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(13, 489);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(493, 20);
            this.labelTotal.TabIndex = 38;
            this.labelTotal.Text = "Total: ";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalGrossWeight
            // 
            this.textBoxTotalGrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalGrossWeight.Location = new System.Drawing.Point(503, 489);
            this.textBoxTotalGrossWeight.Name = "textBoxTotalGrossWeight";
            this.textBoxTotalGrossWeight.Size = new System.Drawing.Size(81, 20);
            this.textBoxTotalGrossWeight.TabIndex = 39;
            // 
            // labelDummy1
            // 
            this.labelDummy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDummy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDummy1.Location = new System.Drawing.Point(583, 489);
            this.labelDummy1.Name = "labelDummy1";
            this.labelDummy1.Size = new System.Drawing.Size(52, 20);
            this.labelDummy1.TabIndex = 40;
            this.labelDummy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalNetWeight
            // 
            this.textBoxTotalNetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalNetWeight.Location = new System.Drawing.Point(634, 489);
            this.textBoxTotalNetWeight.Name = "textBoxTotalNetWeight";
            this.textBoxTotalNetWeight.Size = new System.Drawing.Size(90, 20);
            this.textBoxTotalNetWeight.TabIndex = 41;
            // 
            // labelDummy2
            // 
            this.labelDummy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDummy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDummy2.Location = new System.Drawing.Point(723, 489);
            this.labelDummy2.Name = "labelDummy2";
            this.labelDummy2.Size = new System.Drawing.Size(224, 20);
            this.labelDummy2.TabIndex = 42;
            this.labelDummy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalFine
            // 
            this.textBoxTotalFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalFine.Location = new System.Drawing.Point(945, 489);
            this.textBoxTotalFine.Name = "textBoxTotalFine";
            this.textBoxTotalFine.Size = new System.Drawing.Size(80, 20);
            this.textBoxTotalFine.TabIndex = 43;
            // 
            // textBoxTotalLabour
            // 
            this.textBoxTotalLabour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalLabour.Location = new System.Drawing.Point(1024, 489);
            this.textBoxTotalLabour.Name = "textBoxTotalLabour";
            this.textBoxTotalLabour.Size = new System.Drawing.Size(82, 20);
            this.textBoxTotalLabour.TabIndex = 44;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(595, 522);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 32);
            this.buttonPrint.TabIndex = 48;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Enabled = false;
            this.buttonPrintPreview.Location = new System.Drawing.Point(489, 522);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(100, 32);
            this.buttonPrintPreview.TabIndex = 47;
            this.buttonPrintPreview.Text = "Print Preview";
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // buttonSaveInvoice
            // 
            this.buttonSaveInvoice.Enabled = false;
            this.buttonSaveInvoice.Location = new System.Drawing.Point(383, 522);
            this.buttonSaveInvoice.Name = "buttonSaveInvoice";
            this.buttonSaveInvoice.Size = new System.Drawing.Size(100, 32);
            this.buttonSaveInvoice.TabIndex = 45;
            this.buttonSaveInvoice.Text = "Save Invoice";
            this.buttonSaveInvoice.UseVisualStyleBackColor = true;
            this.buttonSaveInvoice.Click += new System.EventHandler(this.buttonSaveInvoice_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(701, 522);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 32);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.Location = new System.Drawing.Point(945, 522);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(161, 32);
            this.buttonExportToExcel.TabIndex = 49;
            this.buttonExportToExcel.Text = "Export To Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = true;
            this.buttonExportToExcel.Click += new System.EventHandler(this.buttonExportToExcel_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 574);
            this.Controls.Add(this.buttonExportToExcel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonPrintPreview);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveInvoice);
            this.Controls.Add(this.textBoxTotalLabour);
            this.Controls.Add(this.textBoxTotalFine);
            this.Controls.Add(this.labelDummy2);
            this.Controls.Add(this.textBoxTotalNetWeight);
            this.Controls.Add(this.labelDummy1);
            this.Controls.Add(this.textBoxTotalGrossWeight);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.invoiceDateTimePicker);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.buttonAddNewCustomer);
            this.Controls.Add(this.groupBoxItemEntryMode);
            this.Controls.Add(this.selectCustomerLabel);
            this.Controls.Add(this.selectCustomerComboBox);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.groupBoxNewItem);
            this.Controls.Add(this.billDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Invoices";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Invoice";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBoxNewItem.ResumeLayout(false);
            this.groupBoxNewItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSoldBindingSource)).EndInit();
            this.groupBoxItemEntryMode.ResumeLayout(false);
            this.groupBoxItemEntryMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource billBindingSource;
        private BillingDBDataSet billingDBDataSet;
        private BillingDBDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private BillingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView billDataGridView;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private BillingDBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.TextBox pcsTextBox;
        private System.Windows.Forms.TextBox grossWeightTextBox;
        private System.Windows.Forms.TextBox wtChkTextBox;
        private System.Windows.Forms.TextBox netWeightTextBox;
        private System.Windows.Forms.TextBox hishobTextBox;
        private System.Windows.Forms.TextBox tunchTextBox;
        private System.Windows.Forms.TextBox labourRateTextBox;
        private System.Windows.Forms.TextBox fineTextBox;
        private System.Windows.Forms.TextBox labourTextBox;
        private System.Windows.Forms.GroupBox groupBoxNewItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private BillingDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private BillingDBDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.BindingSource itemsSoldBindingSource;
        private BillingDBDataSetTableAdapters.ItemsSoldTableAdapter itemsSoldTableAdapter;
        private System.Windows.Forms.ComboBox selectCustomerComboBox;
        private System.Windows.Forms.Label selectCustomerLabel;
        private System.Windows.Forms.GroupBox groupBoxItemEntryMode;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonPerKg;
        private System.Windows.Forms.RadioButton radioButtonPerPcs;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Button buttonAddNewCustomer;
        private System.Windows.Forms.ComboBox selectItemsComboBox;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.DateTimePicker invoiceDateTimePicker;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotalGrossWeight;
        private System.Windows.Forms.Label labelDummy1;
        private System.Windows.Forms.TextBox textBoxTotalNetWeight;
        private System.Windows.Forms.Label labelDummy2;
        private System.Windows.Forms.TextBox textBoxTotalFine;
        private System.Windows.Forms.TextBox textBoxTotalLabour;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPrintPreview;
        private System.Windows.Forms.Button buttonSaveInvoice;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExportToExcel;
    }
}