namespace OraclePublisherPrintHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabPageActions = new System.Windows.Forms.TabPage();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Printer = new System.Windows.Forms.Label();
            this.buttonFindRTF2PDF = new System.Windows.Forms.Button();
            this.buttonGhostScriptLocation = new System.Windows.Forms.Button();
            this.buttonSelectPrinter = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabPageActions.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(689, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Clo&se";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 525);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(774, 31);
            this.panel1.TabIndex = 5;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabPageActions
            // 
            this.tabPageActions.Controls.Add(this.richTextBox);
            this.tabPageActions.Controls.Add(this.buttonBuild);
            this.tabPageActions.Controls.Add(this.buttonPreview);
            this.tabPageActions.Controls.Add(this.buttonPrint);
            this.tabPageActions.Location = new System.Drawing.Point(4, 22);
            this.tabPageActions.Name = "tabPageActions";
            this.tabPageActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActions.Size = new System.Drawing.Size(766, 525);
            this.tabPageActions.TabIndex = 0;
            this.tabPageActions.Text = "Actions";
            this.tabPageActions.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(168, 6);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "&Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonPreview.Location = new System.Drawing.Point(87, 6);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 0;
            this.buttonPreview.Text = "Pre&view";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageActions);
            this.tabControl.Controls.Add(this.tabPageOptions);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(774, 551);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.textBox3);
            this.tabPageOptions.Controls.Add(this.buttonSelectPrinter);
            this.tabPageOptions.Controls.Add(this.buttonGhostScriptLocation);
            this.tabPageOptions.Controls.Add(this.buttonFindRTF2PDF);
            this.tabPageOptions.Controls.Add(this.Printer);
            this.tabPageOptions.Controls.Add(this.label2);
            this.tabPageOptions.Controls.Add(this.label1);
            this.tabPageOptions.Controls.Add(this.textBox2);
            this.tabPageOptions.Controls.Add(this.textBox1);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(766, 525);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(6, 6);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(75, 23);
            this.buttonBuild.TabIndex = 2;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(670, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\Program Files\\Oracle\\Oracle Analytics Publisher\\Oracle Analytics Publisher Des" +
    "ktop\\Template Builder for Word\\jlib";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(670, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RTF2PDFv2.jar Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ghost Script Location";
            // 
            // Printer
            // 
            this.Printer.AutoSize = true;
            this.Printer.Location = new System.Drawing.Point(6, 109);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(37, 13);
            this.Printer.TabIndex = 5;
            this.Printer.Text = "Printer";
            // 
            // buttonFindRTF2PDF
            // 
            this.buttonFindRTF2PDF.AutoEllipsis = true;
            this.buttonFindRTF2PDF.Location = new System.Drawing.Point(685, 26);
            this.buttonFindRTF2PDF.Name = "buttonFindRTF2PDF";
            this.buttonFindRTF2PDF.Size = new System.Drawing.Size(75, 23);
            this.buttonFindRTF2PDF.TabIndex = 6;
            this.buttonFindRTF2PDF.Text = "Select";
            this.buttonFindRTF2PDF.UseVisualStyleBackColor = true;
            // 
            // buttonGhostScriptLocation
            // 
            this.buttonGhostScriptLocation.Location = new System.Drawing.Point(685, 76);
            this.buttonGhostScriptLocation.Name = "buttonGhostScriptLocation";
            this.buttonGhostScriptLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonGhostScriptLocation.TabIndex = 7;
            this.buttonGhostScriptLocation.Text = "Select";
            this.buttonGhostScriptLocation.UseVisualStyleBackColor = true;
            this.buttonGhostScriptLocation.UseWaitCursor = true;
            // 
            // buttonSelectPrinter
            // 
            this.buttonSelectPrinter.Location = new System.Drawing.Point(686, 122);
            this.buttonSelectPrinter.Name = "buttonSelectPrinter";
            this.buttonSelectPrinter.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPrinter.TabIndex = 8;
            this.buttonSelectPrinter.Text = "Select";
            this.buttonSelectPrinter.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Location = new System.Drawing.Point(6, 35);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(754, 457);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(670, 20);
            this.textBox3.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Oracle Publisher Print Helper";
            this.panel1.ResumeLayout(false);
            this.tabPageActions.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabPage tabPageActions;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.Button buttonSelectPrinter;
        private System.Windows.Forms.Button buttonGhostScriptLocation;
        private System.Windows.Forms.Button buttonFindRTF2PDF;
        private System.Windows.Forms.Label Printer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBox3;
    }
}

