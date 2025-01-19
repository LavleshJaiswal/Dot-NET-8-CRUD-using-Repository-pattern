
namespace CRUD_MVC.Controllers;
public class HomeController(IWebHostEnvironment _webHostEnvironment) : Controller
{
    public IActionResult Index() => View();

    public IActionResult Privacy() => View();

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
