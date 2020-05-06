using ASP_.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace ASP_.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Models.AppContext _context;

        public HomeController(ILogger<HomeController> logger, Models.AppContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Exemplo()
        {
            return View();
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return View();
        }

        public IActionResult Atualizar(int? id)
        {
            if (id.HasValue)
                return View(_context.Users.Find(id.Value));

            return View("Error");
        }

        [HttpPost]
        public IActionResult Atualizar(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Listar()
        {
            return View(_context.Users.ToList());
        }

        public void Deletar(int id)
        {
            var entity = _context.Users.Find(id);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public IActionResult Privacy()
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
