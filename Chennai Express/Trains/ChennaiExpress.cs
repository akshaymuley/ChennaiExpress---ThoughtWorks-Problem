using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chennai_Express
{
    public class ChennaiExpress : ITrain
    {
        private List<string> stations;

        List<string> ITrain.Stations
        {
            get { return stations; }
        }

        public ChennaiExpress()
        {
            stations = new List<string>();
            InitializeStations();
        }

        public int GetStops(string source, string destination)
        {
            if(!IsValidJourney(source, destination))
                return -1;
            return stations.IndexOf(destination) - stations.IndexOf(source) + 1;
        }

        private bool IsValidJourney(string source, string destination)
        {
            if(!IsStationValid(source) || !IsStationValid(destination))
                return false;

            return stations.IndexOf(source) < stations.IndexOf(destination);
        }

        private bool IsStationValid(string station)
        {
            return stations.IndexOf(station)!=-1;
        }

        private void InitializeStations()
        {
            stations.Add("Station 1");
            stations.Add("Station 2");
            stations.Add("Station 3");
            stations.Add("Station 4");
            stations.Add("Station 5");
            stations.Add("Station 6");
            stations.Add("Station 7");
            stations.Add("Station 8");
            stations.Add("Station 9");
            stations.Add("Station 10");
            stations.Add("Station 11");
            stations.Add("Station 12");
            stations.Add("Station 13");
            stations.Add("Station 14");
            stations.Add("Station 15");
            stations.Add("Station 16");
        }        
    }
}
