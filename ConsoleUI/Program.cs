﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new InMemoryProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }
    }
}