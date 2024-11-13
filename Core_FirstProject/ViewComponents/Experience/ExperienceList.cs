using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {

        private readonly IExperienceService _experienceService;

        public ExperienceList(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _experienceService.TGetAll();
            return View(values);
        }
    }
}
