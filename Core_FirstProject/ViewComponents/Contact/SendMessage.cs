using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }



    }
}
