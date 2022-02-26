using Almodhtar.Entities;
using Almodhtar.ViewModels.Newsletter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Almodhtar.Data.Contracts
{
    public interface INewsletterRepository
    {
        Task<List<NewsletterViewModel>> GetPaginateNewsletterAsync(int offset, int limit,string orderBy, string searchText);
    }
}
