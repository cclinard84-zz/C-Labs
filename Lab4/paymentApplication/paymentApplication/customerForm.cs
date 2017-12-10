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
    public partial class customerForm : Form
    {
        private List<Payment> paymentList = new List<Payment>();
        Payment payment = new Payment();

        public customerForm()
        {
            InitializeComponent();
            InitializeCustomerNames();
        }

        private void InitializeCustomerNames()
        {
            this.comboBox1.Items.Add("Matt Clinard");
            this.comboBox1.Items.Add("Greg Carujo");
            this.comboBox1.Items.Add("Bryan Dingman");
        }

        private void BuildTextBox(Payment payment)
        {
            String msg = String.Format("Charge to credit card.\r\n\r\n" 
                + "Card type: {0}\r\n"
                + "Card number: {1}\r\n"
                + "Expiration date: {2}\r\n"
                + "Default billing: {3}", payment.getCreditCardType(), payment.getCardNumber(), payment.getExpirationDate(), payment.getDefaultBilling().ToString());
            textBox1.Text = msg;        
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowPayment_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer", "Select a customer");
                return;
            }
            string customerName = comboBox1.SelectedItem.ToString();
            System.Diagnostics.Debug.WriteLine(customerName);
            paymentForm paymentForm = new paymentForm(paymentList, customerName);
            paymentForm.ShowDialog();
            payment = paymentForm.getPayment();
            BuildTextBox(payment);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Payment payment in paymentList)
            {
                if(payment.getCustomerName() == comboBox1.SelectedItem.ToString())
                {
                    BuildTextBox(payment);
                    return;
                }
            }
            textBox1.Clear();
        }
    }
}
