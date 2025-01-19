using System.Diagnostics;
namespace CRUD_MVC.Controllers;
public class HomeController : Controller
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public HomeController(IWebHostEnvironment webHostEnvironment)
    {
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
    public IActionResult Error(string errorMessage, string ReturnURL)
    {
        var errorData = new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            EnvironmentName = _webHostEnvironment.EnvironmentName,
            ErrorMessage = errorMessage,
            ReturnURL = ReturnURL

        };


        return View(errorData);
    }
}
