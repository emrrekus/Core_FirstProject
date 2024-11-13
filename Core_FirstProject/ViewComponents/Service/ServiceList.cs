using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {

        private readonly IServiceService _serviceService;

        public ServiceList(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _serviceService.TGetAll();
            return View(values);
        }
    }
}
