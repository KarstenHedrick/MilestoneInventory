using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneInventory
{
    class Shoes
    {
        public string ProductDetails { get; set; }
        public string ToString(string inventoryProduct, int productQuantity, double productCost, string productCondition, string productBrand, int productID)
        {
            string details = "Name: " + inventoryProduct + " Quantity: " + productQuantity + " \n\nCost: " + productCost +
                " Condition: " + productCondition + "\n\nBrand: " + productBrand + " ID: " + productID;
            ProductDetails = details;
            return ProductDetails;
        }

        public List<Shoes> ShoeList { get; set; }
    }
}
