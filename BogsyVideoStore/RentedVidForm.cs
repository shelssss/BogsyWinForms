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
    public partial class RentedVidForm : Form
    {
        private string currentCustomerName;
        public RentedVidForm(string currentCustomer)
        {
            InitializeComponent();
            currentCustomerName = currentCustomer;
            LoadRentedVideo();
        }

        public void LoadRentedVideo()
        {
            using (var context = new AppDbContext())
            {
                var rentedVideos = context.CustomerRented
                    .Where(r => r.CustomerName == currentCustomerName && r.ReturnedDate == null)
                    .ToList();

                foreach (var rental in rentedVideos)
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
                RentedVidGrid.DataSource = rentedVideos;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (RentedVidGrid.CurrentRow != null)
            {
                var rentalId = (Guid)RentedVidGrid.CurrentRow.Cells["Id"].Value;

                using (var context = new AppDbContext())
                {
                    var rental = context.CustomerRented.FirstOrDefault(r => r.Id == rentalId);
                    if (rental != null && rental.ReturnedDate == null)
                    {
                        rental.ReturnedDate = DateOnly.FromDateTime(DateTime.Today);

                        // Increase video inventory
                        var video = context.Video.FirstOrDefault(v => v.Title == rental.VideoRented);
                        if (video != null)
                        {
                            video.InCount += 1;
                            video.OutCount -= 1;
                            rental.status = "Returned";
                        }

                        context.SaveChanges();

                        MessageBox.Show($"'{rental.VideoRented}' returned by {rental.CustomerName}. Late Fee: ${rental.LateReturnFee}");
                        LoadRentedVideo(); 
                    }
                }
            }
        }

        private void StoreReturnVideos()
        {

        }
    }
}
