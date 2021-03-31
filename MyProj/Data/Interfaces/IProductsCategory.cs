using MyProj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
