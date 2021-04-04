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
    public class СловоController : Controller
    {
        private readonly ВикисловарьContext _context;

        public СловоController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: Слово
        public async Task<IActionResult> Index()
        {
            return View(await _context.Слово.ToListAsync());
        }

        // GET: Слово/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var слово = await _context.Слово
                .FirstOrDefaultAsync(m => m.IdСлова == id);
            if (слово == null)
            {
                return NotFound();
            }

            return View(слово);
        }

        // GET: Слово/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Слово/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdСлова,Название")] Слово слово)
        {
            if (ModelState.IsValid)
            {
                слово.IdСлова = Guid.NewGuid();
                _context.Add(слово);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(слово);
        }

        // GET: Слово/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var слово = await _context.Слово.FindAsync(id);
            if (слово == null)
            {
                return NotFound();
            }
            return View(слово);
        }

        // POST: Слово/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdСлова,Название")] Слово слово)
        {
            if (id != слово.IdСлова)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(слово);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!СловоExists(слово.IdСлова))
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
            return View(слово);
        }

        // GET: Слово/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var слово = await _context.Слово
                .FirstOrDefaultAsync(m => m.IdСлова == id);
            if (слово == null)
            {
                return NotFound();
            }

            return View(слово);
        }

        // POST: Слово/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var слово = await _context.Слово.FindAsync(id);
            _context.Слово.Remove(слово);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool СловоExists(Guid id)
        {
            return _context.Слово.Any(e => e.IdСлова == id);
        }
    }
}
