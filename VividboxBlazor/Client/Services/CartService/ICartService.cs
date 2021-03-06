using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);

        Task<List<CartItem>> GetCartItems();

        Task DeleteItem(CartItem item);
    }
}