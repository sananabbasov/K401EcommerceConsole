using System;
using ConsoleUI.Business.Abstract;
using ConsoleUI.Models;

namespace ConsoleUI.Business.Concrete
{
    public class ProductManager : IProductService
    {
        List<Product> _products = new()
        {
            new Product(){Id= 1, Name = "Dell",Price = 23 },
            new Product(){Id= 2, Name = "Asus",Price = 24 },
            new Product(){Id= 3, Name = "Macbook",Price = 25 },
        };
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByPrice(decimal price)
        {
            var result = _products.Where(x => x.Price > price).ToList();
            return result;
        }

        public Product GetById(int id)
        {
            var pro = _products.SingleOrDefault(p => p.Id == id);

            return pro;
        }

        public void RemoveProduct(int id)
        {
            var pro = _products.FirstOrDefault(x => x.Id == id);
            _products.Remove(pro);
        }

        public void Update(int id, Product product)
        {
            var pro = _products.FirstOrDefault(x => x.Id == id);
            pro.Name = product.Name;
            pro.Price = product.Price;
        }
    }
}

