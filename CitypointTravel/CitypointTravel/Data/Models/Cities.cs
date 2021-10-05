using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Models
{
    public class Cities
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string shortDescription { get; set; }
        public string weather { get; set; }
        public double costOfFood { get; set; }                  // UAH
        public double taxiCost { get; set; }                    //1 km
        public double apartmentCost { get; set; }               // UAH per square meter
        public string qualityOfLife { get; set; }
        public double costOfLiving { get; set; }                // UAH per month
        public double distance { get; set; }                    // km
        public double cityRating { get; set; }
        public double pollutionIndex { get; set; }
        public bool isFavourite { get; set; }
        public List<Cities> cities { get; set; }
    }
}
