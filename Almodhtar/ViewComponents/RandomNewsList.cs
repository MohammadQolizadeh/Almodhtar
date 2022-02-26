using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Almodhtar.Common;
using Almodhtar.Data.Contracts;
using Almodhtar.ViewModels.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almodhtar.ViewComponents
{
    public class RandomNewsList : ViewComponent
    {
        private readonly IUnitOfWork _uw;
        public RandomNewsList(IUnitOfWork uw)
        {
            _uw = uw;
        }

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var newsList = new List<NewsViewModel>();
            int randomRow;
            for (int i=0;i<number;i++)
            {
                randomRow = CustomMethods.RandomNumber(1, _uw.NewsRepository.CountNewsPublished()+1);
                var news = await _uw._Context.News.Where(n => n.IsPublish == true && n.PublishDateTime <= DateTime.Now).Select(n => new NewsViewModel { Title = n.Title, Url = n.Url, NewsId = n.NewsId, ImageName = n.ImageName }).Skip(randomRow-1).Take(1).FirstOrDefaultAsync();
                if(news!=null)
                    newsList.Add(news);
            }
           
            return View(newsList);
        }
    }
}
