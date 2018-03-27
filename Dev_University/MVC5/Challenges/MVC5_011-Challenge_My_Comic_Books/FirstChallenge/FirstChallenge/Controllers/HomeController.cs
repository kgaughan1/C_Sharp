using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        List<Models.ComicBook> db = Models.ComicBookManager.GetComicBooks(); 

        // GET: Home
        public ActionResult Index()
        {
            return View(db.ToList());
        }

        public ActionResult Detail(int id)
        {
            var comic = db.FirstOrDefault(p => p.ComicBookId == id);
            return View(comic);
        }
    }
}