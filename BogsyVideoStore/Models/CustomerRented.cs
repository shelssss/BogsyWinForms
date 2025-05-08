using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class CustomerRented
    {
        public Guid Id { get; set; }
        public string CustomerUsername { get; set; }
        public string VideoId { get; set; } 
        public string VideoRented { get; set; }
        public DateOnly RentedDate { get; set; }
        public DateOnly? ReturnedDate {  get; set; }
        public int RentCost { get; set; }
        public int LateReturnFee { get; set; } = 0;
        public string status { get; set; } 

    }
}
