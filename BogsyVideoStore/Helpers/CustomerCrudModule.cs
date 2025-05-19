using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogsyVideoStore.Models;


namespace BogsyVideoStore.Helpers
{
    public class CustomerCrudModule
    {
       

        public static bool AddCustomer(AppDbContext context, string name, string username, string password, DateOnly birthday)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Name, Username, and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool usernameExists = context.Customer.Any(c => c.Username == username);
            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = name,
                Username = username,
                Password = PassHash.HashPassword(password),
                Role = "Customer",
                Birthday = birthday
            };

            context.Customer.Add(customer);
            
            context.SaveChanges();
            MessageBox.Show("Customer added!");
            return true;
        }

        public static bool EditCustomer(AppDbContext context, Customer customerToEdit, string name, string username, DateOnly birthday)
        {
            var customer = context.Customer.FirstOrDefault(c => c.Id == customerToEdit.Id);
            if (customer.Username != username) 
            {
                bool usernameExists = context.Customer.Any(c => c.Username == username);
                if (usernameExists)
                {
                    MessageBox.Show("Username already exists. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (customer != null)
            {
                customer.Name = name;
                customer.Username = username;
                customer.Birthday = birthday;
                context.SaveChanges();
                MessageBox.Show("Customer updated!");
                return true;
            }

            MessageBox.Show("Customer not found.");
            return false;
        }

        public static bool CustomerRequest(AppDbContext context, string username, string reason)
        {
            var customer = context.Customer.FirstOrDefault(x => x.Username == username);

            if (customer == null)
            {
                MessageBox.Show("Username does not Exist");
                return false;
            }
            var PassReset = new CustomerQueries
            {
                Id = Guid.NewGuid(),
                Username = username,
                Reason = reason,
                Status = "Pending"
            };
            context.CustomerQueries.Add(PassReset);
            context.SaveChanges();
            MessageBox.Show("Request sent!");
            return true;

        }

        public static bool ChangePassword(AppDbContext context, Customer customerToEdit, string username, string password)
        {
            var customer = context.Customer.FirstOrDefault(c => c.Username == customerToEdit.Username);
            var changeStatus = context.CustomerQueries.FirstOrDefault(c => c.Username == customerToEdit.Username);
            if (customer != null && changeStatus != null)
            {
                customer.Password = PassHash.HashPassword(password);
                changeStatus.Status = "Updated";
                context.SaveChanges();
                MessageBox.Show("Password updated!");
                return true;
            }

            MessageBox.Show("Customer not found.");
            return false;
        }
    }
}
