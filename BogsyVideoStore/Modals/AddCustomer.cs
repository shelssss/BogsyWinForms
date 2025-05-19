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
            _customerToEdit = null;
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

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            string name = customerNameTxt.Text.Trim();
            string username = userNameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            DateOnly birthday = DateOnly.FromDateTime(BdayPicker.Value);
            using (var context = new AppDbContext())
            {   
                
                //edit 
                if (_customerToEdit != null)
                {
                    if (_customerToEdit != null)
                    {
                        bool UpdateSuccess = CustomerCrudModule.EditCustomer(context, _customerToEdit, name, username, birthday);
                        if (UpdateSuccess)
                        {
                            this.Close();
                        }
                    }

                }
                else
                {
                    bool InsertSuccess = CustomerCrudModule.AddCustomer(context, name, username, password, birthday);

                    if (InsertSuccess)
                    {
                        this.Close(); 
                    }

                }
                

            }
            
        }

        
    }
}
