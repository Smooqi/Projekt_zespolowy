using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;
using System;
using System.Collections.Generic;

namespace SimpleMVC.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            var model = new ChartViewModel
            {
                Labels = new List<string> { "Category A", "Category B", "Category C" },
                Data = new List<int> { GenerateRandomValue(), GenerateRandomValue(), GenerateRandomValue() }
            };

            return View(model);
        }

        private int GenerateRandomValue()
        {
            return new Random().Next(1, 100);
        }
    }
}
