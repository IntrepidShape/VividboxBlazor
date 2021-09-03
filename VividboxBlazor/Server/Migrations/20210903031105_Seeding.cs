using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VividboxBlazor.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "HResult", "HelpLink", "Icon", "Name", "Source", "Url" },
                values: new object[] { 1, -2146233088, null, "book", "Books", null, "Books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "HResult", "HelpLink", "Icon", "Name", "Source", "Url" },
                values: new object[] { 2, -2146233088, null, "aperture", "Games", null, "Games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "HResult", "HelpLink", "Icon", "Name", "Source", "Url" },
                values: new object[] { 3, -2146233088, null, "monitor", "Computers", null, "Computers" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 9, 3, 11, 11, 4, 613, DateTimeKind.Local).AddTicks(2358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Here is where the description goes yada yada yada, It can be long.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", false, false, 19.99m, 9.99m, "The Hitchhikers's Guide to the Galaxy" },
                    { 2, 2, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7909), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.", "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg", false, false, 29.99m, 18.88m, "Half-Life 2" },
                    { 7, 2, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7944), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.", "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg", false, false, 29.99m, 18.88m, "Half-Life 2" },
                    { 8, 2, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7949), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.", "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg", false, false, 29.99m, 18.88m, "Half-Life 2" },
                    { 9, 2, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7951), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.", "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg", false, false, 29.99m, 18.88m, "Half-Life 2" },
                    { 10, 2, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7954), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.", "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg", false, false, 29.99m, 18.88m, "Half-Life 2" },
                    { 11, 2, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7956), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2, stylized as HλLF-LIFE2, is a science fiction first-person shooter developed and published by Valve Corporation, and released on November 16, 2004,[1] following an extended development period of five years. The game garnered near-unanimous positive reviews and received critical acclaim, winning over 30 Game of the Year awards. It is included in The Orange Box for the Xbox 360, PS3, and PC. It was also included for the Original Xbox on November 17th 2005.", "https://upload.wikimedia.org/wikipedia/en/2/2d/Half-Life_2_Episode_Two_title.jpg", false, false, 29.99m, 18.88m, "Half-Life 2" },
                    { 3, 3, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7934), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Custom build AMD Guardian series Gaming PC.   Featuring the latest AMD Ryzen 5 5600X CPU, nVidia RTX3060 video card, 1TB NVME M.2 SSD, 16GB DDR4 memory.    Best suited for regular gamers with best price/performance ratio.", "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_5692650061624521489.jpg", false, false, 2572.57m, 2176.79m, "AMD Guardian Gaming PC Ryzen 5 RTX3060 1TB SSD 16G" },
                    { 4, 3, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7937), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AMD Guardian RTX3070 Ti Ryzen 7 Gaming PC. Nvidia RTX3070 Ti video card, Ryzen 7 5800X CPU, 1TB NVME SSD, 16G Ram, 240mm AIO water cooling.", "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_2454617561624413498.jpg", false, false, 3973.97m, 3362.59m, "AMD Guardian Gaming PC Ryzen 7 RTX3070 Ti 1TB SSD 16G" },
                    { 5, 3, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7939), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devastor RTX3080 AMD Ryzen 7 Gaming PC. Ryzen 7 5800X 8 Core CPU, RTX3080 video card, 1TB NVME SSD, 16GB memory.", "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_9626281801626400576.jpg", false, false, 4717.57m, 3991.79m, "AMD Devastor Gaming PC RTX3080 Ryzen 7 1TB SSD 16G" },
                    { 6, 3, new DateTime(2021, 9, 3, 11, 11, 4, 614, DateTimeKind.Local).AddTicks(7942), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devastor RTX3080 Ti Gaming PC. With Intel Core i9 X Series CPU, new RTX3080 Ti video card, 2TB NVME SSD, 16G memory, ARGB All in one 360mm water cooling!", "https://www.compuworld.com.au/app/webroot/stuff/product_image/productImage_2509428591624518566.jpg", false, false, 6533.67m, 5528.49m, "Intel Devastor Gaming PC RTX3080 Ti X-Series i9 2TB SSD 16G" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
