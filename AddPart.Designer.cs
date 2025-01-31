namespace AliceLyC968
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.addPartRadInhouse = new System.Windows.Forms.RadioButton();
            this.addPartRadOutsourced = new System.Windows.Forms.RadioButton();
            this.addPartIdLabel = new System.Windows.Forms.Label();
            this.addPartIdField = new System.Windows.Forms.TextBox();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartNameField = new System.Windows.Forms.TextBox();
            this.addPartInStockLabel = new System.Windows.Forms.Label();
            this.addPartInStockField = new System.Windows.Forms.TextBox();
            this.addPartPrice = new System.Windows.Forms.Label();
            this.addPartPriceField = new System.Windows.Forms.TextBox();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMaxField = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMinField = new System.Windows.Forms.TextBox();
            this.addPartMachLabel = new System.Windows.Forms.Label();
            this.addPartMachIdField = new System.Windows.Forms.TextBox();
            this.saveAddPart = new System.Windows.Forms.Button();
            this.addPartCompLabel = new System.Windows.Forms.Label();
            this.addPartCompField = new System.Windows.Forms.TextBox();
            this.cancelAddPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(59, 16);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartRadInhouse
            // 
            this.addPartRadInhouse.AutoSize = true;
            this.addPartRadInhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartRadInhouse.Location = new System.Drawing.Point(122, 12);
            this.addPartRadInhouse.Name = "addPartRadInhouse";
            this.addPartRadInhouse.Size = new System.Drawing.Size(79, 20);
            this.addPartRadInhouse.TabIndex = 1;
            this.addPartRadInhouse.TabStop = true;
            this.addPartRadInhouse.Text = "In-House";
            this.addPartRadInhouse.UseVisualStyleBackColor = true;
            this.addPartRadInhouse.CheckedChanged += new System.EventHandler(this.addPartCatInHouseCheckedChanged);
            // 
            // addPartRadOutsourced
            // 
            this.addPartRadOutsourced.AutoSize = true;
            this.addPartRadOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartRadOutsourced.Location = new System.Drawing.Point(224, 12);
            this.addPartRadOutsourced.Name = "addPartRadOutsourced";
            this.addPartRadOutsourced.Size = new System.Drawing.Size(94, 20);
            this.addPartRadOutsourced.TabIndex = 2;
            this.addPartRadOutsourced.TabStop = true;
            this.addPartRadOutsourced.Text = "Outsourced";
            this.addPartRadOutsourced.UseVisualStyleBackColor = true;
            this.addPartRadOutsourced.CheckedChanged += new System.EventHandler(this.addPartCatOutCheckedChanged);
            // 
            // addPartIdLabel
            // 
            this.addPartIdLabel.AutoSize = true;
            this.addPartIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIdLabel.Location = new System.Drawing.Point(106, 86);
            this.addPartIdLabel.Name = "addPartIdLabel";
            this.addPartIdLabel.Size = new System.Drawing.Size(22, 18);
            this.addPartIdLabel.TabIndex = 3;
            this.addPartIdLabel.Text = "ID";
            // 
            // addPartIdField
            // 
            this.addPartIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIdField.Location = new System.Drawing.Point(148, 83);
            this.addPartIdField.Name = "addPartIdField";
            this.addPartIdField.ReadOnly = true;
            this.addPartIdField.Size = new System.Drawing.Size(149, 26);
            this.addPartIdField.TabIndex = 4;
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartNameLabel.Location = new System.Drawing.Point(84, 133);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(44, 16);
            this.addPartNameLabel.TabIndex = 5;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartNameField
            // 
            this.addPartNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartNameField.Location = new System.Drawing.Point(148, 128);
            this.addPartNameField.Name = "addPartNameField";
            this.addPartNameField.Size = new System.Drawing.Size(149, 26);
            this.addPartNameField.TabIndex = 6;
            this.addPartNameField.TextChanged += new System.EventHandler(this.addPartNameChanged);
            // 
            // addPartInStockLabel
            // 
            this.addPartInStockLabel.AutoSize = true;
            this.addPartInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInStockLabel.Location = new System.Drawing.Point(67, 175);
            this.addPartInStockLabel.Name = "addPartInStockLabel";
            this.addPartInStockLabel.Size = new System.Drawing.Size(61, 16);
            this.addPartInStockLabel.TabIndex = 7;
            this.addPartInStockLabel.Text = "Inventory";
            // 
            // addPartInStockField
            // 
            this.addPartInStockField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartInStockField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInStockField.Location = new System.Drawing.Point(148, 170);
            this.addPartInStockField.Name = "addPartInStockField";
            this.addPartInStockField.Size = new System.Drawing.Size(149, 26);
            this.addPartInStockField.TabIndex = 8;
            this.addPartInStockField.TextChanged += new System.EventHandler(this.addPartInStockChanged);
            // 
            // addPartPrice
            // 
            this.addPartPrice.AutoSize = true;
            this.addPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPrice.Location = new System.Drawing.Point(53, 220);
            this.addPartPrice.Name = "addPartPrice";
            this.addPartPrice.Size = new System.Drawing.Size(75, 16);
            this.addPartPrice.TabIndex = 9;
            this.addPartPrice.Text = "Price / Cost";
            // 
            // addPartPriceField
            // 
            this.addPartPriceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPriceField.Location = new System.Drawing.Point(148, 215);
            this.addPartPriceField.Name = "addPartPriceField";
            this.addPartPriceField.Size = new System.Drawing.Size(149, 26);
            this.addPartPriceField.TabIndex = 10;
            this.addPartPriceField.TextChanged += new System.EventHandler(this.addPartPriceChanged);
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMaxLabel.Location = new System.Drawing.Point(96, 265);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.addPartMaxLabel.TabIndex = 11;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMaxField
            // 
            this.addPartMaxField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartMaxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMaxField.Location = new System.Drawing.Point(148, 260);
            this.addPartMaxField.Name = "addPartMaxField";
            this.addPartMaxField.Size = new System.Drawing.Size(78, 26);
            this.addPartMaxField.TabIndex = 12;
            this.addPartMaxField.TextChanged += new System.EventHandler(this.addPartMaxChanged);
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMinLabel.Location = new System.Drawing.Point(265, 265);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(28, 16);
            this.addPartMinLabel.TabIndex = 13;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartMinField
            // 
            this.addPartMinField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartMinField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMinField.Location = new System.Drawing.Point(316, 260);
            this.addPartMinField.Name = "addPartMinField";
            this.addPartMinField.Size = new System.Drawing.Size(78, 26);
            this.addPartMinField.TabIndex = 14;
            this.addPartMinField.TextChanged += new System.EventHandler(this.addPartMinChanged);
            // 
            // addPartMachLabel
            // 
            this.addPartMachLabel.AutoSize = true;
            this.addPartMachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMachLabel.Location = new System.Drawing.Point(53, 313);
            this.addPartMachLabel.Name = "addPartMachLabel";
            this.addPartMachLabel.Size = new System.Drawing.Size(74, 16);
            this.addPartMachLabel.TabIndex = 15;
            this.addPartMachLabel.Text = "Machine ID";
            this.addPartMachLabel.Visible = false;
            // 
            // addPartMachIdField
            // 
            this.addPartMachIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartMachIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMachIdField.Location = new System.Drawing.Point(148, 308);
            this.addPartMachIdField.Name = "addPartMachIdField";
            this.addPartMachIdField.Size = new System.Drawing.Size(149, 26);
            this.addPartMachIdField.TabIndex = 16;
            this.addPartMachIdField.Visible = false;
            this.addPartMachIdField.TextChanged += new System.EventHandler(this.addPartMachIdFieldChanged);
            // 
            // saveAddPart
            // 
            this.saveAddPart.AutoSize = true;
            this.saveAddPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAddPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddPart.Location = new System.Drawing.Point(267, 409);
            this.saveAddPart.Name = "saveAddPart";
            this.saveAddPart.Size = new System.Drawing.Size(51, 28);
            this.saveAddPart.TabIndex = 19;
            this.saveAddPart.Text = "Save";
            this.saveAddPart.UseVisualStyleBackColor = false;
            this.saveAddPart.Click += new System.EventHandler(this.saveAddPartClick);
            // 
            // addPartCompLabel
            // 
            this.addPartCompLabel.AutoSize = true;
            this.addPartCompLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartCompLabel.Location = new System.Drawing.Point(22, 313);
            this.addPartCompLabel.Name = "addPartCompLabel";
            this.addPartCompLabel.Size = new System.Drawing.Size(105, 16);
            this.addPartCompLabel.TabIndex = 17;
            this.addPartCompLabel.Text = "Company Name";
            this.addPartCompLabel.Visible = false;
            // 
            // addPartCompField
            // 
            this.addPartCompField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartCompField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartCompField.Location = new System.Drawing.Point(148, 308);
            this.addPartCompField.Name = "addPartCompField";
            this.addPartCompField.Size = new System.Drawing.Size(149, 26);
            this.addPartCompField.TabIndex = 18;
            this.addPartCompField.Visible = false;
            this.addPartCompField.TextChanged += new System.EventHandler(this.addPartCompNameChanged);
            // 
            // cancelAddPart
            // 
            this.cancelAddPart.AutoSize = true;
            this.cancelAddPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelAddPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddPart.Location = new System.Drawing.Point(333, 409);
            this.cancelAddPart.Name = "cancelAddPart";
            this.cancelAddPart.Size = new System.Drawing.Size(61, 28);
            this.cancelAddPart.TabIndex = 20;
            this.cancelAddPart.Text = "Cancel";
            this.cancelAddPart.UseVisualStyleBackColor = false;
            this.cancelAddPart.Click += new System.EventHandler(this.cancelAddPartClick);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 466);
            this.Controls.Add(this.cancelAddPart);
            this.Controls.Add(this.addPartCompField);
            this.Controls.Add(this.addPartCompLabel);
            this.Controls.Add(this.saveAddPart);
            this.Controls.Add(this.addPartMachIdField);
            this.Controls.Add(this.addPartMachLabel);
            this.Controls.Add(this.addPartMinField);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxField);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartPriceField);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartInStockField);
            this.Controls.Add(this.addPartInStockLabel);
            this.Controls.Add(this.addPartNameField);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIdField);
            this.Controls.Add(this.addPartIdLabel);
            this.Controls.Add(this.addPartRadOutsourced);
            this.Controls.Add(this.addPartRadInhouse);
            this.Controls.Add(this.addPartLabel);
            this.Name = "AddPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton addPartRadInhouse;
        private System.Windows.Forms.RadioButton addPartRadOutsourced;
        private System.Windows.Forms.Label addPartIdLabel;
        private System.Windows.Forms.TextBox addPartIdField;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.TextBox addPartNameField;
        private System.Windows.Forms.Label addPartInStockLabel;
        private System.Windows.Forms.TextBox addPartInStockField;
        private System.Windows.Forms.Label addPartPrice;
        private System.Windows.Forms.TextBox addPartPriceField;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.TextBox addPartMaxField;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox addPartMinField;
        private System.Windows.Forms.Label addPartMachLabel;
        private System.Windows.Forms.TextBox addPartMachIdField;
        private System.Windows.Forms.Button saveAddPart;
        private System.Windows.Forms.Label addPartCompLabel;
        private System.Windows.Forms.TextBox addPartCompField;
        private System.Windows.Forms.Button cancelAddPart;
    }
}