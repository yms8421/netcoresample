using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.EFServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BilgeAdam.SelfSite
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Dependency Injection LifeTime Scope
            services.AddScoped<IEmployeeService, EmployeeService>();

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
