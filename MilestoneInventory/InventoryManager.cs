/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * Date: 4/2/2022
 * File: InventoryManager
 * This is my own work.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneInventory
{
    internal class InventoryManager
    {
        /// <summary>
        /// Search Function
        /// </summary>
        /// <param name="nameSearch"></param>
        /// <param name="idSearch"></param>
        /// <param name="vans"></param>
        /// <param name="gvSearchInventory"></param>
        public void SearchFunction(string nameSearch, int idSearch, Vans[] vans, DataGridView gvSearchInventory)
        {
            foreach (Vans van in vans)
            {
                if ((van.InventoryProduct == nameSearch) || (van.ProductID == idSearch))
                {
                    Vans[] shoe = new Vans[1];
                    shoe[0] = vans[van.ProductID - 1];

                    gvSearchInventory.DataSource = shoe;
                    gvSearchInventory.Update();
                    gvSearchInventory.Refresh();

                    break;
                }
            }
        }

        /// <summary>
        /// Remove Function at Index
        /// </summary>
        /// <param name="vansInvArr"></param>
        /// <param name="gvInventory"></param>
        /// <param name="index"></param>
        public void RemoveFunction(Vans[] vansInvArr, DataGridView gvInventory, int index)
        {
            vansInvArr[index] = new Vans(false, "", "", 0, 0.00, "", "", 0);
            gvInventory.Update();
            gvInventory.Refresh();
        }

        /// <summary>
        /// Displays Items
        /// </summary>
        /// <param name="gvInventory"></param>
        /// <param name="vans"></param>
        public void DisplayItems(DataGridView gvInventory, Vans[] vans)
        {
            gvInventory.DataSource = vans;
        }

        /// <summary>
        /// Adds Items from an Array to a GridView
        /// </summary>
        /// <param name="inventoryProduct"></param>
        /// <param name="inventoryWear"></param>
        /// <param name="inventoryBrand"></param>
        /// <param name="fit"></param>
        /// <param name="isAvailable"></param>
        /// <param name="inventoryQuantity"></param>
        /// <param name="inventoryCost"></param>
        /// <param name="productID"></param>
        /// <param name="vansInvArr"></param>
        /// <param name="gvInventory"></param>
        public void AddItems(string inventoryProduct, string inventoryWear, string inventoryBrand, string fit, bool isAvailable,
            int inventoryQuantity, double inventoryCost, int productID, Vans[] vansInvArr, DataGridView gvInventory)
        {

            vansInvArr[productID - 1] = new Vans(isAvailable, fit, inventoryProduct, inventoryQuantity, inventoryCost,
                inventoryWear, inventoryBrand, productID);

            gvInventory.Update();
            gvInventory.Refresh();
        }

        /// <summary>
        /// Restocks Items by Adding Quantity to Item
        /// </summary>
        /// <param name="vansInvArr"></param>
        /// <param name="gvInventory"></param>
        public void RestockItems(Vans[] vansInvArr, DataGridView gvInventory)
        {
            int rowIndex = gvInventory.CurrentCell.RowIndex;

            vansInvArr[rowIndex].ProductQuantity += 1;

            gvInventory.Update();
            gvInventory.Refresh();
        }

    }
}
