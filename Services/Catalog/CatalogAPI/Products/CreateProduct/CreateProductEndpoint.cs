﻿namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductRequest(string Name, string Description, List<string> Category, string ImageFile, decimal Price);
    public record CreateProductResponse(Guid Id);
    public class CreateProductEndPoint
    {
    }
}
