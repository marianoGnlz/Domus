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
    public class CorporativosController : Controller
    {
        private readonly TPIContext _context;

        public CorporativosController(TPIContext context)
        {
            _context = context;
        }

        // GET: Corporativoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Corporativos.ToListAsync());
        }

        // GET: Corporativoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corporativo = await _context.Corporativos
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (corporativo == null)
            {
                return NotFound();
            }

            return View(corporativo);
        }

        // GET: Corporativoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Corporativoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Domicilio,Nacionalidad,RazonSocial,CUIT,IdCliente,NroCuenta")] Corporativo corporativo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(corporativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(corporativo);
        }

        // GET: Corporativoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corporativo = await _context.Corporativos.FindAsync(id);
            if (corporativo == null)
            {
                return NotFound();
            }
            return View(corporativo);
        }

        // POST: Corporativoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Domicilio,Nacionalidad,RazonSocial,CUIT,IdCliente,NroCuenta")] Corporativo corporativo)
        {
            if (id != corporativo.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(corporativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorporativoExists(corporativo.IdCliente))
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
            return View(corporativo);
        }

        // GET: Corporativoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corporativo = await _context.Corporativos
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (corporativo == null)
            {
                return NotFound();
            }

            return View(corporativo);
        }

        // POST: Corporativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var corporativo = await _context.Corporativos.FindAsync(id);
            _context.Corporativos.Remove(corporativo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorporativoExists(int id)
        {
            return _context.Corporativos.Any(e => e.IdCliente == id);
        }
    }
}
