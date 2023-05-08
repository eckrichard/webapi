using System.Collections.Generic;
using System.Linq;
using webapi.Model;

namespace webapi.DAL
{
    // Only edit your Neptun code, otherwise keep the class as-is
    public class ProductRepository : IProductRepository
    {
        private const string Neptun = "KLH5TQ";

        private readonly List<Product> products = new List<Product>()
        {
            new Product()
            {
                ID = 1,
                Name = Neptun + "Activity playgim",
                Price = 7488,
                Stock = 21
            },
            new Product()
            {
                ID = 2,
                Name = Neptun + "Colorful baby book",
                Price = 1738,
                Stock = 58
            },
            new Product()
            {
                ID = 3,
                Name = Neptun + "Baby telephone",
                Price = 3725,
                Stock = 18
            }
        };

        public IReadOnlyCollection<Product> List()
        {
            return this.products;
        }

        public Product GetById(int id)
        {
            return this.products.FirstOrDefault(p => p.ID == id);
        }

        public bool Delete(int id)
        {
            var removedCount = this.products.RemoveAll(p => p.ID == id);
            return removedCount > 0;
        }
    }
}
