using CitypointTravel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.ViewModels
{
    public class CitiesListViewModel
    {
        public IEnumerable<Cities> allCities { get; set; }
    }
}
