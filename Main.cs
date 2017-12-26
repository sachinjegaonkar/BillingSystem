using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Main : Form
    {
        public static Color brandColor = Color.FromArgb(94, 2, 42); // HTML code:	#5E022A
        public static Color yellowColor = Color.FromArgb(248, 189, 68); // HTML code:	#F8BD44

        public static void SetControlsColor(Form form)
        {
            form.BackColor = Main.brandColor;
            foreach (Control c in form.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    c.BackColor = Color.White;
                }
                else if (c.GetType() == typeof(TextBox))
                {
                    c.BackColor = Main.yellowColor;
                }
                else if (c.GetType() == typeof(Button))
                {
                    c.BackColor = Main.yellowColor;
                }
                else if (c.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)c).BackgroundColor = Main.brandColor;
                    ((DataGridView)c).RowsDefaultCellStyle.BackColor = Main.yellowColor;
                    ((DataGridView)c).ColumnHeadersDefaultCellStyle.ForeColor = Main.brandColor;
                    ((DataGridView)c).ColumnHeadersDefaultCellStyle.BackColor = Main.brandColor;
                    ((DataGridView)c).RowHeadersDefaultCellStyle.BackColor = Main.yellowColor;
                }
                else if (c.GetType() == typeof(BindingNavigator))
                {
                    c.BackColor = Main.brandColor;
                    foreach (var item in ((BindingNavigator)c).Items)
                    {
                        if (item.GetType() == typeof(ToolStripButton))
                        {
                            //((ToolStripButton)item).BackColor = Main.yellowColor;
                        }
                        if (item.GetType() == typeof(ToolStripTextBox))
                        {
                            ((ToolStripTextBox)item).BackColor = Main.yellowColor; ;
                        }
                        else if (item.GetType() == typeof(ToolStripLabel))
                        {
                            ((ToolStripLabel)item).ForeColor = Color.White;
                        }
                    }
                }
                else if (c.GetType() == typeof(GroupBox))
                {
                    foreach (Control gc in c.Controls)
                    {
                        if (gc.GetType() == typeof(Label))
                        {
                            gc.ForeColor = Color.White;
                        }
                        else if (gc.GetType() == typeof(TextBox))
                        {
                            gc.BackColor = Main.yellowColor;
                        }
                        else if (gc.GetType() == typeof(Button))
                        {
                            gc.BackColor = Main.yellowColor;
                        }
                        else if (gc.GetType() == typeof(ComboBox))
                        {
                            gc.BackColor = Main.yellowColor;
                        }
                        else
                            gc.BackColor = Main.yellowColor;
                    }
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            SetControlsColor(this);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonAddCustomers_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateInvoice_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddCustomers_Click_1(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.ShowDialog();
        }

        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            Items itemsForm = new Items();
            itemsForm.ShowDialog();
        }

        private void buttonCreateInvoice_Click_1(object sender, EventArgs e)
        {
            Invoices invoicesForm = new Invoices();
            invoicesForm.ShowDialog();
        }
    }
}
