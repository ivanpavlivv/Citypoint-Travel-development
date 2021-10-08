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
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Cities.Any())
                content.Cities.AddRange(
                    new Cities
                    {
                        name = "Budapest",
                        shortDescription = "Capital of Hungary.",
                        img = "/img/Budapest.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Praha",
                        shortDescription = "Capital of Czech Republic.",
                        img = "/img/Prague.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Viena",
                        shortDescription = "Capital of Austria.",
                        img = "/img/Viena.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Katowice",
                        shortDescription = "Thist place is the capital city of the Silesian Voivodeship in south-west Poland.",
                        img = "/img/Katowice.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Linz",
                        shortDescription = "Linz is the capital of Upper Austria and third-largest city in Austria.",
                        img = "/img/Linz.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Brno",
                        shortDescription = "Brno is the former capital city of Moravia and the political and cultural hub of the South Moravian Region.",
                        img = "/img/Brno.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Salzburg",
                        shortDescription = "Salzburg is the fourth-largest city in Austria.",
                        img = "/img/Salzburg.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Ostrava",
                        shortDescription = "Ostrava is a city in the north-east of the Czech Republic, and the capital of the Moravian-Silesian Region.",
                        img = "/img/Ostrava.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Dresden",
                        shortDescription = "Dresden is the capital city of the German state of Saxony and its second most populous city.",
                        img = "/img/Dresden.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    },

                    new Cities
                    {
                        name = "Leipzig",
                        shortDescription = "Leipzig is an economic centre, is rated as the most livable city in Germany.",
                        img = "/img/Leipzig.jpg",
                        weather = "",
                        costOfFood = 150,
                        taxiCost = 150,
                        apartmentCost = 150,
                        qualityOfLife = "",
                        costOfLiving = 150,
                        distance = 150,
                        cityRating = 10,
                        pollutionIndex = 10,
                        isFavourite = true
                    }
                    );
            content.SaveChanges();
        }
    }
}
