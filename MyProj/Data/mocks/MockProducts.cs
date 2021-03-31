using MyProj.Data.Interfaces;
using MyProj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Data.mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory productsCategory = new MockCategory();
        public IEnumerable<Product> Products {
            get
            {
                return new List<Product>
                {
                    new Product{name = "Samsung", price=500, isFavourite=true,available=true, Category = productsCategory.GetCategories.First()}
                };
            }
        }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
