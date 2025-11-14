using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore;
namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
       private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var products = _manager.Product.GetAllProducts(false).ToList();
            return View(products);
        }
        public IActionResult Get(int id)
        {
            var model = _manager.Product.GetOneProduct(id, false);
            return View(model);
        }
    }
}
