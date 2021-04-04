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
    public class ТегController : Controller
    {
        private readonly ВикисловарьContext _context;

        public ТегController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: Тег
        public async Task<IActionResult> Index()
        {
            return View(await _context.Тег.ToListAsync());
        }

        // GET: Тег/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var тег = await _context.Тег
                .FirstOrDefaultAsync(m => m.КодТега == id);
            if (тег == null)
            {
                return NotFound();
            }

            return View(тег);
        }

        // GET: Тег/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Тег/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("КодТега,Название")] Тег тег)
        {
            if (ModelState.IsValid)
            {
                _context.Add(тег);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(тег);
        }

        // GET: Тег/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var тег = await _context.Тег.FindAsync(id);
            if (тег == null)
            {
                return NotFound();
            }
            return View(тег);
        }

        // POST: Тег/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("КодТега,Название")] Тег тег)
        {
            if (id != тег.КодТега)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(тег);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ТегExists(тег.КодТега))
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
            return View(тег);
        }

        // GET: Тег/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var тег = await _context.Тег
                .FirstOrDefaultAsync(m => m.КодТега == id);
            if (тег == null)
            {
                return NotFound();
            }

            return View(тег);
        }

        // POST: Тег/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var тег = await _context.Тег.FindAsync(id);
            _context.Тег.Remove(тег);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ТегExists(long id)
        {
            return _context.Тег.Any(e => e.КодТега == id);
        }
    }
}
