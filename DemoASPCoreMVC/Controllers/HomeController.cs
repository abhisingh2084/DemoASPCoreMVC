using DemoASPCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoASPCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var studnets = new List<StudentModel> 
            {
                new StudentModel {RollNo = 1, Name = "Abhishek Kumar", Gender = "Male", Standard = 5},
                new StudentModel {RollNo = 1, Name = "Abhishek Kumar", Gender = "Male", Standard = 5},
                new StudentModel {RollNo = 1, Name = "Abhishek Kumar", Gender = "Male", Standard = 5},
                new StudentModel {RollNo = 1, Name = "Abhishek Kumar", Gender = "Male", Standard = 5},

            };

            ViewData["student"] = studnets;
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
