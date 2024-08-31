﻿using WingedPlate.Domain.Entities;

namespace WingedPlate.Infrastructure.Repositories;

public interface ICommentsRepository
{
    public Task<List<CommentEntity>> GetCommentsAsync(CancellationToken cancellationToken);

    public Task<CommentEntity?> GetCommentByIdAsync(int id, CancellationToken cancellationToken);

    public Task AddCommentAsync(CommentEntity comment, CancellationToken cancellationToken);

    public Task UpdateCommentAsync(CommentEntity comment, CancellationToken cancellationToken);

    public Task RemoveCommentAsync(CommentEntity comment, CancellationToken cancellationToken);
}
