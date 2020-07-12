using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using MvcMovie.Services;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //FromServices sample
        public IActionResult About([FromServices] IDateTime dateTime)
        {
            return Content($"Current server time: {dateTime.Now}");
        }

        public IActionResult Index()
        {
            ViewData["sample"] = "My Name is..";
            Person person = new Person();
            person.id = 5;
            person.name = "Mike";
            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string FormParsing(int id, string name)
        {
            return "id " + id + " name " + name;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class AwayController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AwayController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "this is away index!";
        }

        public string Privacy()
        {
            return "this is away Privacy!";
        }
    }
}
