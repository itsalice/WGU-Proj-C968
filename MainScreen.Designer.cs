namespace AliceLyC968
{
    partial class MainScreen
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.addPart = new System.Windows.Forms.Button();
            this.searchPartsField = new System.Windows.Forms.TextBox();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchProductField = new System.Windows.Forms.TextBox();
            this.searchProductBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(31, 117);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(608, 245);
            this.dgvParts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(687, 117);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(588, 245);
            this.dgvProducts.TabIndex = 1;
            // 
            // addPart
            // 
            this.addPart.AutoSize = true;
            this.addPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addPart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart.Location = new System.Drawing.Point(382, 387);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 40);
            this.addPart.TabIndex = 2;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = false;
            this.addPart.Click += new System.EventHandler(this.addPartClick);
            // 
            // searchPartsField
            // 
            this.searchPartsField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPartsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartsField.Location = new System.Drawing.Point(439, 76);
            this.searchPartsField.Name = "searchPartsField";
            this.searchPartsField.Size = new System.Drawing.Size(200, 26);
            this.searchPartsField.TabIndex = 3;
            // 
            // modifyPart
            // 
            this.modifyPart.AutoSize = true;
            this.modifyPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyPart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.modifyPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPart.Location = new System.Drawing.Point(474, 387);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(75, 40);
            this.modifyPart.TabIndex = 4;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = false;
            this.modifyPart.Click += new System.EventHandler(this.modifyPartClick);
            // 
            // deletePart
            // 
            this.deletePart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePart.Location = new System.Drawing.Point(564, 387);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 40);
            this.deletePart.TabIndex = 5;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = false;
            this.deletePart.Click += new System.EventHandler(this.deletePartClick);
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(1016, 387);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 40);
            this.addProduct.TabIndex = 6;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProductClick);
            // 
            // modifyProduct
            // 
            this.modifyProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProduct.Location = new System.Drawing.Point(1109, 387);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 40);
            this.modifyProduct.TabIndex = 7;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = false;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProductClick);
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.Location = new System.Drawing.Point(1200, 387);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 40);
            this.deleteProduct.TabIndex = 8;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProductClick);
            // 
            // exitApp
            // 
            this.exitApp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApp.Location = new System.Drawing.Point(1200, 567);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(75, 40);
            this.exitApp.TabIndex = 9;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitAppClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory Management System";
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPartsBtn.Location = new System.Drawing.Point(347, 76);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartsBtn.TabIndex = 11;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = false;
            this.searchPartsBtn.Click += new System.EventHandler(this.searchPartsBtnClick);
            // 
            // searchProductField
            // 
            this.searchProductField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchProductField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductField.Location = new System.Drawing.Point(1075, 76);
            this.searchProductField.Name = "searchProductField";
            this.searchProductField.Size = new System.Drawing.Size(200, 26);
            this.searchProductField.TabIndex = 12;
            // 
            // searchProductBtn
            // 
            this.searchProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductBtn.Location = new System.Drawing.Point(984, 76);
            this.searchProductBtn.Name = "searchProductBtn";
            this.searchProductBtn.Size = new System.Drawing.Size(75, 23);
            this.searchProductBtn.TabIndex = 13;
            this.searchProductBtn.Text = "Search";
            this.searchProductBtn.UseVisualStyleBackColor = false;
            this.searchProductBtn.Click += new System.EventHandler(this.searchProductsBtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Products";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchProductBtn);
            this.Controls.Add(this.searchProductField);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.searchPartsField);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.TextBox searchPartsField;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.TextBox searchProductField;
        private System.Windows.Forms.Button searchProductBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

