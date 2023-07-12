
namespace TestApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOrderItems = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditOrderItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.customers = new System.Windows.Forms.TabPage();
            this.bRecipts = new System.Windows.Forms.Button();
            this.printersList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bPrintOrder = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbnameDirection = new System.Windows.Forms.ComboBox();
            this.cbOrderDirection = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudFilterPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.bFilterProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.bDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pdReceipt = new System.Drawing.Printing.PrintDocument();
            this.cbFilterRecipeIsReq = new System.Windows.Forms.ComboBox();
            this.lbFilRecipe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).BeginInit();
            this.tabControl.SuspendLayout();
            this.customers.SuspendLayout();
            this.products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgCustomers.Location = new System.Drawing.Point(20, 95);
            this.dgCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgCustomers.MultiSelect = false;
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCustomers.RowHeadersVisible = false;
            this.dgCustomers.RowHeadersWidth = 51;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(1203, 223);
            this.dgCustomers.TabIndex = 1;
            this.dgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1608, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.productsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orders";
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(20, 357);
            this.dgOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgOrders.MultiSelect = false;
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.RowHeadersVisible = false;
            this.dgOrders.RowHeadersWidth = 51;
            this.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrders.Size = new System.Drawing.Size(723, 180);
            this.dgOrders.TabIndex = 5;
            this.dgOrders.Click += new System.EventHandler(this.dgOrders_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.Location = new System.Drawing.Point(1250, 95);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customers";
            // 
            // dgOrderItems
            // 
            this.dgOrderItems.AllowUserToAddRows = false;
            this.dgOrderItems.AllowUserToDeleteRows = false;
            this.dgOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderItems.Location = new System.Drawing.Point(20, 591);
            this.dgOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgOrderItems.MultiSelect = false;
            this.dgOrderItems.Name = "dgOrderItems";
            this.dgOrderItems.ReadOnly = true;
            this.dgOrderItems.RowHeadersVisible = false;
            this.dgOrderItems.RowHeadersWidth = 51;
            this.dgOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderItems.Size = new System.Drawing.Size(723, 182);
            this.dgOrderItems.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 553);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order details";
            // 
            // btnEditOrderItem
            // 
            this.btnEditOrderItem.Location = new System.Drawing.Point(751, 603);
            this.btnEditOrderItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditOrderItem.Name = "btnEditOrderItem";
            this.btnEditOrderItem.Size = new System.Drawing.Size(125, 28);
            this.btnEditOrderItem.TabIndex = 14;
            this.btnEditOrderItem.Text = "Edit Order item";
            this.btnEditOrderItem.UseVisualStyleBackColor = true;
            this.btnEditOrderItem.Click += new System.EventHandler(this.btnEditOrderItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(751, 727);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete order item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveChanges.Location = new System.Drawing.Point(1250, 291);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(125, 27);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Refresh";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(1250, 139);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateOrder.Location = new System.Drawing.Point(1250, 194);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(125, 36);
            this.btnCreateOrder.TabIndex = 19;
            this.btnCreateOrder.Text = "Create order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Location = new System.Drawing.Point(751, 656);
            this.btnAddOrderItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(125, 28);
            this.btnAddOrderItem.TabIndex = 21;
            this.btnAddOrderItem.Text = "Add new Item";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
            this.btnAddOrderItem.Click += new System.EventHandler(this.btnAddOrderItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.customers);
            this.tabControl.Controls.Add(this.products);
            this.tabControl.Location = new System.Drawing.Point(16, 47);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1533, 816);
            this.tabControl.TabIndex = 22;
            // 
            // customers
            // 
            this.customers.Controls.Add(this.bRecipts);
            this.customers.Controls.Add(this.printersList);
            this.customers.Controls.Add(this.label3);
            this.customers.Controls.Add(this.textBox1);
            this.customers.Controls.Add(this.bPrintOrder);
            this.customers.Controls.Add(this.btnCreateOrder);
            this.customers.Controls.Add(this.label1);
            this.customers.Controls.Add(this.label4);
            this.customers.Controls.Add(this.btnAddOrderItem);
            this.customers.Controls.Add(this.label2);
            this.customers.Controls.Add(this.button3);
            this.customers.Controls.Add(this.btnAdd);
            this.customers.Controls.Add(this.btnEditOrderItem);
            this.customers.Controls.Add(this.dgCustomers);
            this.customers.Controls.Add(this.btnSaveChanges);
            this.customers.Controls.Add(this.dgOrderItems);
            this.customers.Controls.Add(this.btnEdit);
            this.customers.Controls.Add(this.dgOrders);
            this.customers.Location = new System.Drawing.Point(4, 25);
            this.customers.Margin = new System.Windows.Forms.Padding(4);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(4);
            this.customers.Size = new System.Drawing.Size(1525, 787);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // bRecipts
            // 
            this.bRecipts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRecipts.Location = new System.Drawing.Point(1250, 238);
            this.bRecipts.Margin = new System.Windows.Forms.Padding(4);
            this.bRecipts.Name = "bRecipts";
            this.bRecipts.Size = new System.Drawing.Size(125, 36);
            this.bRecipts.TabIndex = 26;
            this.bRecipts.Text = "Manage recipts";
            this.bRecipts.UseVisualStyleBackColor = true;
            this.bRecipts.Click += new System.EventHandler(this.bRecipts_Click);
            // 
            // printersList
            // 
            this.printersList.FormattingEnabled = true;
            this.printersList.Location = new System.Drawing.Point(943, 359);
            this.printersList.Margin = new System.Windows.Forms.Padding(4);
            this.printersList.Name = "printersList";
            this.printersList.Size = new System.Drawing.Size(160, 24);
            this.printersList.TabIndex = 25;
            this.printersList.Text = "--Select Printer--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Customer lastname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // bPrintOrder
            // 
            this.bPrintOrder.Location = new System.Drawing.Point(751, 357);
            this.bPrintOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bPrintOrder.Name = "bPrintOrder";
            this.bPrintOrder.Size = new System.Drawing.Size(125, 28);
            this.bPrintOrder.TabIndex = 22;
            this.bPrintOrder.Text = "Print Order";
            this.bPrintOrder.UseVisualStyleBackColor = true;
            this.bPrintOrder.Click += new System.EventHandler(this.bPrintOrder_Click);
            // 
            // products
            // 
            this.products.Controls.Add(this.lbFilRecipe);
            this.products.Controls.Add(this.cbFilterRecipeIsReq);
            this.products.Controls.Add(this.button1);
            this.products.Controls.Add(this.label9);
            this.products.Controls.Add(this.cbnameDirection);
            this.products.Controls.Add(this.cbOrderDirection);
            this.products.Controls.Add(this.label8);
            this.products.Controls.Add(this.nudFilterPrice);
            this.products.Controls.Add(this.label7);
            this.products.Controls.Add(this.cbFilterType);
            this.products.Controls.Add(this.bFilterProduct);
            this.products.Controls.Add(this.label6);
            this.products.Controls.Add(this.tbProductSearch);
            this.products.Controls.Add(this.bDeleteProduct);
            this.products.Controls.Add(this.btnEditProduct);
            this.products.Controls.Add(this.btnAddProduct);
            this.products.Controls.Add(this.dgProducts);
            this.products.Controls.Add(this.label5);
            this.products.Location = new System.Drawing.Point(4, 25);
            this.products.Margin = new System.Windows.Forms.Padding(4);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(4);
            this.products.Size = new System.Drawing.Size(1525, 787);
            this.products.TabIndex = 1;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(983, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Order by name Direction";
            // 
            // cbnameDirection
            // 
            this.cbnameDirection.FormattingEnabled = true;
            this.cbnameDirection.Items.AddRange(new object[] {
            "name (A > Я)",
            "name (Я > A)"});
            this.cbnameDirection.Location = new System.Drawing.Point(983, 191);
            this.cbnameDirection.Margin = new System.Windows.Forms.Padding(4);
            this.cbnameDirection.Name = "cbnameDirection";
            this.cbnameDirection.Size = new System.Drawing.Size(153, 24);
            this.cbnameDirection.TabIndex = 33;
            this.cbnameDirection.Text = "--Select--";
            this.cbnameDirection.SelectedIndexChanged += new System.EventHandler(this.cbnameDirection_SelectedIndexChanged);
            // 
            // cbOrderDirection
            // 
            this.cbOrderDirection.FormattingEnabled = true;
            this.cbOrderDirection.Items.AddRange(new object[] {
            "price (high > low)",
            "price (low > high)"});
            this.cbOrderDirection.Location = new System.Drawing.Point(983, 133);
            this.cbOrderDirection.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrderDirection.Name = "cbOrderDirection";
            this.cbOrderDirection.Size = new System.Drawing.Size(153, 24);
            this.cbOrderDirection.TabIndex = 32;
            this.cbOrderDirection.Text = "--Select--";
            this.cbOrderDirection.SelectedIndexChanged += new System.EventHandler(this.cbOrderDirection_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(983, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Order by price Direction";
            // 
            // nudFilterPrice
            // 
            this.nudFilterPrice.Location = new System.Drawing.Point(629, 63);
            this.nudFilterPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudFilterPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFilterPrice.Name = "nudFilterPrice";
            this.nudFilterPrice.Size = new System.Drawing.Size(100, 22);
            this.nudFilterPrice.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Filter type";
            // 
            // cbFilterType
            // 
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "Price >",
            "Price <",
            "Price ="});
            this.cbFilterType.Location = new System.Drawing.Point(485, 60);
            this.cbFilterType.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(127, 24);
            this.cbFilterType.TabIndex = 28;
            this.cbFilterType.Text = "--Select--";
            // 
            // bFilterProduct
            // 
            this.bFilterProduct.Location = new System.Drawing.Point(875, 58);
            this.bFilterProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bFilterProduct.Name = "bFilterProduct";
            this.bFilterProduct.Size = new System.Drawing.Size(100, 28);
            this.bFilterProduct.TabIndex = 27;
            this.bFilterProduct.Text = "Filter";
            this.bFilterProduct.UseVisualStyleBackColor = true;
            this.bFilterProduct.Click += new System.EventHandler(this.bFilterProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product name";
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Location = new System.Drawing.Point(12, 62);
            this.tbProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(259, 22);
            this.tbProductSearch.TabIndex = 25;
            this.tbProductSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductSearch_KeyUp);
            // 
            // bDeleteProduct
            // 
            this.bDeleteProduct.ForeColor = System.Drawing.Color.Red;
            this.bDeleteProduct.Location = new System.Drawing.Point(12, 337);
            this.bDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bDeleteProduct.Name = "bDeleteProduct";
            this.bDeleteProduct.Size = new System.Drawing.Size(133, 28);
            this.bDeleteProduct.TabIndex = 21;
            this.bDeleteProduct.Text = "Delete product";
            this.bDeleteProduct.UseVisualStyleBackColor = true;
            this.bDeleteProduct.Click += new System.EventHandler(this.bDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(844, 337);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(100, 28);
            this.btnEditProduct.TabIndex = 13;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(736, 337);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(12, 100);
            this.dgProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(963, 223);
            this.dgProducts.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Products";
            // 
            // cbFilterRecipeIsReq
            // 
            this.cbFilterRecipeIsReq.FormattingEnabled = true;
            this.cbFilterRecipeIsReq.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbFilterRecipeIsReq.Location = new System.Drawing.Point(747, 62);
            this.cbFilterRecipeIsReq.Name = "cbFilterRecipeIsReq";
            this.cbFilterRecipeIsReq.Size = new System.Drawing.Size(121, 24);
            this.cbFilterRecipeIsReq.TabIndex = 36;
            this.cbFilterRecipeIsReq.Text = "--Select--";
            // 
            // lbFilRecipe
            // 
            this.lbFilRecipe.AutoSize = true;
            this.lbFilRecipe.Location = new System.Drawing.Point(755, 40);
            this.lbFilRecipe.Name = "lbFilRecipe";
            this.lbFilRecipe.Size = new System.Drawing.Size(97, 16);
            this.lbFilRecipe.TabIndex = 37;
            this.lbFilRecipe.Text = "On prescription";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 878);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOrderItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditOrderItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Button bDeleteProduct;
        private System.Drawing.Printing.PrintDocument pdReceipt;
        private System.Windows.Forms.Button bPrintOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.Button bFilterProduct;
        private System.Windows.Forms.NumericUpDown nudFilterPrice;
        private System.Windows.Forms.ComboBox printersList;
        private System.Windows.Forms.ComboBox cbOrderDirection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bRecipts;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbnameDirection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbFilRecipe;
        private System.Windows.Forms.ComboBox cbFilterRecipeIsReq;
    }
}

