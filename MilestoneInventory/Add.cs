/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * File: Add Class
 * Date: 2/26/2022
 * This is my own work.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneInventory
{
    public partial class Add : Form
    {
        public int ProductQuantity { get ; set; }

        public Add()
        {
            InitializeComponent();
            lblError.Visible = false;
        }


        //--------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------

        // Add to Homepage Button
        private void AddToHPButtonClickEvent(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void BtnAddItemClickEvent(object sender, EventArgs e)
        {
            // Declare Variables
            string inventoryProduct = txtAddName.Text;
            string inventoryWear = lstAddWear.GetItemText(lstAddWear.SelectedItem);
            string inventoryBrand = txtAddBrand.Text;
            string fit = txtField2.Text;
            bool isAvailable = false;
            int inventoryQuantity = 0;
            double inventoryCost = 0.00;
            int productID = 0;

            // Flag statement
            bool isSuccessful = true;

            // Try Catch Conversions
            try
            {
                inventoryQuantity = Convert.ToInt32(txtAddQuantity.Text);
                inventoryCost = Convert.ToDouble(txtAddCost.Text);
                productID = Convert.ToInt32(txtAddID.Text);
                isAvailable = Convert.ToBoolean(txtField1.Text);
            }
            catch (Exception)
            {
                lblError.Visible = true;
                isSuccessful = false;
            }

            if (isSuccessful)
            {

                ProductQuantity = inventoryQuantity;
                lblError.Visible = false;

                // Add to inventory page
                Inventory inventory = new Inventory();

                inventory.AddItemToArray(inventoryProduct, inventoryWear, inventoryBrand, fit, isAvailable,
                inventoryQuantity, inventoryCost, productID);

                inventory.Show();
                this.Hide();
            }


        }
    }
}
