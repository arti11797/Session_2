using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Persistence_Layer
{
    public class ProductRepository:IProductRepository
    {
        private readonly ProductDbContext _dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public void Update(Product product)
        {
            _dbContext.Update(product);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _dbContext.Products.Find(id);
            _dbContext.Remove(product);
            _dbContext.SaveChanges();
        }
    }

}

