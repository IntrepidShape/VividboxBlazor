using System.Collections.Generic;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        
        public void LoadProducts()
        {
            Products = new List<Product> 
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhikers's Guide to the Galaxy",
                    Description = "Here is where the description goes yada yada yada, It can be long.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                }, new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                }, new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "AMD Guardian Gaming PC Ryzen 5 RTX3060 1TB SSD 16G",
                    Description = "Custom build AMD Guardian series Gaming PC.   Featuring the latest AMD Ryzen 5 5600X CPU, nVidia RTX3060 video card, 1TB NVME M.2 SSD, 16GB DDR4 memory.    Best suited for regular gamers with best price/performance ratio.",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_5692650061624521489.jpg",
                    Price = 2176.79m,
                    OriginalPrice = 2572.57m,
                },new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "AMD Guardian Gaming PC Ryzen 7 RTX3070 Ti 1TB SSD 16G",
                    Description = "AMD Guardian RTX3070 Ti Ryzen 7 Gaming PC. Nvidia RTX3070 Ti video card, Ryzen 7 5800X CPU, 1TB NVME SSD, 16G Ram, 240mm AIO water cooling.",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_2454617561624413498.jpg",
                    Price = 3362.59m,
                    OriginalPrice = 3973.97m,
                },new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Title = "AMD Devastor Gaming PC RTX3080 Ryzen 7 1TB SSD 16G",
                    Description = "Devastor RTX3080 AMD Ryzen 7 Gaming PC. Ryzen 7 5800X 8 Core CPU, RTX3080 video card, 1TB NVME SSD, 16GB memory.",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_9626281801626400576.jpg",
                    Price = 3991.79m,
                    OriginalPrice = 4717.57m,
                },new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Intel Devastor Gaming PC RTX3080 Ti X-Series i9 2TB SSD 16G",
                    Description = "Devastor RTX3080 Ti Gaming PC. With Intel Core i9 X Series CPU, new RTX3080 Ti video card, 2TB NVME SSD, 16G memory, ARGB All in one 360mm water cooling!",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_2509428591624518566.jpg",
                    Price = 5528.49m,
                    OriginalPrice = 6533.67m,
                },new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                },new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                },new Product
                {
                    Id = 9,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                },new Product
                {
                    Id = 10,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                },new Product
                {
                    Id = 11,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                },
            };  
        }
    }
}