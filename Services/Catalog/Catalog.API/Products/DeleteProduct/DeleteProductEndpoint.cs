
using Catalog.API.Products.CreateProduct;

namespace Catalog.API.Products.DeleteProduct
{
    public record DeleteProductRequest(Guid Id);
    public record DeleteProductResponse(bool IsSuccess);
    public class DeleteProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/{id}", async (Guid id, ISender sender) =>
            {
                var response = await sender.Send(new DeleteProductRequest(id).Adapt<DeleteProductCommand>());
                var result = response.Adapt<DeleteProductResponse>();
                return Results.Ok(result);
            })
            .WithName("DeleteProduct")
            .Produces<DeleteProductResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Delete Product")
            .WithDescription("Delete Product");
        }
    }
}
