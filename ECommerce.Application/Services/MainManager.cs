using ECommerce.Application.DTOs;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Interfaces;
using ECommerce.Infrastructure.EfCore;
using ECommerce.Infrastructure.EfCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Services
{
    public class MainManager
    {
        private readonly ICategoryService _categoryService;

        public MainManager()
        {
            AppDbContext appDbContext = new AppDbContext();
            ICategoryRepository categoryRepository = new CategoryRepository(appDbContext);
            _categoryService = new CategoryManager(categoryRepository);
        }

        public void AddCategory()
        {
            Console.WriteLine("Enter category name:");

            var categoryName = Console.ReadLine();

            var categoryCreateDto = new CategoryCreateDto { Name = categoryName };

            _categoryService.Add(categoryCreateDto);
            Console.WriteLine("Success");

        }
    }
}
