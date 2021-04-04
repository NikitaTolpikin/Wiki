using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wiki.Models;
using Wiki.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Wiki.Controllers
{
    [Authorize(Roles = "Пользователь, Модератор, Администратор")]
    public class EditController : Controller
    {
        ВикисловарьContext db;
        private readonly IHostingEnvironment hostingEnvironment;

        public EditController(ВикисловарьContext context, IHostingEnvironment environment)
        {
            db = context;
            hostingEnvironment = environment;
        }

        public IActionResult Index(Guid edit_id)
        {
            var editQuery = (from e in db.Правка
                             where e.IdПравки == edit_id
                             select e).Include(e => e.КодЧастиРечиNavigation)
                       .Include(e => e.КодСтатусаNavigation).Include(e => e.IdСтатьиNavigation)
                       .ThenInclude(a => a.СловарнаяСтатьяТег).ThenInclude(t => t.КодТегаNavigation);
            Правка edit = editQuery.FirstOrDefault();

            if (edit != null)
            {
                var comments = (from c in db.Комментарий
                                where c.IdПравки == edit.IdПравки
                                orderby c.ВремяНаписания
                                select c).Include(c => c.IdПользователяNavigation)
                                .ThenInclude(u => u.КодКатегорииNavigation).ToList();
                EditViewViewModel model = new EditViewViewModel
                {
                    Правка = edit,
                    ВсеКомментарии = comments,
                    ПредыдущийАдрес = Url.RouteUrl(new { controller = "Edit", action = "Index", edit_id = edit_id })
                };
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ViewAll()
        {
            Guid user_id = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);

            ICollection<Правка> userEdits = (from e in db.Правка
                                             where e.IdПользователя == user_id
                                             select e).Include(e => e.КодСтатусаNavigation).ToList();

            userEdits = userEdits.OrderByDescending(e => e.ДатаИзмененияСтатуса).ToList();

            EditViewAllViewModel model = new EditViewAllViewModel { ВсеПравки = userEdits };

            return View(model);
        }

        [HttpGet]
        public IActionResult New(Guid article_id)
        {
            var articleQuery = (from a in db.СловарнаяСтатья
                                where a.IdСтатьи == article_id
                                select a).Include(a => a.СловарнаяСтатьяТег).ThenInclude(t => t.КодТегаNavigation).Include(s => s.IdСловаNavigation);
            СловарнаяСтатья article = articleQuery.FirstOrDefault();

            if (article != null)
            {
                ViewBag.allPartsOfSpeech = new SelectList(db.ЧастьРечи.ToList(), "КодЧастиРечи", "Название");

                ArticleEditViewModel articleEditViewModel = new ArticleEditViewModel
                {
                    IdСтатьи = article.IdСтатьи,
                    Название = article.Название,
                    ТекстСтатьи = article.ТекстСтатьи,
                    СловарнаяСтатьяТег = article.СловарнаяСтатьяТег,
                    КодЧастиРечи = article.КодЧастиРечи,
                    ПутьДоИзображения = article.ПутьДоИзображения,
                    ПутьДоАудио = article.ПутьДоАудио
                };

                return View(articleEditViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult New(ArticleEditViewModel articleEditViewModel)
        {
            if (ModelState.IsValid)
            {
                СтатусПравки unseen = db.СтатусПравки.FirstOrDefault(s => s.Название == "Не проверено");
                Правка edit = new Правка
                {
                    ДатаСоздания = DateTime.Now,
                    Название = articleEditViewModel.Название,
                    ТекстСтатьи = articleEditViewModel.ТекстСтатьи,
                    ДатаИзмененияСтатуса = DateTime.Now,
                    IdСтатьи = articleEditViewModel.IdСтатьи,
                    IdПользователя = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value),
                    КодЧастиРечи = articleEditViewModel.КодЧастиРечи,
                    КодСтатуса = unseen.КодСтатуса
                };

                if (articleEditViewModel.Изображение != null)
                {
                    string uniqueFileName = GetUniqueFileName(articleEditViewModel.Изображение.FileName);
                    string uploadsPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    string filePath = Path.Combine(uploadsPath, uniqueFileName);
                    articleEditViewModel.Изображение.CopyTo(new FileStream(filePath, FileMode.Create));
                    edit.ПутьДоИзображения = "images"+ "/" + uniqueFileName;
                }

                if (articleEditViewModel.Аудио != null)
                {
                    string uniqueFileName = GetUniqueFileName(articleEditViewModel.Аудио.FileName);
                    string uploadsPath = Path.Combine(hostingEnvironment.WebRootPath, "audio");
                    string filePath = Path.Combine(uploadsPath, uniqueFileName);
                    articleEditViewModel.Аудио.CopyTo(new FileStream(filePath, FileMode.Create));
                    edit.ПутьДоАудио = "audio"+"/"+ uniqueFileName;
                }

                db.Правка.Add(edit);
                db.SaveChanges();

                return RedirectToAction("ViewAll", "Edit");
            }
            return View(articleEditViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Модератор, Администратор")]
        public IActionResult Check(Guid edit_id)
        {
            var editQuery = (from e in db.Правка
                             where e.IdПравки == edit_id
                             select e).Include(e => e.КодЧастиРечиNavigation)
                       .Include(e => e.КодСтатусаNavigation).Include(e => e.IdСтатьиNavigation)
                       .ThenInclude(a => a.СловарнаяСтатьяТег).ThenInclude(t => t.КодТегаNavigation);
            Правка edit = editQuery.FirstOrDefault();

            if (edit != null)
            {
                var comments = (from c in db.Комментарий
                                where c.IdПравки == edit.IdПравки
                                orderby c.ВремяНаписания
                                select c).Include(c => c.IdПользователяNavigation)
                                .ThenInclude(u => u.КодКатегорииNavigation).ToList();

                ViewBag.allStatuses = new SelectList(db.СтатусПравки.Where(s => s.Название!="Не проверено").ToList(), "КодСтатуса", "Название");

                EditCheckViewModel model = new EditCheckViewModel
                {
                    Правка = edit,
                    ВсеКомментарии = comments,
                    ПредыдущийАдрес = Url.RouteUrl(new { controller = "Edit", action = "Check", edit_id = edit_id }),
                    КодСтатуса = edit.КодСтатуса
                };
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize(Roles = "Модератор, Администратор")]
        public IActionResult Check(EditCheckViewModel model)
        {
            Правка edit = db.Правка.FirstOrDefault(e => e.IdПравки == model.IdПравки);
            Guid user_id = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);
            НазначенныйМодератор moderator = (from nm in db.НазначенныйМодератор
                                              where nm.IdСтатьи == edit.IdСтатьи && nm.IdПользователя == user_id
                                              select nm).FirstOrDefault();

            ICollection<СтатусПравки> statuses = db.СтатусПравки.ToList();
            long notChecked = statuses.FirstOrDefault(s => s.Название == "Не проверено").КодСтатуса;
            long approved = statuses.FirstOrDefault(s => s.Название == "Принято").КодСтатуса;

            if (moderator!=null && model.КодСтатуса!=notChecked)
            {
                СловарнаяСтатья article = db.СловарнаяСтатья.FirstOrDefault(e => e.IdСтатьи == edit.IdСтатьи);

                if (model.КодСтатуса == approved)
                {
                    article.СтатьяГотова = true;
                    article.КодЧастиРечи = edit.КодЧастиРечи;
                    article.ТекстСтатьи = edit.ТекстСтатьи;
                    article.ПутьДоИзображения = edit.ПутьДоИзображения;
                    article.ПутьДоАудио = edit.ПутьДоАудио;

                    db.СловарнаяСтатья.Update(article);
                }
                else if (model.КодСтатуса!=approved&&edit.КодСтатуса==approved)
                {

                    var lastEdits = db.Правка.Where(e => e.IdСтатьи==edit.IdСтатьи&&e.КодСтатуса==approved).OrderByDescending(e => e.ДатаИзмененияСтатуса).ToList();

                    if (lastEdits.Count>1)
                    {
                        article.КодЧастиРечи = lastEdits[1].КодЧастиРечи;
                        article.ТекстСтатьи = lastEdits[1].ТекстСтатьи;
                        article.ПутьДоИзображения = lastEdits[1].ПутьДоИзображения;
                        article.ПутьДоАудио = lastEdits[1].ПутьДоАудио;

                        db.СловарнаяСтатья.Update(article);
                    }
                    else
                    {
                        article.СтатьяГотова = false;
                        article.ТекстСтатьи = "Статья в разработке";
                        article.КодЧастиРечи = 0;
                        article.ПутьДоИзображения = null;
                        article.ПутьДоАудио = null;
                        db.СловарнаяСтатья.Update(article);
                    }
                }

                edit.IdНазначенногоМодератора = moderator.IdНазначенногоМодератора;
                edit.ДатаИзмененияСтатуса = DateTime.Now;
                edit.КодСтатуса = model.КодСтатуса;
                db.Правка.Update(edit);

                db.SaveChanges();
            }

            return RedirectToAction("CheckAll", "Edit");
        }

        [Authorize(Roles = "Модератор, Администратор")]
        public IActionResult CheckAll()
        {
            Guid user_id = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);

            ICollection<НазначенныйМодератор> moderators = (from nm in db.НазначенныйМодератор
                                                            where nm.IdПользователя == user_id
                                                            select nm).Include(nm => nm.IdСтатьиNavigation)
                                                            .ThenInclude(a => a.Правка).ToList();

            ICollection<Правка> moderatedEdits = (from e in db.Правка
                                                  where e.IdНазначенногоМодератораNavigation.IdПользователя == user_id
                                                  select e).Include(e => e.КодСтатусаNavigation).ToList();

            List<Правка> forCheck = new List<Правка>();
            long notChecked = db.СтатусПравки.FirstOrDefault(s => s.Название == "Не проверено").КодСтатуса;

            foreach (var mod in moderators)
            {
                var edits = mod.IdСтатьиNavigation.Правка.Where(e => e.КодСтатуса==notChecked).ToList();
                forCheck.AddRange(edits);
            }

            forCheck = forCheck.OrderByDescending(e=>e.ДатаИзмененияСтатуса).ToList();
            moderatedEdits = moderatedEdits.OrderByDescending(e => e.ДатаИзмененияСтатуса).ToList();

            EditCheckAllViewModel model = new EditCheckAllViewModel { ПравкиНаПроверку = forCheck, ПровененныеПравки=moderatedEdits };

            return View(model);
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