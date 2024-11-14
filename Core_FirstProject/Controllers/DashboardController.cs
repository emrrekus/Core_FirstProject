using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
