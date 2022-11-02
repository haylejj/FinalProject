﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category  in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var item in productManager.GetAllByCatogoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
