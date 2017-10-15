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
        }

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

        private void tabControlDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButtonBanana.Checked = false;
            radioButtonFruit.Checked = false;
            radioButtonPomegranate.Checked = false;
            radioButtonVegetable.Checked = false;
            radioButtonWheatberry.Checked = false;
            radioButtonStrawberry.Checked = false;
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSmall.Checked == true)
            {
                radioButtonMedium.Checked = false;
                radioButtonLarge.Checked = false;
            }
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMedium.Checked == true)
            {
                radioButtonSmall.Checked = false;
                radioButtonLarge.Checked = false;
            }
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonLarge.Checked == true)
            {
                radioButtonSmall.Checked = false;
                radioButtonMedium.Checked = false;
            }
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            double cost = 0;
            int quantity = 0;
            string drinkType;
            string amount;
            Console.WriteLine(maskedTextBoxQuantity.Text);
 
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

        private void calculateTotal(double cost)
        {
            labelTotalCost.Text = string.Format("${0:N2}", _totalCost);
        }

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
        }

        private bool IsDrinkTypeChecked()
        {
            bool drinkChecked = !radioButtonPomegranate.Checked && !radioButtonBanana.Checked && !radioButtonStrawberry.Checked && !radioButtonVegetable.Checked && !radioButtonWheatberry.Checked && !radioButtonFruit.Checked;
            if (drinkChecked)
            {
                return false;
            }
            return true;
        }

        private bool IsSizeChecked()
        {
            bool sizeChecked = !radioButtonLarge.Checked && !radioButtonMedium.Checked && !radioButtonSmall.Checked;
            if (sizeChecked)
            {
                return false;
            }
            return true;
        }

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

        private void buttonOrderComplete_Click(object sender, EventArgs e)
        {
            listViewOrderDetails.Clear();
        }

        private void buttonSummaryReport_Click(object sender, EventArgs e)
        {
            double revenue = 0;
            int quantity = 0;
            string message;
            if (!orderList.Any())
            {
                MessageBox.Show("There have been no orders today.", "No Orders");
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
    }
}
