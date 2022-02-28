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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------

        // Edit to Homepage Button
        private void EditToHPButtonClickEvent(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void BtnApplyClickEvent(object sender, EventArgs e)
        {
            InventoryClass inventory = new InventoryClass();
            string product = txtEditName.Text;

            inventory.ChangeProduct(product);

        }
    }
}
