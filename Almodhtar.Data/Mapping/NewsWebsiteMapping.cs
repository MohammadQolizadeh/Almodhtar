using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.Data.Mapping
{
    public static class AlmodhtarMapping
    {
        public static void AddCustomAlmodhtarMappings(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookmarkMapping());
            modelBuilder.ApplyConfiguration(new LikeMapping());
            modelBuilder.ApplyConfiguration(new NewsCategoryMapping());
            modelBuilder.ApplyConfiguration(new NewsTagMapping());
            modelBuilder.ApplyConfiguration(new VisitMapping());
        }

    }
}
