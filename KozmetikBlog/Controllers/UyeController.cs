using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KozmetikBlog.Controllers
{
    public class UyeController : Controller
    {
        public MyContext db = new MyContext();
        // GET: Uye
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var login = db.Kullanıcılar.Where(u => u.KullaniciAdSoyad == kullanici.KullaniciAdSoyad).SingleOrDefault();
            if (login.KullaniciAdSoyad == kullanici.KullaniciAdSoyad && login.email == kullanici.email && login.sifre == kullanici.sifre)
            {
                Session["KullaniciID"] = login.KullaniciID;
                Session["KullaniciAdSoyad"] = login.KullaniciAdSoyad;
                Session["yetkiID"] = login.yetkiID;

                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }

        }

        public ActionResult Logout()
        {
            Session["KullaniciID"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");

        }
    }
}
        
