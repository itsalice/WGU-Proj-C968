using AliceLyC968.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliceLyC968
{
    public partial class AddProduct : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        // new binding list for associated parts
        BindingList<Part> addedParts = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();

            // load data in all parts table
            var allPartsTable = new BindingSource();
            allPartsTable.DataSource = Inventory.AllParts;
            dgvParts.DataSource = allPartsTable;

            // load data in associated parts table
            var associatedPartsTable = new BindingSource();
            associatedPartsTable.DataSource = addedParts;
            dgvAssociatedParts.DataSource = associatedPartsTable;

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

            // to store new product ID
            int productId = 0;

            // new list for existing ids
            var existingIds = new List<int>();

            // get existing products' id and store it in existingIds
            foreach (var product in Inventory.Products)
            {
                existingIds.Add(product.ProductID);
            }

            // while partIds equals existingIds increment by 1
            foreach (var id in existingIds)
            {
                while (productId == id)
                {
                    productId++;
                }
            }

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

            // output new product ID
            addProductIdField.Text = productId.ToString();

            addProductIdField.Enabled = false;
            validateFields();
            saveAddProduct.Enabled = false;
        }

        private void dgvParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void addProductNameChanged(object sender, EventArgs e)
        {
            saveAddProduct.Enabled = validateFields();
        }

        private void addProductInStockChanged(object sender, EventArgs e)
        {
            saveAddProduct.Enabled = validateFields();
        }

        private void addProductPriceChanged(object sender, EventArgs e)
        {
            saveAddProduct.Enabled = validateFields();
        }

        private void addProductMaxChanged(object sender, EventArgs e)
        {
            saveAddProduct.Enabled = validateFields();
        }

        private void addProductMinChanged(object sender, EventArgs e)
        {
            saveAddProduct.Enabled = validateFields();
        }

        private bool validateFields()
        {
            bool isValid = true;
            decimal price;
            int inStock, max, min;

            if (string.IsNullOrEmpty(addProductNameField.Text))
            {
                addProductNameField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addProductNameField, "Please enter a name.");
                isValid = false;
            }
            else
            {
                addProductNameField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addProductNameField, "");
            }

            if (!Int32.TryParse(addProductInStockField.Text, out inStock))
            {
                addProductInStockField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addProductInStockField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                addProductInStockField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addProductInStockField, "");
            }

            if (!Decimal.TryParse(addProductPriceField.Text, out price))
            {
                addProductPriceField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addProductPriceField, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                addProductPriceField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addProductPriceField, "");
            }

            if (!Int32.TryParse(addProductMaxField.Text, out max))
            {
                addProductMaxField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addProductMaxField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                addProductMaxField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addProductMaxField, "");
            }

            if (!Int32.TryParse(addProductMinField.Text, out min))
            {
                addProductMinField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addProductMinField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                addProductMinField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addProductMinField, "");
            }

            return isValid;
        }

        private void saveAddProductClick(object sender, EventArgs e)
        {
            int productId = Int32.Parse(addProductIdField.Text);
            string name = addProductNameField.Text;
            decimal price = Decimal.Parse(addProductPriceField.Text);
            int inStock = Int32.Parse(addProductInStockField.Text);
            int min = Int32.Parse(addProductMinField.Text);
            int max = Int32.Parse(addProductMaxField.Text);

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
                Inventory.addProduct(new Product(productId, name, price, inStock, min, max));

                Product product = Inventory.lookupProduct(productId);

                foreach (Part part in addedParts)
                {
                    product.addAssociatedPart(part);
                }

                MainScreen mainForm = new MainScreen();
                mainForm.Show();
                Close();
            }
        }

        private void addAssociatedPartsClick(object sender, EventArgs e)
        {
            addedParts.Add(dgvParts.CurrentRow.DataBoundItem as Part);

            delAssociatedParts.Enabled = true;
        }

        private void delAssociatedPartsClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this part?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                addedParts.Remove(dgvAssociatedParts.CurrentRow.DataBoundItem as Part);
            }

            delAssociatedParts.Enabled = false;

            if (dgvAssociatedParts.Rows.Count > 0)
            {
                delAssociatedParts.Enabled = true;
            }
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

        private void cancelAddProductClick(object sender, EventArgs e)
        {
            MainScreen mainForm = new MainScreen();
            mainForm.Show();
            Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
