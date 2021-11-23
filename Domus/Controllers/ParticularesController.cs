using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domus.Models;

namespace Domus.Controllers
{
    public class ParticularesController : Controller
    {
        private readonly TPIContext _context;

        public ParticularesController(TPIContext context)
        {
            _context = context;
        }

        // GET: Particulars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Particulares.ToListAsync());
        }

        // GET: Particulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var particular = await _context.Particulares
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (particular == null)
            {
                return NotFound();
            }

            return View(particular);
        }

        // GET: Particulars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Particulars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Apellido,DNI,CUIL,FechaDeNacimiento,Telefono,Email,IdCliente,NroCuenta")] Particular particular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(particular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(particular);
        }

        // GET: Particulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var particular = await _context.Particulares.FindAsync(id);
            if (particular == null)
            {
                return NotFound();
            }
            return View(particular);
        }

        // POST: Particulars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nombre,Apellido,DNI,CUIL,FechaDeNacimiento,Telefono,Email,IdCliente,NroCuenta")] Particular particular)
        {
            if (id != particular.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(particular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticularExists(particular.IdCliente))
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
            return View(particular);
        }

        // GET: Particulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var particular = await _context.Particulares
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (particular == null)
            {
                return NotFound();
            }

            return View(particular);
        }

        // POST: Particulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var particular = await _context.Particulares.FindAsync(id);
            _context.Particulares.Remove(particular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParticularExists(int id)
        {
            return _context.Particulares.Any(e => e.IdCliente == id);
        }
    }
}
