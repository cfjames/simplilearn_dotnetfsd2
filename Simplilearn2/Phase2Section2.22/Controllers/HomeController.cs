﻿using Microsoft.AspNetCore.Mvc;
using Phase2Section2._22.Models;
using System.Diagnostics;

namespace Phase2Section2._22.Controllers
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

        public IActionResult StudentInfo()
        {
            return View();
        }

        public IActionResult TeacherInfo()
        {
            return View();
        }
    }
}