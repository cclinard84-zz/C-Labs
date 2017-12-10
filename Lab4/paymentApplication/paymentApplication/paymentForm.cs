using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paymentApplication
{
    public partial class paymentForm : Form {

        public List<Payment> paymentList;
        Payment payment = new Payment();
        public String customerName;
        public paymentForm(List<Payment> paymentList, String customerName)
        {
            this.paymentList = paymentList;
            this.customerName = customerName;
            InitializeComponent();
            BuildLists();
        }

        private void BuildLists()
        {
            int year = DateTime.Today.Year;
            int endYear = year + 8;
            listBox1.Items.Add("Visa");
            listBox1.Items.Add("Mastercard");
            listBox1.Items.Add("American Express");

            string[] months = { "Select a month...", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                comboBox1.Items.Add(month);
            }
           
            comboBox2.Items.Add("Select a year...");
            while(year < endYear)
            {
                comboBox2.Items.Add(year);
                year++;
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private bool isValid()
        {
            if (radioButton1.Checked)
            {
                if(listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card company.", "Select a company");
                    return false;
                }
                else if(maskedTextBox1.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number", "Enter a valid number");
                    return false;
                }
                else if(comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month", "Select a month");
                    return false;
                }
                else if(comboBox2.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year", "Select a year");
                    return false;
                }
            }
            return true;
        }
        private void SaveData()
        {
            string expDate = comboBox1.Text + "/" + comboBox2.Text;
            if(radioButton1.Checked == true && isValid())
            {
                this.payment = new Payment(maskedTextBox1.Text, listBox1.SelectedItem.ToString(), expDate, checkBox1.Checked);
                this.payment.setCustomerName(this.customerName);
                paymentList.Add(payment);
            }
            
        }

        public Payment getPayment()
        {
            return this.payment;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                maskedTextBox1.Enabled = true;
                listBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                maskedTextBox1.Enabled = false;
                listBox1.Enabled = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && isValid())
            {
                SaveData();
                this.Close();
            }
            
        }
    }
}
