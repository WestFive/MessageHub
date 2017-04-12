using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace MessageHub.Controllers
{
    public class HomeController : Controller
    {
        [EnableCors("AllowAll")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }


        [EnableCors("AllowAll")]
        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }

        [EnableCors("AllowAll")]
        public IActionResult Queue()
        {
            return View();
        }

        [EnableCors("AllowAll")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
