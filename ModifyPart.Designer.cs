namespace AliceLyC968
{
    partial class ModifyPart
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
            this.cancelModPart = new System.Windows.Forms.Button();
            this.modPartCompField = new System.Windows.Forms.TextBox();
            this.modPartCompLabel = new System.Windows.Forms.Label();
            this.saveModPart = new System.Windows.Forms.Button();
            this.modPartMinField = new System.Windows.Forms.TextBox();
            this.modPartMinLabel = new System.Windows.Forms.Label();
            this.modPartMaxField = new System.Windows.Forms.TextBox();
            this.modPartMaxLabel = new System.Windows.Forms.Label();
            this.modPartPriceField = new System.Windows.Forms.TextBox();
            this.modPartPriceLabel = new System.Windows.Forms.Label();
            this.modPartInStockField = new System.Windows.Forms.TextBox();
            this.modPartInvLabel = new System.Windows.Forms.Label();
            this.modPartNameField = new System.Windows.Forms.TextBox();
            this.modPartNameLabel = new System.Windows.Forms.Label();
            this.modPartIdField = new System.Windows.Forms.TextBox();
            this.modPartIdLabel = new System.Windows.Forms.Label();
            this.modPartRadOutsourced = new System.Windows.Forms.RadioButton();
            this.modPartRadInhouse = new System.Windows.Forms.RadioButton();
            this.modPartLabel = new System.Windows.Forms.Label();
            this.modPartMachIdField = new System.Windows.Forms.TextBox();
            this.modPartMachLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelModPart
            // 
            this.cancelModPart.AutoSize = true;
            this.cancelModPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelModPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelModPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelModPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelModPart.Location = new System.Drawing.Point(333, 409);
            this.cancelModPart.Name = "cancelModPart";
            this.cancelModPart.Size = new System.Drawing.Size(61, 28);
            this.cancelModPart.TabIndex = 43;
            this.cancelModPart.Text = "Cancel";
            this.cancelModPart.UseVisualStyleBackColor = false;
            this.cancelModPart.Click += new System.EventHandler(this.cancelModifyPartClick);
            // 
            // modPartCompField
            // 
            this.modPartCompField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartCompField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartCompField.Location = new System.Drawing.Point(148, 308);
            this.modPartCompField.Name = "modPartCompField";
            this.modPartCompField.Size = new System.Drawing.Size(149, 24);
            this.modPartCompField.TabIndex = 40;
            this.modPartCompField.Visible = false;
            this.modPartCompField.TextChanged += new System.EventHandler(this.modPartCompNameChanged);
            // 
            // modPartCompLabel
            // 
            this.modPartCompLabel.AutoSize = true;
            this.modPartCompLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartCompLabel.Location = new System.Drawing.Point(23, 313);
            this.modPartCompLabel.Name = "modPartCompLabel";
            this.modPartCompLabel.Size = new System.Drawing.Size(105, 16);
            this.modPartCompLabel.TabIndex = 39;
            this.modPartCompLabel.Text = "Company Name";
            this.modPartCompLabel.Visible = false;
            // 
            // saveModPart
            // 
            this.saveModPart.AutoSize = true;
            this.saveModPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveModPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveModPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveModPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveModPart.Location = new System.Drawing.Point(267, 409);
            this.saveModPart.Name = "saveModPart";
            this.saveModPart.Size = new System.Drawing.Size(51, 28);
            this.saveModPart.TabIndex = 42;
            this.saveModPart.Text = "Save";
            this.saveModPart.UseVisualStyleBackColor = false;
            this.saveModPart.Click += new System.EventHandler(this.modSavePartClick);
            // 
            // modPartMinField
            // 
            this.modPartMinField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartMinField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartMinField.Location = new System.Drawing.Point(316, 260);
            this.modPartMinField.Name = "modPartMinField";
            this.modPartMinField.Size = new System.Drawing.Size(78, 24);
            this.modPartMinField.TabIndex = 37;
            this.modPartMinField.TextChanged += new System.EventHandler(this.modPartMinChanged);
            // 
            // modPartMinLabel
            // 
            this.modPartMinLabel.AutoSize = true;
            this.modPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartMinLabel.Location = new System.Drawing.Point(265, 265);
            this.modPartMinLabel.Name = "modPartMinLabel";
            this.modPartMinLabel.Size = new System.Drawing.Size(28, 16);
            this.modPartMinLabel.TabIndex = 36;
            this.modPartMinLabel.Text = "Min";
            // 
            // modPartMaxField
            // 
            this.modPartMaxField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartMaxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartMaxField.Location = new System.Drawing.Point(148, 260);
            this.modPartMaxField.Name = "modPartMaxField";
            this.modPartMaxField.Size = new System.Drawing.Size(78, 24);
            this.modPartMaxField.TabIndex = 35;
            this.modPartMaxField.TextChanged += new System.EventHandler(this.modPartMaxChanged);
            // 
            // modPartMaxLabel
            // 
            this.modPartMaxLabel.AutoSize = true;
            this.modPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartMaxLabel.Location = new System.Drawing.Point(96, 265);
            this.modPartMaxLabel.Name = "modPartMaxLabel";
            this.modPartMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.modPartMaxLabel.TabIndex = 34;
            this.modPartMaxLabel.Text = "Max";
            // 
            // modPartPriceField
            // 
            this.modPartPriceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartPriceField.Location = new System.Drawing.Point(148, 215);
            this.modPartPriceField.Name = "modPartPriceField";
            this.modPartPriceField.Size = new System.Drawing.Size(149, 24);
            this.modPartPriceField.TabIndex = 33;
            this.modPartPriceField.TextChanged += new System.EventHandler(this.modPartPriceChanged);
            // 
            // modPartPriceLabel
            // 
            this.modPartPriceLabel.AutoSize = true;
            this.modPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartPriceLabel.Location = new System.Drawing.Point(53, 220);
            this.modPartPriceLabel.Name = "modPartPriceLabel";
            this.modPartPriceLabel.Size = new System.Drawing.Size(75, 16);
            this.modPartPriceLabel.TabIndex = 32;
            this.modPartPriceLabel.Text = "Price / Cost";
            // 
            // modPartInStockField
            // 
            this.modPartInStockField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartInStockField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartInStockField.Location = new System.Drawing.Point(148, 170);
            this.modPartInStockField.Name = "modPartInStockField";
            this.modPartInStockField.Size = new System.Drawing.Size(149, 24);
            this.modPartInStockField.TabIndex = 31;
            this.modPartInStockField.TextChanged += new System.EventHandler(this.modPartInStockChanged);
            // 
            // modPartInvLabel
            // 
            this.modPartInvLabel.AutoSize = true;
            this.modPartInvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartInvLabel.Location = new System.Drawing.Point(67, 175);
            this.modPartInvLabel.Name = "modPartInvLabel";
            this.modPartInvLabel.Size = new System.Drawing.Size(61, 16);
            this.modPartInvLabel.TabIndex = 30;
            this.modPartInvLabel.Text = "Inventory";
            // 
            // modPartNameField
            // 
            this.modPartNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartNameField.Location = new System.Drawing.Point(148, 128);
            this.modPartNameField.Name = "modPartNameField";
            this.modPartNameField.Size = new System.Drawing.Size(149, 24);
            this.modPartNameField.TabIndex = 29;
            this.modPartNameField.TextChanged += new System.EventHandler(this.modPartNameChanged);
            // 
            // modPartNameLabel
            // 
            this.modPartNameLabel.AutoSize = true;
            this.modPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartNameLabel.Location = new System.Drawing.Point(84, 133);
            this.modPartNameLabel.Name = "modPartNameLabel";
            this.modPartNameLabel.Size = new System.Drawing.Size(44, 16);
            this.modPartNameLabel.TabIndex = 28;
            this.modPartNameLabel.Text = "Name";
            // 
            // modPartIdField
            // 
            this.modPartIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartIdField.Location = new System.Drawing.Point(148, 83);
            this.modPartIdField.Name = "modPartIdField";
            this.modPartIdField.ReadOnly = true;
            this.modPartIdField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modPartIdField.Size = new System.Drawing.Size(149, 24);
            this.modPartIdField.TabIndex = 27;
            // 
            // modPartIdLabel
            // 
            this.modPartIdLabel.AutoSize = true;
            this.modPartIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartIdLabel.Location = new System.Drawing.Point(106, 86);
            this.modPartIdLabel.Name = "modPartIdLabel";
            this.modPartIdLabel.Size = new System.Drawing.Size(22, 18);
            this.modPartIdLabel.TabIndex = 26;
            this.modPartIdLabel.Text = "ID";
            // 
            // modPartRadOutsourced
            // 
            this.modPartRadOutsourced.AutoSize = true;
            this.modPartRadOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartRadOutsourced.Location = new System.Drawing.Point(224, 12);
            this.modPartRadOutsourced.Name = "modPartRadOutsourced";
            this.modPartRadOutsourced.Size = new System.Drawing.Size(94, 20);
            this.modPartRadOutsourced.TabIndex = 25;
            this.modPartRadOutsourced.TabStop = true;
            this.modPartRadOutsourced.Text = "Outsourced";
            this.modPartRadOutsourced.UseVisualStyleBackColor = true;
            this.modPartRadOutsourced.CheckedChanged += new System.EventHandler(this.modifyPartCatOutCheckedChanged);
            // 
            // modPartRadInhouse
            // 
            this.modPartRadInhouse.AutoSize = true;
            this.modPartRadInhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartRadInhouse.Location = new System.Drawing.Point(122, 12);
            this.modPartRadInhouse.Name = "modPartRadInhouse";
            this.modPartRadInhouse.Size = new System.Drawing.Size(79, 20);
            this.modPartRadInhouse.TabIndex = 24;
            this.modPartRadInhouse.TabStop = true;
            this.modPartRadInhouse.Text = "In-House";
            this.modPartRadInhouse.UseVisualStyleBackColor = true;
            this.modPartRadInhouse.CheckedChanged += new System.EventHandler(this.modifyPartCatInHouseCheckedChanged);
            // 
            // modPartLabel
            // 
            this.modPartLabel.AutoSize = true;
            this.modPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modPartLabel.Name = "modPartLabel";
            this.modPartLabel.Size = new System.Drawing.Size(74, 16);
            this.modPartLabel.TabIndex = 23;
            this.modPartLabel.Text = "Modify Part";
            // 
            // modPartMachIdField
            // 
            this.modPartMachIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartMachIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartMachIdField.Location = new System.Drawing.Point(148, 308);
            this.modPartMachIdField.Name = "modPartMachIdField";
            this.modPartMachIdField.Size = new System.Drawing.Size(149, 24);
            this.modPartMachIdField.TabIndex = 41;
            this.modPartMachIdField.Visible = false;
            this.modPartMachIdField.TextChanged += new System.EventHandler(this.modPartMachIdFieldChanged);
            // 
            // modPartMachLabel
            // 
            this.modPartMachLabel.AutoSize = true;
            this.modPartMachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartMachLabel.Location = new System.Drawing.Point(53, 313);
            this.modPartMachLabel.Name = "modPartMachLabel";
            this.modPartMachLabel.Size = new System.Drawing.Size(74, 16);
            this.modPartMachLabel.TabIndex = 38;
            this.modPartMachLabel.Text = "Machine ID";
            this.modPartMachLabel.Visible = false;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 466);
            this.Controls.Add(this.modPartMachLabel);
            this.Controls.Add(this.modPartMachIdField);
            this.Controls.Add(this.cancelModPart);
            this.Controls.Add(this.modPartCompField);
            this.Controls.Add(this.modPartCompLabel);
            this.Controls.Add(this.saveModPart);
            this.Controls.Add(this.modPartMinField);
            this.Controls.Add(this.modPartMinLabel);
            this.Controls.Add(this.modPartMaxField);
            this.Controls.Add(this.modPartMaxLabel);
            this.Controls.Add(this.modPartPriceField);
            this.Controls.Add(this.modPartPriceLabel);
            this.Controls.Add(this.modPartInStockField);
            this.Controls.Add(this.modPartInvLabel);
            this.Controls.Add(this.modPartNameField);
            this.Controls.Add(this.modPartNameLabel);
            this.Controls.Add(this.modPartIdField);
            this.Controls.Add(this.modPartIdLabel);
            this.Controls.Add(this.modPartRadOutsourced);
            this.Controls.Add(this.modPartRadInhouse);
            this.Controls.Add(this.modPartLabel);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelModPart;
        private System.Windows.Forms.TextBox modPartCompField;
        private System.Windows.Forms.Label modPartCompLabel;
        private System.Windows.Forms.Button saveModPart;
        private System.Windows.Forms.TextBox modPartMinField;
        private System.Windows.Forms.Label modPartMinLabel;
        private System.Windows.Forms.TextBox modPartMaxField;
        private System.Windows.Forms.Label modPartMaxLabel;
        private System.Windows.Forms.TextBox modPartPriceField;
        private System.Windows.Forms.Label modPartPriceLabel;
        private System.Windows.Forms.TextBox modPartInStockField;
        private System.Windows.Forms.Label modPartInvLabel;
        private System.Windows.Forms.TextBox modPartNameField;
        private System.Windows.Forms.Label modPartNameLabel;
        private System.Windows.Forms.TextBox modPartIdField;
        private System.Windows.Forms.Label modPartIdLabel;
        private System.Windows.Forms.RadioButton modPartRadOutsourced;
        private System.Windows.Forms.RadioButton modPartRadInhouse;
        private System.Windows.Forms.Label modPartLabel;
        private System.Windows.Forms.TextBox modPartMachIdField;
        private System.Windows.Forms.Label modPartMachLabel;
    }
}