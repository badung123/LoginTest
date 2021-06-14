using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TelCoTestLogin.Entities;
using TelCoTestLogin.Models;

namespace TelCoTestLogin.Controllers
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
            var details = new List<CardDetails>() {
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "10007803219293",
                    CardValue = 100000,
                    Time = "11/06/2021 13:47:39",
                    Status = "Thành công",
                    TransactionBefore = 11226600,
                    Success = 80000,
                    Description = "Cộng 80,000 cho tài khoản. Telco: VTT-Seri: 10007803219293-Mã thẻ: 014557080219477",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "10007214401844",
                    CardValue = 0,
                    Time = "08/06/2021 21:07:37",
                    Status = "Thẻ sai",
                    TransactionBefore = 0,
                    Success = 0,
                    Description = "Nạp thẻ thất bại",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "10007794445648",
                    CardValue = 0,
                    Time = "12/06/2021 16:24:44",
                    Status = "Thẻ sai",
                    TransactionBefore = 0,
                    Success = 0,
                    Description = "Nạp thẻ thất bại",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "10007397348087",
                    CardValue = 0,
                    Time = "12/06/2021 14:55:21",
                    Status = "Thẻ sai",
                    TransactionBefore = 0,
                    Success = 0,
                    Description = "Nạp thẻ thất bại",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "10006625533408",
                    CardValue = 50000,
                    Time = "30/05/2021 16:34:01",
                    Status = "Thành công",
                    TransactionBefore = 11188100,
                    Success = 38500,
                    Description = "Cộng 80,000 cho tài khoản. Telco: VTT-Seri: 10007803219293-Mã thẻ: 014557080219477",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "10007881440715",
                    CardValue = 0,
                    Time = "25/05/2021 21:21:52",
                    Status = "Thẻ sai",
                    TransactionBefore = 0,
                    Success = 0,
                    Description = "Nạp thẻ thất bại",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "53510280946205",
                    CardValue = 0,
                    Time = "06/06/2021 14:58:52",
                    Status = "Thẻ sai",
                    TransactionBefore = 0,
                    Success = 0,
                    Description = "Nạp thẻ thất bại",
                },
                new CardDetails() {
                    Company = "VTT",
                    SerialNumber = "092071002036721",
                    CardValue = 0,
                    Time = "25/05/2021 16:23:00",
                    Status = "Thẻ sai",
                    TransactionBefore = 0,
                    Success = 0,
                    Description = "Nạp thẻ thất bại",
                }
            };
            ViewBag.Details = details;
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
