using System.Collections.Generic;
using webapi.Model;

namespace webapi.DAL
{
    // Keep the interface definition as-is
    public interface IProductRepository
    {
        Product GetById(int id);
        IReadOnlyCollection<Product> List();
        bool Delete(int id);
    }
}