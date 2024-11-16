using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_FirstProject.Controllers
{
    [AllowAnonymous]
    public class WriterUserController : Controller
    {
        private readonly IWriterService _writerService;

        public WriterUserController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(_writerService.TGetAll());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser user)
        {
            _writerService.TInsert(user);
            var values = JsonConvert.SerializeObject(user);
            return Json(values);

        }
    }
}
