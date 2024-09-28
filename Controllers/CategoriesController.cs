using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private static List <Category> categories=new List<Category>() 
        {
            new Category()
            {             
                Id = 0,                
                ImageUrl="appartment.png",
                Name="Appartment"
            },
            new Category()
            {
                Name="Commercial",
                Id = 1,
                ImageUrl="commercial.png"
            }
        };


        [HttpGet]
        public IEnumerable<Category> Get() {
                        return categories;        
        }


        [HttpPost]
        public void Post([FromBody]Category category) 
        {
            categories.Add(category);
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Category category)
        {
            categories[id] = category;

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            categories.RemoveAt(id);
        }
    }
}
