using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
        {
            new Category() { Id = 1, Name = "Books", Url = "Books", Icon = "book" },
            new Category() { Id = 2, Name = "Games", Url = "Games", Icon = "aperture" },
            new Category() { Id = 3, Name = "Computers", Url = "Computers", Icon = "monitor" },

        };

        public async Task<List<Category>> GetCategories()
        {   
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }       
}