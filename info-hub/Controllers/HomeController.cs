using info_hub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace info_hub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Politica()
        {
            return View();
        }

        // Nova ação para a página "Mundo"
        public IActionResult Mundo()
        {
            return View();
        }
        public IActionResult Economia()
        {
            return View();
        }

        public IActionResult Tecnologia()
        {
            return View();
        }
        public IActionResult Negocios()
        {
            return View();
        }

        public IActionResult Viagens()
        {
            return View();
        }
        public IActionResult Clima()
        {
            return View();
        }

        public IActionResult Moda()
        {
            return View();
        }

        public IActionResult Comida()
        {
            return View();
        }
        // Nova ação para a página "Esportes"
        public IActionResult Esportes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
