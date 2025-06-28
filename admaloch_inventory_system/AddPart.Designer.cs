namespace admaloch_inventory_system
{
    partial class AddPart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outsourceBtn = new System.Windows.Forms.RadioButton();
            this.inHouseBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partOriginTxt = new System.Windows.Forms.TextBox();
            this.machineIdLbl = new System.Windows.Forms.Label();
            this.maxTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.originLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outsourceBtn);
            this.groupBox1.Controls.Add(this.inHouseBtn);
            this.groupBox1.Location = new System.Drawing.Point(268, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // outsourceBtn
            // 
            this.outsourceBtn.AutoSize = true;
            this.outsourceBtn.Location = new System.Drawing.Point(174, 19);
            this.outsourceBtn.Name = "outsourceBtn";
            this.outsourceBtn.Size = new System.Drawing.Size(154, 29);
            this.outsourceBtn.TabIndex = 1;
            this.outsourceBtn.Text = "Outsourced";
            this.outsourceBtn.UseVisualStyleBackColor = true;
            // 
            // inHouseBtn
            // 
            this.inHouseBtn.AutoSize = true;
            this.inHouseBtn.Checked = true;
            this.inHouseBtn.Location = new System.Drawing.Point(6, 19);
            this.inHouseBtn.Name = "inHouseBtn";
            this.inHouseBtn.Size = new System.Drawing.Size(129, 29);
            this.inHouseBtn.TabIndex = 0;
            this.inHouseBtn.TabStop = true;
            this.inHouseBtn.Text = "In-House";
            this.inHouseBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(236, 131);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(245, 31);
            this.idTxt.TabIndex = 3;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(236, 193);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(245, 31);
            this.nameTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // inventoryTxt
            // 
            this.inventoryTxt.Location = new System.Drawing.Point(236, 267);
            this.inventoryTxt.Name = "inventoryTxt";
            this.inventoryTxt.Size = new System.Drawing.Size(245, 31);
            this.inventoryTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inventory";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(236, 344);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(245, 31);
            this.priceTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price/Cost";
            // 
            // partOriginTxt
            // 
            this.partOriginTxt.Location = new System.Drawing.Point(259, 466);
            this.partOriginTxt.Name = "partOriginTxt";
            this.partOriginTxt.Size = new System.Drawing.Size(286, 31);
            this.partOriginTxt.TabIndex = 11;
            // 
            // machineIdLbl
            // 
            this.machineIdLbl.AutoSize = true;
            this.machineIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineIdLbl.Location = new System.Drawing.Point(53, 460);
            this.machineIdLbl.Name = "machineIdLbl";
            this.machineIdLbl.Size = new System.Drawing.Size(0, 37);
            this.machineIdLbl.TabIndex = 10;
            // 
            // maxTxt
            // 
            this.maxTxt.Location = new System.Drawing.Point(236, 407);
            this.maxTxt.Name = "maxTxt";
            this.maxTxt.Size = new System.Drawing.Size(119, 31);
            this.maxTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max";
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(446, 407);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(119, 31);
            this.minTxt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "Min";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Location = new System.Drawing.Point(326, 531);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 59);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.AddPartSaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Location = new System.Drawing.Point(459, 531);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(114, 59);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // originLbl
            // 
            this.originLbl.AutoSize = true;
            this.originLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originLbl.Location = new System.Drawing.Point(76, 466);
            this.originLbl.Name = "originLbl";
            this.originLbl.Size = new System.Drawing.Size(177, 37);
            this.originLbl.TabIndex = 19;
            this.originLbl.Text = "Machine ID";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(619, 642);
            this.Controls.Add(this.originLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.minTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.partOriginTxt);
            this.Controls.Add(this.machineIdLbl);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton outsourceBtn;
        private System.Windows.Forms.RadioButton inHouseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inventoryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox partOriginTxt;
        private System.Windows.Forms.Label machineIdLbl;
        private System.Windows.Forms.TextBox maxTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label originLbl;
    }
}