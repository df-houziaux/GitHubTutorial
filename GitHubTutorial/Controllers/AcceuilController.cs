using GitHubTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitHubTutorial.Controllers
{
    public class AcceuilController : Controller
    {
        private readonly ILogger<AcceuilController> _logger;

        public AcceuilController(ILogger<AcceuilController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
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
