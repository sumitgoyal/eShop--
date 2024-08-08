
using BuildingBlocks.CQRS;
using CatalogAPI.Models;

namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(string Name,string Description, List<string> Category, string ImageFile, decimal Price):ICommand<CreateProductResult>;
    public record CreateProductResult( Guid ID);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var Product = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Category = command.Category,
                ImageFile = command.ImageFile,
                Price = command.Price
            };
            return new CreateProductResult(Guid.NewGuid());
            //throw  new NotImplementedException();
        }                   
    }
}
