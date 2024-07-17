
using FoodMenuApi.AutoMapper;
using FoodMenuApi.Repositories;
using FoodMenuApi.Services;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddAutoMapper(opts =>
            {
                opts.AddProfile(new ItemProfile());
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<ItemDbContext>(
                opts =>
                {
                    opts.UseSqlServer(connectionString, assembly => assembly.MigrationsAssembly(typeof(ItemDbContext).Assembly.FullName));
                });

            builder.Services.AddScoped<IItemRepository, ItemRepository>();
            builder.Services.AddScoped<IItemService, ItemService>();

            var app = builder.Build();

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
