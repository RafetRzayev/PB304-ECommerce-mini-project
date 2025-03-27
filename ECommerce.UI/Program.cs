using AutoMapper;
using ECommerce.Application.DTOs;
using ECommerce.Application.Interfaces;
using ECommerce.Application.Services;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;
using ECommerce.Infrastructure.EfCore;
using ECommerce.Infrastructure.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace ECommerce.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext();
            IProductRepository productRepository1 = new ProductRepository(appDbContext);
            ProductManager productManager = new ProductManager(productRepository1);
            var product = productManager.Get(x => x.Price > 0);
            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.CategoryName}");
            //}


        }
    }
}
