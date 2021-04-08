using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using montanari.giorgia._5H.SecondaWeb.Models;
using Microsoft.AspNetCore.Authorization;

namespace montanari.giorgia._5H.SecondaWeb.Controllers
{
    public class TXTController : Controller
    {
        private readonly ILogger<TXTController> _logger;

        public TXTController(ILogger<TXTController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Soobin()
        {
            return View();
        }
        public IActionResult Yeonjun()
        {
            return View();
        }
        public IActionResult Beomgyu()
        {
            return View();
        }
        public IActionResult Taehyun()
        {
            return View();
        }
        public IActionResult HueningKai()
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
    }
}
