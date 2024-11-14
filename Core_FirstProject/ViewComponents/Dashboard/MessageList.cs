using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        private readonly IUserMessageService _userMessageService;

        public MessageList(IUserMessageService messageService)
        {
            _userMessageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userMessageService.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
