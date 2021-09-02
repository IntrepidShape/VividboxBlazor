using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            
            return Ok( new List<Category>() 
            {
                new Category() {Id = 1, Name = "Books", Url="Books", Icon ="book"},
                new Category() {Id = 2, Name = "Games", Url="Games", Icon ="aperture"},
                new Category() {Id = 3, Name = "Computers", Url="Computers", Icon ="monitor"},
                
            });
        }
    }
}