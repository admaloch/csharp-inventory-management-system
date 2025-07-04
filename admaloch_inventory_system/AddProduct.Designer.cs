﻿namespace admaloch_inventory_system
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventoryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchPartsTxt = new System.Windows.Forms.TextBox();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Location = new System.Drawing.Point(1382, 939);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(114, 59);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(1251, 939);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 59);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(384, 512);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(119, 31);
            this.minTxt.TabIndex = 33;
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
            // maxTxt
            // 
            this.maxTxt.Location = new System.Drawing.Point(161, 512);
            this.maxTxt.Name = "maxTxt";
            this.maxTxt.Size = new System.Drawing.Size(119, 31);
            this.maxTxt.TabIndex = 31;
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
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(220, 446);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(245, 31);
            this.priceTxt.TabIndex = 27;
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
            // inventoryTxt
            // 
            this.inventoryTxt.Location = new System.Drawing.Point(220, 369);
            this.inventoryTxt.Name = "inventoryTxt";
            this.inventoryTxt.Size = new System.Drawing.Size(245, 31);
            this.inventoryTxt.TabIndex = 25;
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
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(220, 295);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(245, 31);
            this.nameTxt.TabIndex = 23;
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
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(220, 233);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(245, 31);
            this.idTxt.TabIndex = 21;
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
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addBtn.Location = new System.Drawing.Point(1382, 470);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(114, 59);
            this.addBtn.TabIndex = 37;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBtn.Location = new System.Drawing.Point(1382, 864);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(114, 59);
            this.deleteBtn.TabIndex = 38;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchPartsTxt
            // 
            this.searchPartsTxt.Location = new System.Drawing.Point(1196, 97);
            this.searchPartsTxt.Name = "searchPartsTxt";
            this.searchPartsTxt.Size = new System.Drawing.Size(300, 31);
            this.searchPartsTxt.TabIndex = 41;
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
            this.ProductSearchBtn.Click += new System.EventHandler(this.ProductSearchBtn_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(612, 141);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 82;
            this.dgvParts.RowTemplate.Height = 33;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(884, 310);
            this.dgvParts.TabIndex = 42;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(612, 535);
            this.dgvAssociatedParts.MultiSelect = false;
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.RowHeadersVisible = false;
            this.dgvAssociatedParts.RowHeadersWidth = 82;
            this.dgvAssociatedParts.RowTemplate.Height = 33;
            this.dgvAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(884, 310);
            this.dgvAssociatedParts.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(622, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 37);
            this.label6.TabIndex = 44;
            this.label6.Text = "All parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 37);
            this.label9.TabIndex = 45;
            this.label9.Text = "Associated Parts";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 1025);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.searchPartsTxt);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.minTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox minTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inventoryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchPartsTxt;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}