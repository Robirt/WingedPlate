﻿using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ICategoriesRepository
{
    public Task<List<CategoryEntity>> GetCategoriesAsync(CancellationToken cancellationToken);

    public Task<CategoryEntity?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddCategoryAsync(CategoryEntity category, CancellationToken cancellationToken);

    public Task UpdateCategoryAsync(CategoryEntity category, CancellationToken cancellationToken);

    public Task RemoveCategoryAsync(CategoryEntity category, CancellationToken cancellationToken);
}
