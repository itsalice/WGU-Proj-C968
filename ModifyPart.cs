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
using System.Xml.Linq;

namespace AliceLyC968
{
    public partial class ModifyPart : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public ModifyPart()
        {
            InitializeComponent();

            // load current part values
            Part CurrentPart = Inventory.CurrPart;
            modPartIdField.Text = CurrentPart.PartID.ToString();
            modPartNameField.Text = CurrentPart.Name.ToString();
            modPartInStockField.Text = CurrentPart.InStock.ToString();
            modPartPriceField.Text = CurrentPart.Price.ToString();
            modPartMaxField.Text = CurrentPart.Max.ToString();
            modPartMinField.Text = CurrentPart.Min.ToString();
            
            // check if in house or outsourced
            if (CurrentPart is Inhouse)
            {
                modPartRadInhouse.Checked = true;
                modPartMachIdField.Text = ((Inhouse)CurrentPart).MachineID.ToString();
            }
            else
            {
                modPartRadOutsourced.Checked = true;
                modPartCompField.Text = ((Outsourced)CurrentPart).CompanyName.ToString();
            }

            modPartIdField.Enabled = false;
            validateFields();
            saveModPart.Enabled = false;
        }

        private void modifyPartCatInHouseCheckedChanged(object sender, EventArgs e)
        {
            if (modPartRadInhouse.Checked)
            {
                modPartMachLabel.Show();
                modPartMachIdField.Show();
                modPartCompLabel.Hide();
                modPartCompField.Hide();
            }

            saveModPart.Enabled = validateFields();
        }

        private void modifyPartCatOutCheckedChanged(object sender, EventArgs e)
        {
            if (modPartRadOutsourced.Checked)
            {
                modPartCompLabel.Show();
                modPartCompField.Show();
                modPartMachLabel.Hide();
                modPartMachIdField.Hide();
            }

            saveModPart.Enabled = validateFields();
        }
        private void modSavePartClick(object sender, EventArgs e)
        {
            int id;
            id = Inventory.CurrPart.PartID;
            Inventory.deletePart(id);

            string name = modPartNameField.Text;
            decimal price = decimal.Parse(modPartPriceField.Text);
            int inStock = int.Parse(modPartInStockField.Text);
            int min = int.Parse(modPartMinField.Text);
            int max = int.Parse(modPartMaxField.Text);

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
                if (modPartRadInhouse.Checked)
                {
                    int machineId = int.Parse(modPartMachIdField.Text);
                    Inventory.updatePart(id, new Inhouse(id, name, price, inStock, min, max, machineId));
                }
                else
                {
                    string companyName = modPartCompField.Text;
                    Inventory.updatePart(id, new Outsourced(id, name, price, inStock, min, max, companyName));
                }

                MainScreen mainForm = new MainScreen();
                mainForm.Show();
                Close();
            }
        }

        private void modPartNameChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private void modPartInStockChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private void modPartPriceChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private void modPartMaxChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private void modPartMinChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private void modPartMachIdFieldChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private void modPartCompNameChanged(object sender, EventArgs e)
        {
            saveModPart.Enabled = validateFields();
        }

        private bool validateFields()
        {
            bool isValid = true;
            decimal price;
            int inStock, max, min, machineId;

            if (string.IsNullOrEmpty(modPartNameField.Text)) {
                modPartNameField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modPartNameField, "Please enter a name.");
                isValid = false;
            }
            else
            {
                modPartNameField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modPartNameField, "");
            }

            if (!Int32.TryParse(modPartInStockField.Text, out inStock))
            {
                modPartInStockField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modPartInStockField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                modPartInStockField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modPartInStockField, "");
            }

            if (!Decimal.TryParse(modPartPriceField.Text, out price))
            {
                modPartPriceField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modPartPriceField, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                modPartPriceField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modPartPriceField, "");
            }

            if (!Int32.TryParse(modPartMaxField.Text, out max))
            {
                modPartMaxField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modPartMaxField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                modPartMaxField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modPartMaxField, "");
            }

            if (!Int32.TryParse(modPartMinField.Text, out min))
            {
                modPartMinField.BackColor = System.Drawing.Color.Salmon;
                errorProvider.SetError(modPartMinField, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                modPartMinField.BackColor = System.Drawing.Color.White;
                errorProvider.SetError(modPartMinField, "");
            }

            if (modPartRadInhouse.Checked)
            {
                if(!Int32.TryParse(modPartMachIdField.Text, out machineId))
                {
                    modPartMachIdField.BackColor = System.Drawing.Color.Salmon;
                    errorProvider.SetError(modPartMachIdField, "Please enter a valid id.");
                    isValid = false;
                }
                else
                {
                    modPartMachIdField.BackColor = System.Drawing.Color.White;
                    errorProvider.SetError(modPartMachIdField, "");
                }
            }
            else if (modPartRadOutsourced.Checked)
            {
                if (string.IsNullOrEmpty(modPartCompField.Text))
                {
                    modPartCompField.BackColor = System.Drawing.Color.Salmon;
                    errorProvider.SetError(modPartCompField, "Please enter a company name.");
                    isValid = false;
                }
                else
                {
                    modPartCompField.BackColor = System.Drawing.Color.White;
                    errorProvider.SetError(modPartCompField, "");
                }
            }

            return isValid;
        }

        private void cancelModifyPartClick(object sender, EventArgs e)
        {
            MainScreen mainForm = new MainScreen();
            mainForm.Show();
            Close();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
        }
    }
}
