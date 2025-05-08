using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class CustomerQueries
    {
        public Guid Id { get; set; }   
        public string Username { get; set; }
        public string Reason { get; set; }  
        public string Status { get; set; }
    }
}
