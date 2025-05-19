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

namespace BogsyVideoStore.Modals
{
    public partial class PasswordChange : Form
    {
        private Customer _customerToEdit;
        public PasswordChange()
        {
            InitializeComponent();
        }

        public PasswordChange(Customer customer)
        {
            InitializeComponent();
            _customerToEdit = customer;

            customerNameTxt.Text = customer.Name;
            userNameTxt.Text = customer.Username;
            BdayPicker.Value = customer.Birthday.ToDateTime(TimeOnly.MinValue);
            passwordTxt.Text = customer.Password;

            customerNameTxt.Enabled = false;
            userNameTxt.Enabled = false;
            BdayPicker.Enabled = false;
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void SavePassBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();

            using (var context = new AppDbContext())
            {
                if (_customerToEdit != null)
                {
                    bool success = CustomerCrudModule.ChangePassword(context, _customerToEdit, username, password);
                    if (success) 
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
