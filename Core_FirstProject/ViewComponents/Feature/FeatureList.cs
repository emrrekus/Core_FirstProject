using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {

       

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal(new Context()));
        
        public IViewComponentResult Invoke()
        {

            var values = featureManager.TGetAll();
            return View(values);
        }


    }
}
