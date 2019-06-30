using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Potok.Models
{
    public class Parcel
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public decimal Weight { get; set; }
        public decimal PriceOfDelivery { get; set; }
        public int DaysLeft { get; set; }
        public string Status { get; set; }
    }
}