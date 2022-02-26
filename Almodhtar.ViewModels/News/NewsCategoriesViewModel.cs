using Almodhtar.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.ViewModels.News
{
    public class NewsCategoriesViewModel
    {
        public NewsCategoriesViewModel(List<TreeViewCategory> categories, string[] categoryIds)
        {
            Categories = categories;
            CategoryIds = categoryIds;
        }

        public List<TreeViewCategory> Categories { get; set; }
        public string[] CategoryIds { get; set; }
    }
}
