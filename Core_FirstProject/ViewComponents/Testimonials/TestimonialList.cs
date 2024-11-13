using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Testimonials
{
    public class TestimonialList : ViewComponent
    {

        private readonly ITestimonialService _testimonialService;

        public TestimonialList(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _testimonialService.TGetAll();
            return View(values);
        }
    }
}

