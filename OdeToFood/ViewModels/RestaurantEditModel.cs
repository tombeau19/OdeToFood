using System;
using OdeToFood.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
