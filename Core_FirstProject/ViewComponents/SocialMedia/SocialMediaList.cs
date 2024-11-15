using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.SocialMedia
{
    public class SocialMediaList :ViewComponent
    {

        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaList(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetAll();
            return View(values);
        }
    }
}
