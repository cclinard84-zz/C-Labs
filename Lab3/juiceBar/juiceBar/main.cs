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

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            AddToOrder();
        }

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
            maskedTextBoxQuantity.Text = "";
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
            OrderComplete();            
        }

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

        private void buttonSummaryReport_Click(object sender, EventArgs e)
        {
            GetSummaryReport();
        }

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

        private void addToOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToOrder();
        }

        private void completeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderComplete();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSummaryReport();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Blue;
            groupBoxDrinkPicker.BackColor = Color.Blue;
            groupBoxOrderDetails.BackColor = Color.Blue;
            groupBox1.BackColor = Color.Blue;
            main.ActiveForm.BackColor = Color.Blue;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Red;
            groupBoxDrinkPicker.BackColor = Color.Red;
            groupBoxOrderDetails.BackColor = Color.Red;
            groupBox1.BackColor = Color.Red;
            main.ActiveForm.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Green;
            groupBoxDrinkPicker.BackColor = Color.Green;
            groupBoxOrderDetails.BackColor = Color.Green;
            groupBox1.BackColor = Color.Green;
            main.ActiveForm.BackColor = Color.Green;
        }

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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
