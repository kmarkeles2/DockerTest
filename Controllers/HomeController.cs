using DockerTest.Contexts;
using DockerTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DockerTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TestContext _dbContext;

        public HomeController(ILogger<HomeController> logger, TestContext dbContext)
        {
            _logger = logger;
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var welcomeMessages = _dbContext.WelcomeMessages.ToList();
            return View(welcomeMessages);
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
