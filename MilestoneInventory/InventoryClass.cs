/*
 * Name: Karsten Hedrick
 * Professor: William Hughes
 * Class: CST-150
 * Date: 2/26/2022
 * This is my own work.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneInventory
{

    internal class InventoryClass
    {
        // Defined Properties
        public string InventoryProduct { get; set; } // AKA Product Name
        public int ProductQuantity { get; set; }
        public double ProductCost { get; set; }
        public string ProductCondition { get; set; }
        public string ProductBrand { get; set; }
        public int ProductID { get; set; }
        public string ProductDetails { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InventoryClass()
        {
            InventoryProduct = String.Empty;
            ProductQuantity = 0;
            ProductCost = 0.0d;
            ProductCondition = String.Empty;
            ProductBrand = String.Empty;
            ProductID = 0;
        }


        /// <summary>
        /// Change Product Method
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public string ChangeProduct(string product)
        {
            if (product.Length > 0)
            {
                InventoryProduct = product;
            }

            return InventoryProduct;
        }

        /// <summary>
        /// Change Quantity Method
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public int ChangeQuantity(int quantity)
        {
            if (quantity > 0)
            {
                ProductQuantity = quantity;
            }

            return ProductQuantity;
        }

        /// <summary>
        /// Change Quantity Method
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public double ChangeCost(double cost)
        {
            ProductCost = cost;

            return ProductCost;
        }
    }
}
