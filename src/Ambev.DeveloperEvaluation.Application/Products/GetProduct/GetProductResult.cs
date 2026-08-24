namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    public class GetProductResult
    {
        public string Title { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public GetProductRatingResult Rating { get; set; } = new GetProductRatingResult();

    }
    public class GetProductRatingResult
    {
        public double Rate { get; set; } = 0;
        public int Count { get; set; } = 0;
    }
}


