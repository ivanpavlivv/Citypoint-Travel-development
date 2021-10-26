using CitypointTravel.Data;
using CitypointTravel.Data.Interfaces;
using CitypointTravel.Data.Models;
using CitypointTravel.Data.Repository;
using CitypointTravel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly AppDBContext _context;

        public CitiesController(ICity iCities, ICityInfo iCityInfo, AppDBContext context)
        {
            _cities = iCities;
            _citiesInfo = iCityInfo;
            _context = context;
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
            obj.CurrInfo = _citiesInfo.GetInfo(1);
            return View(obj);
        }

        public IActionResult UpdateCityInfo()
        {
            CityInfo cityInfo = _context.CitiesInfo.FirstOrDefault(c => c.Id == 1);
            cityInfo.CostOfFood = _citiesInfo.ParseInfo();
            _context.CitiesInfo.Update(cityInfo);
            _context.SaveChanges();
            return View("SuccessfulUpdate");
        }
    }
}
