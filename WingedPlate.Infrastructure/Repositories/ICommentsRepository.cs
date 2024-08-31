using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ICommentsRepository
{
    public Task<List<CommentEntity>> GetCommentsAsync();

    public Task<CommentEntity?> GetCommentByIdAsync(int id);

    public Task AddCommentAsync(CommentEntity comment);

    public Task UpdateCommentAsync(CommentEntity comment);

    public Task RemoveCommentAsync(CommentEntity comment);
}
