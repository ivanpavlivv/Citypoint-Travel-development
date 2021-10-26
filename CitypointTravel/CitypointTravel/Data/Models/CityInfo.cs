using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Models
{
    public class CityInfo
    {
        public int Id { get; set; }
        public string Weather { get; set; }
        public string CostOfFood { get; set; }
        public double TaxiCost { get; set; }
        public double ApartmentCost { get; set; }
        public string QualityOfLife { get; set; }
        public double CostOfLiving { get; set; }
        public double Distance { get; set; }
        public double CityRating { get; set; }
        public double PollutionIndex { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
