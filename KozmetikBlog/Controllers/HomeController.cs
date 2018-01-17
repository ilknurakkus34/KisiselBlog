using BLL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static BLL.Repository2;

namespace KozmetikBlog.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            Repository<Makale> bref = new Repository<Makale>();
            List<Makale> listem = bref.GetAll();
            return View(listem);
            
        }
        public ActionResult Hakkımda()
        {
            return View();
        }

        
    }
}