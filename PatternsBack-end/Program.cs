using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace PatternsBack_end
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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
                // Вместо возвращения кода иконки, верните только имя иконки
                return Results.Text("CoffeeMaker");
            });

            app.Run();
        }
    }
}