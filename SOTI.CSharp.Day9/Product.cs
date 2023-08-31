using System;
using System.Collections.Generic;

namespace SOTI.CSharp.Day9
{
    //Model class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public interface IRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetAllProducts();
        void UpdateProduct(int id, Product product);
    }

    public class RepositoryFactory
    {       
        public static IRepository GetRepository()
        {
            return new NewProductRepository();
        }
    }

    //DAL
    public class ProductRepositoryV2 : IRepository
    {
        public void AddProduct(Product product) { }
        public void UpdateProduct(int id, Product product) { }
        public void DeleteProduct(int id) { }
        public List<Product> GetAllProducts() { return new List<Product>(); }
    }

    //New Product Repository Class
    public class NewProductRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }

    //BLL
    public class ProductBL
    {
       //private readonly IRepository _repository = null;
        private readonly ProductRepositoryV2 _repository = null;

        public ProductBL()
        {
            //_repository = RepositoryFactory.GetRepository();
            _repository = new ProductRepositoryV2();
        }

        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }

    }
}
