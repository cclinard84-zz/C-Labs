using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Model;

namespace Lab2.UI
{
    public partial class TicketHistory : Form
    {
        public TicketHistory()
        {
            InitializeComponent();
        }

        public TicketHistory(List<Ticket> ticketList)
        {
            InitializeComponent();
            AddColumns();
            AddItems(ticketList);
            this.CenterToScreen();
        }

        //This method adds items to the listview
        private void AddItems(List<Ticket> ticketList)
        {
            foreach(Ticket ticket in ticketList)
            {
                ListViewItem listViewItem = new ListViewItem(ticket.date, 0);
                string amount = String.Format("${0}", ticket.amount);

                listViewItem.SubItems.Add(ticket.ticketNumber);
                listViewItem.SubItems.Add(amount);
                listViewTicketHistory.Items.Add(listViewItem);
            }
        }

        //This method adds column headers to the list view
        private void AddColumns()
        {
            ColumnHeader dateHeader = new ColumnHeader();
            ColumnHeader ticketNumberHeader = new ColumnHeader();
            ColumnHeader ticketAmountHeader = new ColumnHeader();

            dateHeader.Text = "Date";
            dateHeader.TextAlign = HorizontalAlignment.Left;
            dateHeader.Width = 125;

            ticketNumberHeader.Text = "Ticket Number";
            ticketNumberHeader.TextAlign = HorizontalAlignment.Left;
            ticketNumberHeader.Width = 100;

            ticketAmountHeader.Text = "Amount";
            ticketAmountHeader.TextAlign = HorizontalAlignment.Left;
            ticketAmountHeader.Width = 150;

            listViewTicketHistory.Columns.Add(dateHeader);
            listViewTicketHistory.Columns.Add(ticketNumberHeader);
            listViewTicketHistory.Columns.Add(ticketAmountHeader);

            listViewTicketHistory.View = View.Details;
        }

        //This is the event handler for the back button.
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
