//V1 versionamento de codigo
// Configuração do banco

using Microsoft.Extensions.Configuration;
using System.IO;

namespace PortalDengue1.Config.V1
{
    public class DatabaseConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static string Get()
        {
            var builder = new ConfigurationBuilder()//  pegando a configuração do appsettings
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            return Configuration["ConnectionStrings:DefaultConnection"];// retornando a configuração do banco
        }
    }
}
