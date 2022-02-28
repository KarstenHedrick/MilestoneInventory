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
        public Search()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------------
        // Buttons
        //--------------------------------------------------------------

        // Search to Homepage Button
        private void SrchToHPButtonClickEvent(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }
    }
}
