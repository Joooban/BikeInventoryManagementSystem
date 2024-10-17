namespace BikeShopManagement
{
    partial class InventoryManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button searchButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.buttonSellStock = new System.Windows.Forms.Button();
            this.btnExit4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.inventoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(26, 84);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.Size = new System.Drawing.Size(653, 351);
            this.inventoryGridView.TabIndex = 0;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Honeydew;
            this.addButton.Location = new System.Drawing.Point(26, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 26);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Honeydew;
            this.deleteButton.Location = new System.Drawing.Point(120, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 26);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SeaGreen;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Honeydew;
            this.updateButton.Location = new System.Drawing.Point(214, 43);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 26);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update Item";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.SeaGreen;
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Honeydew;
            this.searchButton.Location = new System.Drawing.Point(308, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 26);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search Item";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxSearch.Location = new System.Drawing.Point(414, 43);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(265, 26);
            this.textBoxSearch.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonViewAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonViewAll.Location = new System.Drawing.Point(706, 43);
            this.buttonViewAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(81, 29);
            this.buttonViewAll.TabIndex = 6;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddStock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStock.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonAddStock.Location = new System.Drawing.Point(706, 84);
            this.buttonAddStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(81, 46);
            this.buttonAddStock.TabIndex = 7;
            this.buttonAddStock.Text = "ADD STOCK";
            this.buttonAddStock.UseVisualStyleBackColor = false;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // buttonSellStock
            // 
            this.buttonSellStock.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSellStock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellStock.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonSellStock.Location = new System.Drawing.Point(706, 142);
            this.buttonSellStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSellStock.Name = "buttonSellStock";
            this.buttonSellStock.Size = new System.Drawing.Size(81, 46);
            this.buttonSellStock.TabIndex = 8;
            this.buttonSellStock.Text = "SELL STOCK";
            this.buttonSellStock.UseVisualStyleBackColor = false;
            this.buttonSellStock.Click += new System.EventHandler(this.buttonSellStock_Click);
            // 
            // btnExit4
            // 
            this.btnExit4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit4.Location = new System.Drawing.Point(761, 0);
            this.btnExit4.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit4.Name = "btnExit4";
            this.btnExit4.Size = new System.Drawing.Size(39, 28);
            this.btnExit4.TabIndex = 9;
            this.btnExit4.Text = "X";
            this.btnExit4.UseVisualStyleBackColor = true;
            this.btnExit4.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.btnExit4);
            this.Controls.Add(this.buttonSellStock);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inventoryGridView);
            this.Name = "InventoryManagement";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.Button buttonSellStock;
        private System.Windows.Forms.Button btnExit4;
    }
}
