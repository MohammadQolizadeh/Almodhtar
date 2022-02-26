using Microsoft.EntityFrameworkCore;
using Almodhtar.Common;
using Almodhtar.Data.Contracts;
using Almodhtar.Entities;
using Almodhtar.ViewModels.Newsletter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Almodhtar.Data.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {

        private readonly NewsDBContext _context;
        public NewsletterRepository(NewsDBContext context)
        {
            _context = context;
        }


        public async Task<List<NewsletterViewModel>> GetPaginateNewsletterAsync(int offset, int limit, string orderBy, string searchText)
        {
            var getDateTimesForSearch = searchText.GetDateTimeForSearch();
            List<NewsletterViewModel> newsletter = await _context.Newsletters.Where(c => c.Email.Contains(searchText) || (c.RegisterDateTime >= getDateTimesForSearch.First() && c.RegisterDateTime <= getDateTimesForSearch.Last()))
                                                  .OrderBy(orderBy)
                                                  .Skip(offset).Take(limit)
                                                  .Select(l => new NewsletterViewModel { Email = l.Email, IsActive = l.IsActive, PersianRegisterDateTime = l.RegisterDateTime.ConvertMiladiToShamsi("yyyy/MM/dd ساعت HH:mm:ss") }).AsNoTracking().ToListAsync();


            foreach (var item in newsletter)
                item.Row = ++offset;

            return newsletter;
        }

    }
}
