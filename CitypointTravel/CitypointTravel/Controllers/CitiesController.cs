using CitypointTravel.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICities _cities;

        public CitiesController(ICities iCities)
        {
            _cities = iCities;
        }

        public ViewResult List()
        {
            var cities = _cities.cityList;
            return View(cities);
        }
    }
}
