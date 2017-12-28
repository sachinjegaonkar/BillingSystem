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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
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
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.groupBoxItemEntryMode = new System.Windows.Forms.GroupBox();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonPerKg = new System.Windows.Forms.RadioButton();
            this.radioButtonPerPcs = new System.Windows.Forms.RadioButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.billBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.billBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.itemsSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBoxNewItem.SuspendLayout();
            this.groupBoxItemEntryMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingNavigator)).BeginInit();
            this.billBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSoldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(43, 29);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(58, 13);
            itemCodeLabel.TabIndex = 4;
            itemCodeLabel.Text = "Item Code:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(249, 29);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 5;
            itemNameLabel.Text = "Item Name:";
            // 
            // pcsLabel
            // 
            pcsLabel.AutoSize = true;
            pcsLabel.Location = new System.Drawing.Point(491, 29);
            pcsLabel.Name = "pcsLabel";
            pcsLabel.Size = new System.Drawing.Size(28, 13);
            pcsLabel.TabIndex = 6;
            pcsLabel.Text = "Pcs:";
            // 
            // grossWeightLabel
            // 
            grossWeightLabel.AutoSize = true;
            grossWeightLabel.Location = new System.Drawing.Point(27, 74);
            grossWeightLabel.Name = "grossWeightLabel";
            grossWeightLabel.Size = new System.Drawing.Size(74, 13);
            grossWeightLabel.TabIndex = 8;
            grossWeightLabel.Text = "Gross Weight:";
            // 
            // wtChkLabel
            // 
            wtChkLabel.AutoSize = true;
            wtChkLabel.Location = new System.Drawing.Point(264, 74);
            wtChkLabel.Name = "wtChkLabel";
            wtChkLabel.Size = new System.Drawing.Size(46, 13);
            wtChkLabel.TabIndex = 10;
            wtChkLabel.Text = "Wt Chk:";
            // 
            // netWeightLabel
            // 
            netWeightLabel.AutoSize = true;
            netWeightLabel.Location = new System.Drawing.Point(455, 75);
            netWeightLabel.Name = "netWeightLabel";
            netWeightLabel.Size = new System.Drawing.Size(64, 13);
            netWeightLabel.TabIndex = 12;
            netWeightLabel.Text = "Net Weight:";
            // 
            // hishobLabel
            // 
            hishobLabel.AutoSize = true;
            hishobLabel.Location = new System.Drawing.Point(677, 75);
            hishobLabel.Name = "hishobLabel";
            hishobLabel.Size = new System.Drawing.Size(43, 13);
            hishobLabel.TabIndex = 14;
            hishobLabel.Text = "Hishob:";
            // 
            // tunchLabel
            // 
            tunchLabel.AutoSize = true;
            tunchLabel.Location = new System.Drawing.Point(60, 120);
            tunchLabel.Name = "tunchLabel";
            tunchLabel.Size = new System.Drawing.Size(41, 13);
            tunchLabel.TabIndex = 16;
            tunchLabel.Text = "Tunch:";
            // 
            // labourRateLabel
            // 
            labourRateLabel.AutoSize = true;
            labourRateLabel.Location = new System.Drawing.Point(241, 120);
            labourRateLabel.Name = "labourRateLabel";
            labourRateLabel.Size = new System.Drawing.Size(69, 13);
            labourRateLabel.TabIndex = 18;
            labourRateLabel.Text = "Labour Rate:";
            // 
            // fineLabel
            // 
            fineLabel.AutoSize = true;
            fineLabel.Location = new System.Drawing.Point(489, 119);
            fineLabel.Name = "fineLabel";
            fineLabel.Size = new System.Drawing.Size(30, 13);
            fineLabel.TabIndex = 20;
            fineLabel.Text = "Fine:";
            // 
            // labourLabel
            // 
            labourLabel.AutoSize = true;
            labourLabel.Location = new System.Drawing.Point(677, 119);
            labourLabel.Name = "labourLabel";
            labourLabel.Size = new System.Drawing.Size(43, 13);
            labourLabel.TabIndex = 22;
            labourLabel.Text = "Labour:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(488, 20);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 28;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(696, 20);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 29;
            lastNameLabel.Text = "Last Name:";
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
            this.billDataGridView.AutoGenerateColumns = false;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.billDataGridView.DataSource = this.billBindingSource;
            this.billDataGridView.Location = new System.Drawing.Point(13, 271);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.billDataGridView.Size = new System.Drawing.Size(1093, 231);
            this.billDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pcs";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pcs";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GrossWeight";
            this.dataGridViewTextBoxColumn4.HeaderText = "GrossWeight";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "WtChk";
            this.dataGridViewTextBoxColumn5.HeaderText = "WtChk";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NetWeight";
            this.dataGridViewTextBoxColumn6.HeaderText = "NetWeight";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Hishob";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hishob";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Tunch";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tunch";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LabourRate";
            this.dataGridViewTextBoxColumn9.HeaderText = "LabourRate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fine";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fine";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Labour";
            this.dataGridViewTextBoxColumn11.HeaderText = "Labour";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.billingDBDataSet;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "ItemCode", true));
            this.itemCodeTextBox.Location = new System.Drawing.Point(107, 26);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCodeTextBox.TabIndex = 5;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(316, 26);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // pcsTextBox
            // 
            this.pcsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "Pcs", true));
            this.pcsTextBox.Location = new System.Drawing.Point(525, 26);
            this.pcsTextBox.Name = "pcsTextBox";
            this.pcsTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcsTextBox.TabIndex = 7;
            // 
            // grossWeightTextBox
            // 
            this.grossWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "GrossWeight", true));
            this.grossWeightTextBox.Location = new System.Drawing.Point(107, 69);
            this.grossWeightTextBox.Name = "grossWeightTextBox";
            this.grossWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossWeightTextBox.TabIndex = 9;
            // 
            // wtChkTextBox
            // 
            this.wtChkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "WtChk", true));
            this.wtChkTextBox.Location = new System.Drawing.Point(316, 69);
            this.wtChkTextBox.Name = "wtChkTextBox";
            this.wtChkTextBox.Size = new System.Drawing.Size(100, 20);
            this.wtChkTextBox.TabIndex = 11;
            // 
            // netWeightTextBox
            // 
            this.netWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "NetWeight", true));
            this.netWeightTextBox.Location = new System.Drawing.Point(525, 69);
            this.netWeightTextBox.Name = "netWeightTextBox";
            this.netWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.netWeightTextBox.TabIndex = 13;
            // 
            // hishobTextBox
            // 
            this.hishobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "Hishob", true));
            this.hishobTextBox.Location = new System.Drawing.Point(726, 71);
            this.hishobTextBox.Name = "hishobTextBox";
            this.hishobTextBox.Size = new System.Drawing.Size(100, 20);
            this.hishobTextBox.TabIndex = 15;
            // 
            // tunchTextBox
            // 
            this.tunchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "Tunch", true));
            this.tunchTextBox.Location = new System.Drawing.Point(107, 116);
            this.tunchTextBox.Name = "tunchTextBox";
            this.tunchTextBox.Size = new System.Drawing.Size(100, 20);
            this.tunchTextBox.TabIndex = 17;
            // 
            // labourRateTextBox
            // 
            this.labourRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "LabourRate", true));
            this.labourRateTextBox.Location = new System.Drawing.Point(316, 116);
            this.labourRateTextBox.Name = "labourRateTextBox";
            this.labourRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.labourRateTextBox.TabIndex = 19;
            // 
            // fineTextBox
            // 
            this.fineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "Fine", true));
            this.fineTextBox.Location = new System.Drawing.Point(525, 116);
            this.fineTextBox.Name = "fineTextBox";
            this.fineTextBox.Size = new System.Drawing.Size(100, 20);
            this.fineTextBox.TabIndex = 21;
            // 
            // labourTextBox
            // 
            this.labourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "Labour", true));
            this.labourTextBox.Location = new System.Drawing.Point(726, 116);
            this.labourTextBox.Name = "labourTextBox";
            this.labourTextBox.Size = new System.Drawing.Size(100, 20);
            this.labourTextBox.TabIndex = 23;
            // 
            // groupBoxNewItem
            // 
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
            this.groupBoxNewItem.Controls.Add(this.itemNameTextBox);
            this.groupBoxNewItem.Controls.Add(this.itemCodeTextBox);
            this.groupBoxNewItem.Location = new System.Drawing.Point(238, 47);
            this.groupBoxNewItem.Name = "groupBoxNewItem";
            this.groupBoxNewItem.Size = new System.Drawing.Size(868, 156);
            this.groupBoxNewItem.TabIndex = 24;
            this.groupBoxNewItem.TabStop = false;
            this.groupBoxNewItem.Text = "New Item";
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(860, 218);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(98, 34);
            this.buttonDeleteItem.TabIndex = 27;
            this.buttonDeleteItem.Text = "Delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(611, 218);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(102, 34);
            this.buttonUpdateItem.TabIndex = 26;
            this.buttonUpdateItem.Text = "Update";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(345, 220);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(108, 32);
            this.buttonAddItem.TabIndex = 25;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // groupBoxItemEntryMode
            // 
            this.groupBoxItemEntryMode.Controls.Add(this.radioButtonRegular);
            this.groupBoxItemEntryMode.Controls.Add(this.radioButtonPerKg);
            this.groupBoxItemEntryMode.Controls.Add(this.radioButtonPerPcs);
            this.groupBoxItemEntryMode.Location = new System.Drawing.Point(13, 47);
            this.groupBoxItemEntryMode.Name = "groupBoxItemEntryMode";
            this.groupBoxItemEntryMode.Size = new System.Drawing.Size(219, 156);
            this.groupBoxItemEntryMode.TabIndex = 28;
            this.groupBoxItemEntryMode.TabStop = false;
            this.groupBoxItemEntryMode.Text = "Item Entry Mode";
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(80, 115);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRegular.TabIndex = 30;
            this.radioButtonRegular.Text = "Ragular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerKg
            // 
            this.radioButtonPerKg.AutoSize = true;
            this.radioButtonPerKg.Location = new System.Drawing.Point(80, 73);
            this.radioButtonPerKg.Name = "radioButtonPerKg";
            this.radioButtonPerKg.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPerKg.TabIndex = 29;
            this.radioButtonPerKg.Text = "Per Kg";
            this.radioButtonPerKg.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerPcs
            // 
            this.radioButtonPerPcs.AutoSize = true;
            this.radioButtonPerPcs.Checked = true;
            this.radioButtonPerPcs.Location = new System.Drawing.Point(80, 29);
            this.radioButtonPerPcs.Name = "radioButtonPerPcs";
            this.radioButtonPerPcs.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPerPcs.TabIndex = 0;
            this.radioButtonPerPcs.TabStop = true;
            this.radioButtonPerPcs.Text = "Per Pices";
            this.radioButtonPerPcs.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // billBindingNavigatorSaveItem
            // 
            this.billBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.billBindingNavigatorSaveItem.Enabled = false;
            this.billBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("billBindingNavigatorSaveItem.Image")));
            this.billBindingNavigatorSaveItem.Name = "billBindingNavigatorSaveItem";
            this.billBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.billBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // billBindingNavigator
            // 
            this.billBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.billBindingNavigator.BindingSource = this.billBindingSource;
            this.billBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.billBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.billBindingNavigatorSaveItem});
            this.billBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.billBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billBindingNavigator.Name = "billBindingNavigator";
            this.billBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billBindingNavigator.Size = new System.Drawing.Size(1120, 25);
            this.billBindingNavigator.TabIndex = 3;
            this.billBindingNavigator.Text = "bindingNavigator1";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.billingDBDataSet;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(554, 17);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 29;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(763, 17);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 30;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.billingDBDataSet;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(906, 14);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 31;
            // 
            // itemsSoldBindingSource
            // 
            this.itemsSoldBindingSource.DataMember = "ItemsSold";
            this.itemsSoldBindingSource.DataSource = this.billingDBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customersBindingSource;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(345, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "LastName";
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 566);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.groupBoxItemEntryMode);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.groupBoxNewItem);
            this.Controls.Add(this.billDataGridView);
            this.Controls.Add(this.billBindingNavigator);
            this.Name = "Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Invoice";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBoxNewItem.ResumeLayout(false);
            this.groupBoxNewItem.PerformLayout();
            this.groupBoxItemEntryMode.ResumeLayout(false);
            this.groupBoxItemEntryMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingNavigator)).EndInit();
            this.billBindingNavigator.ResumeLayout(false);
            this.billBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSoldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource billBindingSource;
        private BillingDBDataSet billingDBDataSet;
        private BillingDBDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private BillingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView billDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private BillingDBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
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
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.GroupBox groupBoxItemEntryMode;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonPerKg;
        private System.Windows.Forms.RadioButton radioButtonPerPcs;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton billBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator billBindingNavigator;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private BillingDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private BillingDBDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.BindingSource itemsSoldBindingSource;
        private BillingDBDataSetTableAdapters.ItemsSoldTableAdapter itemsSoldTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}