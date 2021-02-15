using Buisness.Abstract;
using Buisness.Concret;
using DataAccess.Abstract;
using DataAccess.Concret;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Starex
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
            services.AddScoped<IAboutDAL, EFAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IServiceDal, EFServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<INewsDal, EfNewsDal>();
            services.AddScoped<INewsService, NewsManager>();
            services.AddScoped<INewsDetailDal, EFNewsDetailDal>();
            services.AddScoped<INewsDetailService, NewsDetailManager>();
            services.AddScoped<IQuestionNavbarDal, EFQuestionNavbarDal>();
            services.AddScoped<IQuestionNavbarService, QuestionNavbarManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
