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
    public class КатегорияПользователяController : Controller
    {
        private readonly ВикисловарьContext _context;

        public КатегорияПользователяController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: КатегорияПользователя
        public async Task<IActionResult> Index()
        {
            return View(await _context.КатегорияПользователя.ToListAsync());
        }

        // GET: КатегорияПользователя/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var категорияПользователя = await _context.КатегорияПользователя
                .FirstOrDefaultAsync(m => m.КодКатегории == id);
            if (категорияПользователя == null)
            {
                return NotFound();
            }

            return View(категорияПользователя);
        }

        // GET: КатегорияПользователя/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: КатегорияПользователя/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("КодКатегории,Название")] КатегорияПользователя категорияПользователя)
        {
            if (ModelState.IsValid)
            {
                _context.Add(категорияПользователя);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(категорияПользователя);
        }

        // GET: КатегорияПользователя/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var категорияПользователя = await _context.КатегорияПользователя.FindAsync(id);
            if (категорияПользователя == null)
            {
                return NotFound();
            }
            return View(категорияПользователя);
        }

        // POST: КатегорияПользователя/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("КодКатегории,Название")] КатегорияПользователя категорияПользователя)
        {
            if (id != категорияПользователя.КодКатегории)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(категорияПользователя);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!КатегорияПользователяExists(категорияПользователя.КодКатегории))
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
            return View(категорияПользователя);
        }

        // GET: КатегорияПользователя/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var категорияПользователя = await _context.КатегорияПользователя
                .FirstOrDefaultAsync(m => m.КодКатегории == id);
            if (категорияПользователя == null)
            {
                return NotFound();
            }

            return View(категорияПользователя);
        }

        // POST: КатегорияПользователя/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var категорияПользователя = await _context.КатегорияПользователя.FindAsync(id);
            _context.КатегорияПользователя.Remove(категорияПользователя);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool КатегорияПользователяExists(long id)
        {
            return _context.КатегорияПользователя.Any(e => e.КодКатегории == id);
        }
    }
}
