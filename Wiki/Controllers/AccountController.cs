using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wiki.ViewModels;
using Wiki.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Wiki.Controllers
{
    public class AccountController : Controller
    {
        private ВикисловарьContext db;
        public AccountController(ВикисловарьContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Пользователь user = await db.Пользователь.FirstOrDefaultAsync(u => u.EMail == model.EMail && u.Пароль == model.Пароль && u.КодКатегорииNavigation.Название != "");
                if (user != null)
                {
                    КатегорияПользователя category = await db.КатегорияПользователя.FirstOrDefaultAsync(r => r.КодКатегории == user.КодКатегории);
                    user.КодКатегорииNavigation = category;
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Пользователь user = await db.Пользователь.FirstOrDefaultAsync(u => u.EMail == model.EMail);
                if (user == null)
                {
                    Пользователь new_user = new Пользователь
                    {
                        EMail = model.EMail,
                        Пароль = model.Пароль,
                        ДатаРождения = model.ДатаРождения,
                        Имя = model.Имя,
                        Фамилия = model.Фамилия,
                        Отчество = model.Отчество,
                        Пол = bool.Parse(model.Пол),
                        ДатаРегистрации = DateTime.Now
                    };
                    КатегорияПользователя category = await db.КатегорияПользователя.FirstOrDefaultAsync(r => r.Название == "Пользователь");
                    if (category != null)
                        new_user.КодКатегорииNavigation = category;

                    db.Пользователь.Add(new_user);
                    await db.SaveChangesAsync();

                    await Authenticate(new_user);

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(Пользователь user)
        {
            if (user.Отчество==null)
            {
                user.Отчество = "";
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.EMail),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.КодКатегорииNavigation.Название),
                new Claim("Id", user.IdПользователя.ToString()),
                new Claim("FullName", user.Фамилия+" "+user.Имя+" "+user.Отчество)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [Authorize(Roles = "Пользователь, Модератор")]
        public IActionResult Index()
        {
            Guid user_id = new Guid(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);

            var userQuery = (from u in db.Пользователь
                             where u.IdПользователя == user_id
                             select u).Include(u => u.КодКатегорииNavigation);

            Пользователь user = userQuery.FirstOrDefault();

            if(user!=null)
            {
                AccountIndexViewModel model = new AccountIndexViewModel
                {
                    Пользователь = user
                };

                if (user.КодКатегорииNavigation.Название=="Модератор")
                {
                    ICollection<СловарнаяСтатья> articles = (from nm in db.НазначенныйМодератор
                                                             where nm.IdПользователя == user.IdПользователя
                                                             select nm.IdСтатьиNavigation).ToList();

                    model.ВсеСтатьи = articles;
                }

                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}