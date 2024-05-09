using Microsoft.AspNetCore.Mvc;
using info_hub.Models;
using Microsoft.EntityFrameworkCore;

namespace info_hub.Controllers;

public class TemasController : Controller
{
    private readonly AppDbContext _context;

    public TemasController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Temas.ToListAsync());
    }

    // GET: Temas/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tema = await _context.Politica
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tema == null)
        {
            return NotFound();
        }

        return View(tema);
    }

    // GET: Temas/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Temas/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Politica,Mundo,Economia,Tecnologia,Negócios,Viagens,Clima,Moda,Comida,Esporte")] Tema tema)
    {
        if (ModelState.IsValid)
        {
            _context.Temas.Add(tema);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(tema);
    }

    // GET: Temas/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tema = await _context.Politica.FindAsync(id);
        if (tema == null)
        {
            return NotFound();
        }
        return View(tema);
    }

    // POST: Temas/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Politica,Mundo,Economia,Tecnologia,Negócios,Viagens,Clima,Moda,Comida,Esporte")] Tema tema)
    {
        if (id != tema.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(tema);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemaExists(tema.Id))
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
        return View(tema);
    }

    // GET: Temas/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tema = await _context.Politica
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tema == null)
        {
            return NotFound();
        }

        return View(tema);
    }

    // POST: Temas/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var tema = await _context.Politica.FindAsync(id);
        if (tema != null)
        {
            _context.Politica.Remove(tema);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TemaExists(int id)
    {
        return _context.Politica.Any(e => e.Id == id);
    }
}