using System;
using ConsoleUI.Models;

namespace ConsoleUI.Business.Abstract
{
	public interface IProductService
	{
		void AddProduct(Product product);
		void Update(int id, Product product);
		List<Product> GetAll();
		List<Product> GetAllByPrice(decimal price);
		Product GetById(int id);
		void RemoveProduct(int id);
	}
}

