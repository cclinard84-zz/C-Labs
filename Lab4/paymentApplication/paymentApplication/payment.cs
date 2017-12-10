using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentApplication
{
    public class Payment
    {
        private String creditCardNumber;
        private String creditCardType;
        private String expirationDate;
        private bool defaultBilling;
        private String customerName;

        public Payment()
        {
            this.creditCardNumber = "";
            this.creditCardType = "";
            this.expirationDate = "";
            this.defaultBilling = false;
        }

        public Payment(String creditCardNumber, String creditCardType, String expirationDate, bool defaultBilling)
        {
            this.creditCardNumber = creditCardNumber;
            this.creditCardType = creditCardType;
            this.expirationDate = expirationDate;
            this.defaultBilling = defaultBilling;
        }
        
        public String getCardNumber()
        {
            return this.creditCardNumber;
        }

        public String getCreditCardType()
        {
            return this.creditCardType;
        }

        public String getExpirationDate()
        {
            return this.expirationDate;
        }

        public bool getDefaultBilling()
        {
            return this.defaultBilling;
        }

        public void setCardNumber(String cardNumber)
        {
            this.creditCardNumber = cardNumber;
        }

        public void setCreditCardType(String cardType)
        {
            this.creditCardType = cardType;
        }

        public void setDefaultBilling(bool defaultBilling)
        {
            this.defaultBilling = defaultBilling;
        }

        public void setExpirationDate(String expirationDate)
        {
            this.expirationDate = expirationDate;
        }

        public String getCustomerName()
        {
            return this.customerName;
        }

        public void setCustomerName(String customerName)
        {
            this.customerName = customerName;
        }
    }
}
