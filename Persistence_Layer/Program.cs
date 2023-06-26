using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Persistence_Layer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new repository.
            var repository = new ProductRepository();

            // Create a new product.
            var product = new Product()
            {
                Name = "Product 1",
                Description = "This is a product.",
                Price = 10
            };

            // Save the product.
            repository.Save(product);

            // Load the product by ID.
           // var loadedProduct = repository.Load(1);

            // Update the product.
           // loadedProduct.Name = "Product 2";
           // repository.Update(loadedProduct);

            // Delete the product.
            repository.Delete(1);
        }
    }
}
