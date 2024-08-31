using WingedPlate.Domain.Entities;
using WingedPlate.Infrastructure.Repositories;

namespace WingedPlate.Application.Services;

public class TagsService : ITagsService
{
    private readonly ITagsRepository _tagsRepository;

    public TagsService(ITagsRepository tagsRepository)
    {
        ArgumentNullException.ThrowIfNull(tagsRepository, nameof(tagsRepository));

        _tagsRepository = tagsRepository;
    }

    public async Task<List<TagEntity>> GetTagsAsync(CancellationToken cancellationToken)
    {
        return await _tagsRepository.GetTagsAsync(cancellationToken);
    }

    public async Task<TagEntity?> GetTagByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _tagsRepository.GetTagByIdAsync(id, cancellationToken);
    }

    public async Task AddTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        await _tagsRepository.AddTagAsync(tag, cancellationToken);
    }

    public async Task UpdateTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        await _tagsRepository.UpdateTagAsync(tag,cancellationToken);
    }

    public async Task RemoveTagAsync(int id, CancellationToken cancellationToken)
    {
        await _tagsRepository.RemoveTagAsync((await _tagsRepository.GetTagByIdAsync(id, cancellationToken))!, cancellationToken);
    }
}
