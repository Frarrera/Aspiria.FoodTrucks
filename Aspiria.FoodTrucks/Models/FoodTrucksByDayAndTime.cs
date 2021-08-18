using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspiria.FoodTrucks.Models
{
    public class FoodTrucksByDayAndTime
    {
        public int Day { get; set; }
        public TimeSpan Time { get; set; }
        public List<FoodTruck> FoodTrucks { get; set; }
    }
}
