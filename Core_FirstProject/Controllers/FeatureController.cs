using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.Controllers
{
    public class FeatureController : Controller
    {

        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _featureService.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            _featureService.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
