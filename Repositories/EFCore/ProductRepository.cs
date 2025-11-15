using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneProduct(Product product)
        {
            Create(product);
        }

        public void DeleteOneProduct(Product product)
        {
            Remove(product);
        }

        public IQueryable<Product> GetAllProducts(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByConditaion(p=>p.Id.Equals(id),trackChanges);
        }

        public void UpdateOneProduct(Product entity)
        {
            Update(entity);
        }
    }
}
