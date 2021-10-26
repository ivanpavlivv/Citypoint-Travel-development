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
        CityInfo GetInfo(int Id);
        CityInfo GetObjectCityInfo(int infoId);
        public string ParseInfo();
    }
}
