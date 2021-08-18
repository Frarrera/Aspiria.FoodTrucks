using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspiria.FoodTrucks.Models
{
    public class FoodTruck
    {
        public string Applicant { get; set; }

        public string LocationDesc { get; set; }
        public string Start24 { get; set; }
        public string End24 { get; set; }

        public int DayOrder { get; set; }
    }
}
