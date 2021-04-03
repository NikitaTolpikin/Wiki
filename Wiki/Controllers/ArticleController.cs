using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wiki.Models;
using Wiki.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Wiki.Controllers
{
    public class ArticleController : Controller
    {
        ВикисловарьContext db;

        public ArticleController(ВикисловарьContext context)
        {
            db = context;
        }

        public IActionResult Index(Guid article_id)
        {
            var articleQuery = (from a in db.СловарнаяСтатья
                          where a.IdСтатьи== article_id
                                select a).Include(a => a.КодЧастиРечиNavigation).Include(a => a.СловарнаяСтатьяТег).ThenInclude(t => t.КодТегаNavigation);
            СловарнаяСтатья article = articleQuery.FirstOrDefault();

            if (article!=null)
            {
                return View(article);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Пользователь, Модератор")]
        [HttpGet]
        public IActionResult New(string name)
        {
            ArticleNewViewModel model = new ArticleNewViewModel
            {
                Название = name
            };
            ViewBag.allPartsOfSpeech = new SelectList(db.ЧастьРечи.ToList(), "КодЧастиРечи", "Название");

            return View(model);
        }

        [Authorize(Roles = "Пользователь, Модератор")]
        [HttpPost]
        public IActionResult New(ArticleNewViewModel model)
        {
            Слово word = db.Слово.FirstOrDefault(w => model.Название.Contains(w.Название));
            if (word==null)
            {
                word = new Слово { Название=model.Название, IdСлова = Guid.NewGuid() };
                db.Слово.Add(word);
            }

            List<string> tags = model.СтрокаТегов.Split('#').ToList();
            List<Тег> objectTags = new List<Тег>();

            for (int i = 0;i<tags.Count;i++)
            {
                tags[i] = tags[i].Replace("#", "");
                tags[i] = tags[i].Replace(" ", "");
                if (tags[i]!="")
                {
                    Тег foundTag = db.Тег.FirstOrDefault(t => t.Название == tags[i]);
                    if (foundTag==null)
                    {
                        foundTag = new Тег { Название= tags[i], КодТега = db.Тег.ToList().Count};
                        db.Тег.Add(foundTag);
                    }
                    objectTags.Add(foundTag);
                }
            }
            
            СловарнаяСтатья article = new СловарнаяСтатья
            {
                Название = model.Название,
                СтатьяГотова = false,
                IdСлова = word.IdСлова,
                IdСтатьи = Guid.NewGuid()
            };

            db.СловарнаяСтатья.Add(article);

            foreach (Тег tag in objectTags)
            {
                СловарнаяСтатьяТег articleTag = new СловарнаяСтатьяТег { IdСтатьи = article.IdСтатьи, КодТега = tag.КодТега };
                db.СловарнаяСтатьяТег.Add(articleTag);
            }

            Правка edit = new Правка
            {
                ТекстСтатьи = model.ТекстСтатьи,
                Название = model.Название,
                КодЧастиРечи = model.КодЧастиРечи,
                IdСтатьи = article.IdСтатьи,
                ДатаСоздания = DateTime.Now,
                ДатаИзмененияСтатуса = DateTime.Now,
                IdПользователя = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value)
            };

            db.Правка.Add(edit);
            db.SaveChanges();

            return RedirectToAction("ViewAll", "Edit");
        }
    }
}