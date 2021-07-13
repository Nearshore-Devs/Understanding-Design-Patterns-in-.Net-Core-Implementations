using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NearshoreDevs.Application;
using NearshoreDevs.Application.CQRS;
using NearshoreDevs.Application.CQRS.Handlers.Commands;
using NearshoreDevs.Application.CQRS.Handlers.Queries;
using NearshoreDevs.Application.CQRS.Interfaces;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;
using NearshoreDevs.Application.State;
using NearshoreDevs.Controllers.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<StudentsDBContext>(options =>
            {
                options.UseInMemoryDatabase(databaseName: "Test");
            });

            SetupDI(services);
            //This is requiered for versioning our API
            // We set default version to 1.0 and we are gonna use it if no specific version is given.
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
            });
        }
        private void SetupDI(IServiceCollection services)
        {
            services.AddSingleton<OrdersDataStore>(new OrdersDataStore());
            services.AddScoped<ISaveStudentCommandHandler, SaveStudentCommandHandler>();
            services.AddScoped<IGetAllStudentsQueryHandler, GetAllStudentsQueryHandler>();
            services.AddScoped<IGetStudentByIdQueryHandler, GetStudentByIdCommandHandler>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
