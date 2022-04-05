/*
 * Name: Karsten Hedrick
 * Professor: William Hughes
 * Class: CST-150
 * File: Inventory Class
 * Date: 2/28/2022
 * This is my own work.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneInventory
{
    public partial class Inventory : Form
    {
        InventoryManager invMng = new InventoryManager();
        Vans[] vansInvArr = new Vans[10];
        // Nike[] nikeInvArr = new Nike[10];
        public Inventory()
        {
            InitializeComponent();
            btnItemDetails.Visible = false;

            vansInvArr[0] = new Vans(true, "SlipOns", "White Shoes", 3, 60.00, "New", "Vans", 1);
            vansInvArr[1] = new Vans(true, "SlipOns", "Black Shoes", 2, 60.00, "New", "Vans", 2);
            vansInvArr[2] = new Vans(true, "Laced", "Grey Shoes", 5, 60.00, "Worn", "Vans", 3);

            // Displays the items by using Inventory Manager Class Function

            invMng.DisplayItems(gvInventory, vansInvArr);
        }

        // Add item to Array
        public void AddItemToArray(string inventoryProduct, string inventoryWear, string inventoryBrand, string fit, bool isAvailable,
            int inventoryQuantity,double inventoryCost,int productID)
        {
            // From Inventory Manager Class
            invMng.AddItems(inventoryProduct, inventoryWear, inventoryBrand, fit, isAvailable, 
                inventoryQuantity, inventoryCost, productID, vansInvArr, gvInventory);
        }

        // Removes the items by calling Inventory Manager Class Function
        public void RemoveItemToArray(int index)
        {
            // From Inventory Manager Class
            invMng.RemoveFunction(vansInvArr, gvInventory, index);
        }


        //--------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------

        /// Inventory to Homepage Button
        private void InvToHPButtonClickEvent(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        /// Inventory to Edit Button
        private void InvToEditButtonClickEvent(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
        }

        // Inventory to Search Button
        private void InvToSrchButtonClickEvent(object sender, EventArgs e)
        {
            Search search = new Search();
            search.TakeThis(vansInvArr);
            search.Show();
            this.Hide();
        }

        // Inventory to Add Button
        private void InvToAddButtonClickEvent(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        // Inventory to Remove Button
        private void InvToRmvButtonClickEvent(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            remove.TakeThis(vansInvArr);
            remove.Show();
            this.Hide();
        }

        private void InvToDetailsButtonClickEvent(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            this.Hide();
        }

        // Restocks Items by using Inventory Manager Function
        private void BtnRestockClickEvent(object sender, EventArgs e)
        {
            // Adds +1 Quantity to Selected Item
            invMng.RestockItems(vansInvArr, gvInventory);
        }
    }
}
