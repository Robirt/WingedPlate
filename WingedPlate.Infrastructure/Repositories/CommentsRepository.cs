using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class CommentsRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public CommentsRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<CommentEntity>> GetCommentsAsync()
    {
        return await _wingedPlateDbContext.Comments.Include(comments => comments.Recipe).ToListAsync();
    }

    public async Task<CommentEntity?> GetCommentByIdAsync(int id)
    {
        return await _wingedPlateDbContext.Comments.Include(comments => comments.Recipe).SingleOrDefaultAsync(comment => comment.Id == id);
    }

    public async Task AddCommentAsync(CommentEntity comment)
    {
        await _wingedPlateDbContext.Comments.AddAsync(comment);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateCommentAsync(CommentEntity comment)
    {
        _wingedPlateDbContext.Comments.Update(comment);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task RemoveCommentAsync(CommentEntity comment)
    {
        _wingedPlateDbContext.Comments.Remove(comment);
        await _wingedPlateDbContext.SaveChangesAsync();
    }
}
