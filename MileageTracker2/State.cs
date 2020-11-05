using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO; 

namespace MileageTracker2
{
    [Serializable]
    public class State
    {
        private string name; 
        public string Name { get { return name; } }
        public SortedDictionary<string, string> Locations = new SortedDictionary<string, string>() 
        {
            {"Home", "your home address"},
            {"Route 66 Casino", "14500 Central Ave SW, Albuquerque, New Mexico 87121" },
            {"The Downs Racetrack and Casino", "145 Louisiana Blvd NE, Albuquerque, New Mexico 87108" },
            {"Isleta Resort and Casino", "11000 Broadway Blvd SE, Bosque Farms, NM 87105" },
            {"Palace West Casino", "Moonlight Dr, Albuquerque, New Mexico 87105" },
            {"Inn of the Mountain Gods Resort and Casino", "287 Carrizo Canyon Rd, Mescalero, New Mexico 88340" },
            {"Casino Apache Travel Center", "25845 US Highway 70, Mescalero, New Mexico 88340" },
            {"Sandia Resort and Casino", "30 Rainbow Rd NE, Albuquerque, New Mexico 87113" },
            {"Santa Ana Star Casino Hotel", "54 Jemez Canyon Dam Road, Santa Ana Pueblo, New Mexico 87004" },
            {"Northern Edge Navajo Casino", "2752 Navajo Route 36, Fruitland, New Mexico 87416" },
            {"Black Mesa Casino", "25 Hagen Rd, San Felipe, New Mexico 87001" },
            {"Tesuque Casino", "7 Tesuque Rd, Santa Fe, New Mexico 87506" },
            {"Buffalo Thunder Casino", "20 Buffalo Thunder Trl, Santa Fe, New Mexico 87506" },
            {"Cities of Gold Hotel Casino", "10-A Cities of Gold Road, Santa Fe, New Mexico 87506" },
            {"Santa Claran Hotel Casino", "460 N Riverside Dr, Espanola, New Mexico 87532" },
            {"Ohkay Hotel Casino", "68 New Mexico 291, Ohkay Owingeh, New Mexico 87566" },
            {"Zia Park Casino", "3901 W Millen Dr, Hobbs, New Mexico 88240" },
        };
        public DistanceKeeper distanceKeeper;
        public string mileageTrackerFolderPath { get; private set; }
        public string statesFolderPath { get; private set; }
        public string StateFilePath { get; private set; }       

        public State(string stateName)
        {
            name = stateName;
            distanceKeeper = new DistanceKeeper(stateName);
            createStateFilePaths(stateName); 
        }

        public void SaveState()
        {
            if (!Directory.Exists(mileageTrackerFolderPath))
            {
                Directory.CreateDirectory(mileageTrackerFolderPath);
                Directory.CreateDirectory(statesFolderPath); 
            }

            using (Stream output = File.Create(StateFilePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, this); 
            }
        }
        public void LoadState(string pathOfFileToOpen)
        {
            if (File.Exists(pathOfFileToOpen))
            {
                State tempState;
                using (Stream input = File.OpenRead(pathOfFileToOpen))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    tempState = (State)formatter.Deserialize(input);
                }
                Locations = tempState.Locations;
                name = tempState.Name;
                distanceKeeper = tempState.distanceKeeper;                 
            }
             
        }
        public bool IsLocationNew(string location)
        {
            bool isNew = true;
            foreach (string key in Locations.Keys)
            {
                if (location == key)
                {
                    isNew = false;
                    return isNew; 
                }
            }
            return isNew; 
        }
        public void AddLocation(string locationName, string address)
        {
            Locations.Add(locationName, address); 
        }
        private void createStateFilePaths(string stateName)
        {
            mileageTrackerFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Mileage Tracker"; 
            statesFolderPath = mileageTrackerFolderPath + @"\States"; 
            StateFilePath = statesFolderPath + @"\" + stateName + ".dat";
        }

        
    }
}
