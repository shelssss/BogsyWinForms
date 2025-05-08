using BogsyVideoStore.Helpers;
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
                var userCount = FilterResults.UserCount(context);
                userNumLbl.Text = userCount;

                var vcdCount = FilterResults.VcdCount(context);
                vcdNumLbl.Text = vcdCount;

                var dvdCount = FilterResults.DvdCount(context);
                dvdNumLbl.Text = dvdCount;

                var overDues = FilterResults.OverdueCount(context);
                overNumLbl.Text = overDues;

                var totalSales = FilterResults.TotalSales(context);
                totalSalesLbl.Text = totalSales;
            }
        }

        
    }
}
