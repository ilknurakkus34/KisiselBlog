using BLL;
using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KozmetikBlog.Controllers
{
    public class AdminMakaleController : Controller
    {

        // GET: AdminMakale
        public MyContext db = new MyContext();
        public ActionResult Index()
        {
            Repository<Makale> bref = new Repository<Makale>();
            List<Makale> listem = bref.GetAll();
            return View(listem);
        }

        // GET: AdminMakale/Details/5
        public ActionResult Details(int id)
        {
            return View(new Repository<Makale>().GetById(id));
        }

        // GET: AdminMakale/Create
        public ActionResult Create()
        {
            ViewBag.KategoriID = new SelectList(db.Kategoriler, "KategoriID", "KategoriAdi");
            return View();
        }

        // POST: AdminMakale/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Makale makale)
        {
            try
            {
                db.Makaleler.Add(makale);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      
      
        // GET: AdminMakale/Delete/5
        public ActionResult Delete(int id)
        {
            var makales = db.Makaleler.Where(m => m.MakaleID == id).SingleOrDefault();
            return View(makales);
        }

        // POST: AdminMakale/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var makales = db.Makaleler.Where(m => m.MakaleID == id).SingleOrDefault();
                db.Makaleler.Remove(makales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        public JsonResult OyVer(int id, int points)

        {
            try
            {
                if (Session["HasVoted_" + id] == null || (bool)Session["HasVoted_" + id] != true)
                {
                    Repository<Makale> bref = new Repository<Makale>();
                    Makale Selected = bref.GetById(id);
                    if (Selected.TotalRate.HasValue)
                        Selected.TotalRate = Selected.TotalRate.Value + points;
                    else
                       Selected.TotalRate = points;
                    bref.Update(Selected);
                    Session["HasVoted_" + id] = true; 
                    return Json("Thank you for voting");
                }
                else
                {
                    return Json("You can't vote again!");//ikinci kez oy vermeye çalışınca bu mesaj çıkacak oy vermeyecek
                }

            }
            catch (Exception ex)
            {

                return Json("A problem has occured -" + ex.Message);
            }

        }

    }
}

