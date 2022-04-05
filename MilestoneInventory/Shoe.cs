/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * File: Shoe Class
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

    /// <summary>
    /// Parent Class for all Models
    /// </summary>
    class Shoe
    {
        // Properties for Shoes
        public string InventoryProduct { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductCost { get; set; }
        public string ProductCondition { get; set; }
        public string ProductBrand { get; set; }
        public int ProductID { get; set; }
    }
}
