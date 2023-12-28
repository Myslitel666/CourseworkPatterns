using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Runtime.Intrinsics.X86;
using PatternsBack_end.Context;
using PatternsBack_end.Interfaces;
using PatternsBack_end.Repositories;
using PatternsBack_end.Services;

namespace PatternsBack_end
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ƒобавл€ем сервисы в контейнер
            builder.Services.AddDbContext<PatternsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<ILabRepository, LabRepository>();
            builder.Services.AddScoped<IDescriptionLabRepository, DescriptionLabRepository>();

            builder.Services.AddScoped<ILabService, LabService>();
            builder.Services.AddScoped<IDescriptionLabService, DescriptionLabService>();

            // Add services to the container.

            builder.Services.AddControllers();

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins, policy =>
                {
                    policy.WithOrigins().AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);
            app.MapControllers();

            app.MapGet("/api/categories/icon", () =>
            {
                // ¬место возвращени€ кода иконки, верните только им€ иконки
                return Results.Text("CoffeeMaker");
            });

            app.Run();
        }
    }
}