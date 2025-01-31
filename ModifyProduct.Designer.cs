namespace AliceLyC968
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
            this.modifyAssocPartsLabel = new System.Windows.Forms.Label();
            this.delAssociatedParts = new System.Windows.Forms.Button();
            this.addAssociatedParts = new System.Windows.Forms.Button();
            this.modifyAllCurrPartsLabel = new System.Windows.Forms.Label();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchPartsField = new System.Windows.Forms.TextBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.cancelModifyProduct = new System.Windows.Forms.Button();
            this.saveModifyProduct = new System.Windows.Forms.Button();
            this.modProductMinField = new System.Windows.Forms.TextBox();
            this.modifyProductMin = new System.Windows.Forms.Label();
            this.modProductMaxField = new System.Windows.Forms.TextBox();
            this.modifyProductMaxLabel = new System.Windows.Forms.Label();
            this.modProductPriceField = new System.Windows.Forms.TextBox();
            this.modifyProductPriceLabel = new System.Windows.Forms.Label();
            this.modProductInStockField = new System.Windows.Forms.TextBox();
            this.modifyProductInStockLabel = new System.Windows.Forms.Label();
            this.modProductNameField = new System.Windows.Forms.TextBox();
            this.modifyProductNameLabel = new System.Windows.Forms.Label();
            this.modProductIdField = new System.Windows.Forms.TextBox();
            this.modifyProductIdLabel = new System.Windows.Forms.Label();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyAssocPartsLabel
            // 
            this.modifyAssocPartsLabel.AutoSize = true;
            this.modifyAssocPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyAssocPartsLabel.Location = new System.Drawing.Point(509, 331);
            this.modifyAssocPartsLabel.Name = "modifyAssocPartsLabel";
            this.modifyAssocPartsLabel.Size = new System.Drawing.Size(204, 16);
            this.modifyAssocPartsLabel.TabIndex = 74;
            this.modifyAssocPartsLabel.Text = "Parts Associated with the Product";
            // 
            // delAssociatedParts
            // 
            this.delAssociatedParts.AutoSize = true;
            this.delAssociatedParts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delAssociatedParts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delAssociatedParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAssociatedParts.Location = new System.Drawing.Point(944, 557);
            this.delAssociatedParts.Name = "delAssociatedParts";
            this.delAssociatedParts.Size = new System.Drawing.Size(59, 28);
            this.delAssociatedParts.TabIndex = 69;
            this.delAssociatedParts.Text = "Delete";
            this.delAssociatedParts.UseVisualStyleBackColor = false;
            this.delAssociatedParts.Click += new System.EventHandler(this.delAssociatedPartsClick);
            // 
            // addAssociatedParts
            // 
            this.addAssociatedParts.AutoSize = true;
            this.addAssociatedParts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAssociatedParts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addAssociatedParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssociatedParts.Location = new System.Drawing.Point(959, 289);
            this.addAssociatedParts.Name = "addAssociatedParts";
            this.addAssociatedParts.Size = new System.Drawing.Size(44, 28);
            this.addAssociatedParts.TabIndex = 68;
            this.addAssociatedParts.Text = "Add";
            this.addAssociatedParts.UseVisualStyleBackColor = false;
            this.addAssociatedParts.Click += new System.EventHandler(this.addAssociatedPartsClick);
            // 
            // modifyAllCurrPartsLabel
            // 
            this.modifyAllCurrPartsLabel.AutoSize = true;
            this.modifyAllCurrPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyAllCurrPartsLabel.Location = new System.Drawing.Point(509, 62);
            this.modifyAllCurrPartsLabel.Name = "modifyAllCurrPartsLabel";
            this.modifyAllCurrPartsLabel.Size = new System.Drawing.Size(119, 16);
            this.modifyAllCurrPartsLabel.TabIndex = 65;
            this.modifyAllCurrPartsLabel.Text = "All candidate Parts";
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(512, 365);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.Size = new System.Drawing.Size(519, 170);
            this.dgvAssociatedParts.TabIndex = 73;
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPartsBtn.Location = new System.Drawing.Point(732, 55);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartsBtn.TabIndex = 67;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = false;
            this.searchPartsBtn.Click += new System.EventHandler(this.searchPartsBtnClick);
            // 
            // searchPartsField
            // 
            this.searchPartsField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPartsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartsField.Location = new System.Drawing.Point(822, 52);
            this.searchPartsField.Name = "searchPartsField";
            this.searchPartsField.Size = new System.Drawing.Size(209, 26);
            this.searchPartsField.TabIndex = 66;
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(512, 96);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(519, 170);
            this.dgvParts.TabIndex = 72;
            // 
            // cancelModifyProduct
            // 
            this.cancelModifyProduct.AutoSize = true;
            this.cancelModifyProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelModifyProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelModifyProduct.Location = new System.Drawing.Point(942, 629);
            this.cancelModifyProduct.Name = "cancelModifyProduct";
            this.cancelModifyProduct.Size = new System.Drawing.Size(61, 28);
            this.cancelModifyProduct.TabIndex = 71;
            this.cancelModifyProduct.Text = "Cancel";
            this.cancelModifyProduct.UseVisualStyleBackColor = false;
            this.cancelModifyProduct.Click += new System.EventHandler(this.cancelModifyProductClick);
            // 
            // saveModifyProduct
            // 
            this.saveModifyProduct.AutoSize = true;
            this.saveModifyProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveModifyProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveModifyProduct.Location = new System.Drawing.Point(869, 629);
            this.saveModifyProduct.Name = "saveModifyProduct";
            this.saveModifyProduct.Size = new System.Drawing.Size(51, 28);
            this.saveModifyProduct.TabIndex = 70;
            this.saveModifyProduct.Text = "Save";
            this.saveModifyProduct.UseVisualStyleBackColor = false;
            this.saveModifyProduct.Click += new System.EventHandler(this.saveModifyProductClick);
            // 
            // modProductMinField
            // 
            this.modProductMinField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductMinField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductMinField.Location = new System.Drawing.Point(272, 389);
            this.modProductMinField.Name = "modProductMinField";
            this.modProductMinField.Size = new System.Drawing.Size(78, 26);
            this.modProductMinField.TabIndex = 64;
            this.modProductMinField.TextChanged += new System.EventHandler(this.modProductMinChanged);
            // 
            // modifyProductMin
            // 
            this.modifyProductMin.AutoSize = true;
            this.modifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMin.Location = new System.Drawing.Point(225, 394);
            this.modifyProductMin.Name = "modifyProductMin";
            this.modifyProductMin.Size = new System.Drawing.Size(28, 16);
            this.modifyProductMin.TabIndex = 63;
            this.modifyProductMin.Text = "Min";
            // 
            // modProductMaxField
            // 
            this.modProductMaxField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductMaxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductMaxField.Location = new System.Drawing.Point(127, 389);
            this.modProductMaxField.Name = "modProductMaxField";
            this.modProductMaxField.Size = new System.Drawing.Size(78, 26);
            this.modProductMaxField.TabIndex = 62;
            this.modProductMaxField.TextChanged += new System.EventHandler(this.modProductMaxChanged);
            // 
            // modifyProductMaxLabel
            // 
            this.modifyProductMaxLabel.AutoSize = true;
            this.modifyProductMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMaxLabel.Location = new System.Drawing.Point(34, 394);
            this.modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            this.modifyProductMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.modifyProductMaxLabel.TabIndex = 61;
            this.modifyProductMaxLabel.Text = "Max";
            // 
            // modProductPriceField
            // 
            this.modProductPriceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductPriceField.Location = new System.Drawing.Point(127, 344);
            this.modProductPriceField.Name = "modProductPriceField";
            this.modProductPriceField.Size = new System.Drawing.Size(149, 26);
            this.modProductPriceField.TabIndex = 60;
            this.modProductPriceField.TextChanged += new System.EventHandler(this.modProductPriceChanged);
            // 
            // modifyProductPriceLabel
            // 
            this.modifyProductPriceLabel.AutoSize = true;
            this.modifyProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductPriceLabel.Location = new System.Drawing.Point(34, 349);
            this.modifyProductPriceLabel.Name = "modifyProductPriceLabel";
            this.modifyProductPriceLabel.Size = new System.Drawing.Size(38, 16);
            this.modifyProductPriceLabel.TabIndex = 59;
            this.modifyProductPriceLabel.Text = "Price";
            // 
            // modProductInStockField
            // 
            this.modProductInStockField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductInStockField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductInStockField.Location = new System.Drawing.Point(127, 299);
            this.modProductInStockField.Name = "modProductInStockField";
            this.modProductInStockField.Size = new System.Drawing.Size(149, 26);
            this.modProductInStockField.TabIndex = 58;
            this.modProductInStockField.TextChanged += new System.EventHandler(this.modProductInStockChanged);
            // 
            // modifyProductInStockLabel
            // 
            this.modifyProductInStockLabel.AutoSize = true;
            this.modifyProductInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductInStockLabel.Location = new System.Drawing.Point(34, 304);
            this.modifyProductInStockLabel.Name = "modifyProductInStockLabel";
            this.modifyProductInStockLabel.Size = new System.Drawing.Size(61, 16);
            this.modifyProductInStockLabel.TabIndex = 57;
            this.modifyProductInStockLabel.Text = "Inventory";
            // 
            // modProductNameField
            // 
            this.modProductNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductNameField.Location = new System.Drawing.Point(127, 257);
            this.modProductNameField.Name = "modProductNameField";
            this.modProductNameField.Size = new System.Drawing.Size(149, 26);
            this.modProductNameField.TabIndex = 56;
            this.modProductNameField.TextChanged += new System.EventHandler(this.modProductNameChanged);
            // 
            // modifyProductNameLabel
            // 
            this.modifyProductNameLabel.AutoSize = true;
            this.modifyProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductNameLabel.Location = new System.Drawing.Point(34, 262);
            this.modifyProductNameLabel.Name = "modifyProductNameLabel";
            this.modifyProductNameLabel.Size = new System.Drawing.Size(44, 16);
            this.modifyProductNameLabel.TabIndex = 55;
            this.modifyProductNameLabel.Text = "Name";
            // 
            // modProductIdField
            // 
            this.modProductIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductIdField.Location = new System.Drawing.Point(127, 212);
            this.modProductIdField.Name = "modProductIdField";
            this.modProductIdField.ReadOnly = true;
            this.modProductIdField.Size = new System.Drawing.Size(149, 26);
            this.modProductIdField.TabIndex = 54;
            // 
            // modifyProductIdLabel
            // 
            this.modifyProductIdLabel.AutoSize = true;
            this.modifyProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductIdLabel.Location = new System.Drawing.Point(34, 215);
            this.modifyProductIdLabel.Name = "modifyProductIdLabel";
            this.modifyProductIdLabel.Size = new System.Drawing.Size(22, 18);
            this.modifyProductIdLabel.TabIndex = 53;
            this.modifyProductIdLabel.Text = "ID";
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(14, 9);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(96, 16);
            this.modifyProductLabel.TabIndex = 52;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 674);
            this.Controls.Add(this.modifyAssocPartsLabel);
            this.Controls.Add(this.delAssociatedParts);
            this.Controls.Add(this.addAssociatedParts);
            this.Controls.Add(this.modifyAllCurrPartsLabel);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.searchPartsField);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.cancelModifyProduct);
            this.Controls.Add(this.saveModifyProduct);
            this.Controls.Add(this.modProductMinField);
            this.Controls.Add(this.modifyProductMin);
            this.Controls.Add(this.modProductMaxField);
            this.Controls.Add(this.modifyProductMaxLabel);
            this.Controls.Add(this.modProductPriceField);
            this.Controls.Add(this.modifyProductPriceLabel);
            this.Controls.Add(this.modProductInStockField);
            this.Controls.Add(this.modifyProductInStockLabel);
            this.Controls.Add(this.modProductNameField);
            this.Controls.Add(this.modifyProductNameLabel);
            this.Controls.Add(this.modProductIdField);
            this.Controls.Add(this.modifyProductIdLabel);
            this.Controls.Add(this.modifyProductLabel);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyAssocPartsLabel;
        private System.Windows.Forms.Button delAssociatedParts;
        private System.Windows.Forms.Button addAssociatedParts;
        private System.Windows.Forms.Label modifyAllCurrPartsLabel;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.TextBox searchPartsField;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button cancelModifyProduct;
        private System.Windows.Forms.Button saveModifyProduct;
        private System.Windows.Forms.TextBox modProductMinField;
        private System.Windows.Forms.Label modifyProductMin;
        private System.Windows.Forms.TextBox modProductMaxField;
        private System.Windows.Forms.Label modifyProductMaxLabel;
        private System.Windows.Forms.TextBox modProductPriceField;
        private System.Windows.Forms.Label modifyProductPriceLabel;
        private System.Windows.Forms.TextBox modProductInStockField;
        private System.Windows.Forms.Label modifyProductInStockLabel;
        private System.Windows.Forms.TextBox modProductNameField;
        private System.Windows.Forms.Label modifyProductNameLabel;
        private System.Windows.Forms.TextBox modProductIdField;
        private System.Windows.Forms.Label modifyProductIdLabel;
        private System.Windows.Forms.Label modifyProductLabel;
    }
}