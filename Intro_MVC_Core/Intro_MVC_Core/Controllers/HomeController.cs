using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {

        }

        public ViewResult Class()
        {
            return View();
        }
    }
}
