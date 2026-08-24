namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct
{
    public class GetProductResponse
    {
        public string Title { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public GetProductRatingResponse Rating { get; set; } = new GetProductRatingResponse();

    }
    public class GetProductRatingResponse
    {
        public double Rate { get; set; } = 0;
        public int Count { get; set; } = 0;
    }
}
