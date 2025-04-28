using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Helpers
{
    public static class Overdue
    {
        public static void UpdateOverdue(List<CustomerRented> rentals)
        {
            foreach (var rental in rentals)
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
                }
            }
        }

        public static void OverdueForCustomer(List<CustomerRented> rentals)
        {

        }
    }
}
