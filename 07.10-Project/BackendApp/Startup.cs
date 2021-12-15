using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BackendApp.Models;

namespace BackendApp
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
            services.AddServices();
            services.AddDbContext<DatabaseContext>(opt =>
                     //opt.UseInMemoryDatabase("BackendList"));
                     opt.UseSqlServer(Configuration.GetConnectionString("DatabaseContext")
                     // , b => b.MigrationsAssembly("Íàçâà ïðîåêòó WEB.API â ÿêîìó ì³ñòèòèìóòüñÿ ì³ãðàö³¿, ÿêùî ÁÄ òà Ìîäåë³ â ³íøîìó ïðîåêò³")
                     ));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }*/

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
