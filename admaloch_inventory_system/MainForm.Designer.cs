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
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchPartsTxt = new System.Windows.Forms.TextBox();
            this.searchProductsTxt = new System.Windows.Forms.TextBox();
            this.searchProductsBtn = new System.Windows.Forms.Button();
            this.ExitMainFormBtn = new System.Windows.Forms.Button();
            this.deletePartBtn = new System.Windows.Forms.Button();
            this.modifyPartBtn = new System.Windows.Forms.Button();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.modifyProductBtn = new System.Windows.Forms.Button();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
            // searchPartsBtn
            // 
            this.searchPartsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPartsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartsBtn.Location = new System.Drawing.Point(489, 188);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(131, 52);
            this.searchPartsBtn.TabIndex = 3;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = false;
            // 
            // searchPartsTxt
            // 
            this.searchPartsTxt.Location = new System.Drawing.Point(636, 202);
            this.searchPartsTxt.Name = "searchPartsTxt";
            this.searchPartsTxt.Size = new System.Drawing.Size(300, 31);
            this.searchPartsTxt.TabIndex = 4;
            // 
            // searchProductsTxt
            // 
            this.searchProductsTxt.Location = new System.Drawing.Point(1671, 202);
            this.searchProductsTxt.Name = "searchProductsTxt";
            this.searchProductsTxt.Size = new System.Drawing.Size(300, 31);
            this.searchProductsTxt.TabIndex = 6;
            // 
            // searchProductsBtn
            // 
            this.searchProductsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchProductsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsBtn.Location = new System.Drawing.Point(1523, 188);
            this.searchProductsBtn.Name = "searchProductsBtn";
            this.searchProductsBtn.Size = new System.Drawing.Size(131, 52);
            this.searchProductsBtn.TabIndex = 5;
            this.searchProductsBtn.Text = "Search";
            this.searchProductsBtn.UseVisualStyleBackColor = false;
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
            // deletePartBtn
            // 
            this.deletePartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deletePartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePartBtn.Location = new System.Drawing.Point(805, 777);
            this.deletePartBtn.Name = "deletePartBtn";
            this.deletePartBtn.Size = new System.Drawing.Size(131, 59);
            this.deletePartBtn.TabIndex = 11;
            this.deletePartBtn.Text = "Delete";
            this.deletePartBtn.UseVisualStyleBackColor = false;
            this.deletePartBtn.Click += new System.EventHandler(this.DeletePartBtn_Click);
            // 
            // modifyPartBtn
            // 
            this.modifyPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartBtn.Location = new System.Drawing.Point(646, 777);
            this.modifyPartBtn.Name = "modifyPartBtn";
            this.modifyPartBtn.Size = new System.Drawing.Size(131, 59);
            this.modifyPartBtn.TabIndex = 12;
            this.modifyPartBtn.Text = "Modify";
            this.modifyPartBtn.UseVisualStyleBackColor = false;
            this.modifyPartBtn.Click += new System.EventHandler(this.ModifyPartBtn_Click);
            // 
            // addPartBtn
            // 
            this.addPartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartBtn.Location = new System.Drawing.Point(489, 777);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(131, 59);
            this.addPartBtn.TabIndex = 13;
            this.addPartBtn.Text = "Add";
            this.addPartBtn.UseVisualStyleBackColor = false;
            this.addPartBtn.Click += new System.EventHandler(this.AddPartBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.Location = new System.Drawing.Point(1524, 777);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(131, 59);
            this.addProductBtn.TabIndex = 16;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // modifyProductBtn
            // 
            this.modifyProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductBtn.Location = new System.Drawing.Point(1681, 777);
            this.modifyProductBtn.Name = "modifyProductBtn";
            this.modifyProductBtn.Size = new System.Drawing.Size(131, 59);
            this.modifyProductBtn.TabIndex = 15;
            this.modifyProductBtn.Text = "Modify";
            this.modifyProductBtn.UseVisualStyleBackColor = false;
            this.modifyProductBtn.Click += new System.EventHandler(this.ModifyProductBtn_Click);
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductBtn.Location = new System.Drawing.Point(1840, 777);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(131, 59);
            this.deleteProductBtn.TabIndex = 14;
            this.deleteProductBtn.Text = "Delete";
            this.deleteProductBtn.UseVisualStyleBackColor = false;
            this.deleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(67, 280);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 82;
            this.dgvParts.RowTemplate.Height = 33;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(934, 476);
            this.dgvParts.TabIndex = 17;
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(1059, 280);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 82;
            this.dgvProducts.RowTemplate.Height = 33;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(951, 476);
            this.dgvProducts.TabIndex = 18;
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.productBindingComplete);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2100, 1023);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.modifyProductBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.modifyPartBtn);
            this.Controls.Add(this.deletePartBtn);
            this.Controls.Add(this.ExitMainFormBtn);
            this.Controls.Add(this.searchProductsTxt);
            this.Controls.Add(this.searchProductsBtn);
            this.Controls.Add(this.searchPartsTxt);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.TextBox searchPartsTxt;
        private System.Windows.Forms.TextBox searchProductsTxt;
        private System.Windows.Forms.Button searchProductsBtn;
        private System.Windows.Forms.Button ExitMainFormBtn;
        private System.Windows.Forms.Button deletePartBtn;
        private System.Windows.Forms.Button modifyPartBtn;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button modifyProductBtn;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

