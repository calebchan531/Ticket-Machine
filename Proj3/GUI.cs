/* Caleb Chan
 * Proj3
 * File: Proj3.zip
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj3
{
    public partial class GUI : Form
    {
        private const double GeneralPublicTicketPrice = 80.0;
        private const double ParkingPrice = 25.0;
        private const double AlumniDiscountPercentage = 0.1;
        private const double FacultyStaffDiscountPercentage = 0.15;
        private const double MilitaryDiscountPercentage = 0.2;
        private const double StudentDiscountPercentage = 0.5;

        public GUI()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This handles everything that happens when the OK button is selected. This also calculates all of the prices according to what is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOK_Click(object sender, EventArgs e)
        {
            double ticketPrice = GeneralPublicTicketPrice;
            if (uxAlumniRB.Checked)
            {
                ticketPrice -= ticketPrice * (1 - AlumniDiscountPercentage);
            }
            else if (uxFacultyorStaffRB.Checked)
            {
                ticketPrice -= ticketPrice * FacultyStaffDiscountPercentage;
            }
            else if (uxMilitaryRB.Checked)
            {
                ticketPrice -= ticketPrice * MilitaryDiscountPercentage;
            }
            else if (uxStudentRB.Checked)
            {
                ticketPrice -= ticketPrice * StudentDiscountPercentage;
            }

            //converts the ticket numericUpDown to an integer so that I can do int multiplication.
            int totalTicketsRequested = Convert.ToInt32(uxTicketQuantityNumericUpDown.Value);

            double totalCost = ticketPrice * totalTicketsRequested;

            if (uxParkingCheckbox.Checked)
            {
                totalCost += ParkingPrice;
            }

            MessageBox.Show($"You ordered {totalTicketsRequested} ticket(s) for a total cost of ${totalCost:F2}");

        }
    }
}
