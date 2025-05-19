using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Helpers
{
    public static class DisplayHelper
    {

        public static void DisplayDefaults(DataGridView grid)
        {
            // Use the Name or Tag of the grid to determine what columns to hide
            var columnsToHide = new List<string>();

            switch (grid.Name)
            {
                case "CustomerGridView":
                    columnsToHide = new List<string> { "Id", "Password" };
                    break;
                case "VideoGridView":
                    columnsToHide = new List<string> { "Id", "ImagePath"};
                    break;
                case "RentedListGrid":
                    columnsToHide = new List<string> { "Id", "VideoId", "customerId" };
                    break;
                case "ForgotListGrid":
                    columnsToHide = new List<string> { "Id" };
                    break;
                case "RentedVidGrid":
                    columnsToHide = new List<string> { "Id", "VideoId", "customerId" };
                    break;
            }

            foreach (var colName in columnsToHide)
            {
                if (grid.Columns.Contains(colName))
                {
                    grid.Columns[colName].Visible = false;
                }
            }
        }
    }
}
