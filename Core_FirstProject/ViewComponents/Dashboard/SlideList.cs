using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Dashboard
{
    public class SlideList: ViewComponent
    {


        private readonly IPortoflioService _portoflioService;

        public SlideList(IPortoflioService portoflioService)
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
