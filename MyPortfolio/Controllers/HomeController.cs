using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
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
            var home = new HomeDTO
            {
                Name = "Yeray L�pez Santos",
                Description = "basic description",
                MyJobs = new List<Estudio>
                {
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = "Actualmente" },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = DateTime.Now.ToShortDateString() },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = "Actualmente" },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = DateTime.Now.ToShortDateString() },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = "Actualmente" },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = DateTime.Now.ToShortDateString() }
                },
                Studies = new List<Estudio>
                {
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = "Actualmente" },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = DateTime.Now.ToShortDateString() },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = DateTime.Now.ToShortDateString() }
                },
                Experience = new List<Estudio>
                {
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = "Actualmente" },
                    new Estudio{ Id = 1, Name = "asd", Description="asd", InitDate=DateTime.Now.ToShortDateString(), EndDate = DateTime.Now.ToShortDateString() }
                }
            };
            return View(home);
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
