using CitypointTravel.Data.Interfaces;
using CitypointTravel.Data.Models;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
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

        public CityInfo GetInfo(int id) => _context.CitiesInfo.Find(id);

        public CityInfo GetObjectCityInfo(int id) => _context.CitiesInfo.FirstOrDefault(c => c.Id == id);

        public string ParseInfo()
        {
            var url = @"https://www.numbeo.com/cost-of-living/in/Budapest?displayCurrency=UAH";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body/div[@class = 'innerWidth']/" +
                "table[@class = 'data_wide_table new_bar_table']/tr[2]/td[2]");

            return node.InnerText;
        }
    }
}
