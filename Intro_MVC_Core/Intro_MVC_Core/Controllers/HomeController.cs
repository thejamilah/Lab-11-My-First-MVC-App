using Intro_MVC_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_Core.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int fromYear, int toYear)
        {
            return RedirectToAction("Result", new { fromYear, toYear });
        }

        public IActionResult Result(int fromYear, int toYear)
        {
            TimePerson TimePerson = new TimePerson();

            return View(TimePerson.GetPersons(fromYear, toYear));
        }

    }
}
