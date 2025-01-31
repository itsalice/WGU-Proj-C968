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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            // load data
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;

            // select whole row
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // make cell read-only
            dgvParts.ReadOnly = true;
            dgvProducts.ReadOnly = true;

            // disallow multi selection
            dgvParts.MultiSelect = false;
            dgvProducts.MultiSelect = false;

            // disallow users to add rows
            dgvParts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToAddRows = false;

            // hide first column
            dgvParts.RowHeadersVisible = false;
            dgvProducts.RowHeadersVisible = false;

            // disable modify part and product button
            modifyPart.Enabled = false;
            modifyProduct.Enabled = false;

            // disable delete part and product button
            deletePart.Enabled = false;
            deleteProduct.Enabled = false;

            if (dgvParts.Rows.Count > 0) {
                modifyPart.Enabled = true;
                deletePart.Enabled = true;
            }

            if (dgvProducts.Rows.Count > 0) {
                modifyProduct.Enabled = true;
                deleteProduct.Enabled = true;
            }
        }

        private void dgvParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }

        // add part/product form
        private AddPart addPartForm;
        private AddProduct addProductForm;

        // modify part/product form
        private ModifyPart modifyPartForm;
        private ModifyProduct modifyProductForm;

        // add part
        private void addPartClick(object sender, EventArgs e)
        {
            addPartForm = new AddPart();
            addPartForm.Show();
            Hide();
        }

        // add product
        private void addProductClick(object sender, EventArgs e)
        {
            addProductForm = new AddProduct();
            addProductForm.Show();
            Hide();
        }

        // modify part
        private void modifyPartClick(object sender, EventArgs e)
        {
            Inventory.CurrPart = dgvParts.CurrentRow.DataBoundItem as Part;

            modifyPartForm = new ModifyPart();
            modifyPartForm.Show();
            Hide();
        }

        private void modifyProductClick(object sender, EventArgs e)
        {
            Inventory.CurrProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

            modifyProductForm = new ModifyProduct();
            modifyProductForm.Show();
            Hide();
        }

        // delete part
        private void deletePartClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this part?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Inventory.CurrPart = dgvParts.CurrentRow.DataBoundItem as Part;
                Inventory.deletePart(Inventory.CurrPart.PartID);
            }

            modifyPart.Enabled = false;
            deletePart.Enabled = false;

            if (dgvParts.Rows.Count > 0)
            {
                modifyPart.Enabled = true;
                deletePart.Enabled = true;
            }
        }

        // delete product
        private void deleteProductClick(object sender, EventArgs e)
        {
            Inventory.CurrProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

            if (Inventory.CurrProduct.AssociatedParts.Count > 0) {
                MessageBox.Show("Can't remove this product because there are parts assigned to it.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this product?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.removeProduct(Inventory.CurrProduct.ProductID);
                }
            }

            modifyProduct.Enabled = false;
            deleteProduct.Enabled = false;

            if (dgvProducts.Rows.Count > 0)
            {
                modifyProduct.Enabled = true;
                deleteProduct.Enabled = true;
            }
        }

        // search parts
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

            if (!searchResult) {
                MessageBox.Show("The part could not be found.");
            }
        }

        // search products
        private void searchProductsBtnClick(object sender, EventArgs e)
        {
            string searchVal = searchProductField.Text.ToLower();
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bool searchResult = false;
            foreach (DataGridViewColumn col in dgvProducts.Columns)
            {
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (searchVal != "" && (searchVal == row.Cells["ProductID"].Value.ToString().ToLower() || System.Text.RegularExpressions.Regex.IsMatch(row.Cells["Name"].Value.ToString(), searchVal, System.Text.RegularExpressions.RegexOptions.IgnoreCase)))
                    {
                        dgvProducts.ClearSelection();
                        int rowIndex = row.Index;
                        dgvProducts.Rows[rowIndex].Selected = true;
                        searchResult = true;
                    }
                }
            }

            if (!searchResult)
            {
                MessageBox.Show("The product could not be found.");
            }
        }

        // exit application
        private void exitAppClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
