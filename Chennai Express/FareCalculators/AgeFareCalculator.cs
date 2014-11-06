using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public class AgeFareCalculator : FareDecorator
    {
        private const int MaximumAgeForFreeJourney = 5;

        public AgeFareCalculator(IFareCalculator fareCalculator): base(fareCalculator)
        {
        }

        public override double GetFare(ITicket ticket)
        {
            if (ticket.AgeOfPassenger < MaximumAgeForFreeJourney)
                return 0;
            return baseFareCalculator.GetFare(ticket);
        }
    }
}
