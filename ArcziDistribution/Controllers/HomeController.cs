using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArcziDistribution.Models;

namespace ArcziDistribution.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult NewCustomer()
        {
            ViewData["Message"] = "New Klient";

            return View();
        }
        public IActionResult NewVehicle()
        {
            ViewData["Message"] = "Nowy Pojazd";

            return View();
        }
        public IActionResult NewService()
        {
            ViewData["Message"] = "Nowa Usługa";

            return View();
        }
        public IActionResult NewReminder()
        {
            ViewData["Message"] = "Przypomnienia";

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
