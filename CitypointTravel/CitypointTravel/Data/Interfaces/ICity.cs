using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitypointTravel.Data.Models;

namespace CitypointTravel.Data.Interfaces
{
    public interface ICity
    {
        IEnumerable<City> CityList { get; }
        IEnumerable<City> GetFavCity { get; }
        City getObjectCity(int cityId);
    }
}
