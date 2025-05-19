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
                DisplayHelper.DisplayDefaults(CustomerGridView);
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string searchValue = searchBar.Text.Trim().ToLower();

                var filtered = FilterResults.SearchCustomer(context, searchValue);

                CustomerGridView.DataSource = filtered;
                DisplayHelper.DisplayDefaults(CustomerGridView);
            }
        }

        private void CustomerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = CustomerGridView.Rows[e.RowIndex];
                var customer = (Customer)selectedRow.DataBoundItem;


                var editForm = new AddCustomer(customer);
                editForm.ShowDialog();


                LoadCustomer();
            }
        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
