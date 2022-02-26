using Almodhtar.ViewModels.News;
using Almodhtar.ViewModels.Video;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.ViewModels.Home
{
    public  class HomePageViewModel
    {
        public HomePageViewModel(List<NewsViewModel> news, List<NewsViewModel> mostViewedNews, List<NewsViewModel> mostTalkNews, List<NewsViewModel> mostPopularNews, List<VideoViewModel> video, int countNewsPublished)
        {
            News = news;
            MostViewedNews = mostViewedNews;
            MostTalkNews = mostTalkNews;
            MostPopularNews = mostPopularNews;
            Video = video;
            CountNewsPublished = countNewsPublished;
        }

        public List<NewsViewModel> News { get; set; }
        public List<NewsViewModel> MostViewedNews { get; set; }
        public List<NewsViewModel> MostTalkNews { get; set; }
        public List<NewsViewModel> MostPopularNews { get; set; }

        public List<VideoViewModel> Video { get; set; }
        public int CountNewsPublished { get; set; }
    }
}
