using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using PO.Project.Infrastructure.Persistence;
using PO.Project.Domain.Models;
using static PO.Project.Domain.Models.CarPartModule;
using static PO.Project.Domain.Models.CarPartsUsedModule;
using static PO.Project.Domain.Models.ClientModule;
using static PO.Project.Domain.Models.EmployeeModule;
using static PO.Project.Domain.Models.OwnerModule;
using static PO.Project.Domain.Models.RepairModule;
using static PO.Project.Domain.Models.ServiceModule;
using static PO.Project.Domain.Models.ServicesUsedModule;
using static PO.Project.Domain.Models.UserModule;

namespace PO.Project.Api
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IContainer ApplicationContainer { get; private set; }
        public IConfigurationRoot ConfigurationRoot { get; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProjectDbContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("DBConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddSingleton<ICarPartRepository, MockCarPartRepository>();
            services.AddSingleton<ICarPartsUsedRepository, MockCarPartsUsedRepository >();
            services.AddSingleton<IClientRepository, MockClientRepository>();
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            services.AddSingleton<IOwnerRepository, MockOwnerRepository>();
            services.AddSingleton<IRepairRepository, MockRepairRepository>();
            services.AddSingleton<IServiceRepository, MockServiceRepository>();
            services.AddSingleton<IServicesUsedRepository, MockServicesUsedRepository>();
            services.AddSingleton<IUserRepository, MockUserRepository>();



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PO-Project - Pokuta Software WebApi", Version = "v1" });
            });

            var builder = new ContainerBuilder();
            builder.RegisterModule<CarPartModule>();
            builder.RegisterModule<CarPartsUsedModule>();
            builder.RegisterModule<ClientModule>();
            builder.RegisterModule<ClientToRepairXrefModule>();
            builder.RegisterModule<EmployeeModule>();
            builder.RegisterModule<EmployeeToRepairXrefModule>();
            builder.RegisterModule<OwnerModule>();
            builder.RegisterModule<RepairModule>();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<ServicesUsedModule>();
            builder.RegisterModule<UserModule>();

            builder.Populate(services);
            ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(ApplicationContainer);

            
        }

        



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PO-Project - Pokuta Software WebApi");
            });
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}