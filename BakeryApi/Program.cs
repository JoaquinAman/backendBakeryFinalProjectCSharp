using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Model.Data;
using BakeryApi.Dao.Repository.Bakery;
using BakeryApi.Dao.Repository.Bread;
using BakeryApi.Dao.Repository.Order;
using BakeryApi.Dao.Repository.OrderBread;
using BakeryApi.Dao.Service;
using Microsoft.EntityFrameworkCore;

namespace BakeryApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<IBreadRepository, BreadRepository>();
            builder.Services.AddTransient<IDatabase<BreadDao>, BreadDbService>();

            builder.Services.AddTransient<IOrderRepository, OrderRepository>();
            builder.Services.AddTransient<IDatabase<OrderDao>, OrderDbService>();

            builder.Services.AddTransient<IOrderBreadRepository, OrderBreadRepository>();
            builder.Services.AddTransient<IDatabase<OrderBreadDao>, OrderBreadDbService>();

            builder.Services.AddTransient<IBakeryRepository, BakeryRepository>();
            builder.Services.AddTransient<IDatabase<BakeryDao>, BakeryDbService>();
            builder.Services.AddTransient<IBakery<OrderDao>, BakeryDbService>();
            

            builder.Services.AddDbContext<BakeryContext>(
         options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));


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