using System.Collections.Generic;
using System.Threading.Tasks;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductByCategory(string categoryUrl);
        Task<Product> GetProduct(int Id);
    }
}