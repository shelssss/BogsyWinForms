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

    public partial class DashboardForm : Form
    {
        private CustomerListForm customerForm;
        private VideosForm vidForm;
        private dashForm dashForm;
        private CustomerRentedList AllRentsForm;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            dashForm = new dashForm();
            dashForm.FormClosed += dashboardForm_FormClose;
            dashForm.MdiParent = this;
            dashForm.Dock = DockStyle.Fill;
            dashForm.Show();
        }
        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            CloseAllChildForms();

            if (dashForm == null)
            {
                dashForm = new dashForm();
                dashForm.FormClosed += dashboardForm_FormClose;
                dashForm.MdiParent = this;
                dashForm.Dock = DockStyle.Fill;
                dashForm.Show();

            }
            else
            {
                dashForm.Activate();
            }
        }

        private void dashboardForm_FormClose(object sender, FormClosedEventArgs e)
        {
            dashForm = null;
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (customerForm == null)
            {
                customerForm = new CustomerListForm();
                customerForm.FormClosed += CustomerForm_FormClose;
                customerForm.MdiParent = this;
                customerForm.Dock = DockStyle.Fill;
                customerForm.Show();
            }
            else
            {
                customerForm.Activate();
            }
        }

        private void CustomerForm_FormClose(object sender, FormClosedEventArgs e)
        {
            customerForm = null;
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (vidForm == null)
            {
                vidForm = new VideosForm();
                vidForm.FormClosed += VideoForm_FormClose;
                vidForm.MdiParent = this;
                vidForm.Dock = DockStyle.Fill;
                vidForm.Show();
            }
            else
            {
                vidForm.Activate();
            }
        }

        private void VideoForm_FormClose(object sender, FormClosedEventArgs e)
        {
            vidForm = null;
        }



        private void AllRentsBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (AllRentsForm == null)
            {
                AllRentsForm = new CustomerRentedList();
                AllRentsForm.FormClosed += AllRents_FormClose;
                AllRentsForm.MdiParent = this;
                AllRentsForm.Dock = DockStyle.Fill;
                AllRentsForm.Show();
            }
            else
            {
                AllRentsForm.Activate();
            }
        }

        private void AllRents_FormClose(object sender, FormClosedEventArgs e)
        {
            AllRentsForm = null;
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
