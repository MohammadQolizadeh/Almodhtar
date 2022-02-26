using Microsoft.Extensions.DependencyInjection;
using Almodhtar.Data.Contracts;
using Almodhtar.Data.Repositories;
using Almodhtar.Data.UnitOfWork;
using Almodhtar.Services;
using Almodhtar.Services.Api;
using Almodhtar.Services.Api.Contract;
using Almodhtar.Services.Contracts;

namespace Almodhtar.IocConfig
{
    public static class AddCustomServicesExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<SendWeeklyNewsletter>();
            services.AddTransient<IjwtService, jwtService>();
            return services;
        }
    }
}
