using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VividboxBlazor.Client.Services.CategoryService;
using VividboxBlazor.Shared;
using ICategoryService = VividboxBlazor.Server.Services.CategoryService.ICategoryService;

namespace VividboxBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(Services.CategoryService.ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            
            return Ok(await _categoryService.GetCategories());
        }
    }
}