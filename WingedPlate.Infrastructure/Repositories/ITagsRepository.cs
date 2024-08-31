using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ITagsRepository
{
    public Task<List<TagEntity>> GetTagsAsync();

    public Task<TagEntity?> GetTagByIdAsync(int id);

    public Task AddTagAsync(TagEntity tag);

    public Task UpdateTagAsync(TagEntity tag);

    public Task RemoveTagAsync(TagEntity tag);

}
