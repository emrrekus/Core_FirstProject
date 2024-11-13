using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.About
{
    public class AboutList : ViewComponent
    {

        private readonly IAboutService _aboutService;

        public AboutList(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _aboutService.TGetAll();
            return View(values);
        }
    }
}
