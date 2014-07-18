using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.FrequentFlyerCalculator.CS
{
    public class Customer
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Boolean IsSilver { get; set; }
        public Boolean IsGold { get; set; }
        public Boolean InternationalTraveler { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
