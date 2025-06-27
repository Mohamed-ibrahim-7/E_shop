
using E_shop.Models;

namespace E_shop.ViewModels
{
    public class ProductWithRelatedVM
    {
        public Product Product { get; set; } = null!;
        public List<Product> RelatedProducts { get; set; } = null!;
        public List<Product> TopProduct { get; set; } = null!;
        public List<Product> SimilarProduct { get; set; } = null!;
    }
}
