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
using NearshoreDevs.Application.Chain;
using NearshoreDevs.Application.CQRS;
using NearshoreDevs.Application.CQRS.Handlers.Commands;
using NearshoreDevs.Application.CQRS.Handlers.Queries;
using NearshoreDevs.Application.CQRS.Interfaces;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;
using NearshoreDevs.Application.State;
using NearshoreDevs.Application.Strategy;
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
            services.AddSingleton<ProviderStore>(new ProviderStore(GetProviderData()));
            services.AddScoped<ClaimContext>(f=>new ClaimContext( f.GetRequiredService<ProviderStore>()));
            
            services.AddScoped<ISaveStudentCommandHandler, SaveStudentCommandHandler>();
            services.AddScoped<IGetAllStudentsQueryHandler, GetAllStudentsQueryHandler>();
            services.AddScoped<IGetStudentByIdQueryHandler, GetStudentByIdCommandHandler>();
            var sony = new SonyShop();
            var lg = new LGShop();
            var daewoo = new DaewooShop();
            sony.SetSuccessor(lg);
            lg.SetSuccessor(daewoo);
            services.AddScoped<IRepairShop, SonyShop>(f=> sony);


        }
        private IDictionary<string, Provider> GetProviderData()
        {
            var data = new Dictionary<string, Provider>();
            Enumerable.Range(1, 100).ToList().ForEach(i =>
            {
                var NPI = $"1103832140{i.ToString().PadLeft(3,'0')}";
                data.Add(NPI, new Provider
                {
                    NPI = NPI,
                    CreditDayNumber =3 *(int)( i < 33 ? ProviderType.Dental : (i < 66 ? ProviderType.Pharmacy : ProviderType.Phisycian)),
                    Type = i < 33 ? ProviderType.Dental : (i < 66 ? ProviderType.Pharmacy : ProviderType.Phisycian)
                }); ;

             
            });
            return data;
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
