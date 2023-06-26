using Microsoft.AspNetCore.Mvc;
using Persistent.services;

namespace Persistent.controller
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        //public ActionResult Index()
        //{
        //    var products = _productService.GetProducts();
        //    return View(products);
        //}

        //public ActionResult Details(int id)
        //{
        //    var productDto = _productService.GetProduct(id);
        //    return View(productDto);
        //}

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductDto productDto)
        {
           // //_productService.CreateProduct(productDto);
            return RedirectToAction("Index");
        }

        //public ActionResult Edit(int id)
        //{
        //    var productDto = _productService.GetProduct(id);
        //    return View(productDto);
        //}

        [HttpPost]
        public ActionResult Edit(ProductDto productDto)
        {
            //_productService.UpdateProduct(productDto);
            return RedirectToAction("Index");
        }

        //public ActionResult Delete(int id)
        //{
        //    _productService.DeleteProduct(id);
        //    return RedirectToAction("Index");
        //}

        Product PL
            Product

    }

    public partial class ProductDto
    {
        
    }
}
