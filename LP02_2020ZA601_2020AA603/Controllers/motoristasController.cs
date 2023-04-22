﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LP02_2020ZA601_2020AA603.Models;

namespace LP02_2020ZA601_2020AA603.Controllers
{
    public class motoristasController : Controller
    {
        private readonly restauranteDBContext _context;

        public motoristasController(restauranteDBContext context)
        {
            _context = context;
        }

        // GET: motoristas
        public async Task<IActionResult> Index()
        {
              return _context.motoristas != null ? 
                          View(await _context.motoristas.ToListAsync()) :
                          Problem("Entity set 'restauranteDBContext.motoristas'  is null.");
        }

        // GET: motoristas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.motoristas == null)
            {
                return NotFound();
            }

            var motoristas = await _context.motoristas
                .FirstOrDefaultAsync(m => m.motoritaId == id);
            if (motoristas == null)
            {
                return NotFound();
            }

            return View(motoristas);
        }

        // GET: motoristas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: motoristas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("motoritaId,nombreMotorista")] motoristas motoristas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motoristas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motoristas);
        }

        // GET: motoristas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.motoristas == null)
            {
                return NotFound();
            }

            var motoristas = await _context.motoristas.FindAsync(id);
            if (motoristas == null)
            {
                return NotFound();
            }
            return View(motoristas);
        }

        // POST: motoristas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("motoritaId,nombreMotorista")] motoristas motoristas)
        {
            if (id != motoristas.motoritaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motoristas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!motoristasExists(motoristas.motoritaId))
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
            return View(motoristas);
        }

        // GET: motoristas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.motoristas == null)
            {
                return NotFound();
            }

            var motoristas = await _context.motoristas
                .FirstOrDefaultAsync(m => m.motoritaId == id);
            if (motoristas == null)
            {
                return NotFound();
            }

            return View(motoristas);
        }

        // POST: motoristas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.motoristas == null)
            {
                return Problem("Entity set 'restauranteDBContext.motoristas'  is null.");
            }
            var motoristas = await _context.motoristas.FindAsync(id);
            if (motoristas != null)
            {
                _context.motoristas.Remove(motoristas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool motoristasExists(int id)
        {
          return (_context.motoristas?.Any(e => e.motoritaId == id)).GetValueOrDefault();
        }
    }
}
