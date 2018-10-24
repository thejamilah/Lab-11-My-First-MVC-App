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
            return RedirectToAction("Results", new { BeginningYear = fromYear, EndingYear = toYear });
        }

        public IActionResult Results(int fromYear, int toYear)
        {
            TimePerson TimePerson = new TimePerson();

            return View(TimePerson.GetPersons(fromYear, toYear));
        }

    }
}
