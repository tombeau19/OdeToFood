using System;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //about
    [Route("about")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "339-206-5563";
        }

        [Route("address")]
        public string Address()
        {
            return "USA!";
        }
    }
}
