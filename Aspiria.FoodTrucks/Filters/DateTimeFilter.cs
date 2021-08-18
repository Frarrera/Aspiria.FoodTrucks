using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspiria.FoodTrucks.Filters
{
    public class DateTimeFilter
    {
        public int Day { get; set; }
        public TimeSpan Time { get; set; }
    }
}
