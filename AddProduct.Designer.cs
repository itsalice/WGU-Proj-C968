namespace AliceLyC968
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
            this.cancelAddProduct = new System.Windows.Forms.Button();
            this.saveAddProduct = new System.Windows.Forms.Button();
            this.addProductMinField = new System.Windows.Forms.TextBox();
            this.addProductMin = new System.Windows.Forms.Label();
            this.addProductMaxField = new System.Windows.Forms.TextBox();
            this.addProductMaxLabel = new System.Windows.Forms.Label();
            this.addProductPriceField = new System.Windows.Forms.TextBox();
            this.addProductPriceLabel = new System.Windows.Forms.Label();
            this.addProductInStockField = new System.Windows.Forms.TextBox();
            this.addProductInStockLabel = new System.Windows.Forms.Label();
            this.addProductNameField = new System.Windows.Forms.TextBox();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductIdField = new System.Windows.Forms.TextBox();
            this.addProductIdLabel = new System.Windows.Forms.Label();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchPartsField = new System.Windows.Forms.TextBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.allCurrPartsLabel = new System.Windows.Forms.Label();
            this.addAssociatedParts = new System.Windows.Forms.Button();
            this.delAssociatedParts = new System.Windows.Forms.Button();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddProduct
            // 
            this.cancelAddProduct.AutoSize = true;
            this.cancelAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddProduct.Location = new System.Drawing.Point(942, 629);
            this.cancelAddProduct.Name = "cancelAddProduct";
            this.cancelAddProduct.Size = new System.Drawing.Size(61, 28);
            this.cancelAddProduct.TabIndex = 20;
            this.cancelAddProduct.Text = "Cancel";
            this.cancelAddProduct.UseVisualStyleBackColor = false;
            this.cancelAddProduct.Click += new System.EventHandler(this.cancelAddProductClick);
            // 
            // saveAddProduct
            // 
            this.saveAddProduct.AutoSize = true;
            this.saveAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddProduct.Location = new System.Drawing.Point(869, 629);
            this.saveAddProduct.Name = "saveAddProduct";
            this.saveAddProduct.Size = new System.Drawing.Size(51, 28);
            this.saveAddProduct.TabIndex = 19;
            this.saveAddProduct.Text = "Save";
            this.saveAddProduct.UseVisualStyleBackColor = false;
            this.saveAddProduct.Click += new System.EventHandler(this.saveAddProductClick);
            // 
            // addProductMinField
            // 
            this.addProductMinField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductMinField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMinField.Location = new System.Drawing.Point(272, 389);
            this.addProductMinField.Name = "addProductMinField";
            this.addProductMinField.Size = new System.Drawing.Size(78, 26);
            this.addProductMinField.TabIndex = 13;
            this.addProductMinField.TextChanged += new System.EventHandler(this.addProductMinChanged);
            // 
            // addProductMin
            // 
            this.addProductMin.AutoSize = true;
            this.addProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMin.Location = new System.Drawing.Point(225, 394);
            this.addProductMin.Name = "addProductMin";
            this.addProductMin.Size = new System.Drawing.Size(28, 16);
            this.addProductMin.TabIndex = 12;
            this.addProductMin.Text = "Min";
            // 
            // addProductMaxField
            // 
            this.addProductMaxField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductMaxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMaxField.Location = new System.Drawing.Point(127, 389);
            this.addProductMaxField.Name = "addProductMaxField";
            this.addProductMaxField.Size = new System.Drawing.Size(78, 26);
            this.addProductMaxField.TabIndex = 11;
            this.addProductMaxField.TextChanged += new System.EventHandler(this.addProductMaxChanged);
            // 
            // addProductMaxLabel
            // 
            this.addProductMaxLabel.AutoSize = true;
            this.addProductMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMaxLabel.Location = new System.Drawing.Point(34, 394);
            this.addProductMaxLabel.Name = "addProductMaxLabel";
            this.addProductMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.addProductMaxLabel.TabIndex = 10;
            this.addProductMaxLabel.Text = "Max";
            // 
            // addProductPriceField
            // 
            this.addProductPriceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceField.Location = new System.Drawing.Point(127, 344);
            this.addProductPriceField.Name = "addProductPriceField";
            this.addProductPriceField.Size = new System.Drawing.Size(149, 26);
            this.addProductPriceField.TabIndex = 9;
            this.addProductPriceField.TextChanged += new System.EventHandler(this.addProductPriceChanged);
            // 
            // addProductPriceLabel
            // 
            this.addProductPriceLabel.AutoSize = true;
            this.addProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceLabel.Location = new System.Drawing.Point(34, 349);
            this.addProductPriceLabel.Name = "addProductPriceLabel";
            this.addProductPriceLabel.Size = new System.Drawing.Size(38, 16);
            this.addProductPriceLabel.TabIndex = 8;
            this.addProductPriceLabel.Text = "Price";
            // 
            // addProductInStockField
            // 
            this.addProductInStockField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductInStockField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductInStockField.Location = new System.Drawing.Point(127, 299);
            this.addProductInStockField.Name = "addProductInStockField";
            this.addProductInStockField.Size = new System.Drawing.Size(149, 26);
            this.addProductInStockField.TabIndex = 7;
            this.addProductInStockField.TextChanged += new System.EventHandler(this.addProductInStockChanged);
            // 
            // addProductInStockLabel
            // 
            this.addProductInStockLabel.AutoSize = true;
            this.addProductInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductInStockLabel.Location = new System.Drawing.Point(34, 304);
            this.addProductInStockLabel.Name = "addProductInStockLabel";
            this.addProductInStockLabel.Size = new System.Drawing.Size(61, 16);
            this.addProductInStockLabel.TabIndex = 6;
            this.addProductInStockLabel.Text = "Inventory";
            // 
            // addProductNameField
            // 
            this.addProductNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameField.Location = new System.Drawing.Point(127, 257);
            this.addProductNameField.Name = "addProductNameField";
            this.addProductNameField.Size = new System.Drawing.Size(149, 26);
            this.addProductNameField.TabIndex = 5;
            this.addProductNameField.TextChanged += new System.EventHandler(this.addProductNameChanged);
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameLabel.Location = new System.Drawing.Point(34, 262);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(44, 16);
            this.addProductNameLabel.TabIndex = 4;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductIdField
            // 
            this.addProductIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIdField.Location = new System.Drawing.Point(127, 212);
            this.addProductIdField.Name = "addProductIdField";
            this.addProductIdField.ReadOnly = true;
            this.addProductIdField.Size = new System.Drawing.Size(149, 26);
            this.addProductIdField.TabIndex = 3;
            // 
            // addProductIdLabel
            // 
            this.addProductIdLabel.AutoSize = true;
            this.addProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIdLabel.Location = new System.Drawing.Point(34, 215);
            this.addProductIdLabel.Name = "addProductIdLabel";
            this.addProductIdLabel.Size = new System.Drawing.Size(22, 18);
            this.addProductIdLabel.TabIndex = 2;
            this.addProductIdLabel.Text = "ID";
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(14, 9);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(81, 16);
            this.addProductLabel.TabIndex = 1;
            this.addProductLabel.Text = "Add Product";
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPartsBtn.Location = new System.Drawing.Point(732, 55);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartsBtn.TabIndex = 16;
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
            this.searchPartsField.TabIndex = 15;
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(512, 96);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(519, 170);
            this.dgvParts.TabIndex = 44;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(512, 365);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.Size = new System.Drawing.Size(519, 170);
            this.dgvAssociatedParts.TabIndex = 47;
            // 
            // allCurrPartsLabel
            // 
            this.allCurrPartsLabel.AutoSize = true;
            this.allCurrPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCurrPartsLabel.Location = new System.Drawing.Point(509, 62);
            this.allCurrPartsLabel.Name = "allCurrPartsLabel";
            this.allCurrPartsLabel.Size = new System.Drawing.Size(119, 16);
            this.allCurrPartsLabel.TabIndex = 14;
            this.allCurrPartsLabel.Text = "All candidate Parts";
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
            this.addAssociatedParts.TabIndex = 17;
            this.addAssociatedParts.Text = "Add";
            this.addAssociatedParts.UseVisualStyleBackColor = false;
            this.addAssociatedParts.Click += new System.EventHandler(this.addAssociatedPartsClick);
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
            this.delAssociatedParts.TabIndex = 18;
            this.delAssociatedParts.Text = "Delete";
            this.delAssociatedParts.UseVisualStyleBackColor = false;
            this.delAssociatedParts.Click += new System.EventHandler(this.delAssociatedPartsClick);
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assocPartsLabel.Location = new System.Drawing.Point(509, 331);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(204, 16);
            this.assocPartsLabel.TabIndex = 51;
            this.assocPartsLabel.Text = "Parts Associated with the Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 674);
            this.Controls.Add(this.assocPartsLabel);
            this.Controls.Add(this.delAssociatedParts);
            this.Controls.Add(this.addAssociatedParts);
            this.Controls.Add(this.allCurrPartsLabel);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.searchPartsField);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.cancelAddProduct);
            this.Controls.Add(this.saveAddProduct);
            this.Controls.Add(this.addProductMinField);
            this.Controls.Add(this.addProductMin);
            this.Controls.Add(this.addProductMaxField);
            this.Controls.Add(this.addProductMaxLabel);
            this.Controls.Add(this.addProductPriceField);
            this.Controls.Add(this.addProductPriceLabel);
            this.Controls.Add(this.addProductInStockField);
            this.Controls.Add(this.addProductInStockLabel);
            this.Controls.Add(this.addProductNameField);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductIdField);
            this.Controls.Add(this.addProductIdLabel);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddProduct;
        private System.Windows.Forms.Button saveAddProduct;
        private System.Windows.Forms.TextBox addProductMinField;
        private System.Windows.Forms.Label addProductMin;
        private System.Windows.Forms.TextBox addProductMaxField;
        private System.Windows.Forms.Label addProductMaxLabel;
        private System.Windows.Forms.TextBox addProductPriceField;
        private System.Windows.Forms.Label addProductPriceLabel;
        private System.Windows.Forms.TextBox addProductInStockField;
        private System.Windows.Forms.Label addProductInStockLabel;
        private System.Windows.Forms.TextBox addProductNameField;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.TextBox addProductIdField;
        private System.Windows.Forms.Label addProductIdLabel;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.TextBox searchPartsField;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label allCurrPartsLabel;
        private System.Windows.Forms.Button addAssociatedParts;
        private System.Windows.Forms.Button delAssociatedParts;
        private System.Windows.Forms.Label assocPartsLabel;
    }
}