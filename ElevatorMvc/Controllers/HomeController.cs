﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElevatorMvc.Models;
using ElevatorLibrary;

namespace ElevatorMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var el = new Elevator
            {
                Name = "2nd elevator is working."
            };
            return View(el);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
