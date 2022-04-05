/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * File: Vans Class
 * Date: 4/2/2022
 * This is my own work.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneInventory
{
    internal class Vans : Shoe
    {
        // Attributes for Vans
        public bool IsAvailable { get; set; }
        public string Fit { get; set; }

        /// <summary>
        /// Constructor for Vans
        /// </summary>
        /// <param name="isAvailable"></param>
        /// <param name="fit"></param>
        /// <param name="inventoryProduct"></param>
        /// <param name="productQuantity"></param>
        /// <param name="productCost"></param>
        /// <param name="productCondition"></param>
        /// <param name="productBrand"></param>
        /// <param name="productID"></param>
        public Vans(bool isAvailable, string fit, string inventoryProduct, int productQuantity,
            double productCost, string productCondition, string productBrand, int productID)
        {
            // Child Class
            IsAvailable = isAvailable;
            Fit = fit;

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
