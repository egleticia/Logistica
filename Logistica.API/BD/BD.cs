
namespace Logistica.API.BD
{
    public class BD
    {
        public static void CreateDatabase(WebApplication app)
        {
            // Cria um escopo com provedor de serviço
            var serviceScope = app.Services.CreateScope();

            // Obtém o contexto 
            var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>(); ;

            // Valida se a instancia não é nula
            dataContext?.Database.EnsureCreated();

        }
    }
}
