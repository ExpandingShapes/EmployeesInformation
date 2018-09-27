using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using EmployeesInformation.Models;
using EmployeesInformation.Infrastructure;

namespace EmployeesInformation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EmployeesInfoDbContext>(options => options.UseSqlServer("Data Source=%SERVERNAME%\\SQLEXPRESS;Initial Catalog=EmployeesInformationDB;Integrated Security=False;Persist Security Info=True;MultipleActiveResultSets=true;User ID=%USER%;Password=%PASSWORD%"));
            services.AddTransient<IAbstractInterface<Department>, DepartmentRepository>();
            services.AddTransient<IAbstractInterface<Employee>, EmployeeRepository>();
            services.AddTransient<IAbstractInterface<Position>, PositionRepository>();
            services.AddTransient<IAbstractInterface<Redeployment>, RedeploymentRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage(); 
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Department}/{action=Index}/{id?}");
            });
        }
    }
}
