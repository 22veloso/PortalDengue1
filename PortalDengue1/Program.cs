using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PortalDengue1.Views.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalDengue1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var host = CreateHostBuilder().Build();
            //ServiceProvider = host.Services;

            Application.Run(new Frm_HomePage());

        }

        //public static IServiceProvider ServiceProvider { get; private set; }
        //static IHostBuilder CreateHostBuilder()
        //{
        //    return Host.CreateDefaultBuilder()
        //        .ConfigureServices((context, services) => {
        //            services.AddTransient<IHelloService, HelloService>();
        //            services.AddTransient<Form1>();
        //        });
        //}
    }
}
