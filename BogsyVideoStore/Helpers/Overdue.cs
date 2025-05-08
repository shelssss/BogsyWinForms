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
            using (var context = new AppDbContext())
            {
                
                var videos = context.Video.ToDictionary(v => v.Id);

                foreach (var rental in rentals)
                {
                    if (rental.ReturnedDate == null && Guid.TryParse(rental.VideoId, out Guid videoId))
                    {
                        if (videos.TryGetValue(videoId, out var video))                                             
                        {
                            int daysRented = DateOnly.FromDateTime(DateTime.Today).DayNumber - rental.RentedDate.DayNumber;

                            if (daysRented > video.MaxRentDays)
                            {
                                rental.LateReturnFee = (daysRented - video.MaxRentDays) * 5;
                                rental.status = "Overdue";
                            }
                            else
                            {
                                rental.LateReturnFee = 0;
                                rental.status = "Rented";
                            }
                        }
                    }
                }
            }
        }

     
    }
}
