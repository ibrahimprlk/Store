using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
       private readonly RepositoryContext _repositoryContext;

        public ProductController(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IActionResult Index()
        {
            var products = _repositoryContext.Products.AsNoTracking().ToList();
            return View(products);
        }
        public IActionResult Get(int id)
        {
            Product? product = _repositoryContext.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}
