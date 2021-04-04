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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Wiki.Controllers
{
    public class ArticleController : Controller
    {
        ВикисловарьContext db;
        private readonly IHostingEnvironment hostingEnvironment;

        public ArticleController(ВикисловарьContext context, IHostingEnvironment environment)
        {
            db = context;
            hostingEnvironment = environment;
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
            ViewBag.allTags = new List<Тег>(db.Тег.ToList());

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

            List<string> tags = model.СписокТегов;
            List<Тег> objectTags = new List<Тег>();

            for (int i = 0;i<tags.Count;i++)
            {
                tags[i] = tags[i].Replace("#", "");
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

            if (model.Изображение != null)
            {
                string uniqueFileName = GetUniqueFileName(model.Изображение.FileName);
                string uploadsPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
                string filePath = Path.Combine(uploadsPath, uniqueFileName);
                model.Изображение.CopyTo(new FileStream(filePath, FileMode.Create));
                edit.ПутьДоИзображения = "images" + "/" + uniqueFileName;
            }

            if (model.Аудио != null)
            {
                string uniqueFileName = GetUniqueFileName(model.Аудио.FileName);
                string uploadsPath = Path.Combine(hostingEnvironment.WebRootPath, "audio");
                string filePath = Path.Combine(uploadsPath, uniqueFileName);
                model.Аудио.CopyTo(new FileStream(filePath, FileMode.Create));
                edit.ПутьДоАудио = "audio" + "/" + uniqueFileName;
            }

            db.Правка.Add(edit);
            db.SaveChanges();

            return RedirectToAction("ViewAll", "Edit");
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}