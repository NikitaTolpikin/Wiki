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
    public class НазначенныйМодераторController : Controller
    {
        private readonly ВикисловарьContext _context;

        public НазначенныйМодераторController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: НазначенныйМодератор
        public async Task<IActionResult> Index()
        {
            var викисловарьContext = _context.НазначенныйМодератор.Include(н => н.IdПользователяNavigation).Include(н => н.IdСтатьиNavigation);
            return View(await викисловарьContext.ToListAsync());
        }

        // GET: НазначенныйМодератор/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var назначенныйМодератор = await _context.НазначенныйМодератор
                .Include(н => н.IdПользователяNavigation)
                .Include(н => н.IdСтатьиNavigation)
                .FirstOrDefaultAsync(m => m.IdНазначенногоМодератора == id);
            if (назначенныйМодератор == null)
            {
                return NotFound();
            }

            return View(назначенныйМодератор);
        }

        // GET: НазначенныйМодератор/Create
        public IActionResult Create()
        {
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail");
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название");
            return View();
        }

        // POST: НазначенныйМодератор/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdНазначенногоМодератора,ДатаНазначения,IdСтатьи,IdПользователя")] НазначенныйМодератор назначенныйМодератор)
        {
            if (ModelState.IsValid)
            {
                назначенныйМодератор.IdНазначенногоМодератора = Guid.NewGuid();
                _context.Add(назначенныйМодератор);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", назначенныйМодератор.IdПользователя);
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", назначенныйМодератор.IdСтатьи);
            return View(назначенныйМодератор);
        }

        // GET: НазначенныйМодератор/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var назначенныйМодератор = await _context.НазначенныйМодератор.FindAsync(id);
            if (назначенныйМодератор == null)
            {
                return NotFound();
            }
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", назначенныйМодератор.IdПользователя);
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", назначенныйМодератор.IdСтатьи);
            return View(назначенныйМодератор);
        }

        // POST: НазначенныйМодератор/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdНазначенногоМодератора,ДатаНазначения,IdСтатьи,IdПользователя")] НазначенныйМодератор назначенныйМодератор)
        {
            if (id != назначенныйМодератор.IdНазначенногоМодератора)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(назначенныйМодератор);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!НазначенныйМодераторExists(назначенныйМодератор.IdНазначенногоМодератора))
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
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", назначенныйМодератор.IdПользователя);
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", назначенныйМодератор.IdСтатьи);
            return View(назначенныйМодератор);
        }

        // GET: НазначенныйМодератор/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var назначенныйМодератор = await _context.НазначенныйМодератор
                .Include(н => н.IdПользователяNavigation)
                .Include(н => н.IdСтатьиNavigation)
                .FirstOrDefaultAsync(m => m.IdНазначенногоМодератора == id);
            if (назначенныйМодератор == null)
            {
                return NotFound();
            }

            return View(назначенныйМодератор);
        }

        // POST: НазначенныйМодератор/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var назначенныйМодератор = await _context.НазначенныйМодератор.FindAsync(id);
            _context.НазначенныйМодератор.Remove(назначенныйМодератор);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool НазначенныйМодераторExists(Guid id)
        {
            return _context.НазначенныйМодератор.Any(e => e.IdНазначенногоМодератора == id);
        }
    }
}
