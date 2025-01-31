using AliceLyC968.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AliceLyC968
{
    public partial class AddPart : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public AddPart()
        {
            InitializeComponent();

            // variable to set new id
            int partId = 0;

            // new list for existing ids
            var existingIds = new List<int>();

            // get existing parts' id and store it in existingIds
            foreach (var part in Inventory.AllParts)
            {
                existingIds.Add(part.PartID);
            }

            // while partIds equals existingIds increment by 1
            foreach (var id in existingIds) {
                while (partId == id)
                {
                    partId++;
                }
            }

            // new id is in PartId field
            addPartIdField.Text = partId.ToString();

            addPartIdField.Enabled = false;
            validateFields();
            saveAddPart.Enabled = false;
        }

        private void addPartCatInHouseCheckedChanged(object sender, EventArgs e)
        {
            if (addPartRadInhouse.Checked)
            {
                addPartMachLabel.Show();
                addPartMachIdField.Show();
                addPartCompLabel.Hide();
                addPartCompField.Hide();
            }

            saveAddPart.Enabled = validateFields();
        }

        private void addPartCatOutCheckedChanged(object sender, EventArgs e)
        {
            if (addPartRadOutsourced.Checked) {
                addPartCompLabel.Show();
                addPartCompField.Show();
                addPartMachLabel.Hide();
                addPartMachIdField.Hide();
            }

            saveAddPart.Enabled = validateFields();
        }

        private void addPartNameChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private void addPartInStockChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private void addPartPriceChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private void addPartMaxChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private void addPartMinChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private void addPartMachIdFieldChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private void addPartCompNameChanged(object sender, EventArgs e)
        {
            saveAddPart.Enabled = validateFields();
        }

        private bool validateFields()
        {
            bool isValid = true;
            decimal price;
            int inStock, max, min, machineId;

            if (string.IsNullOrEmpty(addPartNameField.Text))
            {
                addPartNameField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addPartNameField, "Please enter a name.");
                isValid = false;
            }
            else
            {
                addPartNameField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addPartNameField, "");
            }

            if (!Int32.TryParse(addPartInStockField.Text, out inStock))
            {
                addPartInStockField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addPartInStockField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                addPartInStockField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addPartInStockField, "");
            }

            if (!Decimal.TryParse(addPartPriceField.Text, out price))
            {
                addPartPriceField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addPartPriceField, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                addPartPriceField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addPartPriceField, "");
            }

            if (!Int32.TryParse(addPartMaxField.Text, out max))
            {
                addPartMaxField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addPartMaxField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                addPartMaxField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addPartMaxField, "");
            }

            if (!Int32.TryParse(addPartMinField.Text, out min))
            {
                addPartMinField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(addPartMinField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                addPartMinField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(addPartMinField, "");
            }

            if (addPartRadInhouse.Checked)
            {
                if (!Int32.TryParse(addPartMachIdField.Text, out machineId))
                {
                    addPartMachIdField.BackColor = System.Drawing.Color.Salmon;
                    errorProvider.SetError(addPartMachIdField, "Please enter a valid id.");
                    isValid = false;
                }
                else
                {
                    addPartMachIdField.BackColor = System.Drawing.Color.White;
                    errorProvider.SetError(addPartMachIdField, "");
                }
            }
            else if (addPartRadOutsourced.Checked)
            {
                if (string.IsNullOrEmpty(addPartCompField.Text))
                {
                    addPartCompField.BackColor = System.Drawing.Color.Salmon;
                    errorProvider.SetError(addPartCompField, "Please enter a company name.");
                    isValid = false;
                }
                else
                {
                    addPartCompField.BackColor = System.Drawing.Color.White;
                    errorProvider.SetError(addPartCompField, "");
                }
            }

            return isValid;
        }

        private void saveAddPartClick(object sender, EventArgs e)
        {
            int partId = Int32.Parse(addPartIdField.Text);
            string name = addPartNameField.Text;
            decimal price = Decimal.Parse(addPartPriceField.Text);
            int inStock = Int32.Parse(addPartInStockField.Text);
            int min = Int32.Parse(addPartMinField.Text);
            int max = Int32.Parse(addPartMaxField.Text);

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
                if (addPartRadInhouse.Checked)
                {
                    int machineID = Int32.Parse(addPartMachIdField.Text);
                    Inventory.addPart(new Inhouse(partId, name, price, inStock, min, max, machineID));
                }
                else if (addPartRadOutsourced.Checked)
                {
                    string companyName = addPartCompField.Text;
                    Inventory.addPart(new Outsourced(partId, name, price, inStock, min, max, companyName));
                }

                MainScreen mainForm = new MainScreen();
                mainForm.Show();
                Close();
            }
        }

        private void cancelAddPartClick(object sender, EventArgs e)
        {
            MainScreen mainForm = new MainScreen();
            mainForm.Show();
            Close();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }
    }
}
