using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Interfaces;

public interface IProductService : ICrudService<Product, ProductDto, ProductCreateDto, ProductUpdateDto>
{
   
}
