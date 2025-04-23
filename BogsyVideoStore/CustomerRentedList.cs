using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStore
{
    public partial class CustomerRentedList : Form
    {
        public CustomerRentedList()
        {
            InitializeComponent();
            LoadAllRents();
        }

        private void LoadAllRents()
        {
            using (var context = new AppDbContext())
            {
                var AllRents = context.CustomerRented.ToList();

                foreach (var rental in AllRents)
                {

                    if (rental.ReturnedDate == null)
                    {
                        int daysRented = DateOnly.FromDateTime(DateTime.Today).DayNumber - rental.RentedDate.DayNumber;

                        if (daysRented > 3)
                        {
                            rental.LateReturnFee = (daysRented - 3) * 5;
                            rental.status = "Overdue";
                        }
                        else
                        {
                            rental.LateReturnFee = 0;
                        }

                        context.CustomerRented.Update(rental);
                    }
                }

                context.SaveChanges();
                RentedListGrid.DataSource = AllRents;
            }
        }

        private void selectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectFilter.SelectedIndex == 0)
            {
                LoadAllRents();
            }
            else if (selectFilter.SelectedIndex == 1) 
            {
                using (var context = new AppDbContext())
                {
                    var RentedVid = context.CustomerRented.Where(r => r.status == "Rented").ToList();
                    RentedListGrid.DataSource = RentedVid;

                }
            }
            else if (selectFilter.SelectedIndex == 2)
            {
                using (var context = new AppDbContext())
                {
                    var OverdueVid = context.CustomerRented.Where(r => r.status == "Overdue").ToList();
                    RentedListGrid.DataSource = OverdueVid;

                }
            }
            else if(selectFilter.SelectedIndex == 3)
            {
                using (var context = new AppDbContext())
                {
                    var ReturnedVid = context.CustomerRented.Where(r => r.status == "Returned").ToList();
                    RentedListGrid.DataSource = ReturnedVid;

                }
            }


        }
    }
}
