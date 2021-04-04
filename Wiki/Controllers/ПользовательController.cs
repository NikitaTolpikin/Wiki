using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wiki;
using Wiki.Models;

namespace Wiki.Controllers
{
    public class ПользовательController : Controller
    {
        private readonly ВикисловарьContext _context;

        public ПользовательController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: Пользователь
        public async Task<IActionResult> Index()
        {
            var викисловарьContext = _context.Пользователь.Include(п => п.КодКатегорииNavigation);
            return View(await викисловарьContext.ToListAsync());
        }

        // GET: Пользователь/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var пользователь = await _context.Пользователь
                .Include(п => п.КодКатегорииNavigation)
                .FirstOrDefaultAsync(m => m.IdПользователя == id);
            if (пользователь == null)
            {
                return NotFound();
            }

            return View(пользователь);
        }

        // GET: Пользователь/Create
        public IActionResult Create()
        {
            ViewData["КодКатегории"] = new SelectList(_context.КатегорияПользователя, "КодКатегории", "Название");
            return View();
        }

        // POST: Пользователь/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdПользователя,EMail,Пароль,ДатаРождения,Фамилия,Имя,Отчество,Пол,КодКатегории,ДатаРегистрации")] Пользователь пользователь)
        {
            if (ModelState.IsValid)
            {
                пользователь.IdПользователя = Guid.NewGuid();
                _context.Add(пользователь);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["КодКатегории"] = new SelectList(_context.КатегорияПользователя, "КодКатегории", "Название", пользователь.КодКатегории);
            return View(пользователь);
        }

        // GET: Пользователь/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var пользователь = await _context.Пользователь.FindAsync(id);
            if (пользователь == null)
            {
                return NotFound();
            }
            ViewData["КодКатегории"] = new SelectList(_context.КатегорияПользователя, "КодКатегории", "Название", пользователь.КодКатегории);
            return View(пользователь);
        }

        // POST: Пользователь/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdПользователя,EMail,Пароль,ДатаРождения,Фамилия,Имя,Отчество,Пол,КодКатегории,ДатаРегистрации")] Пользователь пользователь)
        {
            if (id != пользователь.IdПользователя)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(пользователь);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ПользовательExists(пользователь.IdПользователя))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["КодКатегории"] = new SelectList(_context.КатегорияПользователя, "КодКатегории", "Название", пользователь.КодКатегории);
            return View(пользователь);
        }

        // GET: Пользователь/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var пользователь = await _context.Пользователь
                .Include(п => п.КодКатегорииNavigation)
                .FirstOrDefaultAsync(m => m.IdПользователя == id);
            if (пользователь == null)
            {
                return NotFound();
            }

            return View(пользователь);
        }

        // POST: Пользователь/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var пользователь = await _context.Пользователь.FindAsync(id);
            _context.Пользователь.Remove(пользователь);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ПользовательExists(Guid id)
        {
            return _context.Пользователь.Any(e => e.IdПользователя == id);
        }
    }
}
