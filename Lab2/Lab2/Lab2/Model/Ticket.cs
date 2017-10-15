using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    //This class is used to hold all information about the ticket

    public class Ticket
    {
        public String date { get; set; }
        public String amount { get; set; }
        public String ticketNumber { get; set; }

        public Ticket(String date, String ticketNumber, String amount)
        {
            this.date = date;
            this.amount = amount;
            this.ticketNumber = ticketNumber;
        }

    }
}
