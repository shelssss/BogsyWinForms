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
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {

            string name = customerNameTxt.Text;
            string username = userNameTxt.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Name and Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                if (_customerToEdit != null)
                {
                    // Edit mode
                    var customer = context.Customer.FirstOrDefault(c => c.Id == _customerToEdit.Id);
                    if (customer != null)
                    {
                        customer.Name = customerNameTxt.Text;
                        customer.Username = userNameTxt.Text;
                        customer.Birthday = DateOnly.FromDateTime(BdayPicker.Value);
                    }
                }

                else
                {
                    
                    var customer = new Customer
                    {
                        Id = Guid.NewGuid(),
                        Name = customerNameTxt.Text,
                        Username = userNameTxt.Text,
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


    }
}
