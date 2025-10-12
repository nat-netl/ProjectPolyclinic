using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PdfSharp.Fonts;
using ProjectPolyclinic.Repositories;
using ProjectPolyclinic.Repositories.Implementations;
using Serilog;
using System.Text;
using Unity;
using Unity.Microsoft.Logging;

namespace ProjectPolyclinic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            GlobalFontSettings.FontResolver = new CustomFontResolver();
            Application.Run(CreateContainer().Resolve<FormPolyclinic>());
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

         private static IUnityContainer CreateContainer ()
         {
            var container = new UnityContainer();

            container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

            container.RegisterType<IPacientRepository, PacientRepository>();
            container.RegisterType<IMedicineRepository, MedicineRepository>();
            container.RegisterType<IMedicineReplenishmentRepository, MedicineReplenishmentRepository>();
            container.RegisterType<IHealingPacientRepository, HealingPacientRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IConnectionString, ConnectionString>();

            return container;
         }

        private static LoggerFactory CreateLoggerFactory()
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(new LoggerConfiguration()
            .ReadFrom.Configuration(new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build())
            .CreateLogger());
            return loggerFactory;
        }
    }
}