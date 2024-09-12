using Microsoft.AspNetCore.Mvc;
using WingedPlate.Application.Services;
using WingedPlate.Domain.Entities;

namespace WingedPlate.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoriesService _categoriesService;

    public CategoriesController(ICategoriesService categoriesService)
    {
        ArgumentNullException.ThrowIfNull(categoriesService, nameof(categoriesService));

        _categoriesService = categoriesService;
    }

    [HttpGet]
    public async Task<List<CategoryEntity>> GetCategoriesAsync(CancellationToken cancellationToken)
    {
        return await _categoriesService.GetCategoriesAsync(cancellationToken);
    }

    [HttpGet("id")]
    public async Task<CategoryEntity?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _categoriesService.GetCategoryByIdAsync(id, cancellationToken);
    }

    [HttpPost]
    public async Task AddCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        await _categoriesService.AddCategoryAsync(category, cancellationToken);
    }

    [HttpPut]
    public async Task UpdateCategoryAsync(CategoryEntity category, CancellationToken cancellationToken)
    {
        await _categoriesService.UpdateCategoryAsync(category, cancellationToken);
    }

    [HttpDelete("id")]
    public async Task RemoveCategoryAsync(int id, CancellationToken cancellationToken)
    {
        await _categoriesService.RemoveCategoryAsync(id, cancellationToken);
    }
}
