using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public interface ITicket
    {
        string Source { get; }

        string Destination { get; }

        double AgeOfPassenger { get; }

        double LuggageWeight { get; }
    }
}
