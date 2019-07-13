using BilgeAdam.SelfSite.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BilgeAdam.SelfSite
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Dependency Injection LifeTime Scope
            //TODO: http://umutluoglu.com/2017/01/asp-net-core-dependency-injection/
            services.AddSingleton<IEmployeeService, EFServices.EmployeeService>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //kullanılacak ve aktifleştirilecek ayarlar
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvc(r =>
            {
                r.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseMvcWithDefaultRoute();
        }
    }
}
