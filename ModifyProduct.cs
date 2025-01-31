using AliceLyC968.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliceLyC968
{
    public partial class ModifyProduct : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        
        // new binding list for associated parts
        BindingList<Part> addedParts = new BindingList<Part>();

        public ModifyProduct()
        {
            InitializeComponent();

            // load data in all parts table
            var allPartsTable = new BindingSource();
            allPartsTable.DataSource = Inventory.AllParts;
            dgvParts.DataSource = allPartsTable;

            // load current product values
            Product CurrentProduct = Inventory.CurrProduct;
            modProductIdField.Text = CurrentProduct.ProductID.ToString();
            modProductNameField.Text = CurrentProduct.Name.ToString();
            modProductInStockField.Text = CurrentProduct.InStock.ToString();
            modProductPriceField.Text = CurrentProduct.Price.ToString();
            modProductMaxField.Text = CurrentProduct.Max.ToString();
            modProductMinField.Text = CurrentProduct.Min.ToString();

            // load data for the current product in associated parts table
            addedParts = Inventory.CurrProduct.AssociatedParts;
            dgvAssociatedParts.DataSource = addedParts;

            // select whole row
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // make cell read-only
            dgvParts.ReadOnly = true;
            dgvAssociatedParts.ReadOnly = true;

            // disallow multi selection
            dgvParts.MultiSelect = false;
            dgvAssociatedParts.MultiSelect = false;

            // disallow users to add rows
            dgvParts.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToAddRows = false;

            // hide first column
            dgvParts.RowHeadersVisible = false;
            dgvAssociatedParts.RowHeadersVisible = false;

            // disable buttons if parts and associated parts tables are empty
            addAssociatedParts.Enabled = false;
            delAssociatedParts.Enabled = false;

            if (dgvParts.Rows.Count > 0)
            {
                addAssociatedParts.Enabled = true;
            }

            if (dgvAssociatedParts.Rows.Count > 0)
            {
                delAssociatedParts.Enabled = true;
            }

            modProductIdField.Enabled = false;
            validateFields();
            saveModifyProduct.Enabled = false;
        }

        private void modProductNameChanged(object sender, EventArgs e)
        {
            saveModifyProduct.Enabled = validateFields();
        }

        private void modProductInStockChanged(object sender, EventArgs e)
        {
            saveModifyProduct.Enabled = validateFields();
        }

        private void modProductPriceChanged(object sender, EventArgs e)
        {
            saveModifyProduct.Enabled = validateFields();
        }

        private void modProductMaxChanged(object sender, EventArgs e)
        {
            saveModifyProduct.Enabled = validateFields();
        }

        private void modProductMinChanged(object sender, EventArgs e)
        {
            saveModifyProduct.Enabled = validateFields();
        }

        private bool validateFields()
        {
            bool isValid = true;
            decimal price;
            int inStock, max, min;

            if (string.IsNullOrEmpty(modProductNameField.Text))
            {
                modProductNameField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modProductNameField, "Please enter a name.");
                isValid = false;
            }
            else
            {
                modProductNameField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modProductNameField, "");
            }

            if (!Int32.TryParse(modProductInStockField.Text, out inStock))
            {
                modProductInStockField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modProductInStockField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                modProductInStockField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modProductInStockField, "");
            }

            if (!Decimal.TryParse(modProductPriceField.Text, out price))
            {
                modProductPriceField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modProductPriceField, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                modProductPriceField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modProductPriceField, "");
            }

            if (!Int32.TryParse(modProductMaxField.Text, out max))
            {
                modProductMaxField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modProductMaxField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                modProductMaxField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modProductMaxField, "");
            }

            if (!Int32.TryParse(modProductMinField.Text, out min))
            {
                modProductMinField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modProductMinField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                modProductMinField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modProductMinField, "");
            }

            return isValid;
        }

        private void addAssociatedPartsClick(object sender, EventArgs e)
        {
            addedParts.Add(dgvParts.CurrentRow.DataBoundItem as Part);

            delAssociatedParts.Enabled = true;
            saveModifyProduct.Enabled = true;
        }

        private void delAssociatedPartsClick(object sender, EventArgs e)
        {
            Part removedPart = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;
            Product product = Inventory.lookupProduct(Int32.Parse(modProductIdField.Text));
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this part?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                addedParts.Remove(removedPart);
                product.removeAssociatedPart(removedPart.PartID);
            }

            delAssociatedParts.Enabled = false;

            if (dgvAssociatedParts.Rows.Count > 0)
            {
                delAssociatedParts.Enabled = true;
            }

            saveModifyProduct.Enabled = true;
        }

        private void searchPartsBtnClick(object sender, EventArgs e)
        {
            string searchVal = searchPartsField.Text.ToLower();
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bool searchResult = false;
            foreach (DataGridViewColumn col in dgvParts.Columns)
            {
                foreach (DataGridViewRow row in dgvParts.Rows)
                {
                    if (searchVal != "" && (searchVal == row.Cells["PartID"].Value.ToString().ToLower() || System.Text.RegularExpressions.Regex.IsMatch(row.Cells["Name"].Value.ToString(), searchVal, System.Text.RegularExpressions.RegexOptions.IgnoreCase)))
                    {
                        dgvParts.ClearSelection();
                        int rowIndex = row.Index;
                        dgvParts.Rows[rowIndex].Selected = true;
                        searchResult = true;
                    }
                }
            }

            if (!searchResult)
            {
                MessageBox.Show("The part could not be found.");
            }
        }

        private void saveModifyProductClick(object sender, EventArgs e)
        {
            int productId = Int32.Parse(modProductIdField.Text);
            string name = modProductNameField.Text;
            decimal price = Decimal.Parse(modProductPriceField.Text);
            int inStock = Int32.Parse(modProductInStockField.Text);
            int min = Int32.Parse(modProductMinField.Text);
            int max = Int32.Parse(modProductMaxField.Text);
            Product product = Inventory.lookupProduct(Int32.Parse(modProductIdField.Text));

            if (min > max)
            {
                MessageBox.Show("The max must be higher than the min.");
            }
            else if (inStock > max || inStock < min)
            {
                MessageBox.Show("The inventory is outside of the min/max range.");
            }
            else
            {
                Inventory.updateProduct(productId, new Product(productId, name, price, inStock, min, max));

                foreach (Part part in addedParts) {
                    product.addAssociatedPart(part);
                }

                MainScreen mainForm = new MainScreen();
                mainForm.Show();
                Close();
            }
        }

        private void cancelModifyProductClick(object sender, EventArgs e)
        {
            MainScreen mainForm = new MainScreen();
            mainForm.Show();
            Close();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
