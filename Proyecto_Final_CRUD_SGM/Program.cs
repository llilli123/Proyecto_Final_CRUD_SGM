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
            ApplicationConfiguration.Initialize();

            var login = new Login();

            // Muestra el formulario de login como diálogo
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Menu_Principal());

            }
        }
    }
}