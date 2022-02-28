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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();

            Add add = new Add();
            InventoryClass inventory = new InventoryClass();

            string productQuantity = String.Format("{0}", add.ProductQuantity);

            lblItemQuantity.Text = productQuantity;

        }

    }
}
