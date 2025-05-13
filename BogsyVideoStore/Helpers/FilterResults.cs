using BogsyVideoStore.Models;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Helpers
{
    public class FilterResults
    {
        public static List<CustomerRented> ApplyFilters(AppDbContext context, string searchValue, string selectedStatus, DateOnly? selectedDate)
        {
            searchValue = searchValue?.Trim().ToLower();

            var filtered = context.CustomerRented
                .Where(c =>
                    (string.IsNullOrEmpty(searchValue) || c.CustomerUsername.ToLower().Contains(searchValue)) &&
                    (string.IsNullOrEmpty(selectedStatus) || c.status == selectedStatus) &&
                    (!selectedDate.HasValue || c.RentedDate == selectedDate.Value)
                )
                .ToList();

            return filtered;
        }

        public static List<CustomerRented> ShowRented(AppDbContext context)
        {

            var RentedVid = context.CustomerRented.Where(r => r.status == "Rented").ToList();
            return RentedVid;
        }


        public static List<CustomerRented> ShowOverdue(AppDbContext context)
        {
            var OverdueVid = context.CustomerRented.Where(r => r.status == "Overdue").ToList();
            return OverdueVid;
        }

        public static List<CustomerRented> ShowReturned(AppDbContext context)
        {
            var ReturnedVid = context.CustomerRented.Where(r => r.status == "Returned").ToList();
            return ReturnedVid;
        }
        public static List<CustomerRented> ShowRentCustomer(AppDbContext context, string currentCustomerName)
        {
            var CustomerRentedVid = context.CustomerRented.Where(r => r.CustomerUsername == currentCustomerName && r.status == "Rented" && r.ReturnedDate == null).ToList();
            return CustomerRentedVid;
        }

        public static List<CustomerRented> ShowOverCustomer(AppDbContext context, string currentCustomerName)
        {
            var CustomerOverdueVid = context.CustomerRented.Where(r => r.CustomerUsername == currentCustomerName && r.status == "Overdue" && r.ReturnedDate == null).ToList();
            return CustomerOverdueVid;
        }

        public static List<CustomerRented> ShowReturnCustomer(AppDbContext context, string currentCustomerName)
        {
            var CustomerReturnedVid = context.CustomerRented.Where(r => r.CustomerUsername == currentCustomerName && r.status == "Returned").ToList();
            return CustomerReturnedVid;
        }

        public static List<CustomerRented> SearchName(AppDbContext context, string? searchName)
        {
            searchName = searchName?.Trim().ToLower();
            var searchResult = context.CustomerRented
                    .Where(c => c.CustomerUsername.ToLower().Contains(searchName))
                    .ToList();
            return searchResult;
        }

        public static List<Customer> SearchCustomer(AppDbContext context, string? searchName)
        {
            searchName = searchName?.Trim().ToLower();
            var searchResult = context.Customer
                    .Where(c => c.Name.ToLower().Contains(searchName))
                    .ToList();
            return searchResult;
        }

        public static List<CustomerRented> DateFilter(AppDbContext context, DateOnly? searchDate)
        {

            var searchResult = context.CustomerRented
                    .Where(c => c.RentedDate == searchDate.Value)
                    .ToList();
            return searchResult;
        }

        public static List<Video> SearchTitle(AppDbContext context, string? searchTitle)
        {
            searchTitle = searchTitle?.Trim().ToLower();
            var searchResult = context.Video
                    .Where(v => v.Title.ToLower().Contains(searchTitle))
                    .ToList();
            return searchResult;
        }


        public static String UserCount(AppDbContext context)
        {
            var userCount = context.Customer.Count();

            return userCount.ToString();
        }

        public static String VcdCount(AppDbContext context)
        {
            var vcdCount = context.Video.Where(vcd => vcd.Category == "VCD").Count();
            return vcdCount.ToString(); 
        }

        public static String DvdCount(AppDbContext context)
        {
            var dvdCount = context.Video.Where(vcd => vcd.Category == "DVD").Count();
            return dvdCount.ToString();
        }

        public static String OverdueCount(AppDbContext context)
        {
            var overDues = context.CustomerRented.Where(c => c.status == "Overdue").Count();
            return overDues.ToString();
        }

        public static String TotalSales(AppDbContext context)
        {
            var totalSales = context.CustomerRented.Sum(r => r.RentCost + r.LateReturnFee);
            return totalSales.ToString("C");
        }


    }
}
