using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tienda.Modelo;
using Pomelo.EntityFrameworkCore;
using Tienda.Servicios;
using Tienda.Interfaces;

namespace Tienda
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
            var connectionString = "Server=localhost;Database=TiendaVirtual;Uid=root;Pwd=Dcg142356!";
            services.AddDbContext<ContextoProductoDB>(options => options.UseMySQL(connectionString));

            services.AddTransient<InterfazProducto, ProductoData>();
            services.AddTransient<InterfazUsuario, UsuarioData>();
            services.AddTransient<InterfazCarrito, CarritoData>();
            services.AddTransient<InterfazCategoria, CategoriaData>();
            services.AddTransient<InterfazCarritoItem, CarritoItemData>();
            services.AddTransient<InterfazDetalleOrdenCliente, DetalleOrdenClienteData>();
            services.AddTransient<InterfazListaDeseos, ListaDeseosData>();
            services.AddTransient<InterfazListaDeseosItems, ListaDeseosItemsData>();
            services.AddTransient<InterfazProducto, ProductoData>();
            services.AddTransient<InterfazUsuario, UsuarioData>();

            services.AddControllersWithViews();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
