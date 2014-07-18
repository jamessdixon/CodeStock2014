using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.FrequentFlyerCalculator.CS
{
    public class CalculationEngine
    {
        Flight _flight = null;
        Customer _customer = null;
        public CalculationEngine(Flight flight, Customer customer)
        {
            if (flight == null)
            {
                throw new ArgumentNullException("flight");
            }
            if (customer == null)
            {
                throw new ArgumentNullException("customer");
            }
            _flight = flight;
            _customer = customer;
            
        }

        public double CalculateFrequentFlyerMiles()
        {
            Int32 baseMiles = _flight.FlightMiles;

            if (_customer.JoinDate > DateTime.Now.AddYears(-1))
            {
                if (_customer.IsGold && _customer.InternationalTraveler && _flight.InternationalFlight)
                {
                    return baseMiles * 1.5;
                }
                else if (_customer.IsSilver && _customer.InternationalTraveler && _flight.InternationalFlight)
                {
                    return baseMiles * 1.25;
                }
            }
            else
            {
                if (_customer.IsGold && _customer.InternationalTraveler && _flight.InternationalFlight)
                {
                    return baseMiles * 1.05;

                }
                else if (_customer.IsSilver && _customer.InternationalTraveler && _flight.InternationalFlight)
                {
                    return baseMiles * 1.01;

                }
            }

            if (_customer.Name == "The Boss")
            {
                return baseMiles * 1.3;
            }

            return _flight.FlightMiles;
        }


    }
}
