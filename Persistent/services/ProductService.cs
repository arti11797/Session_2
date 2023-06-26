using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence_Layer;


namespace Persistent.services
{
    public class ProductService: DbContext
    {
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }

        //public IEnumerable<ProductDto> GetProducts()
        //{
        //    var products = Products.ToList();
        //    return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        //}

        //public ProductDto GetProduct(int id)
        //{
        //    var product = Products.Find(id);
        //    return _mapper.Map<Product, ProductDto>(product);
        //}

        //public void CreateProduct(ProductDto productDto)
        //{
        //    var product = _mapper.Map<ProductDto, Product>(productDto);
        //    Products.Add(product);
        //    SaveChanges();
        //}

        //public void UpdateProduct(ProductDto productDto)
        //{
        //    var product = Products.Find(productDto.Id);
        //    _mapper.Map<ProductDto, Product>(productDto, product);
        //    SaveChanges();
        //}

        //public void DeleteProduct(int id)
        //{
        //    var product = Products.Find(id);
        //    Products.Remove(product);
        //    SaveChanges();
        //}
    }
}
