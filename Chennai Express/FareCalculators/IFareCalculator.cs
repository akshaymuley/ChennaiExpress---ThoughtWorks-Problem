using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public interface IFareCalculator
    {
        double GetFare(ITicket ticket);
    }    
}
