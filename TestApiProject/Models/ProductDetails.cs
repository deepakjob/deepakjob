using System.ComponentModel.DataAnnotations;
namespace TestApiProject.Models
{
    public class ProductDetails
    {
        [Key]
        public int slNo { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public int Price { get; set; }
        public string ProductType { get; set; }
    }
}
