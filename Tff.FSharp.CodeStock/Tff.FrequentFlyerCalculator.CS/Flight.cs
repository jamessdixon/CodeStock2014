using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.FrequentFlyerCalculator.CS
{
    public class Flight
    {
        public Int32 Id { get; set; }
        public String StartCity { get; set; }
        public String EndCity { get; set; }
        public Int32 FlightMiles { get; set; }
        public bool InternationalFlight { get; set; }
    }
}
