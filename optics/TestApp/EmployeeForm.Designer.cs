
namespace TestApp
{
    partial class EmployeeForm
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
            this.bEdit = new System.Windows.Forms.Button();
            this.lReportName = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.bAdd = new System.Windows.Forms.Button();
            this.dpHiringData = new System.Windows.Forms.DateTimePicker();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lErrors = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvReport
            // 
            this.gvReport.AllowUserToAddRows = false;
            this.gvReport.AllowUserToDeleteRows = false;
            this.gvReport.AllowUserToResizeRows = false;
            this.gvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReport.Location = new System.Drawing.Point(16, 66);
            this.gvReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvReport.MultiSelect = false;
            this.gvReport.Name = "gvReport";
            this.gvReport.ReadOnly = true;
            this.gvReport.RowHeadersVisible = false;
            this.gvReport.RowHeadersWidth = 51;
            this.gvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReport.Size = new System.Drawing.Size(877, 228);
            this.gvReport.TabIndex = 0;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(919, 66);
            this.bEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(100, 28);
            this.bEdit.TabIndex = 1;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
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
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 28);
            this.bClose.TabIndex = 9;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(919, 117);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 28);
            this.bAdd.TabIndex = 10;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dpHiringData
            // 
            this.dpHiringData.Location = new System.Drawing.Point(301, 33);
            this.dpHiringData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpHiringData.Name = "dpHiringData";
            this.dpHiringData.Size = new System.Drawing.Size(265, 22);
            this.dpHiringData.TabIndex = 22;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(160, 33);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(132, 22);
            this.tbLastName.TabIndex = 21;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(19, 33);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(132, 22);
            this.tbFirstName.TabIndex = 20;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(19, 95);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(132, 22);
            this.tbEmail.TabIndex = 23;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(160, 95);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(132, 22);
            this.tbPhone.TabIndex = 24;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(301, 95);
            this.tbContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(132, 22);
            this.tbContact.TabIndex = 25;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(769, 165);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 28);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lErrors);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbContact);
            this.panel1.Controls.Add(this.dpHiringData);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Location = new System.Drawing.Point(20, 303);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 197);
            this.panel1.TabIndex = 18;
            // 
            // lErrors
            // 
            this.lErrors.AutoSize = true;
            this.lErrors.ForeColor = System.Drawing.Color.IndianRed;
            this.lErrors.Location = new System.Drawing.Point(603, 33);
            this.lErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lErrors.Name = "lErrors";
            this.lErrors.Size = new System.Drawing.Size(43, 16);
            this.lErrors.TabIndex = 33;
            this.lErrors.Text = "Errors";
            this.lErrors.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Contract";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hiring date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "First name";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lReportName);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.gvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvReport;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lReportName;
        private System.Windows.Forms.Button bClose;
        private System.Drawing.Printing.PrintDocument pd;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DateTimePicker dpHiringData;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lErrors;
    }
}