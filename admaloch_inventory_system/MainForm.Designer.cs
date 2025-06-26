namespace admaloch_inventory_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchPartsBtn = new System.Windows.Forms.Button();
            this.SearchPartsTxt = new System.Windows.Forms.TextBox();
            this.SearchProductsTxt = new System.Windows.Forms.TextBox();
            this.SearchProductsBtn = new System.Windows.Forms.Button();
            this.ExitMainFormBtn = new System.Windows.Forms.Button();
            this.DeletePartBtn = new System.Windows.Forms.Button();
            this.ModifyPartBtn = new System.Windows.Forms.Button();
            this.AddPartBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ModifyProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1077, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parts";
            // 
            // SearchPartsBtn
            // 
            this.SearchPartsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchPartsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPartsBtn.Location = new System.Drawing.Point(489, 188);
            this.SearchPartsBtn.Name = "SearchPartsBtn";
            this.SearchPartsBtn.Size = new System.Drawing.Size(131, 52);
            this.SearchPartsBtn.TabIndex = 3;
            this.SearchPartsBtn.Text = "Search";
            this.SearchPartsBtn.UseVisualStyleBackColor = false;
            // 
            // SearchPartsTxt
            // 
            this.SearchPartsTxt.Location = new System.Drawing.Point(636, 202);
            this.SearchPartsTxt.Name = "SearchPartsTxt";
            this.SearchPartsTxt.Size = new System.Drawing.Size(300, 31);
            this.SearchPartsTxt.TabIndex = 4;
            // 
            // SearchProductsTxt
            // 
            this.SearchProductsTxt.Location = new System.Drawing.Point(1671, 202);
            this.SearchProductsTxt.Name = "SearchProductsTxt";
            this.SearchProductsTxt.Size = new System.Drawing.Size(300, 31);
            this.SearchProductsTxt.TabIndex = 6;
            // 
            // SearchProductsBtn
            // 
            this.SearchProductsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchProductsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductsBtn.Location = new System.Drawing.Point(1523, 188);
            this.SearchProductsBtn.Name = "SearchProductsBtn";
            this.SearchProductsBtn.Size = new System.Drawing.Size(131, 52);
            this.SearchProductsBtn.TabIndex = 5;
            this.SearchProductsBtn.Text = "Search";
            this.SearchProductsBtn.UseVisualStyleBackColor = false;
            // 
            // ExitMainFormBtn
            // 
            this.ExitMainFormBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitMainFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitMainFormBtn.Location = new System.Drawing.Point(1814, 877);
            this.ExitMainFormBtn.Name = "ExitMainFormBtn";
            this.ExitMainFormBtn.Size = new System.Drawing.Size(148, 64);
            this.ExitMainFormBtn.TabIndex = 10;
            this.ExitMainFormBtn.Text = "Exit";
            this.ExitMainFormBtn.UseVisualStyleBackColor = false;
            // 
            // DeletePartBtn
            // 
            this.DeletePartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeletePartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartBtn.Location = new System.Drawing.Point(805, 777);
            this.DeletePartBtn.Name = "DeletePartBtn";
            this.DeletePartBtn.Size = new System.Drawing.Size(131, 59);
            this.DeletePartBtn.TabIndex = 11;
            this.DeletePartBtn.Text = "Delete";
            this.DeletePartBtn.UseVisualStyleBackColor = false;
            // 
            // ModifyPartBtn
            // 
            this.ModifyPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ModifyPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartBtn.Location = new System.Drawing.Point(646, 777);
            this.ModifyPartBtn.Name = "ModifyPartBtn";
            this.ModifyPartBtn.Size = new System.Drawing.Size(131, 59);
            this.ModifyPartBtn.TabIndex = 12;
            this.ModifyPartBtn.Text = "Modify";
            this.ModifyPartBtn.UseVisualStyleBackColor = false;
            this.ModifyPartBtn.Click += new System.EventHandler(this.ModifyPartBtn_Click);
            // 
            // AddPartBtn
            // 
            this.AddPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartBtn.Location = new System.Drawing.Point(489, 777);
            this.AddPartBtn.Name = "AddPartBtn";
            this.AddPartBtn.Size = new System.Drawing.Size(131, 59);
            this.AddPartBtn.TabIndex = 13;
            this.AddPartBtn.Text = "Add";
            this.AddPartBtn.UseVisualStyleBackColor = false;
            this.AddPartBtn.Click += new System.EventHandler(this.AddPartBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.Location = new System.Drawing.Point(1524, 777);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(131, 59);
            this.AddProductBtn.TabIndex = 16;
            this.AddProductBtn.Text = "Add";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ModifyProductBtn
            // 
            this.ModifyProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ModifyProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductBtn.Location = new System.Drawing.Point(1681, 777);
            this.ModifyProductBtn.Name = "ModifyProductBtn";
            this.ModifyProductBtn.Size = new System.Drawing.Size(131, 59);
            this.ModifyProductBtn.TabIndex = 15;
            this.ModifyProductBtn.Text = "Modify";
            this.ModifyProductBtn.UseVisualStyleBackColor = false;
            this.ModifyProductBtn.Click += new System.EventHandler(this.ModifyProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductBtn.Location = new System.Drawing.Point(1840, 777);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(131, 59);
            this.DeleteProductBtn.TabIndex = 14;
            this.DeleteProductBtn.Text = "Delete";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.MinPart,
            this.MaxPart});
            this.dataGridView1.Location = new System.Drawing.Point(52, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(884, 477);
            this.dataGridView1.TabIndex = 17;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "Part ID";
            this.PartID.MinimumWidth = 10;
            this.PartID.Name = "PartID";
            this.PartID.Width = 200;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 10;
            this.PartName.Name = "PartName";
            this.PartName.Width = 200;
            // 
            // PartInventory
            // 
            this.PartInventory.HeaderText = "Inventory";
            this.PartInventory.MinimumWidth = 10;
            this.PartInventory.Name = "PartInventory";
            this.PartInventory.Width = 200;
            // 
            // PartPrice
            // 
            this.PartPrice.HeaderText = "Price";
            this.PartPrice.MinimumWidth = 10;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.Width = 200;
            // 
            // MinPart
            // 
            this.MinPart.HeaderText = "Min";
            this.MinPart.MinimumWidth = 10;
            this.MinPart.Name = "MinPart";
            this.MinPart.Width = 200;
            // 
            // MaxPart
            // 
            this.MaxPart.HeaderText = "Max";
            this.MaxPart.MinimumWidth = 10;
            this.MaxPart.Name = "MaxPart";
            this.MaxPart.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.dataGridView2.Location = new System.Drawing.Point(1037, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(925, 477);
            this.dataGridView2.TabIndex = 18;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 10;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 200;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 10;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // ProductInventory
            // 
            this.ProductInventory.HeaderText = "Product Inventory";
            this.ProductInventory.MinimumWidth = 10;
            this.ProductInventory.Name = "ProductInventory";
            this.ProductInventory.Width = 200;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.MinimumWidth = 10;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 200;
            // 
            // ProductMin
            // 
            this.ProductMin.HeaderText = "Min";
            this.ProductMin.MinimumWidth = 10;
            this.ProductMin.Name = "ProductMin";
            this.ProductMin.Width = 200;
            // 
            // ProductMax
            // 
            this.ProductMax.HeaderText = "Max";
            this.ProductMax.MinimumWidth = 10;
            this.ProductMax.Name = "ProductMax";
            this.ProductMax.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2100, 1023);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.ModifyProductBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.AddPartBtn);
            this.Controls.Add(this.ModifyPartBtn);
            this.Controls.Add(this.DeletePartBtn);
            this.Controls.Add(this.ExitMainFormBtn);
            this.Controls.Add(this.SearchProductsTxt);
            this.Controls.Add(this.SearchProductsBtn);
            this.Controls.Add(this.SearchPartsTxt);
            this.Controls.Add(this.SearchPartsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchPartsBtn;
        private System.Windows.Forms.TextBox SearchPartsTxt;
        private System.Windows.Forms.TextBox SearchProductsTxt;
        private System.Windows.Forms.Button SearchProductsBtn;
        private System.Windows.Forms.Button ExitMainFormBtn;
        private System.Windows.Forms.Button DeletePartBtn;
        private System.Windows.Forms.Button ModifyPartBtn;
        private System.Windows.Forms.Button AddPartBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button ModifyProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMax;
    }
}

