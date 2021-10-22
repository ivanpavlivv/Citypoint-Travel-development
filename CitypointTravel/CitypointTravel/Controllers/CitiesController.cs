using CitypointTravel.Data.Interfaces;
using CitypointTravel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitypointTravel.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICity _cities;

        public CitiesController(ICity iCities)
        {
            _cities = iCities;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Список міст для подорожі";
            CitiesListViewModel obj = new CitiesListViewModel();
            obj.allCities = _cities.cityList;
            return View(obj);
        }
    }
}
