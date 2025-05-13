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
                var allRents = context.CustomerRented.ToList();


                Overdue.UpdateOverdue(allRents);

                context.CustomerRented.UpdateRange(allRents);
                context.SaveChanges();

                RentedListGrid.DataSource = allRents;
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
                    var RentedVid = FilterResults.ShowRented(context);
                    RentedListGrid.DataSource = RentedVid;

                }
            }
            else if (selectFilter.SelectedIndex == 2)
            {
                using (var context = new AppDbContext())
                {
                    var OverdueVid = FilterResults.ShowOverdue(context);
                    RentedListGrid.DataSource = OverdueVid;

                }
            }
            else if (selectFilter.SelectedIndex == 3)
            {
                using (var context = new AppDbContext())
                {
                    var ReturnedVid = FilterResults.ShowReturned(context);
                    RentedListGrid.DataSource = ReturnedVid;

                }
            }
        }
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string searchValue = searchBar.Text.Trim().ToLower();

                var filtered = FilterResults.SearchName(context, searchValue);

                RentedListGrid.DataSource = filtered;
            }
        }


        private void dateRented_ValueChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                DateOnly? selectedDate = dateRented.Checked ? DateOnly.FromDateTime(dateRented.Value.Date) : null;
                var dateFilter = FilterResults.DateFilter(context, selectedDate);

                RentedListGrid.DataSource = dateFilter;

            }
        }

        private void searchFilter_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string searchValue = searchBar.Text.Trim().ToLower();
                string selectedStatus = selectFilter.SelectedItem?.ToString();
                DateOnly? selectedDate = dateRented.Checked ? DateOnly.FromDateTime(dateRented.Value.Date) : null;

                var results = FilterResults.ApplyFilters(context, searchValue, selectedStatus, selectedDate);

                RentedListGrid.DataSource = results;
            }
        }

        private void RentedListGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = RentedListGrid.Rows[e.RowIndex];
                var customer = (CustomerRented)selectedRow.DataBoundItem;

                using (var context = new AppDbContext())
                {
                    var video = context.Video.FirstOrDefault(v => v.Id.ToString() == customer.VideoId);

                    if (video != null)
                    {
                        var rentDetails = new RentedDetails
                        {
                            CustomerUsername = customer.CustomerUsername,
                            VideoRented = customer.VideoRented,
                            Category = video.Category,
                            MaxRentDays = video.MaxRentDays,
                            RentedDate = customer.RentedDate,
                            ReturnedDate = customer.ReturnedDate,
                            RentCost = customer.RentCost,
                            LateReturnFee = customer.LateReturnFee,
                            Status = customer.status
                        };

                        var printDialog = new RentDetails(rentDetails);
                        printDialog.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Video details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
