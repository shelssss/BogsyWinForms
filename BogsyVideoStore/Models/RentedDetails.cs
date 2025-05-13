using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class RentedDetails
    {
        public string CustomerUsername { get; set; }
        public string VideoRented { get; set; }
        public string Category { get; set; }
        public int MaxRentDays { get; set; }
        public DateOnly RentedDate { get; set; }
        public DateOnly? ReturnedDate { get; set; }
        public int RentCost { get; set; }
        public int LateReturnFee { get; set; }
        public string Status { get; set; }
    }
}
