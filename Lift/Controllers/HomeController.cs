using System;
using Microsoft.AspNetCore.Mvc;
using Lift.Models;
using Lift.Service.User;

namespace Lift.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("MenuInterface");
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
