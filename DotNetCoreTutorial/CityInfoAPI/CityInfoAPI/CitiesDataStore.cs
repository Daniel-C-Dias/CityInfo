﻿using System.Collections.Generic;
using CityInfoAPI.Models;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                 new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with the big park"
            },

            new CityDto()
            {
                Id = 2,
                Name = "Antwerp",
                Description = "The one with the cathedral that was never finished."
            },

            new CityDto()
            {
                Id = 3,
                Name = "Paris",
                Description = "The one with that big tower"
            }
            };
        }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
    }
}