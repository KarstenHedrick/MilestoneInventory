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
        Shoes shoes = new Shoes();
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
            string inventoryWear = lstAddWear.Text;
            string inventoryBrand = txtAddBrand.Text;
            int inventoryQuantity;
            double inventoryCost;
            int productID;

            // Flag statement
            bool isSuccessful = true;

            // Try Catch Conversions
            try
            {
                inventoryQuantity = Convert.ToInt32(txtAddQuantity.Text);
                inventoryCost = Convert.ToDouble(txtAddCost.Text);
                productID = Convert.ToInt32(txtAddID.Text);
            }
            catch (Exception)
            {
                lblError.Visible = true;
                isSuccessful = false;
            }

            if (isSuccessful)
            {
                inventoryQuantity = Convert.ToInt32(txtAddQuantity.Text);
                inventoryCost = Convert.ToDouble(txtAddCost.Text);
                productID = Convert.ToInt32(txtAddID.Text);

                ProductQuantity = inventoryQuantity;
                lblError.Visible = false;

                InventoryClass product = new InventoryClass();
                Shoes s = new Shoes();
                product.Product(inventoryProduct, inventoryQuantity, inventoryCost, inventoryWear, inventoryBrand, productID);

                //s.ToString(inventoryProduct, inventoryQuantity, inventoryCost, inventoryWear, inventoryBrand, productID);

               // s.ShoesList.Add(inventoryProduct);

                

                // Add to inventory page
                Inventory inventory = new Inventory();
                inventory.AddListedItem(inventoryProduct);

                inventory.Show();
                this.Hide();
            }
        }
    }
}
