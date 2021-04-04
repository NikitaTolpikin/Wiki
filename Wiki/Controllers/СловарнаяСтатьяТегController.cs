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
    public class СловарнаяСтатьяТегController : Controller
    {
        private readonly ВикисловарьContext _context;

        public СловарнаяСтатьяТегController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: СловарнаяСтатьяТег
        public async Task<IActionResult> Index()
        {
            var викисловарьContext = _context.СловарнаяСтатьяТег.Include(с => с.IdСтатьиNavigation).Include(с => с.КодТегаNavigation);
            return View(await викисловарьContext.ToListAsync());
        }

        // GET: СловарнаяСтатьяТег/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var словарнаяСтатьяТег = await _context.СловарнаяСтатьяТег
                .Include(с => с.IdСтатьиNavigation)
                .Include(с => с.КодТегаNavigation)
                .FirstOrDefaultAsync(m => m.IdСтатьи == id);
            if (словарнаяСтатьяТег == null)
            {
                return NotFound();
            }

            return View(словарнаяСтатьяТег);
        }

        // GET: СловарнаяСтатьяТег/Create
        public IActionResult Create()
        {
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название");
            ViewData["КодТега"] = new SelectList(_context.Тег, "КодТега", "Название");
            return View();
        }

        // POST: СловарнаяСтатьяТег/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdСтатьи,КодТега")] СловарнаяСтатьяТег словарнаяСтатьяТег)
        {
            if (ModelState.IsValid)
            {
                словарнаяСтатьяТег.IdСтатьи = Guid.NewGuid();
                _context.Add(словарнаяСтатьяТег);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", словарнаяСтатьяТег.IdСтатьи);
            ViewData["КодТега"] = new SelectList(_context.Тег, "КодТега", "Название", словарнаяСтатьяТег.КодТега);
            return View(словарнаяСтатьяТег);
        }

        // GET: СловарнаяСтатьяТег/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var словарнаяСтатьяТег = await _context.СловарнаяСтатьяТег.FindAsync(id);
            if (словарнаяСтатьяТег == null)
            {
                return NotFound();
            }
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", словарнаяСтатьяТег.IdСтатьи);
            ViewData["КодТега"] = new SelectList(_context.Тег, "КодТега", "Название", словарнаяСтатьяТег.КодТега);
            return View(словарнаяСтатьяТег);
        }

        // POST: СловарнаяСтатьяТег/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdСтатьи,КодТега")] СловарнаяСтатьяТег словарнаяСтатьяТег)
        {
            if (id != словарнаяСтатьяТег.IdСтатьи)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(словарнаяСтатьяТег);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!СловарнаяСтатьяТегExists(словарнаяСтатьяТег.IdСтатьи))
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
            ViewData["IdСтатьи"] = new SelectList(_context.СловарнаяСтатья, "IdСтатьи", "Название", словарнаяСтатьяТег.IdСтатьи);
            ViewData["КодТега"] = new SelectList(_context.Тег, "КодТега", "Название", словарнаяСтатьяТег.КодТега);
            return View(словарнаяСтатьяТег);
        }

        // GET: СловарнаяСтатьяТег/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var словарнаяСтатьяТег = await _context.СловарнаяСтатьяТег
                .Include(с => с.IdСтатьиNavigation)
                .Include(с => с.КодТегаNavigation)
                .FirstOrDefaultAsync(m => m.IdСтатьи == id);
            if (словарнаяСтатьяТег == null)
            {
                return NotFound();
            }

            return View(словарнаяСтатьяТег);
        }

        // POST: СловарнаяСтатьяТег/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var словарнаяСтатьяТег = await _context.СловарнаяСтатьяТег.FindAsync(id);
            _context.СловарнаяСтатьяТег.Remove(словарнаяСтатьяТег);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool СловарнаяСтатьяТегExists(Guid id)
        {
            return _context.СловарнаяСтатьяТег.Any(e => e.IdСтатьи == id);
        }
    }
}
