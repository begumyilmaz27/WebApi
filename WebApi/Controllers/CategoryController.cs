using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApi.DAL;
using WebApi.DAL.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult CategoryGet(int id)
        {
            var values = context.Categories.Find(id);
            return Ok(values);
        }
        [HttpDelete("id")]
        public IActionResult CategoryDelete(int id)
        {
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return Ok();
        }
    }
}
