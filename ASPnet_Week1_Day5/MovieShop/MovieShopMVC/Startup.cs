using ApplicationCore.ServiceInterfaces;
using ApplicationCore.Entites;
using ApplicationCore.RepsoitoryInterfaces;
using Infrastructure.Services;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.OpenApi.Models;

namespace MovieShopMVC
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
            services.AddControllersWithViews();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Bmes Api Core", Description = "It is a WEB Store (Back-end)", Version = "v1" });
               
            });
            services.AddSession();
            services.AddDbContext<MovieShopDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MovieShowDB")));
            //************** Services **********************
            services.AddTransient<ICastService, CastService>();
            services.AddTransient<ICrewService, CrewService>();
            services.AddTransient<IFavoriteService, FavoriteService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IMovieCastService, MovieCastService>();
            services.AddTransient<IMovieCrewService, MovieCrewService>();
            services.AddTransient<IMovieGenreService, MovieGenreService>();
            services.AddTransient<IPurchaseService, PurchaseService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<ITrailerService, TrailerService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRoleService, UserRoleService>();
            //************** Repositorys ************************
            services.AddTransient<IRepository<Cast>, CastRepository>();
            services.AddTransient<IRepository<Crew>, CrewRepository>();
            services.AddTransient<IRepository<Favorite>, FavoriteRepository>();
            services.AddTransient<IRepository<Genre>, GenreRepository>();
            services.AddTransient<IRepository<Movie>, MovieRepository>();
            services.AddTransient<IRepository<MovieCast>, MovieCastRepository>();
            services.AddTransient<IRepository<MovieCrew>, MovieCrewRepository>();
            services.AddTransient<IRepository<MovieGenre>, MovieGenreRepository>();
            services.AddTransient<IRepository<Purchase>, PurchaseRepository>();
            services.AddTransient<IRepository<Review>, ReviewReopsitoy>();
            services.AddTransient<IRepository<Role>, RoleRepository>();
            services.AddTransient<IRepository<Trailer>, TrailerRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<UserRole>, UserRoleRepository>();
            //****************************************************
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Bmes Api Core");
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
