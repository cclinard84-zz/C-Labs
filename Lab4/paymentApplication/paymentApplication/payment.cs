using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentApplication
{
    public class payment
    {
        private String creditCardNumber;
        private String creditCardType;
        private String expirationDate;
        private bool defaultBilling;

        public payment()
        {
            this.creditCardNumber = "";
            this.creditCardType = "";
            this.expirationDate = "";
            this.defaultBilling = false;
        }

        public payment(String creditCardNumber, String creditCardType, String expirationDate, bool defaultBilling)
        {
            this.creditCardNumber = creditCardNumber;
            this.creditCardType = creditCardType;
            this.expirationDate = expirationDate;
            this.defaultBilling = defaultBilling;
        }
    }
}
