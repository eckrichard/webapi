using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using webapi.DAL;
using webapi.Model;

namespace webapi.Controllers
{
    // Keep the URL as-is
    [Route("api/product")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        // Keep this contructor as-is
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return productRepository.List();
        }

        // Add new api endpoints here
        [HttpHead("{id}")]
        public ActionResult<Model.Product> Head(int id)
        {
            var prod = productRepository.GetById(id);
            if (prod == null)
                return NotFound();
            return prod;
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Product> Get(int id)
        {
            Product prod = productRepository.GetById(id);
            if (prod == null)
                return NotFound();
            return prod;
        }

        [HttpDelete("{id}")]
        public ActionResult<Model.Product> Delete(int id)
        {
            var prod = productRepository.Delete(id);
            if (prod)
                return NoContent();
            return NotFound();
        }

        [HttpGet("-/count")]
        public CountResult Count()
        {
            var count = productRepository.List().Count;
            CountResult countResult = new CountResult();
            countResult.Count = count;
            return countResult;
        }
    }
}