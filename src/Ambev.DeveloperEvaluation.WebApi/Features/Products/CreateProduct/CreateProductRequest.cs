namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductRequest
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public CreateProductRatingRequest Rating { get; set; }
    }
    public class CreateProductRatingRequest
    {
        public double Rate { get; set; }
        public int Count { get; set; }
    }
}
