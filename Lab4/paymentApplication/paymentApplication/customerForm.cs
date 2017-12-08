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
        private List<payment> paymentList = new List<payment>();
        private bool isFirstRun = true;

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

        private void BuildListView()
        {
            if(paymentList.Count == 0)
            {

            }
        }
    }
}
