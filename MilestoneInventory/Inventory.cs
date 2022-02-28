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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            btnItemDetails.Visible = false;
        }

        public void AddListedItem(string productName)
        {
            lstInventory.Items.Add(productName);
        }


        private void ItemSelectCheckedEvent(object sender, EventArgs e)
        {
            btnItemDetails.Visible = true;
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
            remove.Show();
            this.Hide();
        }

        private void InvToDetailsButtonClickEvent(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            this.Hide();
        }

    }
}
