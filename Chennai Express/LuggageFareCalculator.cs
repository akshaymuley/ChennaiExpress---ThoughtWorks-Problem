using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public class LuggageFareCalculator: FareDecorator
    {
        private const double PermittedLuggageFreeOfCharge = 10;

        private const double NextChargableLuggageWeight = 2;

        private const double FareForNextChargableLuggageWeight = 5;

        public LuggageFareCalculator(IFareCalculator fareCalculator): base(fareCalculator)
        {
        }

        public override double GetFare(ITicket ticket)
        {
            double totalFare = baseFareCalculator.GetFare(ticket);

            if (ticket.LuggageWeight < PermittedLuggageFreeOfCharge)
                return totalFare;

            totalFare+= Math.Ceiling((ticket.LuggageWeight - PermittedLuggageFreeOfCharge) / NextChargableLuggageWeight) * FareForNextChargableLuggageWeight;

            return totalFare;
        }
    }
}
