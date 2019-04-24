using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Vendas;
using Infra.Data.Data.Context;

namespace ECOMMERCE.UI.Controllers.Venda
{
    public class BebidaController : Controller
    {
        private readonly DbContextGeral _context;

        public BebidaController(DbContextGeral context)
        {
            _context = context;
        }

        // GET: Bebida
        public async Task<IActionResult> Index()
        {
            var contextoGeral = _context.Bebidas.Include(b => b.Categoria);
            return View(await contextoGeral.ToListAsync());
        }

        // GET: Bebida/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bebida = await _context.Bebidas
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(m => m.BebidaId == id);
            if (bebida == null)
            {
                return NotFound();
            }

            return View(bebida);
        }

        // GET: Bebida/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Set<Categoria>(), "CategoriaId", "CategoriaId");
            return View();
        }

        // POST: Bebida/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BebidaId,Nome,MineDescricao,DescricaoLonga,Preco,ImageUrl,ImageThumbnailUrl,BebidaPrefierida,Estoque,CategoriaId")] Bebida bebida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bebida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Set<Categoria>(), "CategoriaId", "CategoriaId", bebida.CategoriaId);
            return View(bebida);
        }

        // GET: Bebida/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bebida = await _context.Bebidas.FindAsync(id);
            if (bebida == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Set<Categoria>(), "CategoriaId", "CategoriaId", bebida.CategoriaId);
            return View(bebida);
        }

        // POST: Bebida/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BebidaId,Nome,MineDescricao,DescricaoLonga,Preco,ImageUrl,ImageThumbnailUrl,BebidaPrefierida,Estoque,CategoriaId")] Bebida bebida)
        {
            if (id != bebida.BebidaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bebida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BebidaExists(bebida.BebidaId))
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
            ViewData["CategoriaId"] = new SelectList(_context.Set<Categoria>(), "CategoriaId", "CategoriaId", bebida.CategoriaId);
            return View(bebida);
        }

        // GET: Bebida/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bebida = await _context.Bebidas
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(m => m.BebidaId == id);
            if (bebida == null)
            {
                return NotFound();
            }

            return View(bebida);
        }

        // POST: Bebida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bebida = await _context.Bebidas.FindAsync(id);
            _context.Bebidas.Remove(bebida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BebidaExists(int id)
        {
            return _context.Bebidas.Any(e => e.BebidaId == id);
        }
    }
}
