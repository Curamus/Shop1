using MyProj.Data.Interfaces;
using MyProj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Data.mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> GetCategories {
            get
            {
                return new List<Category>
                {
                    new Category{caregoryName = "Phones", desc ="means of connection"},
                    new Category{caregoryName = "Charger", desc ="Charging"}
                };
            }
        }
    }
}
