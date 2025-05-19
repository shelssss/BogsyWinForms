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

namespace BogsyVideoStore.AdminForms
{
    public partial class ForgotListForm : Form
    {
        public ForgotListForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ForgotListForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var queries = context.CustomerQueries.ToList();
                ForgotListGrid.DataSource = queries;
                DisplayHelper.DisplayDefaults(ForgotListGrid);
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string searchValue = searchBar.Text.Trim().ToLower();

                var filtered = FilterResults.SearchCustomerQuery(context, searchValue);

                ForgotListGrid.DataSource = filtered;
                DisplayHelper.DisplayDefaults(ForgotListGrid);
            }
        }

        private void ForgotListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new AppDbContext())
                {   
                    var selectedRow = ForgotListGrid.Rows[e.RowIndex];
                    var query = (CustomerQueries)selectedRow.DataBoundItem;

                    var username = query.Username;

                    var customer = context.Customer.FirstOrDefault(c => c.Username == username);

                    if(customer != null)
                    {
                        var changePassForm = new PasswordChange(customer);
                        changePassForm.ShowDialog();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(StringHelpers.usernameNotFound);
                    }
                    

                }
               
            }
        }
    }
}
