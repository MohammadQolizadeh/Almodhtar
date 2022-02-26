using AutoMapper;
using Almodhtar.Entities;
using Almodhtar.Entities.identity;
using Almodhtar.ViewModels.Category;
using Almodhtar.ViewModels.Comments;
using Almodhtar.ViewModels.Manage;
using Almodhtar.ViewModels.News;
using Almodhtar.ViewModels.RoleManager;
using Almodhtar.ViewModels.Tag;
using Almodhtar.ViewModels.UserManager;
using Almodhtar.ViewModels.Video;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.IocConfig.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap()
                .ForMember(p => p.Parent, opt => opt.Ignore())
                .ForMember(p => p.Categories, opt => opt.Ignore())
                .ForMember(p => p.NewsCategories, opt => opt.Ignore());

            CreateMap<Role, RolesViewModel>().ReverseMap()
                    .ForMember(p => p.Users, opt => opt.Ignore())
                    .ForMember(p => p.Claims, opt => opt.Ignore());

            CreateMap<Tag, TagViewModel>().ReverseMap()
                   .ForMember(p => p.NewsTags, opt => opt.Ignore());

            CreateMap<Video, VideoViewModel>().ReverseMap();

            CreateMap<User, UsersViewModel>().ReverseMap()
                  .ForMember(p => p.News, opt => opt.Ignore())
                  .ForMember(p => p.Bookmarks, opt => opt.Ignore())
                  .ForMember(p => p.Claims, opt => opt.Ignore());

            CreateMap<User, ProfileViewModel>().ReverseMap()
                   .ForMember(p => p.News, opt => opt.Ignore())
                   .ForMember(p => p.Bookmarks, opt => opt.Ignore())
                   .ForMember(p => p.Claims, opt => opt.Ignore());

            CreateMap<News, NewsViewModel>().ReverseMap();
            CreateMap<Comment, CommentViewModel>().ReverseMap();

        }
    }
}
