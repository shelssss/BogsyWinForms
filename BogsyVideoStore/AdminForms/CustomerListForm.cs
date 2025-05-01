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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddCustomer();
            addForm.ShowDialog();
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customer.ToList();
                CustomerGridView.DataSource = customers;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CustomerGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CustomerGridView.SelectedRows[0];
                var customer = (Customer)selectedRow.DataBoundItem;

                var editForm = new AddCustomer(customer);
                editForm.ShowDialog();

                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }
    }
}
