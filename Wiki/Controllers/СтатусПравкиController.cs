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
    public class СтатусПравкиController : Controller
    {
        private readonly ВикисловарьContext _context;

        public СтатусПравкиController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: СтатусПравки
        public async Task<IActionResult> Index()
        {
            return View(await _context.СтатусПравки.ToListAsync());
        }

        // GET: СтатусПравки/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var статусПравки = await _context.СтатусПравки
                .FirstOrDefaultAsync(m => m.КодСтатуса == id);
            if (статусПравки == null)
            {
                return NotFound();
            }

            return View(статусПравки);
        }

        // GET: СтатусПравки/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: СтатусПравки/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("КодСтатуса,Название")] СтатусПравки статусПравки)
        {
            if (ModelState.IsValid)
            {
                _context.Add(статусПравки);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(статусПравки);
        }

        // GET: СтатусПравки/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var статусПравки = await _context.СтатусПравки.FindAsync(id);
            if (статусПравки == null)
            {
                return NotFound();
            }
            return View(статусПравки);
        }

        // POST: СтатусПравки/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("КодСтатуса,Название")] СтатусПравки статусПравки)
        {
            if (id != статусПравки.КодСтатуса)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(статусПравки);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!СтатусПравкиExists(статусПравки.КодСтатуса))
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
            return View(статусПравки);
        }

        // GET: СтатусПравки/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var статусПравки = await _context.СтатусПравки
                .FirstOrDefaultAsync(m => m.КодСтатуса == id);
            if (статусПравки == null)
            {
                return NotFound();
            }

            return View(статусПравки);
        }

        // POST: СтатусПравки/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var статусПравки = await _context.СтатусПравки.FindAsync(id);
            _context.СтатусПравки.Remove(статусПравки);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool СтатусПравкиExists(long id)
        {
            return _context.СтатусПравки.Any(e => e.КодСтатуса == id);
        }
    }
}
