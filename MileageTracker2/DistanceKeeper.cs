using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 

namespace MileageTracker2
{
    [Serializable]
    public class DistanceKeeper
    {
        private string name; 
        public string Name { get { return name; } }

        
        public DistanceKeeper(string name)
        {
            this.name = name; 
        }
        public Dictionary<string, int> Distances = new Dictionary<string, int>(); 

        public int ReturnDistanceBetweenLocations(string loc1, string loc2)
        {
            int milesBetween = 0;
            string locations1 = loc1 + ", " + loc2;
            string locations2 = loc2 + ", " + loc1; 

            foreach (string key in Distances.Keys)
            {
                if (locations1 == key || locations2 == key)                
                    milesBetween = Distances[key];                
            }
            return milesBetween; 
        }
        public void EnterMilesBetween(string locations, int miles)
        {
            Distances.Add(locations, miles); 
        }
        
    }
}
