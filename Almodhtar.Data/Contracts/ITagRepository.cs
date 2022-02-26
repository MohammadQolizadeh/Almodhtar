using Almodhtar.Entities;
using Almodhtar.ViewModels.Tag;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Almodhtar.Data.Contracts
{
    public interface ITagRepository
    {
        Task<List<TagViewModel>> GetPaginateTagsAsync(int offset, int limit, string Orderby, string searchText);
        bool IsExistTag(string tagName, string recentTagId = null);
        Task<List<NewsTag>> InsertNewsTags(string[] tags, string newsId = null);
    }
}
