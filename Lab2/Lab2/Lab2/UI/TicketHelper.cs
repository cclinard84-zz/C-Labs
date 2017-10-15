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
using Lab2.UI;

namespace Lab2
{
    public partial class TicketHelper : Form
    {
        private const double _BASE_VISITOR_CHARGE = 35.00;
        private const double _BASE_FACULTY_CHARGE = 75.00;
        private const double _BASE_STUDENT_CHARGE = 75.00;
        private const double _SENIOR_ADDED_CHARGE = 50.00;
        private const double _SENIOR_ADDED_CHARGE_20_OVER = 120.00;
        private const double _FACULTY_EVERY_5MPH_CHARGE = 30.00;
        private const double _STUDENTS_EVERY_5MPH_CHARGE = 37.50;
        private const double _EVENING_COST_ADDITION = 40.00;

        private int _speed, _numTickets;

        public static List<Ticket> ticketList = new List<Ticket>();

        public TicketHelper()
        {

            InitializeComponent();
            this.CenterToScreen();
            this.checkBoxSenior.Visible = false;

            MessageBox.Show("Please enter a speed greater than 35 mph and less than 120 mph." +
                "\nOnce that is completed select whether the offender was a visitor, student, or staff member."+
                "\nMake sure the date is correct and make sure the 'Evening' checkbox is selected if it is night time and hit calculate.", "Instructions");
        }

        //This method makes the focus of the cursor the masked text box
        private void TicketHelper_Shown(object sender, EventArgs e)
        {
            maskedTextBoxSpeed.Focus();
        }

        //This method is the event handler for the calculate button
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int.TryParse(maskedTextBoxSpeed.Text, out _speed);
            bool checkBoxChecked = checkBoxFaculty.Checked || checkBoxStudent.Checked || checkBoxVisitor.Checked;

            if (dateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("You cannot issue a ticket in the future there McFly.", "No Time Traveling");
                return;
            }

            if (_speed <= 35)
            {
                MessageBox.Show("There is no need to write a ticket.", "Do Not Issue Ticket");
                return;
            }

            if (_speed > 35 && _speed < 120 && !checkBoxChecked)
            {
                MessageBox.Show("You must check a box for a Visitor, Faculty/Staff, or Student.", "Make a selection");
                return;
            }

            if(_speed >= 120)
            {
                MessageBox.Show("We don't have cars fast enough to catch speed demons.", "Can't catch speed demons");
                return;
            }

            CalculateTicket();

        }

        //This method claculates the ticket cost of each ticket
        private void CalculateTicket()
        {
            double totalTicketCost = 0;
            if (checkBoxVisitor.Checked)
            {
                totalTicketCost += _BASE_VISITOR_CHARGE;
            }
            else if (checkBoxFaculty.Checked)
            {
                totalTicketCost += _BASE_FACULTY_CHARGE;
                totalTicketCost += (CalculateAddedCost() * _FACULTY_EVERY_5MPH_CHARGE);
            }
            else
            {
                if (checkBoxSenior.Checked)
                {
                    if (_speed < 55)
                    {
                        totalTicketCost = (_SENIOR_ADDED_CHARGE + _BASE_STUDENT_CHARGE) * CalculateAddedCost();
                    }
                    else
                    {
                        totalTicketCost += (_SENIOR_ADDED_CHARGE_20_OVER + _BASE_STUDENT_CHARGE);
                    }
                }
                else
                {
                    totalTicketCost += _BASE_STUDENT_CHARGE + (CalculateAddedCost() * _STUDENTS_EVERY_5MPH_CHARGE);
                }
            }

            if (checkBoxEvening.Checked)
            {
                totalTicketCost += _EVENING_COST_ADDITION;
            }

            _numTickets++;
            labelTotalTicketAmount.Text = totalTicketCost.ToString("0.00");
            labelNumTickets.Text = Convert.ToString(_numTickets);
            AddTicketToList();
            UpdateTicketsByDate();
        }

        //This method updates tickets for each day there is a ticket
        private void UpdateTicketsByDate()
        {
            int ticketCountByDate = 0;
            foreach (Ticket ticket in ticketList)
            {
                if (ticket.date.Equals(dateTimePicker.Value.ToShortDateString()))
                {
                    ticketCountByDate++;
                }
            }
            labelTicketCountByDate.Text = Convert.ToString(ticketCountByDate);
        }

        //This method adds each ticket to the list of tickets
        private void AddTicketToList()
        {
            Ticket ticket = new Ticket(dateTimePicker.Value.ToShortDateString(), Convert.ToString(_numTickets), labelTotalTicketAmount.Text);
            ticketList.Add(ticket);
        }

        //This method calculates the added cost based on each 5 mph over the speed limit
        private int CalculateAddedCost()
        {
            int speed = _speed;
            speed -= 35;
            if (speed == 0)
            {
                return 1;
            }

            for (int i = 1; speed < 0; i++)
            {
                speed -= 5;
                if (speed <= 0)
                {
                    return i;
                }
            }
            return 1;
        }

        //This is the event handler for the clear button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            maskedTextBoxSpeed.Text = string.Empty;
            maskedTextBoxSpeed.Focus();
            labelTotalTicketAmount.Text = string.Empty;
            checkBoxEvening.Checked = false;
            checkBoxFaculty.Checked = false;
            checkBoxSenior.Checked = false;
            checkBoxStudent.Checked = false;
            checkBoxVisitor.Checked = false;
        }

        //This is the event handler for the exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is the event handler to change the check boxes if the visitor box is checked
        private void checkBoxVisitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisitor.Checked)
            {
                checkBoxSenior.Visible = false;
                checkBoxSenior.Checked = false;
                checkBoxStudent.Checked = false;
                checkBoxFaculty.Checked = false;
            }
        }

        //This is the event handler to change the check boxes if the Faculty box is checked
        private void checkBoxFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFaculty.Checked)
            {
                checkBoxSenior.Visible = false;
                checkBoxSenior.Checked = false;
                checkBoxStudent.Checked = false;
                checkBoxVisitor.Checked = false;
            }
        }

        //This button opens up the ticketHistory form
        private void buttonTicketHistory_Click(object sender, EventArgs e)
        {
            TicketHistory ticketHistory = new TicketHistory(ticketList);
            ticketHistory.Show();
        }

        //This is the event handler to listen for date changes
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTicketsByDate();
        }

        //This is the event handler for the appeals button
        private void buttonAppeal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no excuse for speeding.\nSuck it up buttercup!", "No Excuse");
        }

        //This is the event handler to listen for student checkbox changes
        private void checkBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStudent.Checked)
            {
                checkBoxSenior.Visible = true;
                checkBoxSenior.Checked = false;
                checkBoxFaculty.Checked = false;
                checkBoxVisitor.Checked = false;
            }
            else
            {
                checkBoxSenior.Visible = false;
            }
        }
    }
}
