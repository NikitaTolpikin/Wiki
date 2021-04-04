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
    public class ЧастьРечиController : Controller
    {
        private readonly ВикисловарьContext _context;

        public ЧастьРечиController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: ЧастьРечи
        public async Task<IActionResult> Index()
        {
            return View(await _context.ЧастьРечи.ToListAsync());
        }

        // GET: ЧастьРечи/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var частьРечи = await _context.ЧастьРечи
                .FirstOrDefaultAsync(m => m.КодЧастиРечи == id);
            if (частьРечи == null)
            {
                return NotFound();
            }

            return View(частьРечи);
        }

        // GET: ЧастьРечи/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ЧастьРечи/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("КодЧастиРечи,Название")] ЧастьРечи частьРечи)
        {
            if (ModelState.IsValid)
            {
                _context.Add(частьРечи);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(частьРечи);
        }

        // GET: ЧастьРечи/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var частьРечи = await _context.ЧастьРечи.FindAsync(id);
            if (частьРечи == null)
            {
                return NotFound();
            }
            return View(частьРечи);
        }

        // POST: ЧастьРечи/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("КодЧастиРечи,Название")] ЧастьРечи частьРечи)
        {
            if (id != частьРечи.КодЧастиРечи)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(частьРечи);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ЧастьРечиExists(частьРечи.КодЧастиРечи))
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
            return View(частьРечи);
        }

        // GET: ЧастьРечи/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var частьРечи = await _context.ЧастьРечи
                .FirstOrDefaultAsync(m => m.КодЧастиРечи == id);
            if (частьРечи == null)
            {
                return NotFound();
            }

            return View(частьРечи);
        }

        // POST: ЧастьРечи/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var частьРечи = await _context.ЧастьРечи.FindAsync(id);
            _context.ЧастьРечи.Remove(частьРечи);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ЧастьРечиExists(long id)
        {
            return _context.ЧастьРечи.Any(e => e.КодЧастиРечи == id);
        }
    }
}
