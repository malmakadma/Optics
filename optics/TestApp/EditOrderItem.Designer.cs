
namespace TestApp
{
    partial class EditOrderItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lResultF = new System.Windows.Forms.Label();
            this.lResultS = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.dgvOIRecipe = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lCR = new System.Windows.Forms.Label();
            this.bChangeRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOIRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // nPrice
            // 
            this.nPrice.Location = new System.Drawing.Point(522, 204);
            this.nPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(120, 20);
            this.nPrice.TabIndex = 12;
            // 
            // nQty
            // 
            this.nQty.Location = new System.Drawing.Point(522, 236);
            this.nQty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(120, 20);
            this.nQty.TabIndex = 14;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 21);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 15;
            // 
            // lResultF
            // 
            this.lResultF.AutoSize = true;
            this.lResultF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lResultF.Location = new System.Drawing.Point(241, 222);
            this.lResultF.Name = "lResultF";
            this.lResultF.Size = new System.Drawing.Size(115, 13);
            this.lResultF.TabIndex = 22;
            this.lResultF.Text = "Something went wrong";
            this.lResultF.Visible = false;
            // 
            // lResultS
            // 
            this.lResultS.AutoSize = true;
            this.lResultS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lResultS.Location = new System.Drawing.Point(221, 235);
            this.lResultS.Name = "lResultS";
            this.lResultS.Size = new System.Drawing.Size(142, 13);
            this.lResultS.TabIndex = 21;
            this.lResultS.Text = "Order was saved succesfully";
            this.lResultS.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(567, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(116, 21);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(526, 102);
            this.dgProducts.TabIndex = 23;
            this.dgProducts.Visible = false;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            // 
            // cbProducts
            // 
            this.cbProducts.Location = new System.Drawing.Point(116, 21);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(321, 21);
            this.cbProducts.TabIndex = 24;
            this.cbProducts.Visible = false;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.AllowUserToResizeRows = false;
            this.dgvRecipes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(12, 281);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(630, 122);
            this.dgvRecipes.TabIndex = 25;
            this.dgvRecipes.Visible = false;
            // 
            // dgvOIRecipe
            // 
            this.dgvOIRecipe.AllowUserToAddRows = false;
            this.dgvOIRecipe.AllowUserToDeleteRows = false;
            this.dgvOIRecipe.AllowUserToResizeRows = false;
            this.dgvOIRecipe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOIRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOIRecipe.Location = new System.Drawing.Point(12, 139);
            this.dgvOIRecipe.MultiSelect = false;
            this.dgvOIRecipe.Name = "dgvOIRecipe";
            this.dgvOIRecipe.ReadOnly = true;
            this.dgvOIRecipe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOIRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOIRecipe.Size = new System.Drawing.Size(630, 59);
            this.dgvOIRecipe.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Recipe";
            // 
            // lCR
            // 
            this.lCR.AutoSize = true;
            this.lCR.Location = new System.Drawing.Point(17, 265);
            this.lCR.Name = "lCR";
            this.lCR.Size = new System.Drawing.Size(95, 13);
            this.lCR.TabIndex = 28;
            this.lCR.Text = "Customer\'s recipes";
            this.lCR.Visible = false;
            // 
            // bChangeRecipe
            // 
            this.bChangeRecipe.Location = new System.Drawing.Point(12, 238);
            this.bChangeRecipe.Name = "bChangeRecipe";
            this.bChangeRecipe.Size = new System.Drawing.Size(136, 23);
            this.bChangeRecipe.TabIndex = 29;
            this.bChangeRecipe.Text = "Change recipe";
            this.bChangeRecipe.UseVisualStyleBackColor = true;
            this.bChangeRecipe.Visible = false;
            this.bChangeRecipe.Click += new System.EventHandler(this.bChangeRecipe_Click);
            // 
            // EditOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 460);
            this.Controls.Add(this.bChangeRecipe);
            this.Controls.Add(this.lCR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOIRecipe);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.lResultF);
            this.Controls.Add(this.lResultS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.nQty);
            this.Controls.Add(this.nPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditOrderItem";
            this.Shown += new System.EventHandler(this.EditOrderItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOIRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lResultF;
        private System.Windows.Forms.Label lResultS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.DataGridView dgvOIRecipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lCR;
        private System.Windows.Forms.Button bChangeRecipe;
    }
}