using ProjectPolyclinic.Repositories;
using ProjectPolyclinic.Repositories.Implementations;
using Unity;

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
            Application.Run(CreateContainer().Resolve<FormPolyclinic>());
        }

         private static IUnityContainer CreateContainer ()
        {
            var container = new UnityContainer();

            container.RegisterType<IPacientRepository, PacientRepository>();
            container.RegisterType<IMedicineRepository, MedicineRepository>();
            container.RegisterType<IMedicineReplenishmentRepository, MedicineReplenishmentRepository>();
            container.RegisterType<IHealingPacientRepository, HealingPacientRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();

            return container;
        }
    }
}