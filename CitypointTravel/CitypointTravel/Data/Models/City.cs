using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string ShortDescription { get; set; }
        public string Weather { get; set; }
        public double CostOfFood { get; set; }
        public double TaxiCost { get; set; }
        public double ApartmentCost { get; set; }
        public string QualityOfLife { get; set; }
        public double CostOfLiving { get; set; }
        public double Distance { get; set; }
        public double CityRating { get; set; }
        public double PollutionIndex { get; set; }

        public bool IsFavourite { get; set; }
    }
}
