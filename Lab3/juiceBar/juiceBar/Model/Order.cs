using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juiceBar.Model
{
    public class Order
    {
        public string drink { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }

        public Order(string drink, int quantity, double amount)
        {
            this.drink = drink;
            this.quantity = quantity;
            this.amount = amount;
        }

    }
}
