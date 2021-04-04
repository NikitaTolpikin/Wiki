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
    public class СловарнаяСтатьяController : Controller
    {
        private readonly ВикисловарьContext _context;

        public СловарнаяСтатьяController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: СловарнаяСтатья
        public async Task<IActionResult> Index()
        {
            var викисловарьContext = _context.СловарнаяСтатья.Include(с => с.IdСловаNavigation).Include(с => с.КодЧастиРечиNavigation);
            return View(await викисловарьContext.ToListAsync());
        }

        // GET: СловарнаяСтатья/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var словарнаяСтатья = await _context.СловарнаяСтатья
                .Include(с => с.IdСловаNavigation)
                .Include(с => с.КодЧастиРечиNavigation)
                .FirstOrDefaultAsync(m => m.IdСтатьи == id);
            if (словарнаяСтатья == null)
            {
                return NotFound();
            }

            return View(словарнаяСтатья);
        }

        // GET: СловарнаяСтатья/Create
        public IActionResult Create()
        {
            ViewData["IdСлова"] = new SelectList(_context.Слово, "IdСлова", "Название");
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название");
            return View();
        }

        // POST: СловарнаяСтатья/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdСтатьи,Название,ТекстСтатьи,ПутьДоИзображения,ПутьДоАудио,IdСлова,КодЧастиРечи,СтатьяГотова")] СловарнаяСтатья словарнаяСтатья)
        {
            if (ModelState.IsValid)
            {
                словарнаяСтатья.IdСтатьи = Guid.NewGuid();
                _context.Add(словарнаяСтатья);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdСлова"] = new SelectList(_context.Слово, "IdСлова", "Название", словарнаяСтатья.IdСлова);
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название", словарнаяСтатья.КодЧастиРечи);
            return View(словарнаяСтатья);
        }

        // GET: СловарнаяСтатья/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var словарнаяСтатья = await _context.СловарнаяСтатья.FindAsync(id);
            if (словарнаяСтатья == null)
            {
                return NotFound();
            }
            ViewData["IdСлова"] = new SelectList(_context.Слово, "IdСлова", "Название", словарнаяСтатья.IdСлова);
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название", словарнаяСтатья.КодЧастиРечи);
            return View(словарнаяСтатья);
        }

        // POST: СловарнаяСтатья/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdСтатьи,Название,ТекстСтатьи,ПутьДоИзображения,ПутьДоАудио,IdСлова,КодЧастиРечи,СтатьяГотова")] СловарнаяСтатья словарнаяСтатья)
        {
            if (id != словарнаяСтатья.IdСтатьи)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(словарнаяСтатья);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!СловарнаяСтатьяExists(словарнаяСтатья.IdСтатьи))
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
            ViewData["IdСлова"] = new SelectList(_context.Слово, "IdСлова", "Название", словарнаяСтатья.IdСлова);
            ViewData["КодЧастиРечи"] = new SelectList(_context.ЧастьРечи, "КодЧастиРечи", "Название", словарнаяСтатья.КодЧастиРечи);
            return View(словарнаяСтатья);
        }

        // GET: СловарнаяСтатья/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var словарнаяСтатья = await _context.СловарнаяСтатья
                .Include(с => с.IdСловаNavigation)
                .Include(с => с.КодЧастиРечиNavigation)
                .FirstOrDefaultAsync(m => m.IdСтатьи == id);
            if (словарнаяСтатья == null)
            {
                return NotFound();
            }

            return View(словарнаяСтатья);
        }

        // POST: СловарнаяСтатья/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var словарнаяСтатья = await _context.СловарнаяСтатья.FindAsync(id);
            _context.СловарнаяСтатья.Remove(словарнаяСтатья);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool СловарнаяСтатьяExists(Guid id)
        {
            return _context.СловарнаяСтатья.Any(e => e.IdСтатьи == id);
        }
    }
}
