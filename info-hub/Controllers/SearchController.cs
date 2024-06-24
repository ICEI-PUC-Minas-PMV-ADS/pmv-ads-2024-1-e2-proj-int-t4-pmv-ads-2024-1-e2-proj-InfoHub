using info_hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace info_hub.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;
        public SearchController(AppDbContext context) => _context = context;

        public IActionResult Index(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return View(new List<Noticia>()); // Retorna uma lista vazia se não houver termo de pesquisa
            }

            // Consulta no banco de dados para encontrar notícias que correspondam ao termo de pesquisa
            var noticiasEncontradas = _context.Noticias
                .Where(n => n.Titulo.Contains(search) || n.Tema.Contains(search))
                .ToList();

            // Passa os resultados para a view
            ViewBag.SearchTerm = search;
            return View(noticiasEncontradas);
        }
    }
}
