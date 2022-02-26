using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Almodhtar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.Data.Mapping
{
    public class NewsTagMapping : IEntityTypeConfiguration<NewsTag>
    {
        public void Configure(EntityTypeBuilder<NewsTag> builder)
        {
            builder.HasKey(t => new { t.TagId, t.NewsId });
            builder
              .HasOne(p => p.News)
              .WithMany(t => t.NewsTags)
              .HasForeignKey(f => f.NewsId);

            builder
               .HasOne(p => p.Tag)
               .WithMany(t => t.NewsTags)
               .HasForeignKey(f => f.TagId);
        }
    }

}
