/*
 * Name: Karsten Hedrick
 * Class: CST-150
 * Date: 4/4/2022
 * File: Search
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
    public partial class Search : Form
    {
        Vans[] vans = new Vans[10];
        public Search()
        {
            InitializeComponent();
            lblNotFound.Visible = false;
        }

        internal void TakeThis(Vans[] vansInvArr)
        {
            gvSearchInventory.DataSource = vansInvArr;
            vans = vansInvArr;
        }

        //--------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------

        // Search to Homepage Button

        private void BtnSrchToInvClickEvent(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }


        /// <summary>
        /// Search Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchClickEvent(object sender, EventArgs e)
        {
            string nameSearch = txtSearchName.Text;


            int idSearch = 0;

            if (txtSearchID.Text.Length > 0)
            {
                idSearch = Convert.ToInt32(txtSearchID.Text);
            }

            InventoryManager invMng = new InventoryManager();

            // Search Function from Inventory Manager
            invMng.SearchFunction(nameSearch, idSearch, vans, gvSearchInventory);
        }
    }
}
