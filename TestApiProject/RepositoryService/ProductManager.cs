
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestApiProject.DBContext;
using TestApiProject.Models;
namespace TestApiProject.RepositoryService
{
    public class ProductManager : IProduct
    {
       private readonly ProductDbContext _dbContext;
        public ProductManager(ProductDbContext dbContext)
        { 
        _dbContext = dbContext;
        }
        public async Task<IEnumerable<ProductDetails>> GetProductDetails()
        {
           // IEnumerable<ProductDetails> prodDetails = new List<ProductDetails>();
            List<ProductDetails> li = new List<ProductDetails>();
            var details = _dbContext.ProductDetails.Select(row => row); 
            if (details != null)
            {
                ProductDetails Prod = new ProductDetails();
                Parallel.ForEach(details, x =>
                {
                    Prod.slNo = x.slNo;
                    Prod.ProductName = x.ProductName;
                    Prod.Price = Convert.ToInt32(x.Price);
                    Prod.ProductDetail=x.ProductDetail;
                    Prod.ProductType=x.ProductType;
                    li.Add(Prod);

                });
                return await Task.FromResult(li);
            }
            else
            {
                return li;
            }
        }

        public bool SaveProductDetails(ProductDetails pod)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetails> SearchProductDetails(string id)
        {
            throw new NotImplementedException();
        }
    }
}
