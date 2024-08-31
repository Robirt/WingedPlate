using WingedPlate.Domain.Entities;

namespace WingedPlate.Application.Services;

public interface ITagsService
{
    public Task<List<TagEntity>> GetTagsAsync(CancellationToken cancellationToken);

    public Task<TagEntity?> GetTagByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddTagAsync(TagEntity tag, CancellationToken cancellationToken);

    public Task UpdateTagAsync(TagEntity tag, CancellationToken cancellationToken);

    public Task RemoveTagAsync(int id, CancellationToken cancellationToken);
}
