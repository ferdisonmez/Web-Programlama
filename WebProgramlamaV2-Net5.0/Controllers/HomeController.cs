using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebProgramlamaV2_Net5._0.Models;

namespace WebProgramlamaV2_Net5._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static public List<Patron> db = new List<Patron>();
        static public List<Yazilimci> dby = new List<Yazilimci>();
        static public List<Isilani> ilanlar = new List<Isilani>();
        
        Context dbServer = new Context();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
         
            ilanlar = dbServer.isilanlari.ToList();
            return View(ilanlar);
        }


        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(dbServer.isilanlari.Find(id));
        }
        public JsonResult GetAll()
        {
            return Json(dbServer.isilanlari.ToList());
        }


        [HttpGet]

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("Index");
        }







        public IActionResult Isara()
        {
            ilanlar = dbServer.isilanlari.ToList();
            return View(ilanlar);
        }

        public IActionResult IlanSayfasi(int id)
        {
            var ilan = dbServer.isilanlari.Find(id);

            return View(ilan);
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult IlanVer()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult IlanBasvuru()
        {
            //
            return View();
        }

        public IActionResult PatronKayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PatronKayitBackend(Patron ptr)
        {
            ptr.Rolename = "P";
            dbServer.patronlar.Add(ptr);
            dbServer.SaveChanges();
            return RedirectToAction("PatronEnter");
        }
        public IActionResult YazilimciKayit()
        {
            return View();
        }
        public IActionResult YazilimciKayitBackend(Yazilimci yzm)
        {
            yzm.Rolename = "Y";
            dbServer.yazilimcilar.Add(yzm);
            dbServer.SaveChanges();
            return RedirectToAction("YazilimciEnter");
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

        [HttpPost]
        public async Task<IActionResult> AdminEnterLogin(userloginmodel userlogin)
        {
            Models.Admin user = dbServer.Admins.Where(_ => _.Email == userlogin.Email && _.Parola == userlogin.Parola).FirstOrDefault();

            //     var confirmed = dbServer.users.FirstOrDefault(
            //       x => x.Email == userlogin.Email && x.Parola == userlogin.Parola);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Email),
                    new Claim("Name",user.Name)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties() { IsPersistent = user.isPersistent };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AdminEnter");
            }

        }


        [HttpPost]
        public async Task<IActionResult> YazilimciEnterLogin(userloginmodel userlogin)
        {
            Models.Yazilimci user = dbServer.yazilimcilar.Where(_ => _.Email == userlogin.Email && _.Parola == userlogin.Parola).FirstOrDefault();

            //     var confirmed = dbServer.users.FirstOrDefault(
            //       x => x.Email == userlogin.Email && x.Parola == userlogin.Parola);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Email),
                    new Claim("Name",user.Name),
                   new Claim(ClaimTypes.Role, user.Rolename)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties() { IsPersistent = user.isPersistent };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AdminEnter");
            }

        }


        [HttpPost]
        public async Task<IActionResult> PatronEnterLogin(userloginmodel userlogin)
        {
            Models.Patron user = dbServer.patronlar.Where(_ => _.Email == userlogin.Email && _.Parola == userlogin.Parola).FirstOrDefault();

            //     var confirmed = dbServer.users.FirstOrDefault(
            //       x => x.Email == userlogin.Email && x.Parola == userlogin.Parola);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Email),
                    new Claim("Name",user.Name)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties() { IsPersistent = user.isPersistent };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AdminEnter");
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
        [HttpPost]
        public IActionResult IsilaniEnter(Isilani isln)
        {
           
            dbServer.isilanlari.Add(isln);
            dbServer.SaveChanges();
            return RedirectToAction("Index");
        }
           public ActionResult IsaraDatabase(string option, string search)
           {

            ilanlar = dbServer.isilanlari.ToList();
               //if a user choose the radio button option as Subject  
               if (option == "Şirket İsmi")
               {
                   //Index action method will return a view with a student records based on what a user specify the value in textbox  

                   return View(ilanlar.Where(x => x.sirketismi == search || search == null).ToList());
               }
               else if (option == "Lokasyon")
               {
                   return View(ilanlar.Where(x => x.lokasyon == search || search == null).ToList());
               }
               else
               {
                   return View(ilanlar.Where(x => x.pozisyon.StartsWith(search) || search == null).ToList());
               }
           }
           
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
