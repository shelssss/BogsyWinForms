using BogsyVideoStore.Helpers;
using BogsyVideoStore.Modals;
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
                    .Where(r => r.CustomerUsername == currentCustomerName && r.ReturnedDate == null)
                    .ToList();


                Overdue.UpdateOverdue(rentedVideos);

                context.CustomerRented.UpdateRange(rentedVideos);
                context.SaveChanges();

                RentedVidGrid.DataSource = rentedVideos;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (RentedVidGrid.CurrentRow != null)
            {
                var rentalId = (Guid)RentedVidGrid.CurrentRow.Cells["Id"].Value;

               bool ReturnSucess = TransactionVideo.ReturnVideo(rentalId);
                if (ReturnSucess) 
                {   
                    LoadRentedVideo();
                    using (var context = new AppDbContext())
                    {
                        var rental = context.CustomerRented.FirstOrDefault(r => r.Id == rentalId);
                        if (rental != null)
                        {
                            var video = context.Video.FirstOrDefault(v => v.Id.ToString() == rental.VideoId);
                            if (video != null)
                            {
                                var rentDetails = new RentedDetails
                                {
                                    CustomerUsername = rental.CustomerUsername,
                                    VideoRented = rental.VideoRented,
                                    Category = video.Category,
                                    MaxRentDays = video.MaxRentDays,
                                    RentedDate = rental.RentedDate,
                                    ReturnedDate = rental.ReturnedDate,
                                    RentCost = rental.RentCost,
                                    LateReturnFee = rental.LateReturnFee,
                                    Status = rental.status
                                };

                                var printDialog = new RentDetails(rentDetails);
                                printDialog.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Related video details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a video to return.");
            }
                
            
        }

        private void statusCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (statusCbx.SelectedIndex == 0)
            {
                using (var context = new AppDbContext())
                {
                    var RentedVid = FilterResults.ShowRentCustomer(context, currentCustomerName);
                    RentedVidGrid.DataSource = RentedVid;

                }
            }
            else if (statusCbx.SelectedIndex == 1)
            {
                using (var context = new AppDbContext())
                {
                    var OverdueVid = FilterResults.ShowOverCustomer(context, currentCustomerName);  
                    RentedVidGrid.DataSource = OverdueVid;

                }
            }
            else if (statusCbx.SelectedIndex == 2)
            {
                using (var context = new AppDbContext())
                {
                    var ReturnedVid = FilterResults.ShowReturnCustomer(context, currentCustomerName);
                    RentedVidGrid.DataSource = ReturnedVid;

                }
            }
        }
    }
}
