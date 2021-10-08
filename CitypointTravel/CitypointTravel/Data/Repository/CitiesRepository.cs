using CitypointTravel.Data.Interfaces;
using CitypointTravel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Data.Repository
{
    public class CitiesRepository : ICities
    {
        private readonly AppDBContent appDBContent;

        public CitiesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Cities> cityList => appDBContent.Cities;             //???

        public IEnumerable<Cities> getFavCity => appDBContent.Cities.Where(c => c.isFavourite);

        public Cities getObjectCity(int cityId) => appDBContent.Cities.FirstOrDefault(c => c.id == cityId);
    }
}
