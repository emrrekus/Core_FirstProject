using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;
      

        public AdminMessageController(IWriterMessageService writerMessageService, UserManager<WriterUser> userManager)
        {
            _writerMessageService = writerMessageService;
           
        }

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin1@gmail.com";
            var values = _writerMessageService.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin1@gmail.com";
            var values = _writerMessageService.GetListSenderMessage(p);
            return View(values);
        }


        public IActionResult AdminMessageDetails(int id)
        {
            var values = _writerMessageService.TGetById(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = _writerMessageService.TGetById(id);
            _writerMessageService.TDelete(values.WriterMessageID);
            return RedirectToAction("SenderMessageList");
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin1@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            _writerMessageService.TInsert(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
