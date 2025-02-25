
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
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

            // ApiGateway

            builder.Configuration.AddJsonFile($"ocelot.json", false, true); // dosyayý belirleme

            builder.Services.AddEndpointsApiExplorer(); // uç noktalarýn keþfi için

            builder.Services.AddOcelot(builder.Configuration); // eklediðimiz dosyadaki bilgileri kullan




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // ApiGateway

            app.UseOcelot().Wait();



            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
