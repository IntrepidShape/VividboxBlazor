using System.Collections.Generic;
using System.Threading.Tasks;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}