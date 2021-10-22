using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitypointTravel.Data.Models;
using CitypointTravel.Data.Interfaces;

namespace CitypointTravel.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContext content)
        {

            if (!content.Cities.Any())
                content.Cities.AddRange(
                    new City
                    {
                        Name = "Budapest",
                        ShortDescription = "Capital of Hungary.",
                        Img = "/img/Budapest.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Praha",
                        ShortDescription = "Capital of Czech Republic.",
                        Img = "/img/Prague.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Viena",
                        ShortDescription = "Capital of Austria.",
                        Img = "/img/Viena.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Katowice",
                        ShortDescription = "Thist place is the capital city of the Silesian Voivodeship in south-west Poland.",
                        Img = "/img/Katowice.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Linz",
                        ShortDescription = "Linz is the capital of Upper Austria and third-largest city in Austria.",
                        Img = "/img/Linz.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Brno",
                        ShortDescription = "Brno is the former capital city of Moravia and the political and cultural hub of the South Moravian Region.",
                        Img = "/img/Brno.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Salzburg",
                        ShortDescription = "Salzburg is the fourth-largest city in Austria.",
                        Img = "/img/Salzburg.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Ostrava",
                        ShortDescription = "Ostrava is a city in the north-east of the Czech Republic, and the capital of the Moravian-Silesian Region.",
                        Img = "/img/Ostrava.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Dresden",
                        ShortDescription = "Dresden is the capital city of the German state of Saxony and its second most populous city.",
                        Img = "/img/Dresden.jpg",
                        IsFavourite = true,
                    },

                    new City
                    {
                        Name = "Leipzig",
                        ShortDescription = "Leipzig is an economic centre, is rated as the most livable city in Germany.",
                        Img = "/img/Leipzig.jpg",
                        IsFavourite = true,
                    }
                    );

            if (!content.CitiesInfo.Any())
                content.CitiesInfo.AddRange(
                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 1
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 2
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 3
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 4
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 5
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 6
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 7
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 8
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 9
                    },

                    new CityInfo
                    {
                        Weather = "",
                        CostOfFood = 150,
                        TaxiCost = 150,
                        ApartmentCost = 150,
                        QualityOfLife = "",
                        CostOfLiving = 150,
                        Distance = 150,
                        CityRating = 10,
                        PollutionIndex = 10,
                        CityId = 10
                    });
            content.SaveChanges();
        }
    }
}
