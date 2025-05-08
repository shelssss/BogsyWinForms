using BogsyVideoStore.Helpers;
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
    }
}
