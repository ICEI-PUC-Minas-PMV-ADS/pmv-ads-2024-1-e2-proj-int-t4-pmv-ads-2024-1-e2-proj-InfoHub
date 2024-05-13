using info_hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace info_hub.Controllers
{
    public class NoticiasController(AppDbContext context) : Controller
    {
        public class HomeController : Controller
        {
            // Ação para a página inicial
            public ActionResult Index()
            {
                return View("Index");
            }

            // Ação para exibir as notícias
            public ActionResult Noticias()
            {
                return View("~/Views/Noticias/Index.cshtml");
            }
        }
        public async Task<IActionResult> Index()
        {
            var news_data = await context.Noticias.ToListAsync();
            return View(news_data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                context.Noticias.Add(noticia);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(noticia);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var news_data = await context.Noticias.FindAsync(id);

            if (news_data == null)
                return NotFound();

            return View(news_data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Noticia noicia) {
            if (id != noicia.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                context.Noticias.Update(noicia);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) 
                return NotFound();

            var news_data = await context.Noticias.FindAsync(id);
            if (news_data == null)
                return NotFound();

            return View(news_data);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var news_data = await context.Noticias.FindAsync(id);
            if (news_data == null)
                return NotFound();

            return View(news_data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var news_data = await context.Noticias.FindAsync(id);
            if (news_data == null)
                return NotFound();

            context.Noticias.Remove(news_data);
            await context.SaveChangesAsync();

            return View(news_data);
        }

    }
}
