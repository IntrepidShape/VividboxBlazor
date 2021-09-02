using System.Collections.Generic;
using System.Threading.Tasks;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}