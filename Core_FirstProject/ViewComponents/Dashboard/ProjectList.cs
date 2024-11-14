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
    public class ProjectList: ViewComponent
    {
      private readonly IPortoflioService _portoflioService;

        public ProjectList(IPortoflioService portoflioService)
        {
            _portoflioService = portoflioService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portoflioService.TGetAll();
            return View(values);
        }
    }
}
