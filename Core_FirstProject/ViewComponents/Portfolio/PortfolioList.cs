using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {

        private readonly IPortoflioService _portoflioService;

        public PortfolioList(IPortoflioService portoflioService)
        {
            _portoflioService = portoflioService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _portoflioService.TGetAll();
            return View(values);
        }
    }
}
