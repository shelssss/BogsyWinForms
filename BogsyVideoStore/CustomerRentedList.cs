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
                    // Only update rentals that are not returned yet
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
    }
}
