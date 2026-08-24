using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;


namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

public class CreateProduct : Profile
{
    public CreateProduct()
    {
        CreateMap<CreateProductRequest, CreateProductCommand>();   
         
        CreateMap<CreateProductRatingRequest, CreateProductRatingCommand>();

        CreateMap<CreateProductResult, CreateProductResponse>();

    }
}
