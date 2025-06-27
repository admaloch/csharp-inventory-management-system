namespace admaloch_inventory_system
{
    partial class ModifyProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductSearchTxt = new System.Windows.Forms.TextBox();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.AddProductAssociatedGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProductPartBtn = new System.Windows.Forms.Button();
            this.AddProductPartBtn = new System.Windows.Forms.Button();
            this.AddProductPartsGrid = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelAddProductBtn = new System.Windows.Forms.Button();
            this.SaveProductBtn = new System.Windows.Forms.Button();
            this.ProductMinTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductMaxTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductInventoryTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductAssociatedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 36;
            this.label1.Text = "Modify Product";
            // 
            // ProductSearchTxt
            // 
            this.ProductSearchTxt.Location = new System.Drawing.Point(1173, 51);
            this.ProductSearchTxt.Name = "ProductSearchTxt";
            this.ProductSearchTxt.Size = new System.Drawing.Size(300, 31);
            this.ProductSearchTxt.TabIndex = 74;
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchBtn.Location = new System.Drawing.Point(1026, 37);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(131, 52);
            this.ProductSearchBtn.TabIndex = 73;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = false;
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
            this.AddProductAssociatedGrid.Location = new System.Drawing.Point(589, 509);
            this.AddProductAssociatedGrid.MultiSelect = false;
            this.AddProductAssociatedGrid.Name = "AddProductAssociatedGrid";
            this.AddProductAssociatedGrid.RowHeadersVisible = false;
            this.AddProductAssociatedGrid.RowHeadersWidth = 82;
            this.AddProductAssociatedGrid.RowTemplate.Height = 33;
            this.AddProductAssociatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProductAssociatedGrid.Size = new System.Drawing.Size(884, 289);
            this.AddProductAssociatedGrid.TabIndex = 72;
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
            // DeleteProductPartBtn
            // 
            this.DeleteProductPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteProductPartBtn.Location = new System.Drawing.Point(1359, 818);
            this.DeleteProductPartBtn.Name = "DeleteProductPartBtn";
            this.DeleteProductPartBtn.Size = new System.Drawing.Size(114, 59);
            this.DeleteProductPartBtn.TabIndex = 71;
            this.DeleteProductPartBtn.Text = "Delete";
            this.DeleteProductPartBtn.UseVisualStyleBackColor = false;
            // 
            // AddProductPartBtn
            // 
            this.AddProductPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddProductPartBtn.Enabled = false;
            this.AddProductPartBtn.Location = new System.Drawing.Point(1359, 424);
            this.AddProductPartBtn.Name = "AddProductPartBtn";
            this.AddProductPartBtn.Size = new System.Drawing.Size(114, 59);
            this.AddProductPartBtn.TabIndex = 70;
            this.AddProductPartBtn.Text = "Add";
            this.AddProductPartBtn.UseVisualStyleBackColor = false;
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
            this.AddProductPartsGrid.Location = new System.Drawing.Point(589, 117);
            this.AddProductPartsGrid.MultiSelect = false;
            this.AddProductPartsGrid.Name = "AddProductPartsGrid";
            this.AddProductPartsGrid.RowHeadersVisible = false;
            this.AddProductPartsGrid.RowHeadersWidth = 82;
            this.AddProductPartsGrid.RowTemplate.Height = 33;
            this.AddProductPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProductPartsGrid.Size = new System.Drawing.Size(884, 289);
            this.AddProductPartsGrid.TabIndex = 69;
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
            // CancelAddProductBtn
            // 
            this.CancelAddProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelAddProductBtn.Location = new System.Drawing.Point(1359, 893);
            this.CancelAddProductBtn.Name = "CancelAddProductBtn";
            this.CancelAddProductBtn.Size = new System.Drawing.Size(114, 59);
            this.CancelAddProductBtn.TabIndex = 68;
            this.CancelAddProductBtn.Text = "Cancel";
            this.CancelAddProductBtn.UseVisualStyleBackColor = false;
            // 
            // SaveProductBtn
            // 
            this.SaveProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveProductBtn.Enabled = false;
            this.SaveProductBtn.Location = new System.Drawing.Point(1228, 893);
            this.SaveProductBtn.Name = "SaveProductBtn";
            this.SaveProductBtn.Size = new System.Drawing.Size(114, 59);
            this.SaveProductBtn.TabIndex = 67;
            this.SaveProductBtn.Text = "Save";
            this.SaveProductBtn.UseVisualStyleBackColor = false;
            // 
            // ProductMinTxt
            // 
            this.ProductMinTxt.Location = new System.Drawing.Point(370, 570);
            this.ProductMinTxt.Name = "ProductMinTxt";
            this.ProductMinTxt.Size = new System.Drawing.Size(119, 31);
            this.ProductMinTxt.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 37);
            this.label9.TabIndex = 65;
            this.label9.Text = "Min";
            // 
            // ProductMaxTxt
            // 
            this.ProductMaxTxt.Location = new System.Drawing.Point(147, 570);
            this.ProductMaxTxt.Name = "ProductMaxTxt";
            this.ProductMaxTxt.Size = new System.Drawing.Size(119, 31);
            this.ProductMaxTxt.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 37);
            this.label10.TabIndex = 63;
            this.label10.Text = "Max";
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.Location = new System.Drawing.Point(206, 504);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductPriceTxt.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 37);
            this.label11.TabIndex = 61;
            this.label11.Text = "Price/Cost";
            // 
            // ProductInventoryTxt
            // 
            this.ProductInventoryTxt.Location = new System.Drawing.Point(206, 427);
            this.ProductInventoryTxt.Name = "ProductInventoryTxt";
            this.ProductInventoryTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductInventoryTxt.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 37);
            this.label12.TabIndex = 59;
            this.label12.Text = "Inventory";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(206, 353);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductNameTxt.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 37);
            this.label13.TabIndex = 57;
            this.label13.Text = "Name";
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.Location = new System.Drawing.Point(206, 291);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(245, 31);
            this.ProductIDTxt.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(137, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 37);
            this.label14.TabIndex = 55;
            this.label14.Text = "ID";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 1008);
            this.Controls.Add(this.ProductSearchTxt);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.AddProductAssociatedGrid);
            this.Controls.Add(this.DeleteProductPartBtn);
            this.Controls.Add(this.AddProductPartBtn);
            this.Controls.Add(this.AddProductPartsGrid);
            this.Controls.Add(this.CancelAddProductBtn);
            this.Controls.Add(this.SaveProductBtn);
            this.Controls.Add(this.ProductMinTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProductMaxTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProductPriceTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProductInventoryTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProductIDTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddProductAssociatedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductSearchTxt;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.DataGridView AddProductAssociatedGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button DeleteProductPartBtn;
        private System.Windows.Forms.Button AddProductPartBtn;
        private System.Windows.Forms.DataGridView AddProductPartsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPart;
        private System.Windows.Forms.Button CancelAddProductBtn;
        private System.Windows.Forms.Button SaveProductBtn;
        private System.Windows.Forms.TextBox ProductMinTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProductMaxTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ProductPriceTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ProductInventoryTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.Label label14;
    }
}