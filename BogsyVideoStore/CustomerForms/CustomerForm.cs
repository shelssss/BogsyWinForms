using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BogsyVideoStore.Helpers;
using BogsyVideoStore.Models;


namespace BogsyVideoStore
{
    public partial class CustomerForm : Form
    {
        private RentVideoForm RentVidForm;
        private Customer currentCustomer;
        private RentedVidForm RentedListForm;
        CloseChildrenMDI CloseChildrenMDI = new CloseChildrenMDI();
      
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;

            RentVidForm = new RentVideoForm(currentCustomer.Name);
            RentVidForm.FormClosed += RentVidForm_FormClose;
            RentVidForm.MdiParent = this;
            RentVidForm.Dock = DockStyle.Fill;
            RentVidForm.Show();

        }
        
        private void videoBtn_Click(object sender, EventArgs e)
        {
            CloseChildrenMDI.CloseAllChildForms();
            if (RentVidForm == null)
            {
                RentVidForm = new RentVideoForm(currentCustomer.Name);
                RentVidForm.FormClosed += RentVidForm_FormClose;
                RentVidForm.MdiParent = this;
                RentVidForm.Dock = DockStyle.Fill;
                RentVidForm.Show();
            }
            
            else
            {
                RentVidForm.Activate();
            }
        }

        private void RentVidForm_FormClose(object sender, FormClosedEventArgs e)
        {
            RentVidForm = null;
        }

        private void RentVidBtn_Click(object sender, EventArgs e)
        {
            CloseChildrenMDI.CloseAllChildForms();
            if (RentedListForm == null)
            {
                RentedListForm = new RentedVidForm(currentCustomer.Name);
                RentedListForm.FormClosed += RentedListForm_FormClose;
                RentedListForm.MdiParent = this;
                RentedListForm.Dock = DockStyle.Fill;
                RentedListForm.Show();
            }
            else
            {
                RentedListForm.Activate();
            }
        }

        private void RentedListForm_FormClose(object sender, FormClosedEventArgs e)
        {
            RentedListForm = null;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }


    }
}
