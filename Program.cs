using Microsoft.EntityFrameworkCore;
using MyCarSalesPlatform.Core.Interfaces;
using MyCarSalesPlatform.Infrastructure.Data;
using MyCarSalesPlatform.Infrastructure.Repositories;

namespace MyCarSalesPlatform.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IListingRepository, ListingRepository>();

            // CORS privalo būti registruojamas čia, prieš Build()
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            builder.Services.AddControllers()
                     .AddJsonOptions(options =>
                     {
                        options.JsonSerializerOptions.PropertyNamingPolicy = null; // Leisk naudoti didžiąsias raides
                     });


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // CORS middleware naudojamas čia, po Build()
            app.UseCors();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

