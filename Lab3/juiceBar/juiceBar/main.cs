/*
 *  File Name: Program.cs
 *  Author: Matt Clinard
 *  Date: 10/16/17
 *  This program allows a user to select and buy a number of drinks and also get a summary
 *  of how many drinks have been served as well as orders taken.
 */


using juiceBar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juiceBar
{
    public partial class main : Form
    {
        private List<Order> orderList = new List<Order>();
        private double _totalCost = 0;
        private int _totalOrders = 0;

        public main()
        {
            InitializeComponent();
            AddColumnsToListView();
            labelTotalCost.Text = "";
        }

        //This method adds columns to the listview
        private void AddColumnsToListView()
        {
            ColumnHeader drinkHeader = new ColumnHeader();
            ColumnHeader quantityHeader = new ColumnHeader();
            ColumnHeader costHeader = new ColumnHeader();

            drinkHeader.Text = "Drink";
            drinkHeader.TextAlign = HorizontalAlignment.Left;
            drinkHeader.Width = 125;

            quantityHeader.Text = "Quantity";
            quantityHeader.TextAlign = HorizontalAlignment.Left;
            quantityHeader.Width = 125;

            costHeader.Text = "Amount";
            costHeader.TextAlign = HorizontalAlignment.Left;
            costHeader.Width = 125;

            listViewOrderDetails.Columns.Add(drinkHeader);
            listViewOrderDetails.Columns.Add(quantityHeader);
            listViewOrderDetails.Columns.Add(costHeader);

            listViewOrderDetails.View = View.Details;
        }

        //This method sets any selected radio buttons to false if the tabbed page is changed
        private void tabControlDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButtonBanana.Checked = false;
            radioButtonFruit.Checked = false;
            radioButtonPomegranate.Checked = false;
            radioButtonVegetable.Checked = false;
            radioButtonWheatberry.Checked = false;
            radioButtonStrawberry.Checked = false;
        }

        //This method is the event handler for the add to order button
        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            AddToOrder();
        }

        //This method adds a drink to the order
        private void AddToOrder()
        {
            double cost = 0;
            int quantity = 0;
            string drinkType;
            string amount;

            if (IsSizeChecked() && IsDrinkTypeChecked() && maskedTextBoxQuantity.Text != "")
            {
                cost = getSizeCost();
                cost += getSupplementCost();
                int.TryParse(maskedTextBoxQuantity.Text, out quantity);
                cost *= quantity;
                _totalCost += cost;
                amount = string.Format("${0:N2}", cost);
                drinkType = GetDrinkType();
                Order orderItem = new Order(drinkType, quantity, cost);
                orderList.Add(orderItem);
                ListViewItem listViewItem = new ListViewItem(drinkType, 0);
                listViewItem.SubItems.Add(quantity.ToString());
                listViewItem.SubItems.Add(amount);
                listViewOrderDetails.Items.Add(listViewItem);
                calculateTotal(cost);
                clearItem();
            }
        }

        //This changes the labelTotalCost to reflect the cost of the order
        private void calculateTotal(double cost)
        {
            labelTotalCost.Text = string.Format("${0:N2}", _totalCost);
        }

        //This method clears out the previous drink order
        private void clearItem()
        {
            radioButtonBanana.Checked = false;
            radioButtonFruit.Checked = false;
            radioButtonLarge.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonPomegranate.Checked = false;
            radioButtonSmall.Checked = false;
            radioButtonStrawberry.Checked = false;
            radioButtonVegetable.Checked = false;
            radioButtonWheatberry.Checked = false;
            checkBoxCoolDownRemedy.Checked = false;
            checkBoxEnergyBoost.Checked = false;
            checkBoxVitaminPack.Checked = false;
            maskedTextBoxQuantity.Text = "";
        }

        //This method checks to see if a drink has been selected
        private bool IsDrinkTypeChecked()
        {
            bool drinkChecked = !radioButtonPomegranate.Checked && !radioButtonBanana.Checked && !radioButtonStrawberry.Checked && !radioButtonVegetable.Checked && !radioButtonWheatberry.Checked && !radioButtonFruit.Checked;
            if (drinkChecked)
            {
                return false;
            }
            return true;
        }

        //This methods checks to see if the size of the drink has been selected
        private bool IsSizeChecked()
        {
            bool sizeChecked = !radioButtonLarge.Checked && !radioButtonMedium.Checked && !radioButtonSmall.Checked;
            if (sizeChecked)
            {
                return false;
            }
            return true;
        }


        //This method determines gets the stringified value of a checked radio button
        private string GetDrinkType()
        {
            if(radioButtonBanana.Checked == true)
            {
                return "Banana Smoothie";
            }
            if(radioButtonFruit.Checked == true)
            {
                return "Fruit Juice";
            }
            if(radioButtonVegetable.Checked == true)
            {
                return "Vegetable Juice";
            }
            if(radioButtonStrawberry.Checked == true)
            {
                return "Strawberry Smoothie";
            }
            if(radioButtonPomegranate.Checked == true)
            {
                return "Pomegranate Smoothie";
            }

            return "Wheat Berry Smoothie";
        }


        //This method gets the value of the sizes of drinks
        private double getSizeCost()
        {
            if (radioButtonSmall.Checked == true)
            {
                return 3.00;
            }
            else if (radioButtonMedium.Checked == true)
            {
                return 3.50;
            }
            else
            {
                return 4.00;
            }
        }


        //This method determines how much a drinks supplements would add to the total cost
        private double getSupplementCost()
        {
            double cost = 0;
            if (checkBoxCoolDownRemedy.Checked == true)
            {
                cost += 2.50;
            }
            if (checkBoxEnergyBoost.Checked == true)
            {
                cost += 2.50;
            }
            if (checkBoxVitaminPack.Checked == true)
            {
                cost += 2.50;
            }
            return cost;
        }

        //This method is the event handler for the order complete button
        private void buttonOrderComplete_Click(object sender, EventArgs e)
        {
            OrderComplete();            
        }

        //This method is responsible for what happens after an order has been completed.
        private void OrderComplete()
        {
            if (listViewOrderDetails.Items.Count == 0)
            {
                MessageBox.Show("There are no items in this order.", "No items ordered");
                return;
            }
            for (int i = 0; i < listViewOrderDetails.Items.Count; i++)
            {
                listViewOrderDetails.Items[i].Remove();

            }
            labelTotalCost.Text = "";
        }

        //THis method is the event handler for the summary report button
        private void buttonSummaryReport_Click(object sender, EventArgs e)
        {
            GetSummaryReport();
        }

        //This method gets and displays the summary report
        private void GetSummaryReport()
        {
            double revenue = 0;
            int quantity = 0;
            string message;

            if (!orderList.Any())
            {
                MessageBox.Show("There have been no orders today.", "No Orders");
                return;
            }
            _totalOrders++;

            foreach (Order order in orderList)
            {
                revenue += order.amount;
                quantity += order.quantity;
            }

            message = String.Format("Total Orders: {0}\nDrinks Served: {1}\nTotal Amount: ${2:N2}", _totalOrders, quantity, revenue);
            MessageBox.Show(message, "Order Summary Report");
        }

        //This is the event handler for the add to order button on the menu
        private void addToOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToOrder();
        }

        //This is the event handler for the complete order button on the menu
        private void completeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderComplete();
        }

        //This is the event handler for the summary report menu item 
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSummaryReport();
        }

        //This is the even hanlder for the exit button on the menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is the even handler for the blue color menu item 
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Blue;
            groupBoxDrinkPicker.BackColor = Color.Blue;
            groupBoxOrderDetails.BackColor = Color.Blue;
            groupBox1.BackColor = Color.Blue;
            main.ActiveForm.BackColor = Color.Blue;
            tabPage1.BackColor = Color.Blue;
            tabPage2.BackColor = Color.Blue;

            menuStrip1.ForeColor = Color.White;
            groupBoxDrinkPicker.ForeColor = Color.White;
            groupBoxOrderDetails.ForeColor = Color.White;
            groupBoxSizes.ForeColor = Color.White;
            main.ActiveForm.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
        }

        //This is the even handler for the red color menu item 
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Red;
            groupBoxDrinkPicker.BackColor = Color.Red;
            groupBoxOrderDetails.BackColor = Color.Red;
            groupBox1.BackColor = Color.Red;
            main.ActiveForm.BackColor = Color.Red;
            tabPage1.BackColor = Color.Red;
            tabPage2.BackColor = Color.Red;

            menuStrip1.ForeColor = Color.Blue;
            groupBoxDrinkPicker.ForeColor = Color.Blue;
            groupBoxOrderDetails.ForeColor = Color.Blue;
            groupBox1.ForeColor = Color.Blue;
            groupBoxSizes.ForeColor = Color.Blue;
            main.ActiveForm.ForeColor = Color.Blue;
        }

        //This is the even handler for the green color menu item 
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Green;
            groupBoxDrinkPicker.BackColor = Color.Green;
            groupBoxOrderDetails.BackColor = Color.Green;
            groupBox1.BackColor = Color.Green;
            main.ActiveForm.BackColor = Color.Green;
            tabPage1.BackColor = Color.Green;
            tabPage2.BackColor = Color.Green;

            menuStrip1.ForeColor = Color.Pink;
            groupBoxDrinkPicker.ForeColor = Color.Pink;
            groupBoxOrderDetails.ForeColor = Color.Pink;
            groupBox1.ForeColor = Color.Pink;
            groupBoxSizes.ForeColor = Color.Pink;
            main.ActiveForm.ForeColor = Color.Pink;
        }

        //This is the even handler for font times new roman menu item 
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font timesNewRoman = new Font("Times New Roman", 10);
            menuStrip1.Font = timesNewRoman;
            groupBoxDrinkPicker.Font = timesNewRoman;
            groupBox1.Font = timesNewRoman;
            groupBoxOrderDetails.Font = timesNewRoman;
            main.ActiveForm.Font = timesNewRoman;
            buttonAddToOrder.Font = timesNewRoman;
            buttonOrderComplete.Font = timesNewRoman;
            buttonSummaryReport.Font = timesNewRoman;
        }

        //This is the even handler for font helvetica menu item 
        private void helveticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font helvetica = new Font("Helvetica", 10);
            menuStrip1.Font = helvetica;
            groupBoxDrinkPicker.Font = helvetica;
            groupBox1.Font = helvetica;
            groupBoxOrderDetails.Font = helvetica;
            main.ActiveForm.Font = helvetica;
            buttonAddToOrder.Font = helvetica;
            buttonOrderComplete.Font = helvetica;
            buttonSummaryReport.Font = helvetica;
        }

        //This is the event handler for font Comic Sans menu item 
        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font comicSans = new Font("Comic Sans MS", 10);
            menuStrip1.Font = comicSans;
            groupBoxDrinkPicker.Font = comicSans;
            groupBox1.Font = comicSans;
            groupBoxOrderDetails.Font = comicSans;
            main.ActiveForm.Font = comicSans;
            buttonAddToOrder.Font = comicSans;
            buttonOrderComplete.Font = comicSans;
            buttonSummaryReport.Font = comicSans;
        }

        //This is the event handler for the about item on the menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program allows you to make all sorts of\ncombinations of drinks!!\n\nverson: 0.0.2");
        }
    }
}
