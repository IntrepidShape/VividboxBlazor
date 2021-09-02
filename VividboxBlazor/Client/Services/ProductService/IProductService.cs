using System.Collections.Generic;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Client.Services.ProductService
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }

        public void LoadProducts()
        {
        }
    }
}