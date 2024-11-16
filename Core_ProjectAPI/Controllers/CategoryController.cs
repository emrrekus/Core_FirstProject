using Core_ProjectAPI.DAL.ApiContext;
using Core_ProjectAPI.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            var c = new Context();

            return Ok(c.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var c = new Context();
            var values = c.Categories.Find(id);

            if(values != null)
            {
                return Ok(values);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);    
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var c = new Context();
            var values = c.Categories.Find(id);
            if (values != null)
            {
               c.Remove(values);
                c.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
