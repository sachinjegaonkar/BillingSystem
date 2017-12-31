using System;
using System.Data;
using System.Data.SqlClient;
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
                    c.ForeColor = Color.White;
                }
                else if (c.GetType() == typeof(TextBox))
                {
                    c.BackColor = Main.yellowColor;
                }
                else if (c.GetType() == typeof(Button))
                {
                    c.BackColor = Main.yellowColor;
                }
                else if (c.GetType() == typeof(ComboBox))
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
                    c.ForeColor = Color.White;
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
                            gc.ForeColor = Color.Black;
                            gc.BackColor = Main.yellowColor;
                        }
                        else if (gc.GetType() == typeof(ComboBox))
                        {
                            gc.BackColor = Main.yellowColor;
                        }
                        else if (gc.GetType() == typeof(RadioButton))
                        {
                            gc.ForeColor = Color.White;
                            gc.BackColor = Main.brandColor;
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

        private void Main_Load(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            // TODO: Do Something here...

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddCustomers_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.ShowDialog();
        }

        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            Items itemsForm = new Items();
            itemsForm.ShowDialog();
        }

        private void buttonCreateInvoice_Click(object sender, EventArgs e)
        {
            Invoices invoicesForm = new Invoices();
            invoicesForm.ShowDialog();
        }
    }
}
