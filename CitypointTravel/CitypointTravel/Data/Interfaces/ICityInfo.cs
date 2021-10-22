using CitypointTravel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Interfaces
{
    public interface ICityInfo
    {
        IEnumerable<CityInfo> InfoList { get; }
        CityInfo Info { get; }
        CityInfo GetObjectCityInfo(int infoId);
    }
}
