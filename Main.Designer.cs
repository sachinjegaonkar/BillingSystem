namespace BillingSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreateInvoice = new System.Windows.Forms.Button();
            this.buttonAddItems = new System.Windows.Forms.Button();
            this.buttonAddCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(315, 289);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 97);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCreateInvoice
            // 
            this.buttonCreateInvoice.Location = new System.Drawing.Point(315, 19);
            this.buttonCreateInvoice.Name = "buttonCreateInvoice";
            this.buttonCreateInvoice.Size = new System.Drawing.Size(146, 97);
            this.buttonCreateInvoice.TabIndex = 6;
            this.buttonCreateInvoice.Text = "Create Invoices";
            this.buttonCreateInvoice.UseVisualStyleBackColor = true;
            this.buttonCreateInvoice.Click += new System.EventHandler(this.buttonCreateInvoice_Click);
            // 
            // buttonAddItems
            // 
            this.buttonAddItems.Location = new System.Drawing.Point(494, 152);
            this.buttonAddItems.Name = "buttonAddItems";
            this.buttonAddItems.Size = new System.Drawing.Size(146, 97);
            this.buttonAddItems.TabIndex = 5;
            this.buttonAddItems.Text = "Add Items";
            this.buttonAddItems.UseVisualStyleBackColor = true;
            this.buttonAddItems.Click += new System.EventHandler(this.buttonAddItems_Click);
            // 
            // buttonAddCustomers
            // 
            this.buttonAddCustomers.Location = new System.Drawing.Point(138, 152);
            this.buttonAddCustomers.Name = "buttonAddCustomers";
            this.buttonAddCustomers.Size = new System.Drawing.Size(146, 97);
            this.buttonAddCustomers.TabIndex = 4;
            this.buttonAddCustomers.Text = "Add Customers";
            this.buttonAddCustomers.UseVisualStyleBackColor = true;
            this.buttonAddCustomers.Click += new System.EventHandler(this.buttonAddCustomers_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BillingSystem.Properties.Resources.Tradition_of_Trust;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(779, 405);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCreateInvoice);
            this.Controls.Add(this.buttonAddItems);
            this.Controls.Add(this.buttonAddCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Venkatesh Jewellers - Billing System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCreateInvoice;
        private System.Windows.Forms.Button buttonAddItems;
        private System.Windows.Forms.Button buttonAddCustomers;
    }
}

