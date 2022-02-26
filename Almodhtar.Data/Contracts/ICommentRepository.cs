using Almodhtar.ViewModels.Comments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Almodhtar.Data.Contracts
{
    public interface ICommentRepository
    {
        Task<List<CommentViewModel>> GetPaginateCommentsAsync(int offset, int limit, string orderBy, string searchText, string newsId, bool? isConfirm);
        int CountUnAnsweredComments();
    }
}
