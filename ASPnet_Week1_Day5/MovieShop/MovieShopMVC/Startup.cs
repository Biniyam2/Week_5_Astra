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
using ApplicationCore.RepositoryInterfaces;
using Microsoft.AspNetCore.Authentication.Cookies;

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
            services.AddHttpContextAccessor();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddCookie(options =>
              {
                  options.Cookie.Name = "MovieShopAuthCookie";
                  options.ExpireTimeSpan = TimeSpan.FromHours(2);
                  options.LoginPath = "/Account/Login";
              }
              );
            
            services.AddSession();
            services.AddDbContext<MovieShopDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MovieShowDB")));
            //************** Services **********************
            services.AddTransient<ICurrentUserService, CurrentUserService>();
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
            services.AddTransient<ICastRepository, CastRepository>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<ICrewRepository, CrewRepository>();
            services.AddTransient<IFavoriteRepository, FavoriteRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IMovieCastRepository, MovieCastRepository>();
            services.AddTransient<IMovieCrewRepository, MovieCrewRepository>();
            services.AddTransient<IMovieGenreRepository, MovieGenreRepository>();
            services.AddTransient<IPurchaseRepository, PurchaseRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<ITrailerRepository, TrailerRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
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
            
        
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
