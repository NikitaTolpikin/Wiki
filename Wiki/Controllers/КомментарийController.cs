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
    public class КомментарийController : Controller
    {
        private readonly ВикисловарьContext _context;

        public КомментарийController(ВикисловарьContext context)
        {
            _context = context;
        }

        // GET: Комментарий
        public async Task<IActionResult> Index()
        {
            var викисловарьContext = _context.Комментарий.Include(к => к.IdПользователяNavigation).Include(к => к.IdПравкиNavigation);
            return View(await викисловарьContext.ToListAsync());
        }

        // GET: Комментарий/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var комментарий = await _context.Комментарий
                .Include(к => к.IdПользователяNavigation)
                .Include(к => к.IdПравкиNavigation)
                .FirstOrDefaultAsync(m => m.IdКомментария == id);
            if (комментарий == null)
            {
                return NotFound();
            }

            return View(комментарий);
        }

        // GET: Комментарий/Create
        public IActionResult Create()
        {
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail");
            ViewData["IdПравки"] = new SelectList(_context.Правка, "IdПравки", "Название");
            return View();
        }

        // POST: Комментарий/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdКомментария,ТекстКомментария,IdПравки,IdПользователя,ВремяНаписания")] Комментарий комментарий)
        {
            if (ModelState.IsValid)
            {
                комментарий.IdКомментария = Guid.NewGuid();
                _context.Add(комментарий);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", комментарий.IdПользователя);
            ViewData["IdПравки"] = new SelectList(_context.Правка, "IdПравки", "Название", комментарий.IdПравки);
            return View(комментарий);
        }

        // GET: Комментарий/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var комментарий = await _context.Комментарий.FindAsync(id);
            if (комментарий == null)
            {
                return NotFound();
            }
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", комментарий.IdПользователя);
            ViewData["IdПравки"] = new SelectList(_context.Правка, "IdПравки", "Название", комментарий.IdПравки);
            return View(комментарий);
        }

        // POST: Комментарий/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdКомментария,ТекстКомментария,IdПравки,IdПользователя,ВремяНаписания")] Комментарий комментарий)
        {
            if (id != комментарий.IdКомментария)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(комментарий);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!КомментарийExists(комментарий.IdКомментария))
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
            ViewData["IdПользователя"] = new SelectList(_context.Пользователь, "IdПользователя", "EMail", комментарий.IdПользователя);
            ViewData["IdПравки"] = new SelectList(_context.Правка, "IdПравки", "Название", комментарий.IdПравки);
            return View(комментарий);
        }

        // GET: Комментарий/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var комментарий = await _context.Комментарий
                .Include(к => к.IdПользователяNavigation)
                .Include(к => к.IdПравкиNavigation)
                .FirstOrDefaultAsync(m => m.IdКомментария == id);
            if (комментарий == null)
            {
                return NotFound();
            }

            return View(комментарий);
        }

        // POST: Комментарий/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var комментарий = await _context.Комментарий.FindAsync(id);
            _context.Комментарий.Remove(комментарий);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool КомментарийExists(Guid id)
        {
            return _context.Комментарий.Any(e => e.IdКомментария == id);
        }
    }
}
