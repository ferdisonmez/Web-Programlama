using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaV2_Net5._0.Models;

namespace WebProgramlamaV2_Net5._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static public List<User> db = new List<User>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Isara()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult IlanVer()
        {
           
            return View();
        }

        public IActionResult IlanBasvuru()
        {
           
            return View();
        }
        public IActionResult UserKayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Bastir(User user)
        {
            db.Add(user);
            return RedirectToAction("Goster");

        }
        public IActionResult Goster()
        {
            return View(db);
        }
        [HttpPost]
        public IActionResult UserEnter(User usr)
        {
            return View(usr);
        }

        public IActionResult PatronKayit()
        {
            return View();
        }
        public IActionResult YazilimciKayit()
        {
            return View();
        }
        
        public IActionResult PatronORYazilimci()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PatronORYazilimci1(String Deger)
        {
            if (Deger == "Patron")
            {
                return RedirectToAction("PatronKayit");
            }
            else
            {
                return RedirectToAction("YazilimciKayit");
            }
         
        }
        public IActionResult PatronEnter()
        {
            return View();
        }
        public IActionResult YazilimciEnter()
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
