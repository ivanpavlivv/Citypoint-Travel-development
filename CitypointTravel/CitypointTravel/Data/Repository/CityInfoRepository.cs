using CitypointTravel.Data.Interfaces;
using CitypointTravel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Repository
{
    public class CityInfoRepository : ICityInfo
    {
        private readonly AppDBContext _context;

        public CityInfoRepository(AppDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<CityInfo> InfoList => _context.CitiesInfo;

        public CityInfo Info => _context.CitiesInfo.Find(1);

        public CityInfo GetObjectCityInfo(int id) => _context.CitiesInfo.FirstOrDefault(c => c.Id == id);
    }
}
