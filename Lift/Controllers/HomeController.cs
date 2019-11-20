using System;
using Microsoft.AspNetCore.Mvc;
using Lift.Models;
using System.Collections.Immutable;
using System.Linq;

namespace Lift.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MenuInterface(StartupConfigurations startupConfigurations)
        {
            return View("MenuInterface", startupConfigurations);
        }
       
        public ViewResult LiftInterface()
        {
            return View();
        }

        public ViewResult ExitInterface()
        {
            return View();
        }
    }
}
