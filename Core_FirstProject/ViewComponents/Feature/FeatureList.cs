using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {

       private readonly IFeatureService _featureService;

        public FeatureList(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {

            var values = _featureService.TGetAll();
            return View(values);
        }


    }
}
