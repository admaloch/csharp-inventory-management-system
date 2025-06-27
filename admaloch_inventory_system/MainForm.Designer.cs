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
            this.DeletePartBtn.Click += new System.EventHandler(this.DeletePartBtn_Click);
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
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

