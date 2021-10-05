using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitypointTravel.Data.Models;

namespace CitypointTravel.Data.Interfaces
{
    public interface ICities
    {
        IEnumerable<Cities> cityList { get; }
        IEnumerable<Cities> getFavCity { get; set; }
        Cities getObjectCity(int cityId);
    }
}
