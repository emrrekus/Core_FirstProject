using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace Core_FirstProject.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortoflioService _portoflioService;

        public PortfolioController(IPortoflioService portoflioService)
        {
            _portoflioService = portoflioService;
        }

        public IActionResult Index()
        {
            var values = _portoflioService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            FluentValidation.Results.ValidationResult results = validations.Validate(p);

            if (results.IsValid)
            {
                _portoflioService.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();  
       
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = _portoflioService.TGetById(id);
            _portoflioService.TDelete(values.PortfolioId);
            return RedirectToAction("Index");
        }
        public IActionResult EditPortfolio(int id)
        {
            var values = _portoflioService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            _portoflioService.TUpdate(portfolio);
            return RedirectToAction("Index");
                     
         
        }
    }
}
