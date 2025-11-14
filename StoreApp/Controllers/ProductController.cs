using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;
namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
       private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var products = _manager.ProductService.GetAllProducts(false).ToList();
            return View(products);
        }
        public IActionResult Get([FromRoute(Name ="id")]int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}
