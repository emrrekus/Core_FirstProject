﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_FirstProject.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {

        private readonly ISkillService _skillService;

        public SkillList(ISkillService skillService)
        {
            _skillService = skillService;
        }


        public IViewComponentResult Invoke()
        {

            var values = _skillService.TGetAll();
            return View(values);
        }
    }
}
