using CitypointTravel.Data.Interfaces;
using CitypointTravel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Repository
{
    public class CitiesRepository : ICity
    {
        private readonly AppDBContext _context;

        public CitiesRepository(AppDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<City> cityList => _context.Cities;

        public IEnumerable<City> getFavCity => _context.Cities.Where(c => c.IsFavourite);

        public City getObjectCity(int cityId) => _context.Cities.FirstOrDefault(c => c.Id == cityId);
    }
}
