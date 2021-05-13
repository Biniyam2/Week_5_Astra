using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MovieShop.API.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.API
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
            services.AddHttpContextAccessor();
            services.AddDbContext<MovieShopDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MovieShowDB")));
            services.AddControllers();
         //   **************Services * *********************
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
          //  **************Repositorys * ***********************
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

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieShop.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseMovieShopExecptionMiddleware();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieShop.API v1"));
            }
            app.UseCors(builder =>
            {
                builder.WithOrigins(Configuration.GetValue<string>("clientSPAUrl")).AllowAnyHeader()
                    .AllowAnyMethod();
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
