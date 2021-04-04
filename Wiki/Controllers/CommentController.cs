using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wiki.Models;
using Wiki.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Wiki.Controllers
{
    [Authorize(Roles = "Пользователь, Модератор")]
    public class CommentController : Controller
    {
        ВикисловарьContext db;

        public CommentController(ВикисловарьContext context)
        {
            db = context;
        }

        public IActionResult New(CommentableViewModel model)
        {
            Комментарий comment = new Комментарий
            {
                IdПравки = model.IdПравки,
                ТекстКомментария = model.ТекстКомментария,
                IdПользователя = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value),
                ВремяНаписания = DateTime.Now
            };

            db.Комментарий.Add(comment);
            db.SaveChanges();

            return Redirect(model.ПредыдущийАдрес);
        }
    }
}