
namespace TestApp
{
    partial class EditProduct
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
            this.lResultF = new System.Windows.Forms.Label();
            this.lResultS = new System.Windows.Forms.Label();
            this.tbArticle = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.cbRecipeIsReq = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lResultF
            // 
            this.lResultF.AutoSize = true;
            this.lResultF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lResultF.Location = new System.Drawing.Point(92, 211);
            this.lResultF.Name = "lResultF";
            this.lResultF.Size = new System.Drawing.Size(115, 13);
            this.lResultF.TabIndex = 36;
            this.lResultF.Text = "Something went wrong";
            this.lResultF.Visible = false;
            // 
            // lResultS
            // 
            this.lResultS.AutoSize = true;
            this.lResultS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lResultS.Location = new System.Drawing.Point(72, 224);
            this.lResultS.Name = "lResultS";
            this.lResultS.Size = new System.Drawing.Size(153, 13);
            this.lResultS.TabIndex = 35;
            this.lResultS.Text = "Product was saved succesfully";
            this.lResultS.Visible = false;
            // 
            // tbArticle
            // 
            this.tbArticle.Location = new System.Drawing.Point(135, 144);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(146, 20);
            this.tbArticle.TabIndex = 5;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(135, 111);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(146, 20);
            this.tbCountry.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Article";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Country";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(135, 46);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(146, 20);
            this.tbDescription.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(135, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(135, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nPrice
            // 
            this.nPrice.Location = new System.Drawing.Point(135, 78);
            this.nPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(146, 20);
            this.nPrice.TabIndex = 3;
            // 
            // cbRecipeIsReq
            // 
            this.cbRecipeIsReq.AutoSize = true;
            this.cbRecipeIsReq.Location = new System.Drawing.Point(135, 170);
            this.cbRecipeIsReq.Name = "cbRecipeIsReq";
            this.cbRecipeIsReq.Size = new System.Drawing.Size(111, 17);
            this.cbRecipeIsReq.TabIndex = 37;
            this.cbRecipeIsReq.Text = "Recipe is required";
            this.cbRecipeIsReq.UseVisualStyleBackColor = true;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 316);
            this.Controls.Add(this.cbRecipeIsReq);
            this.Controls.Add(this.nPrice);
            this.Controls.Add(this.lResultF);
            this.Controls.Add(this.lResultS);
            this.Controls.Add(this.tbArticle);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lResultF;
        private System.Windows.Forms.Label lResultS;
        private System.Windows.Forms.TextBox tbArticle;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.CheckBox cbRecipeIsReq;
    }
}