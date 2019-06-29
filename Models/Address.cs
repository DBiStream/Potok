using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Potok.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string Appartment { get; set; }
    }
}