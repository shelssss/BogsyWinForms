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
    public partial class AddCustomer : Form
    {
        private Customer _customerToEdit;
        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer(Customer customer)
        {
            InitializeComponent();
            _customerToEdit = customer;


            customerNameTxt.Text = customer.Name;
            userNameTxt.Text = customer.Username;
            BdayPicker.Value = customer.Birthday.ToDateTime(TimeOnly.MinValue);
            passwordTxt.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {

            string name = customerNameTxt.Text.Trim();
            string username = userNameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim(); 


            using (var context = new AppDbContext())
            {
                if (_customerToEdit != null)
                {
                    var customer = context.Customer.FirstOrDefault(c => c.Id == _customerToEdit.Id);
                    if (customer != null)
                    {
                        customer.Name = name;
                        customer.Username = username;
                        customer.Birthday = DateOnly.FromDateTime(BdayPicker.Value);
                        
                    
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Name, Username, and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool usernameExists = context.Customer.Any(c => c.Username == username);
                    if (usernameExists)
                    {
                        MessageBox.Show("Username already exists. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var customer = new Customer
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Username = username,
                        Password = PassHash.HashPassword(password),
                        Role = "Customer",
                        Birthday = DateOnly.FromDateTime(BdayPicker.Value)
                    };
                    context.Customer.Add(customer);
                }

                context.SaveChanges();
                MessageBox.Show("Customer saved!");
            }

            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
