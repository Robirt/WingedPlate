using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class TagsRepository : ITagsRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public TagsRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        ArgumentNullException.ThrowIfNull(wingedPlateDbContext, nameof(wingedPlateDbContext));

        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<TagEntity>> GetTagsAsync(CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Tags.Include(tags => tags.Recipes).ToListAsync(cancellationToken);
    }

    public async Task<TagEntity?> GetTagByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Tags.Include(tags => tags.Recipes).SingleOrDefaultAsync(tag => tag.Id == id, cancellationToken);
    }

    public async Task AddTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        await _wingedPlateDbContext.Tags.AddAsync(tag,cancellationToken);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Tags.Update(tag);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveTagAsync(TagEntity tag, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Tags.Remove(tag);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

}
