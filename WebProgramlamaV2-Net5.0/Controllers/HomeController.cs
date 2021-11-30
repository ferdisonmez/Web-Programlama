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
        static public List<String> str = new List<string> {"Ali","Osman","Veli"};

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
            return View(db);
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
        
        public IActionResult UserGirisSecim()
        {
            return View();
        }
        public IActionResult UserKayitSecim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KullaniciRegister(String Deger)
        {
            if (Deger == "Patron")
            {
                return RedirectToAction("PatronKayit");
            }
            else if (Deger=="Admin")
            {
                return RedirectToAction("AdminEnter");
            }
            else
            {
                return RedirectToAction("YazilimciKayit");
            }
         
        }

        [HttpPost]
        public IActionResult KullaniciEnter(String Deger)
        {
            if (Deger == "Patron")
            {
                return RedirectToAction("PatronEnter");
            }
            else if (Deger == "Admin")
            {
                return RedirectToAction("AdminEnter");
            }
            else
            {
                return RedirectToAction("YazilimciEnter");
            }

        }
        public IActionResult AdminEnter()
        {
            return View();
        }
        public IActionResult PatronEnter()
        {
            return View();
        }
        public IActionResult YazilimciEnter()
        {
            return View();
        }

     /*   public ActionResult IsaraDatabase(string option, string search)
        {

            //if a user choose the radio button option as Subject  
            if (option =="Subjects")
            {
                //Index action method will return a view with a student records based on what a user specify the value in textbox  
                return View(db.Students.Where(x = > x.Subjects == search || search == null).ToList());
            }
            else if (option == "Gender")
            {
                return View(db.Students.Where(x = > x.Gender == search || search == null).ToList());
            }
            else
            {
                return View(db.Students.Where(x = > x.Name.StartsWith(search) || search == null).ToList());
            }
        }
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
