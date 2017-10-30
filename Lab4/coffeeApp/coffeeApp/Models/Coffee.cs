// File: Coffee.cs
// Author: Matt Clinard
// Date: 10.30.17
// This class is used by Beans.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeApp.Models
{
    class Coffee
    {
        public string coffeeFlavor;
        public string syrupFlavor;
        public string size;
        public string price;
        public string quantity;

        public Coffee(string coffeeFlavor, string syrupFlavor, string size, string price, string quantity)
        {
            this.coffeeFlavor = coffeeFlavor;
            this.syrupFlavor = syrupFlavor;
            this.size = size;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
