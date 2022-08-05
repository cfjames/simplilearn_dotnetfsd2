using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phase3Section4.Models;

namespace Phase3Section4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { Name = "React", Code = "react" });
            categories.Add(new Category { Name = "Redux", Code = "redux" });
            categories.Add(new Category { Name = "Angular", Code = "react" });
            categories.Add(new Category { Name = "ES6", Code = "es6" });
            categories.Add(new Category { Name = "Java", Code = "java" });
            categories.Add(new Category { Name = "C#", Code = "c#" });

            return categories;
        }
    }
}
