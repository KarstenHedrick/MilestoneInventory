/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * Date: 4/2/2022
 * File: Homepage
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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// View Inventory From Homepage Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInventoryOnClick(object sender, EventArgs e)
        {
            // Instantiate the class. On click show inventory form and hide this form
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }
    }
}
