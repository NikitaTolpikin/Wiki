using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
