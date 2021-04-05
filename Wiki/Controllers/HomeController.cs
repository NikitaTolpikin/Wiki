using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wiki.Models;

namespace Wiki.Controllers
{
    public class HomeController : Controller
    {
        ВикисловарьContext db;

        public HomeController(ВикисловарьContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            DateTime now = DateTime.Now;
            string now_str = now.ToString("HH:mm:ss");
            string time = HttpContext.Session.GetString("BeginTime");
            if (HttpContext.Session.GetString("BeginTime") == null)
            {
                HttpContext.Session.SetString("BeginTime", now_str);
                time = HttpContext.Session.GetString("BeginTime");
            };
            return View();
        }

        public IActionResult Search(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                ViewData["searchString"] = searchString;

                var articles = from w in db.СловарнаяСтатья
                               select w;

                articles = articles.Where(s => s.Название.Contains(searchString));
                if (articles.Count()==1)
                {
                    СловарнаяСтатья статья = articles.FirstOrDefault();
                    return RedirectToAction("Index", "Article", new { article_id = статья.IdСтатьи});
                }
                else
                {
                    articles = articles.Include(a => a.СловарнаяСтатьяТег).ThenInclude(t => t.КодТегаNavigation);
                    return View(articles);
                }
            }

            return Redirect("~/Home/Index");
        }
    }
}
