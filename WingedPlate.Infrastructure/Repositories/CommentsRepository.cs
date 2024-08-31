using Microsoft.EntityFrameworkCore;
using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public class CommentsRepository : ICommentsRepository
{
    private readonly WingedPlateDbContext _wingedPlateDbContext;

    public CommentsRepository(WingedPlateDbContext wingedPlateDbContext)
    {
        ArgumentNullException.ThrowIfNull(wingedPlateDbContext, nameof(wingedPlateDbContext));

        _wingedPlateDbContext = wingedPlateDbContext;
    }

    public async Task<List<CommentEntity>> GetCommentsAsync(CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Comments.Include(comments => comments.Recipe).ToListAsync(cancellationToken);
    }

    public async Task<CommentEntity?> GetCommentByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _wingedPlateDbContext.Comments.Include(comments => comments.Recipe).SingleOrDefaultAsync(comment => comment.Id == id, cancellationToken);
    }

    public async Task AddCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        await _wingedPlateDbContext.Comments.AddAsync(comment, cancellationToken);
        await _wingedPlateDbContext.SaveChangesAsync();
    }

    public async Task UpdateCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Comments.Update(comment);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveCommentAsync(CommentEntity comment, CancellationToken cancellationToken)
    {
        _wingedPlateDbContext.Comments.Remove(comment);
        await _wingedPlateDbContext.SaveChangesAsync(cancellationToken);
    }
}
