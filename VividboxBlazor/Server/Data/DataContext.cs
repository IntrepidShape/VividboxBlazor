using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VividboxBlazor.Shared;

namespace VividboxBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new {p.ProductId,p.EditionId});
            
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Books", Url = "Books", Icon = "book" },
                new Category() { Id = 2, Name = "Games", Url = "Games", Icon = "aperture" },
                new Category() { Id = 3, Name = "Computers", Url = "Computers", Icon = "monitor" }
            );
            
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhikers's Guide to the Galaxy",
                    Description = "Here is where the description goes yada yada yada, It can be long.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                    DateCreated = new DateTime(2021,9,2)
                }, new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg",
                    Price = 18.88m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2021,9,2)
                }, new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "AMD Guardian Gaming PC Ryzen 5 RTX3060 1TB SSD 16G",
                    Description = "Custom build AMD Guardian series Gaming PC.   Featuring the latest AMD Ryzen 5 5600X CPU, nVidia RTX3060 video card, 1TB NVME M.2 SSD, 16GB DDR4 memory.    Best suited for regular gamers with best price/performance ratio.",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_5692650061624521489.jpg",
                    
                    DateCreated = new DateTime(2021,9,2)
                },new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "AMD Guardian Gaming PC Ryzen 7 RTX3070 Ti 1TB SSD 16G",
                    Description = "AMD Guardian RTX3070 Ti Ryzen 7 Gaming PC. Nvidia RTX3070 Ti video card, Ryzen 7 5800X CPU, 1TB NVME SSD, 16G Ram, 240mm AIO water cooling.",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_2454617561624413498.jpg",
                    Price = 3362.59m,
                    OriginalPrice = 3973.97m,
                    DateCreated = new DateTime(2021,9,2)
                },new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Title = "AMD Devastor Gaming PC RTX3080 Ryzen 7 1TB SSD 16G",
                    Description = "Devastor RTX3080 AMD Ryzen 7 Gaming PC. Ryzen 7 5800X 8 Core CPU, RTX3080 video card, 1TB NVME SSD, 16GB memory.",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_9626281801626400576.jpg",
                    Price = 3991.79m,
                    OriginalPrice = 4717.57m,
                    DateCreated = new DateTime(2021,9,2)
                },new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Intel Devastor Gaming PC RTX3080 Ti X-Series i9 2TB SSD 16G",
                    Description = "Devastor RTX3080 Ti Gaming PC. With Intel Core i9 X Series CPU, new RTX3080 Ti video card, 2TB NVME SSD, 16G memory, ARGB All in one 360mm water cooling!",
                    Image = "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_2509428591624518566.jpg",
                    Price = 5528.49m,
                    OriginalPrice = 6533.67m,
                    DateCreated = new DateTime(2021,9,2)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition {Id = 1, Name = "Paperback"},
                new Edition {Id = 2, Name = "E-Book"},
                new Edition {Id = 3, Name = "AudioBook"},
                new Edition {Id = 4, Name = "PC"},
                new Edition {Id = 5, Name = "Playstation"},
                new Edition {Id = 6, Name = "XBox"},
                new Edition {Id = 7, Name = "Tier 1"},
                new Edition {Id = 8, Name = "Tier 2"},
                new Edition {Id = 9, Name = "Tier 3"},
                new Edition {Id = 10, Name = "Tier 4"}
            );
            modelBuilder.Entity<Edition>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 1,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 2176.79m,
                    OriginalPrice = 2572.57m,
                }, new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 5,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 6,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 7,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 8,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 9,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }, new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 10,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }
                );
        }
    }
}