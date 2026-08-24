using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Product name is required.")
                .Length(3, 50)
                .WithMessage("Product name must be between 3 and 50 characters.");
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Product description is required.")
                .Length(10, 200)
                .WithMessage("Product description must be between 10 and 200 characters.");
            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("Product price must be greater than zero.");
        }
    }
}
