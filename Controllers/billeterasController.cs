using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using enigmaBilleteras.Models;

namespace enigmaBilleteras.Controllers
{
    public class billeterasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public billeterasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: billeteras
        public async Task<IActionResult> Index()
        {
            return View(await _context.billeteras.ToListAsync());
        }

        // GET: billeteras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billetera = await _context.billeteras
                .FirstOrDefaultAsync(m => m.ID == id);
            if (billetera == null)
            {
                return NotFound();
            }

            return View(billetera);
        }

        // GET: billeteras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: billeteras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,marca,precio,colorDisponible,CalidadMaterial")] billetera billetera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billetera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(billetera);
        }

        // GET: billeteras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billetera = await _context.billeteras.FindAsync(id);
            if (billetera == null)
            {
                return NotFound();
            }
            return View(billetera);
        }

        // POST: billeteras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,marca,precio,colorDisponible,CalidadMaterial")] billetera billetera)
        {
            if (id != billetera.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billetera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!billeteraExists(billetera.ID))
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
            return View(billetera);
        }

        // GET: billeteras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billetera = await _context.billeteras
                .FirstOrDefaultAsync(m => m.ID == id);
            if (billetera == null)
            {
                return NotFound();
            }

            return View(billetera);
        }

        // POST: billeteras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var billetera = await _context.billeteras.FindAsync(id);
            _context.billeteras.Remove(billetera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool billeteraExists(int id)
        {
            return _context.billeteras.Any(e => e.ID == id);
        }
    }
}
