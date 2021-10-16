using EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Service.APP;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.AntiForgery;
using Volo.Abp.AspNetCore.Mvc.Conventions;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CX.APP.Service
{
    [DependsOn(
       typeof(AbpAutofacModule),
      typeof(AbpAspNetCoreMvcModule),
       typeof(APPModule),
       typeof(EFModule)
        )]
    public class WebModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options
                    .ConventionalControllers
                    .Create(typeof(APPModule).Assembly, opts =>
                    {
                        opts.UseV3UrlStyle = true;
                    });
            });
            Configure<AbpConventionalControllerOptions>(options =>
            {
                options.UseV3UrlStyle = true;
            });
            Configure<AbpAntiForgeryOptions>(options =>
            {
                options.AutoValidate = false;
            });
            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Novel API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "CX API");
            });


            app.UseConfiguredEndpoints();
        }
    }
}
