using BogsyVideoStore.Modals;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Helpers
{
    public class PrintModule
    {
        public static void PrintRentalDetails(RentDetails form)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                float y = 20;
                Font font = new Font("Arial", 12);
                Brush brush = Brushes.Black;

                e.Graphics.DrawString("Video Rental Details", new Font("Arial", 16, FontStyle.Bold), brush, 20, y);
                y += 40;
                e.Graphics.DrawString($"{form.dateTodayLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Customer: {form.custNameLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Title: {form.titleLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Category: {form.catLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Date Rented: {form.dateRentedLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Return Date: {form.returnedLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Max Rent Days: {form.maxRentLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Rent Cost: {form.costLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Late Fee: {form.ovedueLbl.Text}", font, brush, 20, y);
                y += 25;
                e.Graphics.DrawString($"Total: {form.totalLbl.Text}", font, brush, 20, y);
            };

            PrintDialog dialog = new PrintDialog();
            dialog.Document = printDocument;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
