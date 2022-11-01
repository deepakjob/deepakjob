using TestApiProject.DBContext;
using Moq;
using TestApiProject;
using TestApiProject.Controllers;
using TestApiProject.RepositoryService;
using TestApiProject.Models;
using System.Security.Principal;

namespace XunitTestApi
{
    public class ProductServiceTests
    {

        private readonly Mock<IProduct> productService;
        public ProductServiceTests()
        {
            productService = new Mock<IProduct>();
        }
        [Fact]
        public async void GetProductList_ValidData()
        {
            //arrange
            var productList = GetProductsData();
            //var productLists=List<ProductDetails>{productList};
            var returnProductLists = new Task<IEnumerable<ProductDetails>>(() => productList);
            returnProductLists.RunSynchronously();

            //Mock
            productService.Setup(x => x.GetProductDetails())
                .Returns(returnProductLists);

            var productController = new ProductController(productService.Object);

            //act
            var productResult =await productController.showProductList();

            //assert
            Assert.NotNull(productResult);
           // Assert.Equal(GetProductsData().Count(), productResult.Count());
            Assert.Equal(GetProductsData().ToString(), productResult.ToString());
            Assert.True(productList.Equals(productResult));
        }

        private List<ProductDetails> GetProductsData()
        {
            List<ProductDetails> productsData = new List<ProductDetails>
        {
            new ProductDetails
            {
            slNo = 1,
            ProductName = "WindowsOS",
            Price = 4000,
            ProductDetail = "Operating System",
            ProductType = "Hardware"
        }
        };
        return productsData;

    }





    }
}