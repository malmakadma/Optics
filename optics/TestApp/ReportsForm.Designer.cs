
namespace TestApp
{
    partial class ReportsForm
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
            this.gvReport = new System.Windows.Forms.DataGridView();
            this.bRequest1 = new System.Windows.Forms.Button();
            this.bRequest2 = new System.Windows.Forms.Button();
            this.bRequest3 = new System.Windows.Forms.Button();
            this.bRequest4 = new System.Windows.Forms.Button();
            this.dtpR2 = new System.Windows.Forms.DateTimePicker();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lReportName = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bReport5 = new System.Windows.Forms.Button();
            this.bReport6 = new System.Windows.Forms.Button();
            this.dtpR6 = new System.Windows.Forms.DateTimePicker();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.bPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gvReport
            // 
            this.gvReport.AllowUserToAddRows = false;
            this.gvReport.AllowUserToDeleteRows = false;
            this.gvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReport.Location = new System.Drawing.Point(16, 66);
            this.gvReport.Margin = new System.Windows.Forms.Padding(4);
            this.gvReport.Name = "gvReport";
            this.gvReport.RowHeadersWidth = 51;
            this.gvReport.Size = new System.Drawing.Size(877, 396);
            this.gvReport.TabIndex = 0;
            // 
            // bRequest1
            // 
            this.bRequest1.Location = new System.Drawing.Point(1116, 66);
            this.bRequest1.Margin = new System.Windows.Forms.Padding(4);
            this.bRequest1.Name = "bRequest1";
            this.bRequest1.Size = new System.Drawing.Size(100, 28);
            this.bRequest1.TabIndex = 1;
            this.bRequest1.Text = "Report 1";
            this.bRequest1.UseVisualStyleBackColor = true;
            this.bRequest1.Click += new System.EventHandler(this.bRequest1_Click);
            // 
            // bRequest2
            // 
            this.bRequest2.Location = new System.Drawing.Point(1116, 129);
            this.bRequest2.Margin = new System.Windows.Forms.Padding(4);
            this.bRequest2.Name = "bRequest2";
            this.bRequest2.Size = new System.Drawing.Size(100, 28);
            this.bRequest2.TabIndex = 2;
            this.bRequest2.Text = "Report 2";
            this.bRequest2.UseVisualStyleBackColor = true;
            this.bRequest2.Click += new System.EventHandler(this.bRequest2_Click);
            // 
            // bRequest3
            // 
            this.bRequest3.Location = new System.Drawing.Point(1116, 199);
            this.bRequest3.Margin = new System.Windows.Forms.Padding(4);
            this.bRequest3.Name = "bRequest3";
            this.bRequest3.Size = new System.Drawing.Size(100, 28);
            this.bRequest3.TabIndex = 3;
            this.bRequest3.Text = "Report 3";
            this.bRequest3.UseVisualStyleBackColor = true;
            this.bRequest3.Click += new System.EventHandler(this.bRequest3_Click);
            // 
            // bRequest4
            // 
            this.bRequest4.Location = new System.Drawing.Point(1116, 266);
            this.bRequest4.Margin = new System.Windows.Forms.Padding(4);
            this.bRequest4.Name = "bRequest4";
            this.bRequest4.Size = new System.Drawing.Size(100, 28);
            this.bRequest4.TabIndex = 4;
            this.bRequest4.Text = "Report 4";
            this.bRequest4.UseVisualStyleBackColor = true;
            this.bRequest4.Click += new System.EventHandler(this.bRequest4_Click);
            // 
            // dtpR2
            // 
            this.dtpR2.Location = new System.Drawing.Point(901, 133);
            this.dtpR2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpR2.Name = "dtpR2";
            this.dtpR2.Size = new System.Drawing.Size(192, 22);
            this.dtpR2.TabIndex = 5;
            // 
            // nPrice
            // 
            this.nPrice.Location = new System.Drawing.Point(901, 270);
            this.nPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(193, 22);
            this.nPrice.TabIndex = 6;
            this.nPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPrice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(915, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Product with Price >";
            this.label1.Visible = false;
            // 
            // lReportName
            // 
            this.lReportName.AutoSize = true;
            this.lReportName.Location = new System.Drawing.Point(16, 47);
            this.lReportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReportName.Name = "lReportName";
            this.lReportName.Size = new System.Drawing.Size(0, 16);
            this.lReportName.TabIndex = 8;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(1116, 471);
            this.bClose.Margin = new System.Windows.Forms.Padding(4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 28);
            this.bClose.TabIndex = 9;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bReport5
            // 
            this.bReport5.Location = new System.Drawing.Point(1119, 400);
            this.bReport5.Margin = new System.Windows.Forms.Padding(4);
            this.bReport5.Name = "bReport5";
            this.bReport5.Size = new System.Drawing.Size(100, 28);
            this.bReport5.TabIndex = 10;
            this.bReport5.Text = "Report 6";
            this.bReport5.UseVisualStyleBackColor = true;
            this.bReport5.Click += new System.EventHandler(this.bReport5_Click);
            // 
            // bReport6
            // 
            this.bReport6.Location = new System.Drawing.Point(1119, 339);
            this.bReport6.Margin = new System.Windows.Forms.Padding(4);
            this.bReport6.Name = "bReport6";
            this.bReport6.Size = new System.Drawing.Size(100, 28);
            this.bReport6.TabIndex = 12;
            this.bReport6.Text = "Report 5";
            this.bReport6.UseVisualStyleBackColor = true;
            this.bReport6.Click += new System.EventHandler(this.bReport6Print_Click);
            // 
            // dtpR6
            // 
            this.dtpR6.Location = new System.Drawing.Point(901, 345);
            this.dtpR6.Margin = new System.Windows.Forms.Padding(4);
            this.dtpR6.Name = "dtpR6";
            this.dtpR6.Size = new System.Drawing.Size(192, 22);
            this.dtpR6.TabIndex = 13;
            // 
            // pd
            // 
            this.pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(375, 471);
            this.bPrint.Margin = new System.Windows.Forms.Padding(4);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(239, 28);
            this.bPrint.TabIndex = 14;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 514);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.dtpR6);
            this.Controls.Add(this.bReport6);
            this.Controls.Add(this.bReport5);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lReportName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nPrice);
            this.Controls.Add(this.dtpR2);
            this.Controls.Add(this.bRequest4);
            this.Controls.Add(this.bRequest3);
            this.Controls.Add(this.bRequest2);
            this.Controls.Add(this.bRequest1);
            this.Controls.Add(this.gvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvReport;
        private System.Windows.Forms.Button bRequest1;
        private System.Windows.Forms.Button bRequest2;
        private System.Windows.Forms.Button bRequest3;
        private System.Windows.Forms.Button bRequest4;
        private System.Windows.Forms.DateTimePicker dtpR2;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lReportName;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bReport5;
        private System.Windows.Forms.Button bReport6;
        private System.Windows.Forms.DateTimePicker dtpR6;
        private System.Drawing.Printing.PrintDocument pd;
        private System.Windows.Forms.Button bPrint;
    }
}