using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneInventory
{
    internal class Nike : Shoe
    {
        public bool IsAvailable { get; set; }
        public bool Cleats { get; set; }
        public string Sport { get; set; }

        public Nike(bool isAvailable, bool cleats, string sport, string inventoryProduct, int productQuantity,
            double productCost, string productCondition, string productBrand, int productID)
        {
            // Child Class
            IsAvailable = isAvailable;
            Cleats = cleats;
            Sport = sport;

            // Parent Class
            InventoryProduct = inventoryProduct;
            ProductQuantity = productQuantity;
            ProductCost = productCost;
            ProductCondition = productCondition;
            ProductBrand = productBrand;
            ProductID = productID;
        }
    }
}
