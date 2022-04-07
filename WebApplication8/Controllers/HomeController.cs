﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;
using WebApplication8.Services.SmsService;
using System.Diagnostics;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmsService _smsService;

        public HomeController(ISmsService smsService)
        {
            _smsService = smsService;
        }


        public IActionResult Index()
        {
            var result = _smsService.Send(new SmsModel()
            {
                TelefonNo = "12345",
                Mesaj = "home/index çalıştı"
            });
            return View();
        }

        public IActionResult Privacy()
        {
            var result = _smsService.Send(new SmsModel()
            {
                TelefonNo = "12345",
                Mesaj = "home/index çalıştı"
            });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}