using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Helpers
{
    public class TransactionVideo
    {
        public static void RentAVideo(Video video, string customerUsername)
        {

            int cost = video.Category == "DVD" ? 50 : 25;


            var result = MessageBox.Show(
                $"You are about to rent '{video.Title}' ({video.Category}) for ₱{cost}.\n" +
                $"You can only rent the video for {video.MaxRentDays} day/s.\n" +
                "After that, ₱5 will be charged for each extra day.\n\n" +
                "Do you want to continue?",
                "Confirm Rental",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.No)
                return;

            using (var context = new AppDbContext())
            {
                var v = context.Video.FirstOrDefault(x => x.Id == video.Id);
                if (v != null)
                {
                    if (v.InCount > 0)
                    {
                        v.InCount -= 1;
                        v.OutCount += 1;

                        var rental = new CustomerRented
                        {
                            Id = Guid.NewGuid(),
                            CustomerUsername = customerUsername,
                            VideoRented = v.Title,
                            RentedDate = DateOnly.FromDateTime(DateTime.Today),
                            RentCost = cost,
                            status = "Rented",
                            VideoId = v.Id.ToString(),
                        };

                        context.CustomerRented.Add(rental);
                        context.SaveChanges();

                        MessageBox.Show($"'{v.Title}' rented successfully");
                    }
                    else
                    {
                        MessageBox.Show("No copies left to rent.");
                    }
                }
            }
        }

       public static bool ReturnVideo(Guid rentalID)
        {
            using (var context = new AppDbContext())
            {
                var rental = context.CustomerRented.FirstOrDefault(r => r.Id == rentalID);
                if (rental == null || rental.ReturnedDate != null)
                    return false;

                rental.ReturnedDate = DateOnly.FromDateTime(DateTime.Today);

                var video = context.Video.FirstOrDefault(v => v.Title == rental.VideoRented);
                if (video != null)
                {
                    video.InCount += 1;
                    video.OutCount -= 1;
                    rental.status = "Returned";
                }

                context.SaveChanges();

                MessageBox.Show($"You have returned '{rental.VideoRented}'. Late Fee: ${rental.LateReturnFee}");
                return true;
            }
        }

    }
}
