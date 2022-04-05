/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * File: Remove Class
 * Date: 4/2/2022
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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        internal void TakeThis(Vans[] vansInvArr)
        {
            gvRemoveItems.DataSource = vansInvArr;
        }

        /// <summary>
        /// Remove Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveClickEvent(object sender, EventArgs e)
        {
            int rowIndex = gvRemoveItems.CurrentCell.RowIndex;

            Inventory inv = new Inventory();

            inv.RemoveItemToArray(rowIndex);

            inv.Show();
            this.Hide();
        }

        //--------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------

        // Remove to Hoempage Button
        private void RmvToHPButtonClickEvent(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

    }
}
