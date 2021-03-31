using MyProj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get;  }
        IEnumerable<Product> GetFavProducts { get; set; }
        Product GetProductById(int productId);
    }
}
