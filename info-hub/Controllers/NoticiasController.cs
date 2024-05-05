using info_hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace info_hub.Controllers
{
    public class NoticiasController(AppDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var news_data = await context.Noticias.ToListAsync();
            return View(news_data);
        }
    }
}
