using Logistica.API.BD;
using Logistica.API.Extensions;
using Logistica.Persistence.Repositories;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Logistica.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ConfigurePersistenceApp(builder.Configuration);

            builder.Services.ConfigureApplicationApp();
            builder.Services.ConfigureCorsPolicy();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                var openApiInfo = new OpenApiInfo();

                openApiInfo.Title = "Logistica API";
                openApiInfo.Description = "Integração entre Site de Compras e entregas de produtos";
                openApiInfo.License = new OpenApiLicense
                {
                    Name = "Logistica",
                    Url = new Uri(@"https://github.com/egleticia/Logistica")
                };
                openApiInfo.Contact = new OpenApiContact()
                {
                    Name = "Eng-Sof II",
                    Email = "leticia@yahoo.com.br"
                };

                options.SwaggerDoc("v1", openApiInfo);

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var path = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(path, true);
            });

            var app = builder.Build();

            BD.BD.CreateDatabase(app);
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseCors();
            app.MapControllers();
            app.Run();
        }
    }
}