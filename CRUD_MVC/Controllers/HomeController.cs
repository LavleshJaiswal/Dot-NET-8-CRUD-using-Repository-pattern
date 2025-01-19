using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;

namespace CRUD_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string errorMessage,string ReturnURL)
        {
            var errorData = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                EnvironmentName = _webHostEnvironment.EnvironmentName,
                ErrorMessage = errorMessage,
                ReturnURL= ReturnURL

            };


            return View(errorData);
        }
    }
}
