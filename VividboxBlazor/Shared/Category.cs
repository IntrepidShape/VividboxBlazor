using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace VividboxBlazor.Shared
{
    public class Category : Exception
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public List<Product> Products { get; set; }
    }
}