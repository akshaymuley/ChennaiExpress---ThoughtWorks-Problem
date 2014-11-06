using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public interface ITrain
    {
        List<string> Stations { get; }

        int GetStops(string source, string Destination);

    }    
}
