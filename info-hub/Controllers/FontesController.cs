using info_hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace info_hub.Controllers
{
    public class FontesController : Controller

    {
        private readonly AppDbContext _context;
        public FontesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        {
            var dados = await _context.Fontes.ToListAsync();

            return View(dados); 
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Fonte fonte)
        {

            if (ModelState.IsValid)
            {
                _context.Fontes.Add(fonte);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
                return NotFound();

            var dados = await _context.Fontes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Fonte fonte)

        {
            if(id != fonte.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Fontes.Update(fonte);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Fontes.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View(dados); 
        
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Fontes.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Fontes.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Fontes.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
