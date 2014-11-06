using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public class FareCalculator : IFareCalculator
    {
        private const double MinimumFare = 10.0;

        private const int NumberOfStationForMinimumFare = 5;

        private const int NextChargableStations = 5;

        private const double FareForNextChargableStations = 5;

        private ITrain train;

        public FareCalculator(ITrain train)
        {
            this.train = train;
        }

        public double GetFare(ITicket ticket)
        {
            double totalFare = MinimumFare;
            int numberOfStops = train.GetStops(ticket.Source, ticket.Destination);

            if (numberOfStops < NumberOfStationForMinimumFare)
                return totalFare;
            numberOfStops -= NumberOfStationForMinimumFare;
            totalFare += (Math.Ceiling((double)(numberOfStops / NextChargableStations))) * FareForNextChargableStations;
            
            return totalFare;
        }
    }
}
