﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {

        private readonly IContactService _contactService;

        public ContactList(IContactService contactService)
        {
            _contactService = contactService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _contactService.TGetAll();
            return View(values);
        }
    }
}
