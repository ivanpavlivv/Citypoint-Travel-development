using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitypointTravel.Data.Models;

namespace CitypointTravel.Data.Interfaces
{
    public interface ICity
    {
        IEnumerable<City> cityList { get; }
        IEnumerable<City> getFavCity { get; }
        City getObjectCity(int cityId);
    }
}
