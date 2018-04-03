using System;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //about
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "339-206-5563";
        }

        public string Address()
        {
            return "USA!";
        }
    }
}
