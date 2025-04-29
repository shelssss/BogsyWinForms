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
    public partial class dashForm : Form
    {
        public dashForm()
        {
            InitializeComponent();
            loadCount();
        }


        private void loadCount()
        {
            using (var context = new AppDbContext())
            {
                var userCount = context.Customer.Count();
                userNumLbl.Text = userCount.ToString();

                var vcdCount = context.Video.Where(vcd => vcd.Category == "VCD").Count();
                vcdNumLbl.Text = vcdCount.ToString();

                var dvdCount = context.Video.Where(dvd => dvd.Category == "DVD").Count();
                dvdNumLbl.Text = dvdCount.ToString();

                var overDues = context.CustomerRented.Where(c => c.status == "Overdue").Count();
                overNumLbl.Text = overDues.ToString();

                var totalSales = context.CustomerRented.Sum(r => r.RentCost + r.LateReturnFee);
                totalSalesLbl.Text = totalSales.ToString("C");
            }
        }
    }
}
