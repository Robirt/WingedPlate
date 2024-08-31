﻿using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ITagsRepository
{
    public Task<List<TagEntity>> GetTagsAsync(CancellationToken cancellationToken);

    public Task<TagEntity?> GetTagByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddTagAsync(TagEntity tag, CancellationToken cancellationToken);

    public Task UpdateTagAsync(TagEntity tag, CancellationToken cancellationToken);

    public Task RemoveTagAsync(TagEntity tag, CancellationToken cancellationToken);
}
