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
        private readonly ICityInfo _citiesInfo;

        public CitiesController(ICity iCities, ICityInfo iCityInfo)
        {
            _cities = iCities;
            _citiesInfo = iCityInfo;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Список міст для подорожі";
            CitiesListViewModel obj = new CitiesListViewModel();
            obj.AllCities = _cities.CityList;
            obj.AllInfo = _citiesInfo.InfoList;
            return View(obj);
        }

        public ViewResult BudapestInfo()
        {
            ViewBag.Title = "Місто Будапешт";
            CitiesListViewModel obj = new CitiesListViewModel();
            obj.AllCities = _cities.CityList;
            obj.AllInfo = _citiesInfo.InfoList;
            obj.CurrInfo = _citiesInfo.Info;
            return View(obj);
        }
    }
}
