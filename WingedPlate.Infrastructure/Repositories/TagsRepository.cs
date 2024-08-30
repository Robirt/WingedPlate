using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class TagsRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public TagsRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<TagEntity>> GetTagsAsync()
    {
        return await _wingedPlateDbContext.Tags.Include(tags => tags.Recipes).ToListAsync();
    }

    public async Task<TagEntity?> GetTagByIdAsync(int id)
    {
        return await _wingedPlateDbContext.Tags.Include(tags => tags.Recipes).SingleOrDefaultAsync(tag => tag.Id == id);
    }

    public async Task AddTagAsync(TagEntity tag)
    {
        await _wingedPlateDbContext.Tags.AddAsync(tag);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateTagAsync(TagEntity tag)
    {
        _wingedPlateDbContext.Tags.Update(tag);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task RemoveTagAsync(TagEntity tag)
    {
        _wingedPlateDbContext.Tags.Remove(tag);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

}
