namespace BillingSystem
{
    partial class PrintInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvoice));
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMagnification = new System.Windows.Forms.GroupBox();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.radioButton200 = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelPages = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.buttonPageSetup = new System.Windows.Forms.Button();
            this.groupBoxFormatting = new System.Windows.Forms.GroupBox();
            this.cbListHeaderOnEveryPage = new System.Windows.Forms.CheckBox();
            this.cbPrintSelection = new System.Windows.Forms.CheckBox();
            this.cbShrinkToFit = new System.Windows.Forms.CheckBox();
            this.cbUseGridLines = new System.Windows.Forms.CheckBox();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonOverTheTop = new System.Windows.Forms.RadioButton();
            this.radioButtonModern = new System.Windows.Forms.RadioButton();
            this.radioButtonMinimal = new System.Windows.Forms.RadioButton();
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.listViewPrinter = new BillingSystem.ListViewPrinter();
            this.groupBoxMagnification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBoxFormatting.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView.Location = new System.Drawing.Point(-38, -25);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(0, 0);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Code";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 275;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pcs";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gross Weight";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Wt Chk";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Net Weight";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hishob";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tunch %";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Labour Rate";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fine";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Labour";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 80;
            // 
            // groupBoxMagnification
            // 
            this.groupBoxMagnification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMagnification.Controls.Add(this.radioButton50);
            this.groupBoxMagnification.Controls.Add(this.radioButton200);
            this.groupBoxMagnification.Controls.Add(this.radioButton100);
            this.groupBoxMagnification.Controls.Add(this.radioButtonAuto);
            this.groupBoxMagnification.Location = new System.Drawing.Point(670, 169);
            this.groupBoxMagnification.Name = "groupBoxMagnification";
            this.groupBoxMagnification.Size = new System.Drawing.Size(95, 95);
            this.groupBoxMagnification.TabIndex = 14;
            this.groupBoxMagnification.TabStop = false;
            this.groupBoxMagnification.Text = "Magnification:";
            // 
            // radioButton50
            // 
            this.radioButton50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton50.AutoSize = true;
            this.radioButton50.Location = new System.Drawing.Point(15, 71);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(45, 17);
            this.radioButton50.TabIndex = 3;
            this.radioButton50.Text = "&50%";
            this.radioButton50.UseVisualStyleBackColor = true;
            this.radioButton50.CheckedChanged += new System.EventHandler(this.radioButton50_CheckedChanged);
            // 
            // radioButton200
            // 
            this.radioButton200.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton200.AutoSize = true;
            this.radioButton200.Location = new System.Drawing.Point(15, 37);
            this.radioButton200.Name = "radioButton200";
            this.radioButton200.Size = new System.Drawing.Size(51, 17);
            this.radioButton200.TabIndex = 1;
            this.radioButton200.Text = "&200%";
            this.radioButton200.UseVisualStyleBackColor = true;
            this.radioButton200.CheckedChanged += new System.EventHandler(this.radioButton200_CheckedChanged);
            // 
            // radioButton100
            // 
            this.radioButton100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton100.AutoSize = true;
            this.radioButton100.Location = new System.Drawing.Point(15, 54);
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.Size = new System.Drawing.Size(51, 17);
            this.radioButton100.TabIndex = 2;
            this.radioButton100.Text = "&100%";
            this.radioButton100.UseVisualStyleBackColor = true;
            this.radioButton100.CheckedChanged += new System.EventHandler(this.radioButton100_CheckedChanged);
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Checked = true;
            this.radioButtonAuto.Location = new System.Drawing.Point(15, 19);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAuto.TabIndex = 0;
            this.radioButtonAuto.TabStop = true;
            this.radioButtonAuto.Text = "&Auto";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            this.radioButtonAuto.CheckedChanged += new System.EventHandler(this.radioButtonAuto_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Location = new System.Drawing.Point(716, 297);
            this.numericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown.TabIndex = 16;
            this.numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelPages
            // 
            this.labelPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(670, 299);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(40, 13);
            this.labelPages.TabIndex = 15;
            this.labelPages.Text = "&Pages:";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(670, 140);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(95, 23);
            this.buttonPrint.TabIndex = 13;
            this.buttonPrint.Text = "&Print...";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintPreview.Location = new System.Drawing.Point(670, 111);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(95, 23);
            this.buttonPrintPreview.TabIndex = 12;
            this.buttonPrintPreview.Text = "Print Pre&view...";
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // buttonPageSetup
            // 
            this.buttonPageSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPageSetup.Location = new System.Drawing.Point(670, 82);
            this.buttonPageSetup.Name = "buttonPageSetup";
            this.buttonPageSetup.Size = new System.Drawing.Size(95, 23);
            this.buttonPageSetup.TabIndex = 11;
            this.buttonPageSetup.Text = "Page &Setup...";
            this.buttonPageSetup.UseVisualStyleBackColor = true;
            this.buttonPageSetup.Click += new System.EventHandler(this.buttonPageSetup_Click);
            // 
            // groupBoxFormatting
            // 
            this.groupBoxFormatting.Controls.Add(this.cbListHeaderOnEveryPage);
            this.groupBoxFormatting.Controls.Add(this.cbPrintSelection);
            this.groupBoxFormatting.Controls.Add(this.cbShrinkToFit);
            this.groupBoxFormatting.Controls.Add(this.cbUseGridLines);
            this.groupBoxFormatting.Location = new System.Drawing.Point(294, 12);
            this.groupBoxFormatting.Name = "groupBoxFormatting";
            this.groupBoxFormatting.Size = new System.Drawing.Size(351, 67);
            this.groupBoxFormatting.TabIndex = 17;
            this.groupBoxFormatting.TabStop = false;
            this.groupBoxFormatting.Text = "Formatting";
            // 
            // cbListHeaderOnEveryPage
            // 
            this.cbListHeaderOnEveryPage.AutoSize = true;
            this.cbListHeaderOnEveryPage.Checked = true;
            this.cbListHeaderOnEveryPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbListHeaderOnEveryPage.Location = new System.Drawing.Point(180, 39);
            this.cbListHeaderOnEveryPage.Name = "cbListHeaderOnEveryPage";
            this.cbListHeaderOnEveryPage.Size = new System.Drawing.Size(149, 17);
            this.cbListHeaderOnEveryPage.TabIndex = 8;
            this.cbListHeaderOnEveryPage.Text = "List header on every page";
            this.cbListHeaderOnEveryPage.UseVisualStyleBackColor = true;
            this.cbListHeaderOnEveryPage.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // cbPrintSelection
            // 
            this.cbPrintSelection.AutoSize = true;
            this.cbPrintSelection.Location = new System.Drawing.Point(30, 39);
            this.cbPrintSelection.Name = "cbPrintSelection";
            this.cbPrintSelection.Size = new System.Drawing.Size(114, 17);
            this.cbPrintSelection.TabIndex = 7;
            this.cbPrintSelection.Text = "Print only selection";
            this.cbPrintSelection.UseVisualStyleBackColor = true;
            this.cbPrintSelection.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // cbShrinkToFit
            // 
            this.cbShrinkToFit.AutoSize = true;
            this.cbShrinkToFit.Checked = true;
            this.cbShrinkToFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShrinkToFit.Location = new System.Drawing.Point(180, 22);
            this.cbShrinkToFit.Name = "cbShrinkToFit";
            this.cbShrinkToFit.Size = new System.Drawing.Size(79, 17);
            this.cbShrinkToFit.TabIndex = 6;
            this.cbShrinkToFit.Text = "Shrink to fit";
            this.cbShrinkToFit.UseVisualStyleBackColor = true;
            this.cbShrinkToFit.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // cbUseGridLines
            // 
            this.cbUseGridLines.AutoSize = true;
            this.cbUseGridLines.Checked = true;
            this.cbUseGridLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseGridLines.Location = new System.Drawing.Point(30, 22);
            this.cbUseGridLines.Name = "cbUseGridLines";
            this.cbUseGridLines.Size = new System.Drawing.Size(89, 17);
            this.cbUseGridLines.TabIndex = 5;
            this.cbUseGridLines.Text = "Use grid lines";
            this.cbUseGridLines.UseVisualStyleBackColor = true;
            this.cbUseGridLines.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.radioButtonCustom);
            this.groupBoxStyle.Controls.Add(this.radioButtonOverTheTop);
            this.groupBoxStyle.Controls.Add(this.radioButtonModern);
            this.groupBoxStyle.Controls.Add(this.radioButtonMinimal);
            this.groupBoxStyle.Location = new System.Drawing.Point(18, 12);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(270, 67);
            this.groupBoxStyle.TabIndex = 18;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(138, 38);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCustom.TabIndex = 4;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // radioButtonOverTheTop
            // 
            this.radioButtonOverTheTop.AutoSize = true;
            this.radioButtonOverTheTop.Location = new System.Drawing.Point(45, 39);
            this.radioButtonOverTheTop.Name = "radioButtonOverTheTop";
            this.radioButtonOverTheTop.Size = new System.Drawing.Size(87, 17);
            this.radioButtonOverTheTop.TabIndex = 3;
            this.radioButtonOverTheTop.Text = "Over the top!";
            this.radioButtonOverTheTop.UseVisualStyleBackColor = true;
            this.radioButtonOverTheTop.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // radioButtonModern
            // 
            this.radioButtonModern.AutoSize = true;
            this.radioButtonModern.Checked = true;
            this.radioButtonModern.Location = new System.Drawing.Point(137, 19);
            this.radioButtonModern.Name = "radioButtonModern";
            this.radioButtonModern.Size = new System.Drawing.Size(61, 17);
            this.radioButtonModern.TabIndex = 2;
            this.radioButtonModern.TabStop = true;
            this.radioButtonModern.Text = "Modern";
            this.radioButtonModern.UseVisualStyleBackColor = true;
            this.radioButtonModern.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // radioButtonMinimal
            // 
            this.radioButtonMinimal.AutoSize = true;
            this.radioButtonMinimal.Location = new System.Drawing.Point(45, 17);
            this.radioButtonMinimal.Name = "radioButtonMinimal";
            this.radioButtonMinimal.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMinimal.TabIndex = 1;
            this.radioButtonMinimal.Text = "Minimal";
            this.radioButtonMinimal.UseVisualStyleBackColor = true;
            this.radioButtonMinimal.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.Columns = 2;
            this.printPreviewControl.Document = this.listViewPrinter;
            this.printPreviewControl.Location = new System.Drawing.Point(18, 85);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(627, 528);
            this.printPreviewControl.TabIndex = 9;
            this.printPreviewControl.Zoom = 0.45765611633875108D;
            // 
            // listViewPrinter
            // 
            // 
            // 
            // 
            this.listViewPrinter.CellFormat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.CellFormat.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.listViewPrinter.CellFormat.BottomBorderWidth = 0.5F;
            this.listViewPrinter.CellFormat.CanWrap = true;
            this.listViewPrinter.CellFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewPrinter.CellFormat.LeftBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.listViewPrinter.CellFormat.LeftBorderWidth = 0.5F;
            this.listViewPrinter.CellFormat.MinimumTextHeight = 0F;
            this.listViewPrinter.CellFormat.RightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.listViewPrinter.CellFormat.RightBorderWidth = 0.5F;
            this.listViewPrinter.CellFormat.TextColor = System.Drawing.Color.Empty;
            this.listViewPrinter.CellFormat.TopBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.listViewPrinter.CellFormat.TopBorderWidth = 0.5F;
            this.listViewPrinter.Footer = "{1}\t\tPage #{0}";
            // 
            // 
            // 
            this.listViewPrinter.FooterFormat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.FooterFormat.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.FooterFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            this.listViewPrinter.FooterFormat.LeftBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.FooterFormat.MinimumTextHeight = 0F;
            this.listViewPrinter.FooterFormat.RightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.FooterFormat.TextColor = System.Drawing.Color.Black;
            this.listViewPrinter.FooterFormat.TopBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listViewPrinter.FooterFormat.TopBorderWidth = 0.5F;
            // 
            // 
            // 
            this.listViewPrinter.GroupHeaderFormat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.GroupHeaderFormat.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.GroupHeaderFormat.BottomBorderWidth = 3F;
            this.listViewPrinter.GroupHeaderFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.listViewPrinter.GroupHeaderFormat.LeftBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.GroupHeaderFormat.MinimumTextHeight = 0F;
            this.listViewPrinter.GroupHeaderFormat.RightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.GroupHeaderFormat.TextColor = System.Drawing.Color.Black;
            this.listViewPrinter.GroupHeaderFormat.TopBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.Header = "ListViewPrinterDemo";
            // 
            // 
            // 
            this.listViewPrinter.HeaderFormat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.HeaderFormat.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.HeaderFormat.Font = new System.Drawing.Font("Verdana", 24F);
            this.listViewPrinter.HeaderFormat.LeftBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.HeaderFormat.MinimumTextHeight = 0F;
            this.listViewPrinter.HeaderFormat.RightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.HeaderFormat.TextColor = System.Drawing.Color.WhiteSmoke;
            this.listViewPrinter.HeaderFormat.TopBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewPrinter.IsListHeaderOnEachPage = false;
            this.listViewPrinter.IsShrinkToFit = true;
            this.listViewPrinter.ListFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewPrinter.ListGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.listViewPrinter.ListHeaderFormat.BackgroundColor = System.Drawing.Color.LightGray;
            this.listViewPrinter.ListHeaderFormat.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.listViewPrinter.ListHeaderFormat.BottomBorderWidth = 1.5F;
            this.listViewPrinter.ListHeaderFormat.CanWrap = true;
            this.listViewPrinter.ListHeaderFormat.Font = new System.Drawing.Font("Verdana", 12F);
            this.listViewPrinter.ListHeaderFormat.LeftBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.listViewPrinter.ListHeaderFormat.LeftBorderWidth = 1.5F;
            this.listViewPrinter.ListHeaderFormat.MinimumTextHeight = 0F;
            this.listViewPrinter.ListHeaderFormat.RightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.listViewPrinter.ListHeaderFormat.RightBorderWidth = 1.5F;
            this.listViewPrinter.ListHeaderFormat.TextColor = System.Drawing.Color.Black;
            this.listViewPrinter.ListHeaderFormat.TopBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.listViewPrinter.ListHeaderFormat.TopBorderWidth = 1.5F;
            this.listViewPrinter.ListView = this.listView;
            this.listViewPrinter.Watermark = "Venkatesh Jewellers";
            this.listViewPrinter.WatermarkColor = System.Drawing.Color.Empty;
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 571);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxFormatting);
            this.Controls.Add(this.groupBoxMagnification);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonPrintPreview);
            this.Controls.Add(this.buttonPageSetup);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.printPreviewControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrintInvoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            this.groupBoxMagnification.ResumeLayout(false);
            this.groupBoxMagnification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBoxFormatting.ResumeLayout(false);
            this.groupBoxFormatting.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
        private ListViewPrinter listViewPrinter;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBoxMagnification;
        private System.Windows.Forms.RadioButton radioButton50;
        private System.Windows.Forms.RadioButton radioButton200;
        private System.Windows.Forms.RadioButton radioButton100;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPrintPreview;
        private System.Windows.Forms.Button buttonPageSetup;
        private System.Windows.Forms.GroupBox groupBoxFormatting;
        private System.Windows.Forms.CheckBox cbListHeaderOnEveryPage;
        private System.Windows.Forms.CheckBox cbPrintSelection;
        private System.Windows.Forms.CheckBox cbShrinkToFit;
        private System.Windows.Forms.CheckBox cbUseGridLines;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonOverTheTop;
        private System.Windows.Forms.RadioButton radioButtonModern;
        private System.Windows.Forms.RadioButton radioButtonMinimal;
    }
}