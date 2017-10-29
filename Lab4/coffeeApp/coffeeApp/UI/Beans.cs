using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeApp.UI;
using coffeeApp.Models;

namespace coffeeApp
{
    public partial class Beans : Form
    {
        private List<Coffee> orderList = new List<Coffee>();
        private List<SyrupFlavor> syrupList = new List<SyrupFlavor>();
        public List<CoffeeFlavor> coffeeFlavorList = new List<CoffeeFlavor>();

        public Beans()
        {
            InitializeComponent();
            listViewOrder.View = View.Details;
            addCoffeeFlavorsToList();
            addSyrupFlavorsToList();
            addItemsToListBox();
            addItemsToComboBox();
        }

        private void addCoffeeFlavorsToList()
        {
            CoffeeFlavor regular = new CoffeeFlavor("Regular");
            CoffeeFlavor darkRoast = new CoffeeFlavor("Dark Roast");
            CoffeeFlavor americana = new CoffeeFlavor("Americana");
            CoffeeFlavor espresso = new CoffeeFlavor("Espresso");
            CoffeeFlavor latte = new CoffeeFlavor("Latte");
            coffeeFlavorList.Add(regular);
            coffeeFlavorList.Add(darkRoast);
            coffeeFlavorList.Add(americana);
            coffeeFlavorList.Add(espresso);
            coffeeFlavorList.Add(latte);
        }

        private void addSyrupFlavorsToList()
        {
            SyrupFlavor almond = new SyrupFlavor("Almond");
            SyrupFlavor amaretto = new SyrupFlavor("Amaretto");
            SyrupFlavor caramel = new SyrupFlavor("Caramel");
            SyrupFlavor chocolateMilano = new SyrupFlavor("Chocolate Milano");
            SyrupFlavor cinnamon = new SyrupFlavor("Cinnamon");
            SyrupFlavor pumpkinSpice = new SyrupFlavor("Pumpkin Spice");
            syrupList.Add(almond);
            syrupList.Add(amaretto);
            syrupList.Add(caramel);
            syrupList.Add(chocolateMilano);
            syrupList.Add(cinnamon);
            syrupList.Add(pumpkinSpice);
        }

        private void addItemsToComboBox()
        {
            foreach (CoffeeFlavor coffeeFlavor in coffeeFlavorList)
            {
                comboBoxCoffeeFlavors.Items.Add(coffeeFlavor.flavor);
            }
        }

        private void addItemsToListBox()
        {
            foreach (SyrupFlavor syrupFlavor in syrupList)
            {
                listBoxSyrupFlavors.Items.Add(syrupFlavor.flavor);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(coffeeFlavorList);
            addForm.ShowDialog();
            CoffeeFlavor tempFlavor = addForm.getFlavor();
            if (tempFlavor != null)
            {
                addCoffeeFlavorsToList(tempFlavor);
            }

        }

        private void addCoffeeFlavorsToList(CoffeeFlavor flavor)
        {
            comboBoxCoffeeFlavors.Items.Add(flavor.flavor);
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String msgBox = String.Format("There are {0} coffee flavors in the list", comboBoxCoffeeFlavors.Items.Count);
            MessageBox.Show(msgBox, "Number of Coffee Flavors");
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            string coffeeFlavor;
            string syrupFlavor;
            string quantity;
            string price;
            string size;
            bool sizeSelected = radioButtonExtraLarge.Checked == false && radioButtonLarge.Checked == false && radioButtonMedium.Checked == false && radioButtonSmall.Checked == false;

            if (comboBoxCoffeeFlavors.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a coffee flavor", "Select Coffee Flavor");
                return;
            }
            if (comboBoxQuantity.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a quantity", "Select Number of Drinks");
                return;
            }
            if (sizeSelected)
            {
                MessageBox.Show("You must select a drink size", "Select drink size");
                return;
            }
            if (listBoxSyrupFlavors.SelectedIndex != -1)
            {
                syrupFlavor = listBoxSyrupFlavors.Text;
            }
            else
            {
                syrupFlavor = "";
            }
            coffeeFlavor = comboBoxCoffeeFlavors.Text;
            size = getSize();
            price = getPrice(size);
            quantity = comboBoxQuantity.Text;

            Coffee coffee = new Coffee(coffeeFlavor, syrupFlavor, size, price, quantity);
            orderList.Add(coffee);
            addOrderToListView(coffee);
        }

        private void addOrderToListView(Coffee coffee)
        {

            ListViewItem listViewItem = new ListViewItem(coffee.coffeeFlavor, 0);
            listViewItem.SubItems.Add(coffee.syrupFlavor);
            listViewItem.SubItems.Add(coffee.quantity);
            listViewItem.SubItems.Add(coffee.price);
            listViewOrder.Items.Add(listViewItem);

        }

        private string getSize()
        {
            if (radioButtonExtraLarge.Checked == true)
            {
                return "Extra-Large";
            }
            else if (radioButtonLarge.Checked == true)
            {
                return "Large";
            }
            else if (radioButtonMedium.Checked == true)
            {
                return "Medium";
            }
            else
            {
                return "Small";
            }
        }

        private string getPrice(string size)
        {
            string price = "";
            double tempPrice = 0;
            if (listBoxSyrupFlavors.SelectedIndex != -1)
            {
                tempPrice += 2.50;
            }
            if (size == "Small")
            {
                tempPrice += 1.00;
            }
            else if (size == "Medium")
            {
                tempPrice += 1.50;
            }
            else if (size == "Large")
            {
                tempPrice += 2.50;
            }
            else
            {
                tempPrice += 3.00;
            }

            price = string.Format("${0:N2}", tempPrice);
            return price;
        }

        private void buttonCompleteOrder_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxOrderName.Text == string.Empty)
            {
                MessageBox.Show("You must give an order name", "Give an order name");
            }

            clearListAndListView();
            clearSelected();  
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            clearListAndListView();
        }

        private void clearListAndListView()
        {
            orderList.Clear();
            listViewOrder.Items.Clear();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you wish to clear the list?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                comboBoxCoffeeFlavors.Items.Clear();
                MessageBox.Show("Coffee flavor list is cleared!", "Coffee List Cleared");
            }
            else
            {
                return;
            }

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxCoffeeFlavors.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a flavor to remove", "Select a flavor");
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to remove this flavor?", "Remove Flavor", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                comboBoxCoffeeFlavors.Items.RemoveAt(comboBoxCoffeeFlavors.SelectedIndex);
            }
            else
            {
                return;
            }
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearListAndListView();
        }

        private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        private void clearSelected()
        {
            comboBoxCoffeeFlavors.SelectedIndex = -1;
            listBoxSyrupFlavors.SelectedIndex = -1;
            radioButtonExtraLarge.Checked = false;
            radioButtonLarge.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonSmall.Checked = false;
            comboBoxQuantity.SelectedIndex = -1;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new About();
            aboutForm.Show();
        }
    }
}
