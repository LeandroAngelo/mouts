namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public CreateProductRatingReaponse Rating { get; set; }
    }

    public class CreateProductRatingReaponse
    {
        public double Rate { get; set; }
        public int Count { get; set; }
    }

}
