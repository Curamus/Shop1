using Microsoft.AspNetCore.Mvc;
using MyProj.Data.Interfaces;
using MyProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Controllers
{
    public class ProductsController:Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;

        public ProductsController(IAllProducts allProducts, IProductsCategory productsCategory)
        {
            _allCategories = productsCategory;
            _allProducts = allProducts;
        }
        public ViewResult List()
        {
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.AllProducts = _allProducts.Products;
            obj.currCategory = "Phones";
            return View(obj);
        }
    }
}
