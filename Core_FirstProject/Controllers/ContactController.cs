using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.Controllers
{
    public class ContactController : Controller
    {
      private readonly  IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var values = _messageService.TGetAll();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var values = _messageService.TGetById(id);
            _messageService.TDelete(values.MessageId);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var values = _messageService.TGetById(id);
            return View(values);
        }
    }
}
