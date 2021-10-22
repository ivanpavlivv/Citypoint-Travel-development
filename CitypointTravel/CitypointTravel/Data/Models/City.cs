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
        public bool IsFavourite { get; set; }

        public virtual CityInfo CityInfo { get; set; }

    }
}
