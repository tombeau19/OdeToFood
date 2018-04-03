using System;
using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Tommy's"},
                new Restaurant { Id = 2, Name = "Billy's" },
                new Restaurant { Id = 3, Name = "Freddy's"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }
}
