﻿using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Interfaces;

public interface ICategoryService : ICrudService<Category, CategoryDto, CategoryCreateDto, CategoryUpdateDto>
{
}