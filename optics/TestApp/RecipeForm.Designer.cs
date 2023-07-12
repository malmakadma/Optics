
namespace TestApp
{
    partial class RecipeForm
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
            this.dgvRecipts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nBAS = new System.Windows.Forms.NumericUpDown();
            this.nADD = new System.Windows.Forms.NumericUpDown();
            this.nAX = new System.Windows.Forms.NumericUpDown();
            this.nCYL = new System.Windows.Forms.NumericUpDown();
            this.nSPH = new System.Windows.Forms.NumericUpDown();
            this.nR = new System.Windows.Forms.NumericUpDown();
            this.nDP = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nADD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCYL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecipts
            // 
            this.dgvRecipts.AllowUserToAddRows = false;
            this.dgvRecipts.AllowUserToDeleteRows = false;
            this.dgvRecipts.AllowUserToResizeRows = false;
            this.dgvRecipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipts.Location = new System.Drawing.Point(12, 23);
            this.dgvRecipts.MultiSelect = false;
            this.dgvRecipts.Name = "dgvRecipts";
            this.dgvRecipts.ReadOnly = true;
            this.dgvRecipts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipts.Size = new System.Drawing.Size(776, 158);
            this.dgvRecipts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(12, 187);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(275, 187);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 3;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nBAS);
            this.panel1.Controls.Add(this.nADD);
            this.panel1.Controls.Add(this.nAX);
            this.panel1.Controls.Add(this.nCYL);
            this.panel1.Controls.Add(this.nSPH);
            this.panel1.Controls.Add(this.nR);
            this.panel1.Controls.Add(this.nDP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Location = new System.Drawing.Point(15, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 196);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // nBAS
            // 
            this.nBAS.DecimalPlaces = 2;
            this.nBAS.Location = new System.Drawing.Point(47, 163);
            this.nBAS.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nBAS.Name = "nBAS";
            this.nBAS.Size = new System.Drawing.Size(68, 20);
            this.nBAS.TabIndex = 19;
            // 
            // nADD
            // 
            this.nADD.DecimalPlaces = 2;
            this.nADD.Location = new System.Drawing.Point(47, 137);
            this.nADD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nADD.Name = "nADD";
            this.nADD.Size = new System.Drawing.Size(68, 20);
            this.nADD.TabIndex = 18;
            // 
            // nAX
            // 
            this.nAX.DecimalPlaces = 2;
            this.nAX.Location = new System.Drawing.Point(47, 111);
            this.nAX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nAX.Name = "nAX";
            this.nAX.Size = new System.Drawing.Size(68, 20);
            this.nAX.TabIndex = 17;
            // 
            // nCYL
            // 
            this.nCYL.DecimalPlaces = 2;
            this.nCYL.Location = new System.Drawing.Point(47, 85);
            this.nCYL.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nCYL.Name = "nCYL";
            this.nCYL.Size = new System.Drawing.Size(68, 20);
            this.nCYL.TabIndex = 16;
            // 
            // nSPH
            // 
            this.nSPH.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSPH.DecimalPlaces = 2;
            this.nSPH.Location = new System.Drawing.Point(47, 59);
            this.nSPH.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nSPH.Name = "nSPH";
            this.nSPH.Size = new System.Drawing.Size(68, 20);
            this.nSPH.TabIndex = 15;
            // 
            // nR
            // 
            this.nR.DecimalPlaces = 2;
            this.nR.Location = new System.Drawing.Point(47, 33);
            this.nR.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nR.Name = "nR";
            this.nR.Size = new System.Drawing.Size(68, 20);
            this.nR.TabIndex = 14;
            // 
            // nDP
            // 
            this.nDP.DecimalPlaces = 2;
            this.nDP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nDP.Location = new System.Drawing.Point(47, 7);
            this.nDP.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nDP.Name = "nDP";
            this.nDP.Size = new System.Drawing.Size(68, 20);
            this.nDP.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ADD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CYL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SPH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DP";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(416, 170);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(369, 187);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecipts);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nADD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCYL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecipts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nBAS;
        private System.Windows.Forms.NumericUpDown nADD;
        private System.Windows.Forms.NumericUpDown nAX;
        private System.Windows.Forms.NumericUpDown nCYL;
        private System.Windows.Forms.NumericUpDown nSPH;
        private System.Windows.Forms.NumericUpDown nR;
        private System.Windows.Forms.NumericUpDown nDP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAdd;
    }
}