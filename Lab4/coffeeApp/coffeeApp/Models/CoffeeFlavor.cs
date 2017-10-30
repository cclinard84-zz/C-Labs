// File: CoffeeFlavor.cs
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
    public class CoffeeFlavor
    {
        public string flavor;

        public CoffeeFlavor(string flavor)
        {
            this.flavor = flavor;
        }
    }
}
