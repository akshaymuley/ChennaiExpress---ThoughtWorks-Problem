using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public class Ticket : ITicket
    {
        public string Source  
        {
            get;
            private set;
        }

        public string Destination
        {
            get;
            private set;
        }

        public double AgeOfPassenger
        {
            get;
            private set;
        }

        public double LuggageWeight
        {
            get;
            private set;
        }

        public Ticket(string source, string destination, double ageOfPassenger, double luggageWeight)
        {
            Source = source;
            Destination = destination;
            AgeOfPassenger = ageOfPassenger;
            LuggageWeight = luggageWeight;
        }
    }
}
