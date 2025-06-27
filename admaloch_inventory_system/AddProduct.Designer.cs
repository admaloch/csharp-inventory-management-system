namespace admaloch_inventory_system
{
    partial class AddProduct
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
            this.CancelAddProductBtn = new System.Windows.Forms.Button();
            this.SaveProductBtn = new System.Windows.Forms.Button();
            this.ProductMinTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductMaxTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductInventoryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductPartsGrid = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductPartBtn = new System.Windows.Forms.Button();
            this.DeleteProductPartBtn = new System.Windows.Forms.Button();
            this.AddProductAssociatedGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSearchTxt = new System.Windows.Forms.TextBox();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductAssociatedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAddProductBtn
            // 
            this.CancelAddProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelAddProductBtn.Location = new System.Drawing.Point(1382, 939);
            this.CancelAddProductBtn.Name = "CancelAddProductBtn";
            this.CancelAddProductBtn.Size = new System.Drawing.Size(114, 59);
            this.CancelAddProductBtn.TabIndex = 35;
            this.CancelAddProductBtn.Text = "Cancel";
            this.CancelAddProductBtn.UseVisualStyleBackColor = false;
            // 
            // SaveProductBtn
            // 
            this.SaveProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveProductBtn.Enabled = false;
            this.SaveProductBtn.Location = new System.Drawing.Point(1251, 939);
            this.SaveProductBtn.Name = "SaveProductBtn";
            this.SaveProductBtn.Size = new System.Drawing.Size(114, 59);
            this.SaveProductBtn.TabIndex = 34;
            this.SaveProductBtn.Text = "Save";
            this.SaveProductBtn.UseVisualStyleBackColor = false;
            // 
            // ProductMinTxt
            // 
            this.ProductMinTxt.Location = new System.Drawing.Point(384, 512);
            this.ProductMinTxt.Name = "ProductMinTxt";
            this.ProductMinTxt.Size = new System.Drawing.Size(119, 31);
            this.ProductMinTxt.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 37);
            this.label8.TabIndex = 32;
            this.label8.Text = "Min";
            // 
            // ProductMaxTxt
            // 
            this.ProductMaxTxt.Location = new System.Drawing.Point(161, 512);
            this.ProductMaxTxt.Name = "ProductMaxTxt";
            this.ProductMaxTxt.Size = new System.Drawing.Size(119, 31);
            this.ProductMaxTxt.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 37);
            this.label7.TabIndex = 30;
            this.label7.Text = "Max";
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.Location = new System.Drawing.Point(220, 446);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductPriceTxt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price/Cost";
            // 
            // ProductInventoryTxt
            // 
            this.ProductInventoryTxt.Location = new System.Drawing.Point(220, 369);
            this.ProductInventoryTxt.Name = "ProductInventoryTxt";
            this.ProductInventoryTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductInventoryTxt.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Inventory";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(220, 295);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductNameTxt.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.Location = new System.Drawing.Point(220, 233);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductIDTxt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 51);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Product";
            // 
            // AddProductPartsGrid
            // 
            this.AddProductPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProductPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.MinPart,
            this.MaxPart});
            this.AddProductPartsGrid.Location = new System.Drawing.Point(612, 163);
            this.AddProductPartsGrid.MultiSelect = false;
            this.AddProductPartsGrid.Name = "AddProductPartsGrid";
            this.AddProductPartsGrid.RowHeadersVisible = false;
            this.AddProductPartsGrid.RowHeadersWidth = 82;
            this.AddProductPartsGrid.RowTemplate.Height = 33;
            this.AddProductPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProductPartsGrid.Size = new System.Drawing.Size(884, 289);
            this.AddProductPartsGrid.TabIndex = 36;
            // 
            // PartID
            // 
            this.PartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartID.HeaderText = "Part ID";
            this.PartID.MinimumWidth = 10;
            this.PartID.Name = "PartID";
            this.PartID.Width = 122;
            // 
            // PartName
            // 
            this.PartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 10;
            this.PartName.Name = "PartName";
            this.PartName.Width = 158;
            // 
            // PartInventory
            // 
            this.PartInventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartInventory.HeaderText = "Inventory";
            this.PartInventory.MinimumWidth = 10;
            this.PartInventory.Name = "PartInventory";
            this.PartInventory.Width = 145;
            // 
            // PartPrice
            // 
            this.PartPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartPrice.HeaderText = "Price";
            this.PartPrice.MinimumWidth = 10;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.Width = 106;
            // 
            // MinPart
            // 
            this.MinPart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinPart.HeaderText = "Min";
            this.MinPart.MinimumWidth = 10;
            this.MinPart.Name = "MinPart";
            this.MinPart.Width = 92;
            // 
            // MaxPart
            // 
            this.MaxPart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaxPart.HeaderText = "Max";
            this.MaxPart.MinimumWidth = 10;
            this.MaxPart.Name = "MaxPart";
            this.MaxPart.Width = 98;
            // 
            // AddProductPartBtn
            // 
            this.AddProductPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddProductPartBtn.Enabled = false;
            this.AddProductPartBtn.Location = new System.Drawing.Point(1382, 470);
            this.AddProductPartBtn.Name = "AddProductPartBtn";
            this.AddProductPartBtn.Size = new System.Drawing.Size(114, 59);
            this.AddProductPartBtn.TabIndex = 37;
            this.AddProductPartBtn.Text = "Add";
            this.AddProductPartBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteProductPartBtn
            // 
            this.DeleteProductPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteProductPartBtn.Location = new System.Drawing.Point(1382, 864);
            this.DeleteProductPartBtn.Name = "DeleteProductPartBtn";
            this.DeleteProductPartBtn.Size = new System.Drawing.Size(114, 59);
            this.DeleteProductPartBtn.TabIndex = 38;
            this.DeleteProductPartBtn.Text = "Delete";
            this.DeleteProductPartBtn.UseVisualStyleBackColor = false;
            // 
            // AddProductAssociatedGrid
            // 
            this.AddProductAssociatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProductAssociatedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.AddProductAssociatedGrid.Location = new System.Drawing.Point(612, 555);
            this.AddProductAssociatedGrid.MultiSelect = false;
            this.AddProductAssociatedGrid.Name = "AddProductAssociatedGrid";
            this.AddProductAssociatedGrid.RowHeadersVisible = false;
            this.AddProductAssociatedGrid.RowHeadersWidth = 82;
            this.AddProductAssociatedGrid.RowTemplate.Height = 33;
            this.AddProductAssociatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProductAssociatedGrid.Size = new System.Drawing.Size(884, 289);
            this.AddProductAssociatedGrid.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 158;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 145;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 106;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 98;
            // 
            // ProductSearchTxt
            // 
            this.ProductSearchTxt.Location = new System.Drawing.Point(1196, 97);
            this.ProductSearchTxt.Name = "ProductSearchTxt";
            this.ProductSearchTxt.Size = new System.Drawing.Size(300, 31);
            this.ProductSearchTxt.TabIndex = 41;
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchBtn.Location = new System.Drawing.Point(1049, 83);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(131, 52);
            this.ProductSearchBtn.TabIndex = 40;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 1025);
            this.Controls.Add(this.ProductSearchTxt);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.AddProductAssociatedGrid);
            this.Controls.Add(this.DeleteProductPartBtn);
            this.Controls.Add(this.AddProductPartBtn);
            this.Controls.Add(this.AddProductPartsGrid);
            this.Controls.Add(this.CancelAddProductBtn);
            this.Controls.Add(this.SaveProductBtn);
            this.Controls.Add(this.ProductMinTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductMaxTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductPriceTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductInventoryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductIDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductAssociatedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddProductBtn;
        private System.Windows.Forms.Button SaveProductBtn;
        private System.Windows.Forms.TextBox ProductMinTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductMaxTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductPriceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductInventoryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AddProductPartsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPart;
        private System.Windows.Forms.Button AddProductPartBtn;
        private System.Windows.Forms.Button DeleteProductPartBtn;
        private System.Windows.Forms.DataGridView AddProductAssociatedGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox ProductSearchTxt;
        private System.Windows.Forms.Button ProductSearchBtn;
    }
}