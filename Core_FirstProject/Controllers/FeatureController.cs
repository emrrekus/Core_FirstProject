using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
