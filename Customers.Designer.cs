namespace BillingSystem
{
    partial class Customers
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label organisationLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label eMailIDLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label pincodeLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label stateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.billingDBDataSet = new BillingSystem.BillingDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new BillingSystem.BillingDBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new BillingSystem.BillingDBDataSetTableAdapters.TableAdapterManager();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.organisationTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.eMailIDTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.pincodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxNewCustomer = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
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
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            organisationLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            eMailIDLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            pincodeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.groupBoxNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(256, 29);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(64, 13);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name*:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(485, 29);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(65, 13);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name*:";
            // 
            // organisationLabel
            // 
            organisationLabel.AutoSize = true;
            organisationLabel.Location = new System.Drawing.Point(26, 65);
            organisationLabel.Name = "organisationLabel";
            organisationLabel.Size = new System.Drawing.Size(73, 13);
            organisationLabel.TabIndex = 6;
            organisationLabel.Text = "Organisation*:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(268, 78);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(52, 13);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address*:";
            // 
            // eMailIDLabel
            // 
            eMailIDLabel.AutoSize = true;
            eMailIDLabel.Location = new System.Drawing.Point(47, 103);
            eMailIDLabel.Name = "eMailIDLabel";
            eMailIDLabel.Size = new System.Drawing.Size(50, 13);
            eMailIDLabel.TabIndex = 10;
            eMailIDLabel.Text = "EMail ID:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(54, 140);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(45, 13);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone*:";
            // 
            // pincodeLabel
            // 
            pincodeLabel.AutoSize = true;
            pincodeLabel.Location = new System.Drawing.Point(497, 142);
            pincodeLabel.Name = "pincodeLabel";
            pincodeLabel.Size = new System.Drawing.Size(53, 13);
            pincodeLabel.TabIndex = 16;
            pincodeLabel.Text = "Pincode*:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(65, 29);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // billingDBDataSet
            // 
            this.billingDBDataSet.DataSetName = "BillingDBDataSet";
            this.billingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.billingDBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.ItemsSoldTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BillingSystem.BillingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToResizeColumns = false;
            this.customersDataGridView.AllowUserToResizeRows = false;
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 271);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customersDataGridView.Size = new System.Drawing.Size(873, 203);
            this.customersDataGridView.TabIndex = 2;
            this.customersDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellEndEdit);
            this.customersDataGridView.SelectionChanged += new System.EventHandler(this.customersDataGridView_SelectionChanged);
            this.customersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customersDataGridView_KeyDown);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(228, 218);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(108, 32);
            this.buttonAddCustomer.TabIndex = 1;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(403, 216);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(102, 34);
            this.buttonUpdateCustomer.TabIndex = 3;
            this.buttonUpdateCustomer.Text = "Update";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(578, 216);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(98, 34);
            this.buttonDeleteCustomer.TabIndex = 4;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(322, 26);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(552, 26);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // organisationTextBox
            // 
            this.organisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Organisation", true));
            this.organisationTextBox.Location = new System.Drawing.Point(101, 62);
            this.organisationTextBox.Name = "organisationTextBox";
            this.organisationTextBox.Size = new System.Drawing.Size(148, 20);
            this.organisationTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(322, 62);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(368, 60);
            this.addressTextBox.TabIndex = 9;
            // 
            // eMailIDTextBox
            // 
            this.eMailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "EMailID", true));
            this.eMailIDTextBox.Location = new System.Drawing.Point(101, 100);
            this.eMailIDTextBox.Name = "eMailIDTextBox";
            this.eMailIDTextBox.Size = new System.Drawing.Size(148, 20);
            this.eMailIDTextBox.TabIndex = 11;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(101, 137);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(148, 20);
            this.phoneTextBox.TabIndex = 13;
            // 
            // pincodeTextBox
            // 
            this.pincodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Pincode", true));
            this.pincodeTextBox.Location = new System.Drawing.Point(552, 140);
            this.pincodeTextBox.Name = "pincodeTextBox";
            this.pincodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.pincodeTextBox.TabIndex = 17;
            // 
            // groupBoxNewCustomer
            // 
            this.groupBoxNewCustomer.Controls.Add(stateLabel);
            this.groupBoxNewCustomer.Controls.Add(this.stateTextBox);
            this.groupBoxNewCustomer.Controls.Add(titleLabel);
            this.groupBoxNewCustomer.Controls.Add(this.titleTextBox);
            this.groupBoxNewCustomer.Controls.Add(pincodeLabel);
            this.groupBoxNewCustomer.Controls.Add(this.pincodeTextBox);
            this.groupBoxNewCustomer.Controls.Add(phoneLabel);
            this.groupBoxNewCustomer.Controls.Add(this.phoneTextBox);
            this.groupBoxNewCustomer.Controls.Add(eMailIDLabel);
            this.groupBoxNewCustomer.Controls.Add(this.eMailIDTextBox);
            this.groupBoxNewCustomer.Controls.Add(addressLabel);
            this.groupBoxNewCustomer.Controls.Add(this.addressTextBox);
            this.groupBoxNewCustomer.Controls.Add(organisationLabel);
            this.groupBoxNewCustomer.Controls.Add(this.organisationTextBox);
            this.groupBoxNewCustomer.Controls.Add(lastNameLabel);
            this.groupBoxNewCustomer.Controls.Add(this.lastNameTextBox);
            this.groupBoxNewCustomer.Controls.Add(firstNameLabel);
            this.groupBoxNewCustomer.Controls.Add(this.firstNameTextBox);
            this.groupBoxNewCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxNewCustomer.Location = new System.Drawing.Point(76, 22);
            this.groupBoxNewCustomer.Name = "groupBoxNewCustomer";
            this.groupBoxNewCustomer.Size = new System.Drawing.Size(746, 176);
            this.groupBoxNewCustomer.TabIndex = 0;
            this.groupBoxNewCustomer.TabStop = false;
            this.groupBoxNewCustomer.Text = "New Customer";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(101, 26);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(148, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(281, 142);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 14;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(322, 139);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(138, 20);
            this.stateTextBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Organisation";
            this.dataGridViewTextBoxColumn5.HeaderText = "Organisation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMailID";
            this.dataGridViewTextBoxColumn7.HeaderText = "EMailID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn9.HeaderText = "State";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Pincode";
            this.dataGridViewTextBoxColumn10.HeaderText = "Pincode";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 555);
            this.Controls.Add(this.groupBoxNewCustomer);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.buttonUpdateCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.customersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Customers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.groupBoxNewCustomer.ResumeLayout(false);
            this.groupBoxNewCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BillingDBDataSet billingDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private BillingDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private BillingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox organisationTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox eMailIDTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox pincodeTextBox;
        private System.Windows.Forms.GroupBox groupBoxNewCustomer;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
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
    }
}