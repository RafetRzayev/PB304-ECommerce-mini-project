using ECommerce.Domain.Entities;

namespace ECommerce.Application.DTOs;

public class CategoryDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class CategoryCreateDto
{
    public required string Name { get; set; }

    public Category ToCategory()
    {
        return new Category
        {
            Name = Name
        };
    }

}

public class CategoryUpdateDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
}
