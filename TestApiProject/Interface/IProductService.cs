using TestApiProject.Models;
namespace TestApiProject
{
    public interface IProductService
    {
        bool SaveProductDetails(ProductDetails pod);
        List<ProductDetails> SearchProductDetails(string id);
      Task<IEnumerable<ProductDetails>> GetProductDetails();
    }

}
