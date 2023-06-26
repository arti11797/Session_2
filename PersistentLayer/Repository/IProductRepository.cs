using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistentLayer;

namespace Persistence_Layer
{
    internal interface IProductRepository
    {
        void Save(Product product);
        IEnumerable<Product> GetAll();
        void Update(Product product);
        void Delete(int id);
    }
}
