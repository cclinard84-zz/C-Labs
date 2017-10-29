using coffeeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeApp.UI
{
    public partial class AddForm : Form
    {
        private List<CoffeeFlavor> flavorList;
        public CoffeeFlavor returnedFlavor;
        public  AddForm(List<CoffeeFlavor> coffeeFlavorList)
        {
            flavorList = coffeeFlavorList;
            InitializeComponent();

        }

        private void buttonAddFlavor_Click(object sender, EventArgs e)
        {
            string tempStr;
            tempStr = maskedTextBox1.Text.Trim();
            foreach(CoffeeFlavor coffeeFlavor in flavorList)
            {
                if (tempStr.Equals(coffeeFlavor.flavor, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("You cannot duplicate a flavor already in the list", "Duplicate Flavor");
                    returnedFlavor = null;
                    return;
                }
            }
            CoffeeFlavor newFlavor = new CoffeeFlavor(maskedTextBox1.Text);
            string tempFlavor = newFlavor.flavor.Replace(" ", "");
            newFlavor.flavor = tempFlavor;
            if(newFlavor.flavor == "")
            {
                MessageBox.Show("You must enter a valid flavor", "Enter a valid flavor");
                return;
            }
            returnedFlavor = newFlavor;
            Close();
        }
        
        public CoffeeFlavor getFlavor()
        {
            return this.returnedFlavor;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            returnedFlavor = null;
            this.Close();
        }
    }
}
