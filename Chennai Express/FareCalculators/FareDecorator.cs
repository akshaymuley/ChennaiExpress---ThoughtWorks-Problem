using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public abstract class FareDecorator: IFareCalculator
    {
        protected IFareCalculator baseFareCalculator;

        public FareDecorator(IFareCalculator fareCalculator)
        {
            this.baseFareCalculator = fareCalculator;
        }

        public abstract double GetFare(ITicket ticket);
    }
}
