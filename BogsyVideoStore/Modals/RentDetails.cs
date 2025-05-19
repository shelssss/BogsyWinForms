using BogsyVideoStore.Helpers;
using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStore.Modals
{
    public partial class RentDetails : Form
    {
        private CustomerRented _customer;
        private PrintDocument printDocument;
        public RentDetails()
        {
            InitializeComponent();
        }

        public RentDetails(RentedDetails customer)
        {
            InitializeComponent();

            dateTodayLbl.Text = DateTime.Now.ToString();
            custNameLbl.Text = customer.CustomerUsername;
            titleLbl.Text = customer.VideoRented;
            catLbl.Text = customer.Category;
            dateRentedLbl.Text = customer.RentedDate.ToString();
            maxRentLbl.Text = customer.MaxRentDays.ToString();
            returnedLbl.Text = customer.ReturnedDate?.ToString() ?? "Not Yet Returned";
            costLbl.Text = customer.RentCost.ToString("C");
            ovedueLbl.Text = customer.LateReturnFee.ToString("C");
            statusLbl.Text = customer.Status.ToString();
            totalLbl.Text = (customer.RentCost + customer.LateReturnFee).ToString("C");

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintModule.PrintRentalDetails(this);
        }

        
    }
}
