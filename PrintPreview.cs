using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class PrintInvoice : Form
    {
        string customerName = string.Empty;

        public PrintInvoice(ListView tempListView, string customer, string totalGrossWt, string totalNetWt, string totalFine, string totalLabour)
        {
            InitializeComponent();
            Main.SetControlsColor(this);

            customerName = customer;
            for (int i=0; i < tempListView.Items.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                for (int j = 0; j < this.listView.Columns.Count; j++)
                {
                    if (j != 0)
                        lvi.SubItems.Add(tempListView.Items[i].SubItems[j].Text);
                    else
                        lvi.SubItems[0].Text = tempListView.Items[i].SubItems[j].Text;
                }
                this.listView.Items.Add(lvi);
            }
            // Add Empty Item
            {
                ListViewItem emptyItem = new ListViewItem();
                for (int j = 0; j < this.listView.Columns.Count; j++)
                {
                    if (j != 0)
                        emptyItem.SubItems.Add(string.Empty);
                    else
                        emptyItem.SubItems[0].Text = string.Empty;
                }
                this.listView.Items.Add(emptyItem);
            }
            // Add Total Item
            {
                ListViewItem totalItem = new ListViewItem();
                for (int j = 0; j < this.listView.Columns.Count; j++)
                {
                    if (j == 0)
                        totalItem.SubItems[0].Text = string.Empty;
                    else if (j == 1)
                        totalItem.SubItems.Add("Total: ");
                    else if (j == 3)
                        totalItem.SubItems.Add(totalGrossWt);
                    else if (j == 5)
                        totalItem.SubItems.Add(totalNetWt);
                    else if (j == 9)
                        totalItem.SubItems.Add(totalFine);
                    else if (j == 10)
                        totalItem.SubItems.Add(totalLabour);
                    else
                        totalItem.SubItems.Add(string.Empty);
                }
                this.listView.Items.Add(totalItem);
            }
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            UpdatePrintPreview(null, null);
        }

        private void UpdatePrintPreview(object sender, EventArgs e)
        {
            this.listViewPrinter.Header = $"\t{customerName.Substring(0, customerName.IndexOf(" - "))}";
            this.listViewPrinter.Footer = "{1:f}\t\tPages #{0}";
            this.listViewPrinter.Watermark = "Venkatesh Jewellers";

            this.listViewPrinter.IsShrinkToFit = this.cbShrinkToFit.Checked;
            //this.listViewPrinter.IsTextOnly = !this.cbListHeaderOnEveryPage.Checked;
            this.listViewPrinter.IsListHeaderOnEachPage = this.cbListHeaderOnEveryPage.Checked;
            this.listViewPrinter.IsPrintSelectionOnly = this.cbPrintSelection.Checked;

            this.ApplyModernFormatting();

            if (this.radioButtonMinimal.Checked == true)
                this.ApplyMinimalFormatting();
            else if (this.radioButtonModern.Checked == true)
                this.ApplyModernFormatting();
            else if (this.radioButtonOverTheTop.Checked == true)
                this.ApplyOverTheTopFormatting();
            else if (this.radioButtonCustom.Checked == true)
                this.ApplyCustomFormatting();

            if (this.cbUseGridLines.Checked == false)
                this.listViewPrinter.ListGridPen = null;

            //this.listViewPrinter.FirstPage = (int)this.numericUpDown1.Value;
            //this.listViewPrinter.LastPage = (int)this.numericUpDown2.Value;

            this.printPreviewControl.InvalidatePreview();
        }
        /// <summary>
        /// Give the report a minimal set of default formatting values.
        /// </summary>
        public void ApplyMinimalFormatting()
        {
            this.listViewPrinter.CellFormat = null;
            this.listViewPrinter.ListFont = new Font("Tahoma", 9);

            this.listViewPrinter.HeaderFormat = BlockFormat.Header();
            this.listViewPrinter.HeaderFormat.TextBrush = Brushes.Black;
            this.listViewPrinter.HeaderFormat.BackgroundBrush = null;
            this.listViewPrinter.HeaderFormat.SetBorderPen(Sides.Bottom, new Pen(Color.Black, 0.5f));

            this.listViewPrinter.FooterFormat = BlockFormat.Footer();
            this.listViewPrinter.GroupHeaderFormat = BlockFormat.GroupHeader();
            Brush brush = new LinearGradientBrush(new Point(0, 0), new Point(200, 0), Color.Gray, Color.White);
            this.listViewPrinter.GroupHeaderFormat.SetBorder(Sides.Bottom, 2, brush);

            this.listViewPrinter.ListHeaderFormat = BlockFormat.ListHeader();
            this.listViewPrinter.ListHeaderFormat.BackgroundBrush = null;

            this.listViewPrinter.WatermarkFont = null;
            this.listViewPrinter.WatermarkColor = Color.Empty;
        }

        /// <summary>
        /// Give the report a minimal set of default formatting values.
        /// </summary>
        public void ApplyModernFormatting()
        {
            this.listViewPrinter.CellFormat = null;
            this.listViewPrinter.ListFont = new Font("Ms Sans Serif", 9);
            this.listViewPrinter.ListGridPen = new Pen(Color.DarkGray, 0.5f);

            this.listViewPrinter.HeaderFormat = BlockFormat.Header(new Font("Verdana", 24, FontStyle.Bold));
            this.listViewPrinter.HeaderFormat.BackgroundBrush = new LinearGradientBrush(new Point(0, 0), new Point(200, 0), Color.DarkBlue, Color.White);

            this.listViewPrinter.FooterFormat = BlockFormat.Footer();
            this.listViewPrinter.FooterFormat.BackgroundBrush = new LinearGradientBrush(new Point(0, 0), new Point(200, 0), Color.White, Color.Blue);

            this.listViewPrinter.GroupHeaderFormat = BlockFormat.GroupHeader();
            this.listViewPrinter.ListHeaderFormat = BlockFormat.ListHeader(new Font("Verdana", 12));

            this.listViewPrinter.WatermarkFont = null;
            this.listViewPrinter.WatermarkColor = Color.Empty;
        }

        /// <summary>
        /// Give the report a some outrageous formatting values.
        /// </summary>
        public void ApplyOverTheTopFormatting()
        {
            this.listViewPrinter.CellFormat = null;
            this.listViewPrinter.ListFont = new Font("Ms Sans Serif", 9);
            this.listViewPrinter.ListGridPen = new Pen(Color.Blue, 0.5f);

            this.listViewPrinter.HeaderFormat = BlockFormat.Header(new Font("Comic Sans MS", 36));
            this.listViewPrinter.HeaderFormat.TextBrush = new LinearGradientBrush(new Point(0, 0), new Point(900, 0), Color.Black, Color.Blue);
            //this.listViewPrinter.HeaderFormat.BackgroundBrush = new TextureBrush(this.listView.SmallImageList.Images["music"], WrapMode.Tile);
            this.listViewPrinter.HeaderFormat.SetBorder(Sides.All, 10, new LinearGradientBrush(new Point(0, 0), new Point(300, 0), Color.Purple, Color.Pink));

            this.listViewPrinter.FooterFormat = BlockFormat.Footer(new Font("Comic Sans MS", 12));
            this.listViewPrinter.FooterFormat.TextBrush = Brushes.Blue;
            this.listViewPrinter.FooterFormat.BackgroundBrush = new LinearGradientBrush(new Point(0, 0), new Point(200, 0), Color.Gold, Color.Green);
            this.listViewPrinter.FooterFormat.SetBorderPen(Sides.All, new Pen(Color.FromArgb(128, Color.Green), 5));

            this.listViewPrinter.GroupHeaderFormat = BlockFormat.GroupHeader();
            Brush brush = new HatchBrush(HatchStyle.LargeConfetti, Color.Blue, Color.Empty);
            this.listViewPrinter.GroupHeaderFormat.SetBorder(Sides.Bottom, 5, brush);

            this.listViewPrinter.ListHeaderFormat = BlockFormat.ListHeader(new Font("Comic Sans MS", 12));
            this.listViewPrinter.ListHeaderFormat.BackgroundBrush = Brushes.PowderBlue;
            this.listViewPrinter.ListHeaderFormat.TextBrush = Brushes.Black;

            this.listViewPrinter.WatermarkFont = new Font("Comic Sans MS", 72);
            this.listViewPrinter.WatermarkColor = Color.Red;
        }


        /// <summary>
        /// Copy the formatting from the formatting that the user has setup on the custom format panel.
        /// </summary>
        public void ApplyCustomFormatting()
        {
            /*this.listViewPrinter.ListFont = this.listViewPrinter2.ListFont;
            this.listViewPrinter.CellFormat = this.listViewPrinter2.CellFormat;
            this.listViewPrinter.HeaderFormat = this.listViewPrinter2.HeaderFormat;
            this.listViewPrinter.FooterFormat = this.listViewPrinter2.FooterFormat;
            this.listViewPrinter.GroupHeaderFormat = this.listViewPrinter2.GroupHeaderFormat;
            this.listViewPrinter.ListHeaderFormat = this.listViewPrinter2.ListHeaderFormat;
            this.listViewPrinter.WatermarkFont = this.listViewPrinter2.WatermarkFont;
            this.listViewPrinter.WatermarkTransparency = this.listViewPrinter2.WatermarkTransparency;
            this.listViewPrinter.WatermarkColor = this.listViewPrinter2.WatermarkColor;*/
        }

        private void buttonPageSetup_Click(object sender, EventArgs e)
        {
            this.listViewPrinter.PageSetup();
            this.UpdatePrintPreview(null, null);
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            this.listViewPrinter.PrintPreview();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.listViewPrinter.PrintWithDialog();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int pages = (int)this.numericUpDown.Value;

            switch (pages)
            {
                case 1:
                case 2:
                case 3:
                    this.printPreviewControl.Rows = 1;
                    this.printPreviewControl.Columns = pages;
                    break;
                default:
                    this.printPreviewControl.Rows = 2;
                    this.printPreviewControl.Columns = ((pages - 1) / 2) + 1;
                    break;
            }
        }

        private void radioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl.Zoom = 1.0;
            this.printPreviewControl.AutoZoom = true;
        }

        private void radioButton200_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl.Zoom = 2.0;
        }

        private void radioButton100_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl.Zoom = 1.0;
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl.Zoom = 0.5;
        }
    }
}
