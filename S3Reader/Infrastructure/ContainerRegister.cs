using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.AzureAppServices.Internal;

using S3Reader.Data;
using S3Reader.Domain;

namespace S3Reader.Infrastructure
{
    public static class ContainerRegister
    {
        public static void Config(IServiceCollection services)
        {
            services.AddDbContext<S3ReaderContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=S3Reader;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddSingleton<IApplicationMapper, ApplicationMapper>();
            services.AddScoped<IApplicationRepository, EfApplicationRepository>();
            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStorageService, StorageService>();
            services.AddMvc();

        }
    }
}
