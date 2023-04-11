using ConsoleUI;
using ConsoleUI.Business.Concrete;
using ConsoleUI.Models;


ProductManager _productManager = new();


//ProductManager newProduct = new()
//{

//};


_productManager.RemoveProduct(2);


var proByPrice = _productManager.GetAll();

foreach (var item in proByPrice)
{
    Console.WriteLine(item.Name + " " + item.Price);
}


