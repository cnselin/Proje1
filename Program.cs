using System;
using Business.Concrete;
using ConsoleUI;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[]args)
        {
            ProductManager productManager = new ProductManager(new InMmemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }

    }
}