using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PersistentLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistence_Layer
{
    public class ProductDbContext: DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Product>Products { get; set; }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>(); //Map from Developer Object to DeveloperDTO Object
        }

        private class ProductDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}
