﻿using Almodhtar.ViewModels.News;
using System;
using System.Collections.Generic;
using Almodhtar.Entities;
using System.Text;

namespace Almodhtar.ViewModels.Home
{
    public class NewsDetailsViewModel
    {
        public NewsDetailsViewModel(NewsViewModel news, List<Comment> comments, List<NewsViewModel> newsRelated, List<NewsViewModel> nextAndPreviousNews)
        {
            News = news;
            Comments = comments;
            NewsRelated = newsRelated;
            NextAndPreviousNews = nextAndPreviousNews;
        }
        public NewsViewModel News { get; set; }
        public List<Comment> Comments { get; set; }
        public List<NewsViewModel> NewsRelated { get; set; }
        public List<NewsViewModel> NextAndPreviousNews { get; set; }
    }
}
