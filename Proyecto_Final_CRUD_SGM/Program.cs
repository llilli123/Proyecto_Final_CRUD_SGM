using CAPA_PRESENTACION;
using CAPA_PRESENTACION.Properties;

namespace Proyecto_Final_CRUD_SGM
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
            Application.Run(new Entrada_Datos_Pacientes());

        }
    }
}