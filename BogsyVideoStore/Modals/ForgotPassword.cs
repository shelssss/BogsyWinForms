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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
           string username = usernameTxt.Text.Trim();
           string reason = reasonTxt.Text.Trim();

            using (var context = new AppDbContext()) 
            { 
                var customer = context.Customer.FirstOrDefault(x => x.Username == username);

                if (customer == null)
                {
                    MessageBox.Show("Username does not Exist");
                }
                else
                {
                    var PassReset = new CustomerQueries
                    {
                        Id = Guid.NewGuid(),
                        Username = username,
                        Reason = reason,
                        Status = "Pending"
                    };
                   context.CustomerQueries.Add(PassReset);  
                }
                context.SaveChanges();
                //add message dialog

            }
            this.Close();
        }
    }
}
