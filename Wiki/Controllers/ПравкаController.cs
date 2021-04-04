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
    public class ПравкаController : Controller
    {
        private readonly ВикисловарьContext _context;

        public ПравкаController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: Правка
        public async Task<IActionResult> Index()
        {
            var викисловарьContext = _context.Правка.Include(п => п.IdНазначенногоМодератораNavigation).Include(п => п.IdПользователяNavigation).Include(п => п.IdСтатьиNavigation).Include(п => п.КодСтатусаNavigation).Include(п => п.КодЧастиРечиNavigation);
            return View(await викисловарьContext.ToListAsync());
        }

        // GET: Правка/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var правка = await _context.Правка
                .Include(п => п.IdНазначенногоМодератораNavigation)
                .Include(п => п.IdПользователяNavigation)
                .Include(п => п.IdСтатьиNavigation)
                .Include(п => п.КодСтатусаNavigation)
                .Include(п => п.КодЧастиРечиNavigation)
                .FirstOrDefaultAsync(m => m.IdПравки == id);
            if (правка == null)
            {
                return NotFound();
            }

            return View(правка);
        }

        // GET: Правка/Create
        public IActionResult Create()
        {
            ViewData["IdНазначенногоМодератора"] = new SelectList(_context.НазначенныйМодератор, "IdНазначенногоМодератора", "IdНазначенногоМодератора");
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail");
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название");
            ViewData["КодСтатуса"] = new SelectList(_context.СтатусПравки, "КодСтатуса", "Название");
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название");
            return View();
        }

        // POST: Правка/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdПравки,ДатаСоздания,Название,ТекстСтатьи,ПутьДоИзображения,ПутьДоАудио,ДатаИзмененияСтатуса,IdСтатьи,IdПользователя,КодЧастиРечи,IdНазначенногоМодератора,КодСтатуса")] Правка правка)
        {
            if (ModelState.IsValid)
            {
                правка.IdПравки = Guid.NewGuid();
                _context.Add(правка);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdНазначенногоМодератора"] = new SelectList(_context.НазначенныйМодератор, "IdНазначенногоМодератора", "IdНазначенногоМодератора", правка.IdНазначенногоМодератора);
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", правка.IdПользователя);
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", правка.IdСтатьи);
            ViewData["КодСтатуса"] = new SelectList(_context.СтатусПравки, "КодСтатуса", "Название", правка.КодСтатуса);
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название", правка.КодЧастиРечи);
            return View(правка);
        }

        // GET: Правка/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var правка = await _context.Правка.FindAsync(id);
            if (правка == null)
            {
                return NotFound();
            }
            ViewData["IdНазначенногоМодератора"] = new SelectList(_context.НазначенныйМодератор, "IdНазначенногоМодератора", "IdНазначенногоМодератора", правка.IdНазначенногоМодератора);
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", правка.IdПользователя);
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", правка.IdСтатьи);
            ViewData["КодСтатуса"] = new SelectList(_context.СтатусПравки, "КодСтатуса", "Название", правка.КодСтатуса);
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название", правка.КодЧастиРечи);
            return View(правка);
        }

        // POST: Правка/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdПравки,ДатаСоздания,Название,ТекстСтатьи,ПутьДоИзображения,ПутьДоАудио,ДатаИзмененияСтатуса,IdСтатьи,IdПользователя,КодЧастиРечи,IdНазначенногоМодератора,КодСтатуса")] Правка правка)
        {
            if (id != правка.IdПравки)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(правка);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ПравкаExists(правка.IdПравки))
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
            ViewData["IdНазначенногоМодератора"] = new SelectList(_context.НазначенныйМодератор, "IdНазначенногоМодератора", "IdНазначенногоМодератора", правка.IdНазначенногоМодератора);
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", правка.IdПользователя);
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", правка.IdСтатьи);
            ViewData["КодСтатуса"] = new SelectList(_context.СтатусПравки, "КодСтатуса", "Название", правка.КодСтатуса);
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название", правка.КодЧастиРечи);
            return View(правка);
        }

        // GET: Правка/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var правка = await _context.Правка
                .Include(п => п.IdНазначенногоМодератораNavigation)
                .Include(п => п.IdПользователяNavigation)
                .Include(п => п.IdСтатьиNavigation)
                .Include(п => п.КодСтатусаNavigation)
                .Include(п => п.КодЧастиРечиNavigation)
                .FirstOrDefaultAsync(m => m.IdПравки == id);
            if (правка == null)
            {
                return NotFound();
            }

            return View(правка);
        }

        // POST: Правка/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var правка = await _context.Правка.FindAsync(id);
            _context.Правка.Remove(правка);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ПравкаExists(Guid id)
        {
            return _context.Правка.Any(e => e.IdПравки == id);
        }
    }
}
