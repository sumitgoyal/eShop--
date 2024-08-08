﻿namespace CatalogAPI.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = default;
        public string Description { get; set; } = default;
        public List<string> Category { get; set; } = new();
        public string ImageFile { get; set; } = default;
        public decimal Price { get; set; }
    }
}
